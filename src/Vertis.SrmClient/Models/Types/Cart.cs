using System.Collections.Generic;
using Newtonsoft.Json;
using RestSharp.Deserializers;

namespace Vertis.SrmClient.Models.Types
{
    public class Cart
    {
        public Cart()
        {
            ShippingAddress = new Address();
            BillingAddress= new Address();
            Customer = new Customer();
            Items = new List<CartItem>();
            
        }
        [JsonProperty(PropertyName = "shippingValue"), DeserializeAs(Name = "shippingvalue")]
        public decimal ShippingCost { get; set; }

        [JsonProperty(PropertyName = "taxValue"), DeserializeAs(Name = "taxValue")]
        public decimal InstallmentTax { get; set; }

        [JsonProperty(PropertyName = "deviceFingerprint"), DeserializeAs(Name = "deviceFingerprint")]
        public string DeviceFingerprint { get; set; }

        [JsonProperty(PropertyName = "shippingAddress"), DeserializeAs(Name = "shippingAddress")]
        public Address ShippingAddress { get; set; }

        [JsonProperty(PropertyName = "billingAddress"), DeserializeAs(Name = "billingAddress")]
        public Address BillingAddress { get; set; }

        [JsonProperty(PropertyName = "buyer"), DeserializeAs(Name = "buyer")]
        public Customer Customer { get; set; }

        [JsonProperty(PropertyName = "items"), DeserializeAs(Name = "items")]
        public List<CartItem> Items { get; set; }
    }
}