using System.Collections.Generic;
using RestSharp.Deserializers;
using Vertis.SrmClient.Models.Types;

namespace Vertis.SrmClient.Models.Operations.Response
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