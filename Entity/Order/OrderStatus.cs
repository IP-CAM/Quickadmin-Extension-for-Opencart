using Newtonsoft.Json;

namespace Entity
{
    public class OrderStatus
    {
        [JsonProperty("order_status_id")]
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
