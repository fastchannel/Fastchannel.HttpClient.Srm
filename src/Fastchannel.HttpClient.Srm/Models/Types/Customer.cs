using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Fastchannel.HttpClient.Srm.Models.Types
{
    public class Customer
    {
        [JsonProperty(PropertyName = "firstName"), DeserializeAs(Name = "firstName")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "lastName"), DeserializeAs(Name = "lastName")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "document"), DeserializeAs(Name = "document")]
        public string Document { get; set; }

        [JsonProperty(PropertyName = "documentType"), DeserializeAs(Name = "documentType")]
        public string DocumentType { get; set; }

        [JsonProperty(PropertyName = "email"), DeserializeAs(Name = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "phone"), DeserializeAs(Name = "phone")]
        public string Phone { get; set; }
    }
}