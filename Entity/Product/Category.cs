using Newtonsoft.Json;

namespace Entity
{
    public class Category
    {
        [JsonProperty("category_id")]
        public int ID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
