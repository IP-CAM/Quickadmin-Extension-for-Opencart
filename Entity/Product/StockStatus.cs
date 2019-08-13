using Newtonsoft.Json;

namespace Entity
{
    public class StockStatus
    {
        [JsonProperty("stock_status_id")]
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
