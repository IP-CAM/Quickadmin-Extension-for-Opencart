using Newtonsoft.Json;

namespace QuickAdmin.API
{
    public sealed class ServerData
    {
        [JsonProperty("ip")]
        public string IP { get; set; }
        [JsonProperty("url_image")]
        public string URL_img { get; set; }
    }
}
