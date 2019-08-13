using Newtonsoft.Json;

namespace Entity
{
    public class OrderProduct
    {
        [JsonProperty("order_product_id")]
        public int ID { get; set; }
        [JsonProperty("order_id")]
        public int OrderID { get; set; }
        [JsonProperty("product_id")]
        public int ProductID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("model")]
        public string Model { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("price")]
        public decimal Price { get; set; }
        [JsonProperty("total")]
        public decimal Total { get; set; }
        [JsonProperty("tax")]
        public double Tax { get; set; }
        [JsonProperty("reward")]
        public int Reward { get; set; }

        public override string ToString() => $"{Model} {Name}";
    }
}
