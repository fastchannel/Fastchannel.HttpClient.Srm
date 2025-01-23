namespace Fastchannel.HttpClient.Srm.Models.Operations.Request
{
    public class OrderInvoice : BaseRequest<Types.OrderInvoice>
    {
        public OrderInvoice(Types.OrderInvoice requestData) : base(requestData)
        {
        }
    }
}