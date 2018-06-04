using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Vertis.SrmClient.Models.Types
{
    public class Address
    {
        [JsonProperty(PropertyName = "country"), DeserializeAs(Name = "country")]
        public string Country { get; set; }

        [JsonProperty(PropertyName = "street"), DeserializeAs(Name = "street")]
        public string Street { get; set; }

        [JsonProperty(PropertyName = "number"), DeserializeAs(Name = "number")]
        public int Number { get; set; }

        [JsonProperty(PropertyName = "complement"), DeserializeAs(Name = "complement")]
        public string Complement { get; set; }

        [JsonProperty(PropertyName = "neighborhood"), DeserializeAs(Name = "neighborhood")]
        public string Neighborhood { get; set; }

        [JsonProperty(PropertyName = "postalCode"), DeserializeAs(Name = "postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty(PropertyName = "city"), DeserializeAs(Name = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "state"), DeserializeAs(Name = "state")]
        public string State { get; set; }

    }
}