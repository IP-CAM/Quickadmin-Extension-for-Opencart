using Newtonsoft.Json;

namespace Entity
{
    public class CustomerGroup
    {
        [JsonProperty("customer_group_id")]
        public int ID { get; set; }
        [JsonProperty("approval")]
        public int Approval { get; set; }
        [JsonProperty("sort_order")]
        public string SortOrder { get; set; }
        [JsonProperty("language_id")]
        public int LanguageID { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }

        public override string ToString() => Name;
    }
}
