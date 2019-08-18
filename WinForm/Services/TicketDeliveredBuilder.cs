using System;
using System.Drawing;
using System.Drawing.Printing;
using EntityLayer;
using Presentation.Models;
using Service.Ticket;

namespace Presentation.Utils.Ticket
{
    internal class TicketDeliveredBuilder : ITicketBuilder
    {
        private TicketDocument ticket;
        private readonly Folio folio;
        private readonly Detail detail;

        public TicketDocument GetTicket() => ticket;

        public TicketDeliveredBuilder(Folio folio, Detail detail, ISettingsModel settingsModel)
        {
            this.folio = folio;
            this.detail = detail;
            ticket = new TicketDocument("Servitec: ticket de entrega", 8, 45 - 7)
            {
                Logo = Properties.Resources.logotipo,
                PrinterSettings = new PrinterSettings()
                {
                    PrinterName = settingsModel.PRINT_printer
                }
            };
        }

        public void BuildBody()
        {
            ticket.TextLocationMode = TicketPaperLocation.Body;
            Product product = folio.Product;
            Customer customer = folio.Customer;
            ticket.SideText("Fecha de expedición:", DateTime.Today.ToShortDateString());
            ticket.SideText("Entrega de equipo", $"Folio: {folio.ID}");
            ticket.SideText("Total:", $"${folio.Total}");
            ticket.Separator(TicketSeparator.Asterisk);
            ticket.CenterText("[Datos del cliente]");
            ticket.LeftText($"Nombre: {customer.Firstname} {customer.Lastname}");
            if (!string.IsNullOrWhiteSpace(customer.Telephone))
                ticket.LeftText($"Teléfono: {customer.Telephone}");
            if (!string.IsNullOrWhiteSpace(customer.Email))
                ticket.LeftText($"Email: {customer.Email}");
            ticket.Separator(TicketSeparator.Asterisk);
            ticket.CenterText("[Datos del equipo]");
            ticket.LeftText($"Marca: {product.Trademark}");
            ticket.LeftText($"Modelo: {product.Model}");
            ticket.LeftText($"No. de Serie:");
            ticket.LeftText($"{product.SerialNumber}");
            ticket.LeftText($"Descripción de la falla:");
            foreach (Issue i in detail.Issues)
                ticket.RightText($"* {i.Text}");
            ticket.Separator(TicketSeparator.Dash);
            ticket.LeftText("Acciones realizadas:");
            ticket.CenterText(detail.Action);
            ticket.LeftText("Observaciones:");
            ticket.CenterText(detail.Recommendation);
            ticket.Separator(TicketSeparator.Dash);
        }

        public void BuildFooter()
        {
            ticket.TextLocationMode = TicketPaperLocation.Footer;
            ticket.Text[TicketPaperLocation.Footer].Font = new Font(FontFamily.GenericMonospace.Name, 7, FontStyle.Regular);
            string[] terms = new string[]
            {
                "* Es obligación del cliente verificar que el equipo se encuentre completo, no se aceptan reclamaciones posteriores",
                "* Todas las reparaciones tienen una garantía de 15 días presentando este documento",
                "* Sus datos están protegidos bajo nuestro aviso de privacidad, si desea conocerlo escríbanos a:",
                "soporte@tecnomarketing.com.mx"
            };
            foreach (string term in terms)
                ticket.LeftText(term);
        }

        public void BuildHeader()
        {
            ticket.TextLocationMode = TicketPaperLocation.Header;
            string[] header = new string[]
            {
                "Rosalio Barajas Amezquita",
                "R.F.C. BAAR820625AH9",
                "Av. de los Normalistas 564, Colinas de La Normal, 44270 Guadalajara, Jal.",
                "Tel: (33) 3854-54-63 Ext 4",
                "E-mail: ventas@tecnomarketing.com.mx",
                "www.tecnomarketing.com.mx",
                "Horario: L-V. De 9-14 hrs y 16-19 hrs",
                "Sábados de 9 a 14 hrs"
            };
            foreach (string ht in header)
                ticket.CenterText(ht);
            ticket.Separator(TicketSeparator.Dash);
        }
    }
}
