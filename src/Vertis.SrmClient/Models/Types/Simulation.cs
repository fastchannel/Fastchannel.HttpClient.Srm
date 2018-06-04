using System.Collections.Generic;
using RestSharp.Deserializers;

namespace Vertis.SrmClient.Models.Types
{
    public class Simulation
    {
        public Simulation()
        {
            Installments = new List<Installment>();
        }
        [DeserializeAs(Name = "installmants")]
        public List<Installment> Installments { get; set; }
    }
}