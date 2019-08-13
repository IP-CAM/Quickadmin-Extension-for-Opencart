using Newtonsoft.Json;

namespace Entity
{
    public class Description
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string DescriptionText { get; set; }
        [JsonProperty("tag")]
        public string Tag { get; set; }
        [JsonProperty("meta_title")]
        public string MetaTitle { get; set; }
        [JsonProperty("meta_description")]
        public string MetaDescription { get; set; }
        [JsonProperty("meta_keyword")]
        public string MetaKeyword { get; set; }
    }
}