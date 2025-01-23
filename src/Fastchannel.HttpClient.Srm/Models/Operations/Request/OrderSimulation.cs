using System.Globalization;
using Fastchannel.HttpClient.Srm.Models.Types;
using Newtonsoft.Json;
using RestSharp.Serializers;
namespace Fastchannel.HttpClient.Srm.Models.Operations.Request
{
    public class OrderSimulationRequest : BaseRequest<OrderSimulation>
    {
        public OrderSimulationRequest(OrderSimulation requestData) : base(requestData)
        {
        }
    }
}