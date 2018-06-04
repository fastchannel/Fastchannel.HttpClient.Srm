using System.Globalization;
using Newtonsoft.Json;
using RestSharp.Serializers;
using Vertis.SrmClient.Models.Types;
namespace Vertis.SrmClient.Models.Operations.Request
{
    public class OrderSimulationRequest : BaseRequest<OrderSimulation>
    {
        public OrderSimulationRequest(OrderSimulation requestData) : base(requestData)
        {
        }
    }
}