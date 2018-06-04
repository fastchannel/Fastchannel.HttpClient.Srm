using Newtonsoft.Json;

namespace Vertis.SrmClient.Models.Types
{
    public class OrderSimulation
    {
        [JsonProperty(PropertyName = "merchantDocument")]
        public string MerchantDocument { get; set; }
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }
        [JsonProperty(PropertyName = "clients")]
        public Client[] Clients { get; set; }
    }
}