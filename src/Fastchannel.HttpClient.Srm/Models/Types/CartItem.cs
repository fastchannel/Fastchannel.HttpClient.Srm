using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Fastchannel.HttpClient.Srm.Models.Types
{
    public class CartItem
    {
        [JsonProperty(PropertyName = "id"), DeserializeAs(Name = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name"), DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "price"), DeserializeAs(Name = "price")]
        public decimal Price { get; set; }

        [JsonProperty(PropertyName = "quantity"), DeserializeAs(Name = "quantity")]
        public int Quantity { get; set; }

        [JsonProperty(PropertyName = "discount"), DeserializeAs(Name = "discount")]
        public decimal Discount { get; set; }

        [JsonProperty(PropertyName = "clientDocument"), DeserializeAs(Name = "clientDocument")]
        public string SellerDocument { get; set; }

        [JsonProperty(PropertyName = "clientDocumentType"), DeserializeAs(Name = "clientDocumentType")]
        public string SellerDocumentType { get; set; }
    }
}