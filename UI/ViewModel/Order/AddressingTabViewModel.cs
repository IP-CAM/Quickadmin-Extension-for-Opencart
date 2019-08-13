using Entity;
using System;
using System.Collections.Generic;

namespace UI.ViewModel
{
    internal abstract class AddressingTabViewModel : ViewModelBase
    {
        protected Address address;
        private IEnumerable<Zone> zones;
        protected readonly OrderData order;
        private IEnumerable<Address> addresses;
        private readonly Func<int, IEnumerable<Zone>> callbackGetZones;

        public AddressingTabViewModel(OrderData order, Address address, IEnumerable<Country> countries, Func<int, IEnumerable<Zone>> callbackGetZones)
        {
            this.order = order;
            this.callbackGetZones = callbackGetZones;
            Address = address;
            Countries = countries;
        }

        public Address Address
        {
            get => address;
            set
            {
                address = value;
                Firstname = value.Firstname;
                Lastname = value.Lastname;
                Company = value.Company;
                Address1 = value.Address1;
                Address2 = value.Address2;
                City = value.City;
                Postcode = value.Postcode;
                CountryID = value.CountryID;
                ZoneID = value.ZoneID;
                SetAddress();
            }
        }

        protected abstract void SetAddress();

        public IEnumerable<Country> Countries { get; }

        public IEnumerable<Zone> Zones
        {
            get => zones;
            set
            {
                zones = value;
                OnPropertyChanged(nameof(Zones));
            }
        }

        public IEnumerable<Address> Addresses
        {
            get => addresses;
            set
            {
                addresses = value;
                OnPropertyChanged(nameof(Addresses));
            }
        }

        public string Firstname
        {
            get => Address.Firstname;
            set
            {
                Address.Firstname = value;
                OnPropertyChanged(nameof(Firstname));
            }
        }
        public string Lastname
        {
            get => Address.Lastname;
            set
            {
                Address.Lastname = value;
                OnPropertyChanged(nameof(Lastname));
            }
        }
        public string Company
        {
            get => Address.Company;
            set
            {
                Address.Company = value;
                OnPropertyChanged(nameof(Company));
            }
        }
        public string Address1
        {
            get => Address.Address1;
            set
            {
                Address.Address1 = value;
                OnPropertyChanged(nameof(Address1));
            }
        }
        public string Address2
        {
            get => Address.Address2;
            set
            {
                Address.Address2 = value;
                OnPropertyChanged(nameof(Address2));
            }
        }
        public string City
        {
            get => Address.City;
            set
            {
                Address.City = value;
                OnPropertyChanged(nameof(City));
            }
        }
        public string Postcode
        {
            get => Address.Postcode;
            set
            {
                Address.Postcode = value;
                OnPropertyChanged(nameof(Postcode));
            }
        }
        public int CountryID
        {
            get => Address.CountryID;
            set
            {
                Address.CountryID = value;
                Zones = callbackGetZones(value);
                OnPropertyChanged(nameof(CountryID));
            }
        }
        public int ZoneID
        {
            get => Address.ZoneID;
            set
            {
                Address.ZoneID = value;
                OnPropertyChanged(nameof(ZoneID));
            }
        }
    }
}
