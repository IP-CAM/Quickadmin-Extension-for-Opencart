using Entity;
using QuickAdmin.API;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Input;
using UI.Models;
using UI.Services;
using UI.View;

namespace UI.ViewModel
{
    internal class CustomerTabViewModel : ViewModelBase
    {
        private OrderData order;
        private readonly IEnumerable<Customer> customers;
        private readonly IRestAPI api;
        private readonly ISettings settings;

        public CustomerTabViewModel(OrderData order, IRestAPI api, ISettings settings)
        {
            this.order = order;
            this.api = api;
            this.settings = settings;
            customers = this.api.GetCustomers(null);
            CustomerGroups = this.api.GetCustomerGroups();
            Stores = this.api.GetStores();
            Currencies = this.api.GetCurrencies();
            Customer = order.Customer;
            AddCustomer = new CommandHandler(AddCustomerFn);
            SelectedCustomer = new CommandHandler(SelectCustomerFn);
            Customers = new AutoCompleteStringCollection();
            Customers.AddRange((from c in customers
                                orderby c.ID, c.Firstname
                                select $"{c.Firstname} {c.Lastname}, {c.ID}").ToArray());
        }

        public AutoCompleteStringCollection Customers { get; }
        public IEnumerable<Store> Stores { get; private set; }
        public IEnumerable<Currency> Currencies { get; }
        public IEnumerable<CustomerGroup> CustomerGroups { get; }

        public Store Store
        {
            get => order.Store;
            set
            {
                order.Store = value;
                OnPropertyChanged(nameof(Store));
            }
        }
        public Currency Currency
        {
            get => order.Currency;
            set
            {
                order.Currency = value;
                OnPropertyChanged(nameof(Currency));
            }
        }
        public int CustomerGroupID
        {
            get => Customer.CustomerGroupID;
            set
            {
                Customer.CustomerGroupID = value;
                OnPropertyChanged(nameof(CustomerGroupID));
            }
        }

        public Customer Customer
        {
            private get => order.Customer;
            set
            {
                order.Customer = value;
                CustomerGroupID = value.CustomerGroupID;
                Firstname = value.Firstname;
                Lastname = value.Lastname;
                Email = value.Email;
                Telephone = value.Telephone;
            }
        }

        public string Firstname
        {
            get => Customer.Firstname;
            set
            {
                Customer.Firstname = value;
                OnPropertyChanged(nameof(Firstname));
            }
        }
        public string Lastname
        {
            get => Customer.Lastname;
            set
            {
                Customer.Lastname = value;
                OnPropertyChanged(nameof(Lastname));
            }
        }
        public string Email
        {
            get => Customer.Email;
            set
            {
                Customer.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        public string Telephone
        {
            get => Customer.Telephone;
            set
            {
                Customer.Telephone = value;
                OnPropertyChanged(nameof(Telephone));
            }
        }

        public ICommand AddCustomer { get; }
        public ICommand SelectedCustomer { get; }

        private void AddCustomerFn(object obj) => Messenger.Instance.Send(new CustomerView(api, settings, new Customer() { Address = new Address() }) as IView);

        private void SelectCustomerFn(object obj)
        {
            string txt = obj as string;
            string result = Regex.Match(txt, @"\d+").Value;
            if (string.IsNullOrWhiteSpace(result))
            {
                return;
            }

            int id = int.Parse(result);
            var customer = (from c in customers where c.ID == id select c).FirstOrDefault();
            Messenger.Instance.Send(customer);
        }
    }
}
