using Newtonsoft.Json;

namespace Entity
{
    public class Manufacturer
    {
        [JsonProperty("manufacturer_id")]
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
