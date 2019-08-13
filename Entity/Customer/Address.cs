using Newtonsoft.Json;

namespace Entity
{
    public class Address
    {
        [JsonProperty("address_id")]
        public int ID { get; set; }
        [JsonProperty("customer_id")]
        public int CustomerID { get; set; }
        [JsonProperty("firstname")]
        public string Firstname { get; set; }
        [JsonProperty("lastname")]
        public string Lastname { get; set; }
        [JsonProperty("company")]
        public string Company { get; set; }
        [JsonProperty("address_1")]
        public string Address1 { get; set; }
        [JsonProperty("address_2")]
        public string Address2 { get; set; }
        [JsonProperty("postcode")]
        public string Postcode { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("zone_id")]
        public int ZoneID { get; set; }
        [JsonProperty("country_id")]
        public int CountryID { get; set; }

        public override string ToString() => $"{Firstname} {Lastname}, {Address1}, {City}";
    }
}
