using Entity;
using QuickAdmin.API;
using Service;
using Service.Mailing;
using Service.Ticket;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using UI.Models;
using UI.Services;
using UI.Services.Tickets;
using UI.View;

namespace UI.ViewModel
{
    internal class OrderReviewViewModel : ViewModelBase
    {
        private ICommand _backTo;
        private ICommand _save;
        private ICommand _load;

        private Order order;
        private readonly IOrderReviewView view;
        private readonly IRestAPI api;
        private readonly ISettings settings;
        private IEnumerable<CustomerGroup> customerGroups;
        private IEnumerable<Country> countries;
        private Zone payment_zone;
        private Zone shipping_zone;
        private bool sendMail;
        private bool printTicket;
        private string pdf_file;

        public OrderReviewViewModel(IOrderReviewView view, IRestAPI api, ISettings settings, Order order)
        {
            this.order = order;
            this.view = view;
            this.api = api;
            this.settings = settings;
        }

        public string OrderNo => $"Venta (#{order.ID})";
        public string Store => (order as OrderData).Store.Name;
        public string Date => (order as OrderData).DateAdded.ToShortDateString();
        public string PaymentMethod => (order as OrderData).PaymentMethod.Title;
        public string ShippingMethod => (order as OrderData).ShippingMethod.Title;
        public string CustomerName => $"{(order as OrderData).Customer.Firstname} {(order as OrderData).Customer.Lastname}";
        public string CustomerGroup
            => (from cg in customerGroups
                where cg.ID == (order as OrderData).Customer.CustomerGroupID
                select cg.Name).FirstOrDefault();
        public string CustomerEmail => (order as OrderData).Customer.Email;
        public string CustomerTelephone => (order as OrderData).Customer.Telephone;
        public string Invoice => $"{(order as OrderData).InvoicePrefix}{(order as OrderData).InvoiceNo}";
        public string Reward => (order as OrderData).Reward.ToString();
        public string Affiliate => (order as OrderData).Commission.ToString();
        public string PaymentInfo
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                OrderData order = this.order as OrderData;
                sb.AppendLine($"{order.PaymentAddress.Firstname} {order.PaymentAddress.Lastname}");
                sb.AppendLine(order.PaymentAddress.Company);
                sb.AppendLine(order.PaymentAddress.Address1);
                sb.AppendLine(order.PaymentAddress.Address2);
                sb.AppendLine($"{order.PaymentAddress.City} {order.PaymentAddress.Postcode}");
                Country country = (from c in countries where c.ID == order.PaymentAddress.CountryID select c).FirstOrDefault();
                sb.AppendLine($"{country}, {payment_zone}");
                return sb.ToString();
            }
        }
        public string ShippingInfo
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                OrderData order = this.order as OrderData;
                sb.AppendLine($"{order.ShippingAddress.Firstname} {order.ShippingAddress.Lastname}");
                sb.AppendLine(order.ShippingAddress.Company);
                sb.AppendLine(order.ShippingAddress.Address1);
                sb.AppendLine(order.ShippingAddress.Address2);
                sb.AppendLine($"{order.ShippingAddress.City} {order.ShippingAddress.Postcode}");
                Country country = (from c in countries where c.ID == order.ShippingAddress.CountryID select c).FirstOrDefault();
                sb.AppendLine($"{country}, {shipping_zone}");
                return sb.ToString();
            }
        }

        public IList<OrderProduct> Products => (order as OrderData).Products;

        public string Totals
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                var items = (order as OrderData).OrderTotals.OrderBy(t => t.SortOrder);
                foreach (OrderTotal o in items)
                {
                    sb.AppendLine($"{o.Title}: ${o.Value.ToString("#.##")}");
                }

                return sb.ToString();
            }
        }

        public bool SendMail
        {
            get => sendMail;
            set
            {
                sendMail = value;
                OnPropertyChanged(nameof(sendMail));
            }
        }

        public bool PrintTicket
        {
            get => printTicket;
            set
            {
                if (printTicket == value)
                {
                    return;
                }

                printTicket = value;
                OnPropertyChanged(nameof(PrintTicket));
            }
        }

        public ICommand BackTo
        {
            get
            {
                if (_backTo == null)
                {
                    _backTo = new CommandHandler(Return);
                }

                return _backTo;
            }
        }

        public ICommand Save
        {
            get
            {
                if (_save == null)
                {
                    _save = new CommandHandler(SaveFn);
                }

                return _save;
            }
        }

        public ICommand Load
        {
            get
            {
                if (_load == null)
                {
                    _load = new CommandHandler(LoadFn);
                }

                return _load;
            }
        }

        private async void LoadFn(object obj)
        {
            view.Loading(true);
            try
            {
                await Task.Run(() =>
                {
                    order = api.GetOrder(order) as OrderData;
                    countries = api.GetCountries();
                    customerGroups = api.GetCustomerGroups();
                    var payment_zones = api.GetZones((order as OrderData).PaymentAddress.CountryID);
                    var shipping_zones = api.GetZones((order as OrderData).ShippingAddress.CountryID);
                    payment_zone = (from z in payment_zones where z.ID == (order as OrderData).PaymentAddress.ZoneID select z).FirstOrDefault();
                    shipping_zone = (from z in shipping_zones where z.ID == (order as OrderData).ShippingAddress.ZoneID select z).FirstOrDefault();
                });
            }
            catch (InvalidOperationException ex)
            {
                view.Message(ex.Message);
            }
            finally
            {
                view.Loading(false);
            }
        }

        private async void SaveFn(object obj)
        {
            view.Loading(true);
            if (SendMail && await GeneratePDFAsync())
                SendEmail();
            if (PrintTicket)
                PrintTicketFn();
            view.Loading(false);
        }

        private void Return(object callback) => (callback as Action<bool>)(true);

        private async void SendEmail()
        {
            OrderData order = this.order as OrderData;
            IMailBuilder mailBuilder = new OrderMailBuilder(settings.Email, order.Customer.Email, pdf_file);
            var mail = mailBuilder.BuildMessage();
            DialogResult result = DialogResult.None;
            do
            {
                try
                {
                    view.Loading(true);
                    view.Message("Enviando correo...");
                    await Task.Run(() => ServiceLocator.Default.GetService<MailingService>().Send(mail, settings.EmailPwd));
                    view.Message("Correo enviado");
                }
                catch (Exception ex)
                {
                    result = view.Message("Error al enviar correo", $"{ex.Message}{Environment.NewLine}¿Reintentar envío de correo?", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    view.Loading(false);
                    await Task.Delay(TimeSpan.FromSeconds(3));
                    view.Message(string.Empty);
                }
            } while (result == DialogResult.Retry);
        }

        private async Task<bool> GeneratePDFAsync()
        {
            DialogResult answer = DialogResult.None;
            bool success = false;
            if (!settings.SaveFiles)
            {
                view.Message("Establezca la configuración para generar comprobantes de venta");
                return false;
            }
            do
            {
                try
                {
                    view.Loading(true);
                    view.Message("Generando comprobante de venta...");
                    pdf_file = await Task.Run(() => new ReceiptPDFBuilder(order as OrderData, settings, api).Build());
                    answer = view.Message("Comprobante de venta", $"El archivo ha sido creado correctamente, {Environment.NewLine}¿Desea abrir el directorio de archivos?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                        Process.Start("explorer.exe", $"/select,\"{pdf_file}\"");
                    success = true;
                    view.Message(string.Empty);
                }
                catch (ArgumentException ex)
                {
                    success = false;
                    answer = view.Message("Error de servicio: Archivo PDF", ex.Message, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    view.Loading(false);
                }
            } while (answer == DialogResult.Retry);

            return success;
        }

        private void PrintTicketFn()
        {
            view.Message("Imprimiendo ticket...");
            ITicketBuilder ticketBuilder = new ReceiptTicketBuilder(order as OrderData, api);
            TicketDocument ticket = new TicketDocBuilder(ticketBuilder).BuildTicket();
            DialogResult answer = DialogResult.None;
            do
            {
                try
                {
                    ServiceLocator.Default.GetService<PrintingService>().Print(view.PrintDialog, ticket);
                    answer = DialogResult.None;
                }
                catch (Exception ex)
                {
                    answer = view.Message("Error en el servicio: Ticket printer", ex.Message, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            } while (answer == DialogResult.Retry);
            view.Message(string.Empty);
        }
    }
}