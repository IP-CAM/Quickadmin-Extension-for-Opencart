using Newtonsoft.Json;

namespace Entity
{
    public class Tax
    {
        [JsonProperty("tax_class_id")]
        public int ID { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
