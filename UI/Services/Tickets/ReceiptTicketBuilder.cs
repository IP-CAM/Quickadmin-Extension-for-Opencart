using Entity;
using QuickAdmin.API;
using Service.Ticket;
using System;
using System.Drawing.Printing;
using System.Linq;

namespace UI.Services.Tickets
{
    internal class ReceiptTicketBuilder : ITicketBuilder
    {
        private readonly TicketDocument ticket;
        private readonly OrderData order;
        private readonly IRestAPI api;

        private static int TicketLen { get; } = 45 - 7;

        public ReceiptTicketBuilder(OrderData order, IRestAPI api)
        {
            this.order = order;
            this.api = api;
            ticket = new TicketDocument("OpenCart QuickAdmin: Ticket", 8, TicketLen)
            {
                Logo = Properties.Resources.OpenCart_32px,
                PrinterSettings = new PrinterSettings()
            };
        }

        public void BuildBody()
        {
            Customer customer = order.Customer;
            ticket.TextLocationMode = TicketPaperLocation.Body;
            ticket.SideText("Expidation date:", DateTime.Today.ToShortDateString());
            ticket.SideText("Date of sale:", order.DateAdded.ToShortDateString());
            ticket.SideText("Folio:", $"#{order.ID}");
            ticket.Separator(TicketSeparator.Dash);
            // Customer
            ticket.CenterText("[Customer]");
            ticket.LeftText($"Fullname: {customer.Firstname} {customer.Lastname}");
            if (!string.IsNullOrWhiteSpace(customer.Email))
            {
                ticket.LeftText($"Email: {customer.Email}");
            }

            ticket.Separator(TicketSeparator.Asterisk);
            // Order
            ticket.CenterText("[Order]");
            ticket.SideText("Payment method:", order.PaymentMethod.ToString());
            ticket.SideText("Shipping method:", order.ShippingMethod.ToString());
            ticket.Separator(TicketSeparator.Blank);
            ticket.Separator(TicketSeparator.Dash);
            ticket.LeftText("Product\tU/P\tQuantity\tTotal");
            ticket.Separator(TicketSeparator.Dash);
            // Products
            foreach (OrderProduct op in order.Products)
            {
                decimal unitPrice = op.Price;
                decimal totalProduct = op.Total;
                string prod = (op.Name.Length < 8) ? op.Name.PadRight(8) : op.Name.Substring(0, 8);
                ticket.LeftText($"-{prod}\t${unitPrice.ToString("#.##")}\t{op.Quantity}\t${totalProduct.ToString("#.##")}");
            }
            ticket.Separator(TicketSeparator.Dash);
            // Totals
            var orderTotals = order.OrderTotals.OrderBy(o => o.SortOrder);
            foreach (OrderTotal ot in orderTotals)
            {
                if (ot.Code == "sub_total")
                {
                    decimal subtotal = ot.Value;
                    ticket.LeftText($"Subtotal: ${subtotal.ToString("#.##")}");
                }
                else
                {
                    ticket.LeftText($"{ot.Title}: ${ot.Value.ToString("#.##")}");
                }
            }
            ticket.Separator(TicketSeparator.Dash);
        }

        public void BuildFooter()
        {
            //ticket.TextLocationMode = TicketPaperLocation.Footer;
            //ticket.Text[TicketPaperLocation.Footer].Font = new Font(FontFamily.GenericMonospace.Name, 7, FontStyle.Regular);
        }

        public void BuildHeader()
        {

            ticket.Separator(TicketSeparator.Dash);
        }

        public TicketDocument GetTicket() => ticket;
    }
}
