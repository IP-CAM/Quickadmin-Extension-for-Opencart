using Newtonsoft.Json;

namespace Entity
{
    public class Length
    {
        [JsonProperty("length_class_id")]
        public int ID { get; set; }
        [JsonProperty("unit")]
        public string Unit { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
