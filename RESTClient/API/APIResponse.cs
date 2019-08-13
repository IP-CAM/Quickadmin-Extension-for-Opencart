using Newtonsoft.Json;

namespace QuickAdmin.API
{
    public class APIResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("api_token")]
        public string Token { get; set; }
    }
}
