using Entity.Converters;
using Newtonsoft.Json;

namespace Entity
{
    public class Customer
    {
        [JsonProperty("customer_id")]
        public int ID { get; set; }
        [JsonProperty("firstname")]
        public string Firstname { get; set; }
        [JsonProperty("lastname")]
        public string Lastname { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("telephone")]
        public string Telephone { get; set; }
        [JsonProperty("status"), JsonConverter(typeof(BoolConverter))]
        public bool Status { get; set; }
        [JsonProperty("address_id")]
        public int AddressID { get; set; }
        [JsonProperty("date_added")]
        public string DateAdded { get; set; }
        [JsonProperty("customer_group_id")]
        public int CustomerGroupID { get; set; }
        [JsonProperty("newsletter"), JsonConverter(typeof(BoolConverter))]
        public bool Newsletter { get; set; }
        [JsonProperty("safe"), JsonConverter(typeof(BoolConverter))]
        public bool Safe { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("address")]
        public Address Address { get; set; }
    }
}
