using Entity;
using FluentValidation.Results;
using QuickAdmin.API;
using Service.Mailing;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Models;
using UI.Services;
using UI.Validators;
using UI.View;
using UI.ViewModel;

namespace UI.Presenter
{
    internal class CustomerPresenter
    {
        private readonly IView view;
        private readonly IRestAPI api;
        private readonly ISettings settings;

        public CustomerViewModel ViewModel { get; }

        public CustomerPresenter(IView view, IRestAPI api, ISettings settings, Customer customer)
        {
            this.view = view;
            this.settings = settings;
            this.api = api;
            ViewModel = new CustomerViewModel() { Customer = customer };
            WireUpViewModel();
        }

        private void WireUpViewModel()
        {
            ViewModel.Load = new CommandHandler(Load);
            ViewModel.Back = new CommandHandler(Back);
            ViewModel.Save = new CommandHandler(Save);
            ViewModel.SendMail = new CommandHandler(SendEmail, p => ViewModel.Customer.ID == 0);
        }

        private async void Save(object obj)
        {
            view.Loading(true);
            if (IsValid())
            {
                Customer c = ViewModel.Customer;
                string msg = await Task.Run(() => c.ID > 0 ? api.UpdateCustomer(c) : api.AddCustomer(c));
                view.Message(msg);
                // Extract Customer's ID.
                if (c.ID == 0)
                {
                    string id = Regex.Match(msg, @"\d+").Value;
                    if (!string.IsNullOrWhiteSpace(id))
                    {
                        c.ID = int.Parse(id);
                        Messenger.Instance.Send(c);
                    }
                }
            }
            view.Loading(false);
        }

        private void Back(object callback) => (callback as Action<bool>).Invoke(true);

        private async void Load(object sender)
        {
            view.Loading(true);
            await Task.Run(() =>
            {
                try
                {
                    ViewModel.CustomerGroups = api.GetCustomerGroups();
                    ViewModel.Countries = api.GetCountries();
                    Customer customer = ViewModel.Customer;
                    if (customer.ID > 0)
                    {
                        customer = api.GetCustomer(ViewModel.Customer);
                        if (customer.Address == null)
                        {
                            // The customer doesn't have default address yet.
                            customer.Address = new Address();
                        }
                        if (customer.Address.ZoneID != 0)
                        {
                            ViewModel.Zones = api.GetZones(customer.Address.CountryID);
                        }
                        ViewModel.Customer = customer;
                    }
                    else
                    {
                        ViewModel.Customer.Password = System.Web.Security.Membership.GeneratePassword(10, 2);
                    }
                    Messenger.Instance.Register<int>(this, async country_id => await Task.Run(() => ViewModel.Zones = api.GetZones(country_id)));
                }
                catch (InvalidOperationException ex)
                {
                    view.Message(ex.Message);
                }
            });
            view.Loading(false);
        }

        /// <summary>
        /// Send an Email to the customer when he/she is new
        /// </summary>
        private async void SendEmail(object arg)
        {
            bool again = false;
            do
            {
                try
                {
                    SettingsValidator sv = new SettingsValidator();
                    var result = sv.Validate(settings);
                    if (!result.IsValid)
                    {
                        throw new InvalidOperationException(result.Errors[0].ErrorMessage);
                    }

                    if (IsValid())
                    {
                        view.Loading(true);
                        view.Message("Enviando correo...");
                        IMailBuilder mailBuilder = new WelcomeMailBuilder(settings.Email, ViewModel.Customer.Email, ViewModel.Customer.Password);
                        await Task.Run(() => ServiceLocator.Default.GetService<MailingService>().Send(mailBuilder.BuildMessage(), settings.EmailPwd));
                        view.Message("Correo enviado");
                    }
                    else
                    {
                        view.Message("Ingrese los datos faltantes del cliente");
                    }
                }
                catch (Exception ex)
                {
                    again = DialogResult.Yes == view.Message("Error de servicio", $"{ex.Message}{Environment.NewLine}¿Reintentar?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
                finally
                {
                    view.Message(string.Empty);
                    view.Loading(false);
                }
            } while (again);
        }

        private bool IsValid()
        {
            ValidationResult results_customer = new CustomerValidator().Validate(ViewModel.Customer);
            if (!results_customer.IsValid)
            {
                for (int i = 0; i < results_customer.Errors.Count && i < 1; i++)
                {
                    view.Message(results_customer.Errors[i].ErrorMessage);
                }
            }

            return results_customer.IsValid;
        }
    }
}
