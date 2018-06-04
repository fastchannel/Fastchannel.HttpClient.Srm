using Vertis.SrmClient.Models.Types;

namespace Vertis.SrmClient.Models.Operations.Request
{
    public class CreateOrder : BaseRequest<Order>
    {
        public CreateOrder(Order requestData) : base(requestData)
        {
        }
    }
}