using Entity.Converters;
using Newtonsoft.Json;

namespace Entity
{
    public class Currency
    {
        [JsonProperty("currency_id")]
        public int ID { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("symbol_left")]
        public string SymbolLeft { get; set; }
        [JsonProperty("symbol_right")]
        public string SymbolRight { get; set; }
        [JsonProperty("decimal_place")]
        public int DecimalPlace { get; set; }
        [JsonProperty("value")]
        public double Value { get; set; }
        [JsonProperty("status"), JsonConverter(typeof(BoolConverter))]
        public bool Status { get; set; }
    }
}
