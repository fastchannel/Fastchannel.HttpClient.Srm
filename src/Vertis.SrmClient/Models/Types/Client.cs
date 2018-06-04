using Newtonsoft.Json;
using RestSharp.Serializers;

namespace Vertis.SrmClient.Models.Types
{
    public class Client
    {
        [JsonProperty(PropertyName = "clientIdentification")]
        public string ClientIdentification { get; set; }
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }
    }
}