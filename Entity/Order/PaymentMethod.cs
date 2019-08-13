using Newtonsoft.Json;

namespace Entity
{
    public class PaymentMethod
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("terms")]
        public string Terms { get; set; }
        [JsonProperty("sort_order")]
        public string SortOrder { get; set; }

        public override string ToString() => Title;
    }
}
