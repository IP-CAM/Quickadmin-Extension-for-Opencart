using Entity;
using QuickAdmin.API;
using QuickAdmin.API;
using System;
using System.Collections.Generic;

namespace UI.Proxy
{
    public sealed class RestAPIProxy : IRestAPI
    {
        private TimeSpan timeOut;
        private readonly int time_out;

        // Cache {
        private IEnumerable<Country> countries;
        private IEnumerable<CustomerGroup> customer_groups;
        private IEnumerable<Store> stores;
        private IEnumerable<Manufacturer> manufacturers;
        private IEnumerable<Category> categories;
        private IEnumerable<StockStatus> stockStatuses;
        private IEnumerable<Tax> taxes;
        private IEnumerable<Length> lengths;
        private IEnumerable<Weight> weights;
        private IEnumerable<Language> languages;
        private IEnumerable<Currency> currencies;
        private IEnumerable<PaymentMethod> paymentMethods;
        private IEnumerable<ShippingMethod> shippingMethods;
        private IEnumerable<OrderStatus> orderStatuses;
        // }

        public RestAPI API { get; }

        public RestAPIProxy(RestAPI api, int time_out)
        {
            API = api;
            this.time_out = time_out;
            GetData();
        }

        public IEnumerable<Zone> GetZones(int country_id) => API.GetZones(country_id);

        private void GetData()
        {
            countries = API.GetCountries();
            customer_groups = API.GetCustomerGroups();
            stores = API.GetStores();
            orderStatuses = API.GetOrderStatuses();
            shippingMethods = API.GetShippingMethods();
            paymentMethods = API.GetPaymentMethods();
            currencies = API.GetCurrencies();
            languages = API.GetLanguages();
            weights = API.GetWeightClasses();
            lengths = API.GetLengthClasses();
            taxes = API.GetTaxClasses();
            stockStatuses = API.GetStockStatuses();
            categories = API.GetCategories();
            manufacturers = API.GetManufacturers();
            // Reset time out
            timeOut = DateTime.Now.AddMinutes(time_out).TimeOfDay;
        }

        public APIResponse Login(string username, string key) => throw new NotImplementedException();

        public ServerData GetServerData() => API.GetServerData();

        public IEnumerable<PaymentMethod> GetPaymentMethods()
        {
            if (timeOut <= DateTime.Now.TimeOfDay)
                GetData();

            return paymentMethods;
        }

        public IEnumerable<ShippingMethod> GetShippingMethods()
        {
            if (timeOut <= DateTime.Now.TimeOfDay)
                GetData();

            return shippingMethods;
        }

        public IEnumerable<Language> GetLanguages()
        {
            if (timeOut <= DateTime.Now.TimeOfDay)
                GetData();

            return languages;
        }

        public IEnumerable<CustomerGroup> GetCustomerGroups()
        {
            if (timeOut <= DateTime.Now.TimeOfDay)
                GetData();

            return customer_groups;
        }

        public IEnumerable<Manufacturer> GetManufacturers()
        {
            if (timeOut <= DateTime.Now.TimeOfDay)
                GetData();

            return manufacturers;
        }

        public IEnumerable<Currency> GetCurrencies()
        {
            if (timeOut <= DateTime.Now.TimeOfDay)
                GetData();

            return currencies;
        }

        public IEnumerable<Country> GetCountries()
        {
            if (timeOut <= DateTime.Now.TimeOfDay)
                GetData();

            return countries;
        }

        public IEnumerable<Weight> GetWeightClasses()
        {
            if (timeOut <= DateTime.Now.TimeOfDay)
                GetData();

            return weights;
        }

        public IEnumerable<Length> GetLengthClasses()
        {
            if (timeOut <= DateTime.Now.TimeOfDay)
                GetData();

            return lengths;
        }

        public IEnumerable<Category> GetCategories()
        {
            if (timeOut <= DateTime.Now.TimeOfDay)
                GetData();

            return categories;
        }

        public IEnumerable<Tax> GetTaxClasses()
        {
            if (timeOut <= DateTime.Now.TimeOfDay)
                GetData();

            return taxes;
        }

        public IEnumerable<StockStatus> GetStockStatuses()
        {
            if (timeOut <= DateTime.Now.TimeOfDay)
                GetData();

            return stockStatuses;
        }

        public IEnumerable<OrderStatus> GetOrderStatuses()
        {
            if (timeOut <= DateTime.Now.TimeOfDay)
                GetData();

            return orderStatuses;
        }

        public IEnumerable<Store> GetStores()
        {
            if (timeOut <= DateTime.Now.TimeOfDay)
                GetData();

            return stores;
        }

        public IList<Customer> GetCustomers(IDictionary<string, object> @params) => API.GetCustomers(@params);

        public Customer GetCustomer(Customer customer) => API.GetCustomer(customer);

        public string DeleteCustomer(Customer customer) => API.DeleteCustomer(customer);

        public string AddCustomer(Customer customer) => API.AddCustomer(customer);

        public string UpdateCustomer(Customer customer) => API.UpdateCustomer(customer);

        public IEnumerable<Address> GetAddresses(Customer customer) => API.GetAddresses(customer);

        public Address GetAddress(int address_id) => API.GetAddress(address_id);

        public IList<Order> GetOrders(IDictionary<string, object> @params) => API.GetOrders(@params);

        public Order GetOrder(Order order) => API.GetOrder(order);

        public string AddOrder(Order order) => API.AddOrder(order);

        public string DeleteOrder(Order order) => API.DeleteOrder(order);

        public string UpdateOrder(Order order) => API.UpdateOrder(order);

        public IList<Product> GetProducts(IDictionary<string, object> @params) => API.GetProducts(@params);

        public string AddProduct(Product product) => API.AddProduct(product);

        public string UpdateProduct(Product product) => API.UpdateProduct(product);

        public string DeleteProduct(Product product) => API.DeleteProduct(product);

        public Product GetProduct(Product product) => API.GetProduct(product);
    }
}
