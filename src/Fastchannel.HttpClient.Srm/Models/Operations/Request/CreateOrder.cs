using Fastchannel.HttpClient.Srm.Models.Types;

namespace Fastchannel.HttpClient.Srm.Models.Operations.Request
{
    public class CreateOrder : BaseRequest<Order>
    {
        public CreateOrder(Order requestData) : base(requestData)
        {
        }
    }
}