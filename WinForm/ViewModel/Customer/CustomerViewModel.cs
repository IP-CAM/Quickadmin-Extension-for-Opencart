using Entity;
using System.Collections.Generic;
using System.Windows.Input;
using UI.Services;

namespace UI.ViewModel
{
    internal sealed class CustomerViewModel : ViewModelBase
    {
        private IEnumerable<CustomerGroup> groups;
        private IEnumerable<Country> countries;
        private IEnumerable<Zone> zones;
        private Customer customer;

        public Customer Customer
        {
            get => customer;
            set
            {
                customer = value;
                // Customer
                CustomerGroupID = value.CustomerGroupID;
                CustomerFisrtname = value.Firstname;
                CustomerLastname = value.Lastname;
                Email = value.Email;
                Telephone = value.Telephone;
                Newsletter = value.Newsletter;
                Status = value.Status;
                Safe = value.Safe;
                // Address
                if (value.Address == null)
                    return;
                AddressFirstname = value.Address.Firstname;
                AddressLastname = value.Address.Lastname;
                Company = value.Address.Company;
                Address_1 = value.Address.Address1;
                Address_2 = value.Address.Address2;
                City = value.Address.City;
                Postcode = value.Address.Postcode;
                CountryID = value.Address.CountryID;
                ZoneID = value.Address.ZoneID;
            }
        }

        // Customer
        public IEnumerable<CustomerGroup> CustomerGroups
        {
            get => groups;
            set
            {
                groups = value;
                OnPropertyChanged(nameof(CustomerGroups));
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
        public string CustomerFisrtname
        {
            get => Customer.Firstname;
            set
            {
                Customer.Firstname = value;
                OnPropertyChanged(nameof(CustomerFisrtname));
            }
        }
        public string CustomerLastname
        {
            get => Customer.Lastname;
            set
            {
                Customer.Lastname = value;
                OnPropertyChanged(nameof(CustomerLastname));
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
        public bool Newsletter
        {
            get => Customer.Newsletter;
            set
            {
                Customer.Newsletter = value;
                OnPropertyChanged(nameof(Newsletter));
            }
        }
        public bool Status
        {
            get => Customer.Status;
            set
            {
                Customer.Status = value;
                OnPropertyChanged(nameof(Status));
            }
        }
        public bool Safe
        {
            get => Customer.Safe;
            set
            {
                Customer.Safe = value;
                OnPropertyChanged(nameof(Safe));
            }
        }
        // Address
        public string AddressFirstname
        {
            get => Customer.Address.Firstname;
            set
            {
                Customer.Address.Firstname = value;
                OnPropertyChanged(nameof(AddressFirstname));
            }
        }
        public string AddressLastname
        {
            get => Customer.Address.Lastname;
            set
            {
                Customer.Address.Lastname = value;
                OnPropertyChanged(nameof(AddressLastname));
            }
        }
        public string Company
        {
            get => Customer.Address.Company;
            set
            {
                Customer.Address.Company = value;
                OnPropertyChanged(nameof(Company));
            }
        }
        public string Address_1
        {
            get => Customer.Address.Address1;
            set
            {
                Customer.Address.Address1 = value;
                OnPropertyChanged(nameof(Address_1));
            }
        }
        public string Address_2
        {
            get => Customer.Address.Address2;
            set
            {
                Customer.Address.Address2 = value;
                OnPropertyChanged(nameof(Address_2));
            }
        }
        public string City
        {
            get => Customer.Address.City;
            set
            {
                Customer.Address.City = value;
                OnPropertyChanged(nameof(City));
            }
        }
        public string Postcode
        {
            get => Customer.Address.Postcode;
            set
            {
                Customer.Address.Postcode = value;
                OnPropertyChanged(nameof(Postcode));
            }
        }
        public int CountryID
        {
            get => Customer.Address.CountryID;
            set
            {
                Customer.Address.CountryID = value;
                Messenger.Instance.Send(value);
                OnPropertyChanged(nameof(CountryID));
            }
        }
        public int ZoneID
        {
            get => Customer.Address.ZoneID;
            set
            {
                Customer.Address.ZoneID = value;
                OnPropertyChanged(nameof(ZoneID));
            }
        }
        public IEnumerable<Zone> Zones
        {
            get => zones;
            set
            {
                zones = value;
                OnPropertyChanged(nameof(Zones));
            }
        }
        public IEnumerable<Country> Countries
        {
            get => countries;
            set
            {
                countries = value;
                OnPropertyChanged(nameof(Countries));
            }
        }

        // Commands
        public ICommand SendMail { get; set; }
        public ICommand Load { get; set; }
        public ICommand Save { get; set; }
        public ICommand Back { get; set; }
    }
}
