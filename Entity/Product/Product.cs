using Entity.Converters;
using Newtonsoft.Json;

namespace Entity
{
    public class Product
    {
        [JsonProperty("product_id")]
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("image")]
        public string Image { get; set; }
        [JsonProperty("model")]
        public string Model { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("status"), JsonConverter(typeof(BoolConverter))]
        public bool Status { get; set; }

        public override string ToString() => $"{Model} {Name}";
    }
}
