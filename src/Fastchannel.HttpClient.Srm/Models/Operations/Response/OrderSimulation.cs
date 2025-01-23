using System.Collections.Generic;
using Fastchannel.HttpClient.Srm.Models.Types;
using RestSharp.Deserializers;

namespace Fastchannel.HttpClient.Srm.Models.Operations.Response
{
    public class OrderSimulation : BaseResponse
    {
        public OrderSimulation()
        {
            Simulation = new List<Simulation>();
        }

        [DeserializeAs(Name = "simulation")]
        public List<Simulation> Simulation { get; set; }
    }
}