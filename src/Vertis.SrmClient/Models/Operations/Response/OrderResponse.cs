using RestSharp.Deserializers;

namespace Vertis.SrmClient.Models.Operations.Response
{
    public class OrderResponse : Types.Order
    {
        [DeserializeAs(Name = "status_processamento")]
        public string Status { get; set; }
    }
}