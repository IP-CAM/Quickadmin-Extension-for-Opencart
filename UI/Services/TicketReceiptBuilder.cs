using EntityLayer;
using Presentation.Models;
using Service.Ticket;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;

namespace Presentation.Utils.Ticket
{
    internal class TicketReceiptBuilder : ITicketBuilder
    {
        private TicketDocument ticket;
        private readonly Folio folio;
        private readonly ICollection<Issue> issues;

        public TicketReceiptBuilder(Folio folio, ICollection<Issue> issues, ISettingsModel settingsModel)
        {
            this.folio = folio;
            this.issues = issues;
            ticket = new TicketDocument("Servitec: ticket de recepción", 8, 45 - 7)
            {
                Logo = Properties.Resources.logotipo,
                PrinterSettings = new PrinterSettings()
                {
                    PrinterName = settingsModel.PRINT_printer
                }
            };
        }

        public TicketDocument GetTicket() => ticket;

        public void BuildBody()
        {
            Customer customer = folio.Customer;
            Product product = folio.Product;
            ticket.TextLocationMode = TicketPaperLocation.Body;
            ticket.SideText("Fecha de expedición:", DateTime.Today.ToShortDateString());
            ticket.SideText("Recepción de equipos", $"Folio: {folio.ID}");
            ticket.Separator(TicketSeparator.Dash);
            ticket.CenterText("[Datos del cliente]");
            ticket.LeftText($"Nombre: {customer.Firstname} {customer.Lastname}");
            //if (!string.IsNullOrWhiteSpace(customer.Telephone))
            //    ticket.LeftText($"Teléfono: {customer.Telephone}");
            if (!string.IsNullOrWhiteSpace(customer.Email))
                ticket.LeftText($"Email: {customer.Email}");
            ticket.Separator(TicketSeparator.Asterisk);
            ticket.CenterText("[Datos del equipo]");
            ticket.LeftText($"Marca: {product.Trademark}");
            ticket.LeftText($"Modelo: {product.Model}");
            ticket.LeftText($"No. de Serie:");
            ticket.LeftText($"{product.SerialNumber}");
            ticket.LeftText($"Descripción de la falla:");
            foreach (Issue i in issues)
                ticket.RightText($"* {i.Text}");
            ticket.Separator(TicketSeparator.Dash);
        }

        public void BuildFooter()
        {
            ticket.TextLocationMode = TicketPaperLocation.Footer;
            ticket.Text[TicketPaperLocation.Footer].Font = new Font(FontFamily.GenericMonospace.Name, 7, FontStyle.Regular);
            string[] terms = new string[]
            {
                "*En casos en los que el equipo almacene información no respaldada, el cliente se hace responsable del mismo.",
                "*Toda garantía o reparación de equipos de almacenamiento, aplica respecto a daño físico y no sobre la información contenida.",
                "*El cliente tendrá un plazo máximo de 5 días hábiles para recoger su equipo, posteriores a la notificación de que el mismo se encuentre listo. Después del plazo, no nos hacemos responsables de equipos no reclamados.",
                "*Toda reparación dentro del período de garantía, se encuentra sujeta a los términos que la póliza marque.",
                "*De ser necesario el envío por paquetería dentro o fuera de la zona metropolitana, el cliente cubrirá los gastos que éste genere.",
                "*Toda revisión de equipo causará un cargo de 200 pesos, al aceptar el presupuesto se elimina el cargo de revisión.",
                "*El cliente se hace responsable de que la información presentada en el documento es correcta y accepta los términos y condiciones en el mismo."
            };
            foreach (string tc in terms)
                ticket.LeftText(tc);
        }

        public void BuildHeader()
        {
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
