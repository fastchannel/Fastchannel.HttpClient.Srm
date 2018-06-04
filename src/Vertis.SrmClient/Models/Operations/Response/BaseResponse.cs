using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Vertis.SrmClient.Models.Operations.Response
{
    public class BaseResponse
    {
        [JsonProperty(PropertyName = "responseStatus")]
        public int ResponseStatus { get; set; }
        [JsonProperty(PropertyName = "responseStatusMessage")]
        public string ResponseStatusMessage { get; set; }

        [JsonIgnore]
        public bool IsHttpStatusCodeOk { get; set; }
    }
}