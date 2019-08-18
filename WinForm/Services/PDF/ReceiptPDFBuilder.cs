using Entity;
using QuickAdmin.API;
using SelectPdf;
using Service.PDF;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UI.Models;

namespace UI.Services
{
    internal class ReceiptPDFBuilder : IPDFBuilder
    {
        private string filename;
        private IDictionary<string, string> flags;
        private readonly string template;
        private readonly string path_to_save;
        private readonly OrderData order;
        private readonly IRestAPI api;

        public ReceiptPDFBuilder(OrderData order, ISettings settings, IRestAPI api)
        {
            this.api = api;
            this.order = order;
            template = settings.PDFTemplate;
            path_to_save = settings.PathPDFfiles;
        }

        public string Build()
        {
            if (string.IsNullOrWhiteSpace(path_to_save))
            {
                throw new ArgumentException("Directory for ticket is not setted. Please, check settings");
            }

            if (string.IsNullOrWhiteSpace(template))
            {
                throw new ArgumentException("Design template is not found");
            }

            filename = $"{path_to_save}\\{order.ID}_{order.Customer.Firstname}{order.Customer.Lastname}.pdf";

            string html_products = string.Empty;
            foreach (OrderProduct or in order.Products)
            {
                decimal unitPrice = or.Price;
                decimal totalProduct = or.Total;
                html_products += $"<tr><td>{or.Name}</td><td>{or.Model}</td><td>${unitPrice.ToString("#.##")}</td><td>{or.Quantity}</td><td>${totalProduct.ToString("#.##")}</td></tr>";
            }

            var countries = api.GetCountries();
            Country payment_country = (from c in countries where order.PaymentAddress.CountryID == c.ID select c).FirstOrDefault();
            Zone payment_zone = (from z in api.GetZones(order.PaymentAddress.CountryID) where order.PaymentAddress.ZoneID == z.ID select z).FirstOrDefault();
            Country shipping_country = (from c in countries where order.PaymentAddress.CountryID == c.ID select c).FirstOrDefault();
            Zone shipping_zone = (from z in api.GetZones(order.ShippingAddress.CountryID) where order.ShippingAddress.ZoneID == z.ID select z).FirstOrDefault();

            var order_totals = order.OrderTotals.OrderBy(o => o.SortOrder);
            string html_totals_header = string.Empty;
            string html_totals_value = string.Empty;
            foreach (OrderTotal t in order_totals)
            {
                html_totals_header += $"<th>{t.Title}</th>";
                if (t.Code == "sub_total")
                {
                    decimal subtotal = t.Value;
                    html_totals_value += $"<td>${subtotal.ToString("#.##")}</td>";
                }
                else
                {
                    html_totals_value += $"<td>${t.Value.ToString("#.##")}</td>";
                }
            }

            flags = new Dictionary<string, string>()
            {
                // Order
                { "[FLAG_DATE_EXPEDITION]", DateTime.Today.ToShortDateString() },
                { "[FLAG_FOLIO]", order.ID.ToString() },
                { "[FLAG_DATE_ORDER]", order.DateAdded.ToShortDateString() },
                // Customer
                { "[FLAG_CNAME]", $"{order.Customer.Firstname} {order.Customer.Lastname}"},
                { "[FLAG_TELEPHONE]", $"{order.Customer.Telephone}" },
                { "[FLAG_EMAIL]", $"{order.Customer.Email}" },
                { "[FLAG_INVOICE]", $"{order.InvoicePrefix}{order.InvoiceNo}" },
                { "[FLAG_PAYMETHOD]", order.PaymentMethod.ToString() },
                { "[FLAG_SHIPMETHOD]", order.ShippingMethod.ToString() },
                // Payment
                { "[FLAG_PAYMENT_NAME]", $"{order.PaymentAddress.Firstname} {order.PaymentAddress.Lastname}" },
                { "[FLAG_PAYMENT_COMPANY]", order.PaymentAddress.Company },
                { "[FLAG_PAYMENT_ADDRESS]", order.PaymentAddress.Address1 },
                { "[FLAG_PAYMENT_CITY]", order.PaymentAddress.City },
                { "[FLAG_PAYMENT_POSTCODE]", order.PaymentAddress.Postcode },
                { "[FLAG_PAYMENT_ZONE]", payment_zone?.ToString() },
                { "[FLAG_PAYMENT_COUNTRY]", payment_country?.ToString() },
                // Shipping
                { "[FLAG_SHIPPING_NAME]", $"{order.ShippingAddress.Firstname} {order.ShippingAddress.Lastname}" },
                { "[FLAG_SHIPPING_COMPANY]", order.ShippingAddress.Company },
                { "[FLAG_SHIPPING_ADDRESS]", order.ShippingAddress.Address1 },
                { "[FLAG_SHIPPING_CITY]", order.ShippingAddress.City },
                { "[FLAG_SHIPPING_POSTCODE]", order.ShippingAddress.Postcode },
                { "[FLAG_SHIPPING_ZONE]", shipping_zone?.ToString() },
                { "[FLAG_SHIPPING_COUNTRY]", shipping_country?.ToString() },
                // Products
                { "[FLAG_PRODS]", html_products },
                // Totals
                { "[FLAG_TOTALS_HEADER]", html_totals_header },
                { "[FLAG_TOTALS_VALUE]", html_totals_value },
            };

            string html = File.ReadAllText(template);
            foreach (var flag in flags)
            {
                html = html.Replace(flag.Key, flag.Value);
            }

            HTMLtoPDF(html, filename);

            return filename;
        }

        private void HTMLtoPDF(string html, string pdf_name)
        {
            HtmlToPdf converter = new HtmlToPdf();
            //Setting up
            converter.Options.PdfPageSize = PdfPageSize.A4;
            converter.Options.PdfPageOrientation = PdfPageOrientation.Portrait;
            converter.Options.AutoFitWidth = HtmlToPdfPageFitMode.AutoFit;
            converter.Options.PdfDocumentInformation.Title = "OpenCart QuickAdmin: Order ticket";
            converter.Options.PdfDocumentInformation.Author = "OpenCart QuickAdmin";
            converter.Options.PdfDocumentInformation.Subject = "Order Ticket";
            // Make file
            PdfDocument doc = converter.ConvertHtmlString(html, template);
            doc.Save(pdf_name);
            doc.Close();
        }
    }
}
