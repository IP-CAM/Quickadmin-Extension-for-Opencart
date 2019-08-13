using Entity;
using System.Collections.Generic;

namespace QuickAdmin.API
{
    public interface IRestAPI
    {
        APIResponse Login(string username, string key);
        // Common API
        ServerData GetServerData();
        IEnumerable<PaymentMethod> GetPaymentMethods();
        IEnumerable<ShippingMethod> GetShippingMethods();
        IEnumerable<Language> GetLanguages();
        IEnumerable<CustomerGroup> GetCustomerGroups();
        IEnumerable<Manufacturer> GetManufacturers();
        IEnumerable<Currency> GetCurrencies();
        IEnumerable<Country> GetCountries();
        IEnumerable<Zone> GetZones(int country_id);
        IEnumerable<Weight> GetWeightClasses();
        IEnumerable<Length> GetLengthClasses();
        IEnumerable<Category> GetCategories();
        IEnumerable<Tax> GetTaxClasses();
        IEnumerable<StockStatus> GetStockStatuses();
        IEnumerable<OrderStatus> GetOrderStatuses();
        IEnumerable<Store> GetStores();
        // Customer API
        IList<Customer> GetCustomers(IDictionary<string, object> @params);
        Customer GetCustomer(Customer customer);
        string DeleteCustomer(Customer customer);
        string AddCustomer(Customer customer);
        string UpdateCustomer(Customer customer);
        IEnumerable<Address> GetAddresses(Customer customer);
        Address GetAddress(int address_id);
        // Order API
        IList<Order> GetOrders(IDictionary<string, object> @params);
        Order GetOrder(Order order);
        string AddOrder(Order order);
        string DeleteOrder(Order order);
        string UpdateOrder(Order order);
        // Product API
        IList<Product> GetProducts(IDictionary<string, object> @params);
        string AddProduct(Product product);
        string UpdateProduct(Product product);
        string DeleteProduct(Product product);
        Product GetProduct(Product product);
    }
}
