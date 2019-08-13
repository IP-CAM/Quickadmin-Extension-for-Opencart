using Newtonsoft.Json;

namespace Entity
{
    public class ProductImage
    {
        [JsonProperty("image")]
        public string Image { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("is_new")]
        public bool IsNew { get; set; }
    }
}
