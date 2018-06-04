
using RestSharp.Deserializers;

namespace Vertis.SrmClient.Models.Operations.Response
{
    public class OrderStatus : BaseResponse
    {
        public OrderStatus()
        {
            Order = new OrderResponse();
        }

        [DeserializeAs(Name = "order")]
        public OrderResponse Order { get; set; }
    }
}