using Entity;
using Flurl;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace QuickAdmin.API
{
    public class RestAPI : IRestAPI
    {
        private readonly string route;
        private string token;
        private readonly Url baseURL;
        private readonly RestClient client;

        public RestAPI(string base_url)
        {
            route = Api.Properties.Settings.Default.route;
            baseURL = base_url.AppendPathSegment("index.php");
            client = new RestClient(baseURL)
            {
                Encoding = Encoding.UTF8,
                CookieContainer = new CookieContainer()
            };
        }

        private string SendRequest(string api_action, string json_data)
        { // TODO: something wrong in server session api_id. The server doesn't save the session.
            client.BaseUrl = baseURL.SetQueryParam("route", $"{route}/{api_action}").ToUri();
            IRestRequest request = new RestRequest(Method.POST);
            // Header params
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded ; charset=UTF-8");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("content-length", "190");
            // Body params
            request.AddParameter("data", json_data);
            request.AddParameter("api_token", token);
            // Post request
            RestResponse response = client.Post(request) as RestResponse;
            // Data response treatment
            return DataTreatment(response.Content);
        }

        private string SendRequest(string api_action, string body_params, IDictionary<string, string> filenames)
        {
            client.BaseUrl = baseURL.SetQueryParam("route", $"{route}/{api_action}").ToUri();
            IRestRequest request = new RestRequest(Method.POST)
            {
                AlwaysMultipartFormData = true
            };
            // Header params
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("Connection", "keep-alive");
            request.AddHeader("content-length", "190");
            request.AddHeader("Content-Type", "multipart/form-data");
            // Body params
            request.AddParameter("data", body_params);
            request.AddParameter("api_token", token);
            foreach (var kvp in filenames)
            {
                request.AddFile(kvp.Key, kvp.Value);
            }
            // Post request
            RestResponse response = client.Post(request) as RestResponse;
            // Data response treatment
            return DataTreatment(response.Content);
        }

        private string DataTreatment(string data)
        {
            try
            {
                data = data.Substring(data.IndexOf('{') - 1);
                if (data.StartsWith(">"))
                {
                    data = data.TrimStart('>');
                }
            }
            catch
            {
                try
                {
                    data = data.Substring(data.IndexOf('['));
                }
                catch
                {
                    return string.Empty;
                }
            }
            return data;
        }

        // Login
        public APIResponse Login(string username, string key)
        {
            string response = SendRequest("login", $"{{ \"username\" : \"{username}\", \"key\" : \"{key}\" }}");
            try
            {
                var resp = JsonConvert.DeserializeObject<APIResponse>(response);
                if (!string.IsNullOrWhiteSpace(resp.Token))
                {
                    token = resp.Token;
                }
                return resp;
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        // Customer API
        public string DeleteCustomer(Customer customer)
        {
            string response = SendRequest("deleteCustomer", JsonConvert.SerializeObject(customer));
            try
            {
                return JsonConvert.DeserializeObject<APIResponse>(response).Message;
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public string AddCustomer(Customer customer)
        {
            string json_customer = JsonConvert.SerializeObject(customer);
            string response = SendRequest("addCustomer", json_customer);
            try
            {
                return JsonConvert.DeserializeObject<APIResponse>(response).Message;
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public Address GetAddress(int address_id)
        {
            string response = SendRequest("getAddress", $@"{{ ""address_id"" : {address_id} }}");
            try
            {
                return JsonConvert.DeserializeObject<Address>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<Address> GetAddresses(Customer customer)
        {
            string response = SendRequest("getAddresses", JsonConvert.SerializeObject(customer));
            try
            {
                return JsonConvert.DeserializeObject<List<Address>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public Customer GetCustomer(Customer customer)
        {
            string response = SendRequest("getCustomer", JsonConvert.SerializeObject(customer));
            try
            {
                return JsonConvert.DeserializeObject<Customer>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IList<Customer> GetCustomers(IDictionary<string, object> @params)
        {
            string response = SendRequest("getCustomers", JsonConvert.SerializeObject(@params));
            try
            {
                return JsonConvert.DeserializeObject<List<Customer>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public string UpdateCustomer(Customer customer)
        {
            string response = SendRequest("updateCustomer", JsonConvert.SerializeObject(customer));
            try
            {
                return JsonConvert.DeserializeObject<APIResponse>(response).Message;
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        // Product API
        private IDictionary<string, string> GetImgsFiles(ProductData product)
        {
            Dictionary<string, string> filenames = new Dictionary<string, string>();
            if (product.Image.IsNew)
            {
                filenames.Add(product.Image.Name, product.Image.Image);
            }

            foreach (ProductImage image in product.Images)
            {
                if (image.IsNew)
                {
                    filenames.Add(image.Name, image.Image);
                }
            }
            return filenames;
        }

        public string AddProduct(Product product)
        {
            string response = SendRequest("addProduct", JsonConvert.SerializeObject(product as ProductData), GetImgsFiles(product as ProductData));
            return JsonConvert.DeserializeObject<APIResponse>(response).Message;
        }

        public string DeleteProduct(Product product)
        {
            string response = SendRequest("deleteProduct", JsonConvert.SerializeObject(product));
            return JsonConvert.DeserializeObject<APIResponse>(response).Message;
        }

        public Product GetProduct(Product product)
        {
            string response = SendRequest("getProduct", JsonConvert.SerializeObject(product));
            try
            {
                return JsonConvert.DeserializeObject<ProductData>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidCastException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IList<Product> GetProducts(IDictionary<string, object> @params)
        {
            string response = SendRequest("getProducts", JsonConvert.SerializeObject(@params));
            try
            {
                return JsonConvert.DeserializeObject<List<Product>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public string UpdateProduct(Product product)
        {
            string response = SendRequest("updateProduct", JsonConvert.SerializeObject(product as ProductData), GetImgsFiles(product as ProductData));
            return JsonConvert.DeserializeObject<APIResponse>(response).Message;

        }

        // Order API
        public string AddOrder(Order order)
        {
            string response = SendRequest("addOrder", JsonConvert.SerializeObject(order));
            return JsonConvert.DeserializeObject<APIResponse>(response).Message;
        }

        public string DeleteOrder(Order order)
        {
            string response = SendRequest("deleteOrder", JsonConvert.SerializeObject(order));
            return JsonConvert.DeserializeObject<APIResponse>(response).Message;
        }

        public Order GetOrder(Order order)
        {
            string response = SendRequest("getOrder", JsonConvert.SerializeObject(order));
            try
            {
                return JsonConvert.DeserializeObject<Order>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IList<Order> GetOrders(IDictionary<string, object> @params)
        {
            string response = SendRequest("getOrders", JsonConvert.SerializeObject(@params));
            try
            {
                return JsonConvert.DeserializeObject<List<Order>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public string UpdateOrder(Order order)
        {
            string response = SendRequest("updateOrder", JsonConvert.SerializeObject(order));
            return JsonConvert.DeserializeObject<APIResponse>(response).Message;
        }

        // Global API
        public ServerData GetServerData()
        {
            string response = SendRequest("getServerData", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<ServerData>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<PaymentMethod> GetPaymentMethods()
        {
            string response = SendRequest("GetPaymentMethods", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<List<PaymentMethod>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<ShippingMethod> GetShippingMethods()
        {
            string response = SendRequest("GetShippingMethods", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<List<ShippingMethod>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<Language> GetLanguages()
        {
            string response = SendRequest("GetLanguages", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<List<Language>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<CustomerGroup> GetCustomerGroups()
        {
            string response = SendRequest("GetCustomerGroups", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<List<CustomerGroup>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<Manufacturer> GetManufacturers()
        {
            string response = SendRequest("GetManufacturers", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<List<Manufacturer>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<Currency> GetCurrencies()
        {
            string response = SendRequest("GetCurrencies", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<List<Currency>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<Country> GetCountries()
        {
            string response = SendRequest("GetCountries", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<List<Country>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<Zone> GetZones(int country_id)
        {
            string response = SendRequest("GetZones", $@"{{ ""country_id"" : {country_id} }}");
            try
            {
                return JsonConvert.DeserializeObject<List<Zone>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<Weight> GetWeightClasses()
        {
            string response = SendRequest("GetWeightClasses", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<List<Weight>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<Length> GetLengthClasses()
        {
            string response = SendRequest("GetLengthClasses", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<List<Length>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }

        }

        public IEnumerable<Category> GetCategories()
        {
            string response = SendRequest("GetCategories", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<List<Category>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<Tax> GetTaxClasses()
        {
            string response = SendRequest("GetTaxClasses", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<List<Tax>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<StockStatus> GetStockStatuses()
        {
            string response = SendRequest("GetStockStatuses", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<List<StockStatus>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<OrderStatus> GetOrderStatuses()
        {
            string response = SendRequest("GetOrderStatuses", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<List<OrderStatus>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }

        public IEnumerable<Store> GetStores()
        {
            string response = SendRequest("GetStores", string.Empty);
            try
            {
                return JsonConvert.DeserializeObject<List<Store>>(response);
            }
            catch (JsonSerializationException)
            {
                throw new InvalidOperationException(JsonConvert.DeserializeObject<APIResponse>(response).Message);
            }
        }
    }
}
