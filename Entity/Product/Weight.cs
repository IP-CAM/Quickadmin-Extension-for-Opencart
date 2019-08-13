using Newtonsoft.Json;

namespace Entity
{
    public class Weight
    {
        [JsonProperty("weight_class_id")]
        public int ID { get; set; }
        [JsonProperty("unit")]        
        public string Unit { get; set; }
        [JsonProperty("title")]        
        public string Title { get; set; }
    }
}
