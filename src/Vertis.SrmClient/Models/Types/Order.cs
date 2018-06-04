using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Vertis.SrmClient.Models.Types
{
    public class Order
    {
        public Order()
        {
            MiniCart = new Cart();
        }

        [JsonProperty(PropertyName = "id"), DeserializeAs(Name = "id")]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "orderId"), DeserializeAs(Name = "orderId")]
        public string OrderId { get; set; }

        [JsonProperty(PropertyName = "value"), DeserializeAs(Name = "value")]
        public decimal TotalOrder { get; set; }

        [JsonProperty(PropertyName = "installments"), DeserializeAs(Name = "installments")]
        public int Installments { get; set; }

        [JsonProperty(PropertyName = "merchantDocument"), DeserializeAs(Name = "merchantDocument")]
        public string MerchantDocument { get; set; }

        [JsonProperty(PropertyName = "merchantDocumentType"), DeserializeAs(Name = "merchantDocumentType")]
        public string MerchantDocumentType { get; set; }

        [JsonProperty(PropertyName = "miniCart"), DeserializeAs(Name = "miniCart")]
        public Cart MiniCart { get; set; }

        

    }
}