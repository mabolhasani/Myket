using Newtonsoft.Json;
using System.Net;

namespace Myket.Models
{
    public class Error
    {
        [JsonProperty("code")]
        public HttpStatusCode Code { get; set; }

        [JsonProperty("messageCode")]
        public string MessageCode { get; set; }

        [JsonProperty("translatedMessage")]
        public string TranslatedMessage { get; set; }
    }
}
