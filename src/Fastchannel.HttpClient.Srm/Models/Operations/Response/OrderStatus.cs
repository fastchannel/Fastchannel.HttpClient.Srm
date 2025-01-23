using RestSharp.Deserializers;

namespace Fastchannel.HttpClient.Srm.Models.Operations.Response
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