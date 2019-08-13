using Entity.Converters;
using Newtonsoft.Json;
using System;

namespace Entity
{
    public class SpecialOffer
    {

        [JsonProperty("product_special_id")]
        public int ID { get; set; }
        [JsonProperty("customer_group_id")]
        public int CustomerGroupID { get; set; }
        [JsonProperty("priority")]
        public int Priority { get; set; }
        [JsonProperty("price")]
        public double Price { get; set; }
        [JsonProperty("date_start"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime DateStart { get; set; }
        [JsonProperty("date_end"), JsonConverter(typeof(DateTimeConverter))]
        public DateTime DateEnd { get; set; }
    }
}
