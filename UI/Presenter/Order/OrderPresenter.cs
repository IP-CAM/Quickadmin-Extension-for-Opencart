using Entity;
using QuickAdmin.API;
using QuickAdmin.API;
using Service;
using Service.Mailing;
using Service.Ticket;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Models;
using UI.Properties;
using UI.Services;
using UI.Services.Tickets;
using UI.Validators;
using UI.View;
using UI.ViewModel;

namespace UI.Presenter
{
    internal class OrderPresenter
    {
        private readonly IOrderView view;
        private readonly IRestAPI api;
        private readonly ISettings settings;
        private Order order;
        private string pdf_file;

        public OrderViewModel OrderVM { get; private set; }

        public CustomerTabViewModel CustomerTabVM { get; private set; }
        public ProductsTabViewModel ProductsTabVM { get; private set; }
        public PaymentTabViewModel PaymentTabVM { get; private set; }
        public ShippingTabViewModel ShippingTabVM { get; private set; }
        public TotalTabViewModel TotalTabVM { get; private set; }

        public OrderPresenter(IOrderView view, IRestAPI api, ISettings settings, Order order)
        {
            this.view = view;
            this.order = order;
            this.api = api;
            this.settings = settings;
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            view.LoadView += View_LoadView;
            Messenger.Instance.Register<Customer>(this, async c =>
            {
                CustomerTabVM.Customer = c;
                ShippingTabVM.Addresses = PaymentTabVM.Addresses = await Task.Run(() => api.GetAddresses(c));
            });
        }

        private async void View_LoadView(object sender, EventArgs e)
        {
            view.Loading(true);
            try
            {
                await Task.Run(async () =>
                {
                    if (this.order.ID > 0)
                    {
                        this.order = await Task.Run(() => api.GetOrder(this.order)) as OrderData;
                    }

                    OrderData order = this.order as OrderData;
                    OrderVM = new OrderViewModel();
                    CustomerTabVM = new CustomerTabViewModel(order, api, settings);
                    ProductsTabVM = new ProductsTabViewModel(order, api.GetProducts(null));
                    PaymentTabVM = new PaymentTabViewModel(order, api.GetPaymentMethods(), api.GetCountries(), api.GetZones);
                    ShippingTabVM = new ShippingTabViewModel(order, api.GetShippingMethods(), api.GetCountries(), api.GetZones);
                    TotalTabVM = new TotalTabViewModel(order, api.GetOrderStatuses());
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

        public async void Save()
        {
            OrderData o = order as OrderData;
            view.Loading(true);
            if (IsValid())
            {
                string message = await Task.Run(() => order.ID > 0 ? api.UpdateOrder(order) : api.AddOrder(order));
                view.Message(message);
                // Extract Order's ID
                if (order.ID == 0)
                {
                    string id = Regex.Match(message, @"\d+").Value;
                    if (!string.IsNullOrWhiteSpace(id))
                    {
                        order.ID = int.Parse(id);
                    }
                }
                await Task.Delay(TimeSpan.FromSeconds(2));
                view.Message(string.Empty);
                if (order.ID > 0)
                {
                    if (OrderVM.SendEmail & await GeneratePDFAsync())
                    {
                        SendEmailAsync();
                    }
                    PrintTicket();
                }
            }
            view.Loading(false);
        }

        private void PrintTicket()
        {
            view.Message("Printing ticket...");
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
                    answer = view.Message("There was an error: Ticket printer", ex.Message, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            } while (answer == DialogResult.Retry);
            view.Message(string.Empty);
        }

        private async void SendEmailAsync()
        {
            OrderData order = this.order as OrderData;
            IMailBuilder mailBuilder = new OrderMailBuilder(Settings.Default.eEmail, order.Customer.Email, pdf_file);
            var mail = mailBuilder.BuildMessage();
            DialogResult result = DialogResult.None;
            do
            {
                try
                {
                    await Task.Run(() => ServiceLocator.Default.GetService<MailingService>().Send(mail, Settings.Default.ePwd));
                }
                catch (Exception ex)
                {
                    result = view.Message("There was an error sending the mail", $"{ex.Message}{Environment.NewLine}Try again?", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            } while (result == DialogResult.Retry);
        }

        private async Task<bool> GeneratePDFAsync()
        {
            DialogResult answer = DialogResult.None;
            bool success = false;
            if (!Settings.Default.saveFile)
            {
                view.Message("Please, check settings to be allowed for generating tickets");
                return false;
            }
            do
            {
                try
                {
                    view.Message("Creating ticket...");
                    pdf_file = await Task.Run(() => new ReceiptPDFBuilder(order as OrderData, settings, api).Build());
                    answer = view.Message("Ticket", $"The file has been created succesfully, {Environment.NewLine}Do you want to open the directory where it's allocated?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == DialogResult.Yes)
                    {
                        Process.Start("explorer.exe", $"/select,\"{pdf_file}\"");
                    }

                    success = true;
                    view.Message(string.Empty);
                }
                catch (ArgumentException ex)
                {
                    success = false;
                    answer = view.Message("Service Error: PDF File", ex.Message, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            } while (answer == DialogResult.Retry);

            return success;
        }

        private bool IsValid()
        {
            var result = new OrderValidator().Validate(order as OrderData);
            if (!result.IsValid)
            {
                foreach (var msg in result.Errors)
                {
                    view.Message(msg.ErrorMessage);
                }
            }

            return result.IsValid;
        }

        public void BackTo(Action<bool> fn) => fn(true);
    }
}
