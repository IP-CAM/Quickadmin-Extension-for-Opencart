using Newtonsoft.Json;

namespace Entity
{
    public class Store
    {
        [JsonProperty("store_id")]
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string URL { get; set; }
        [JsonProperty("ssl")]
        public string SSL { get; set; }
    }
}
