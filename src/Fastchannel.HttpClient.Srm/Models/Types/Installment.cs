using RestSharp.Deserializers;

namespace Fastchannel.HttpClient.Srm.Models.Types
{
    public class Installment
    {
        [DeserializeAs(Name = "installmant")]
        public int Parcel { get; set; }
        [DeserializeAs(Name = "amount")]
        public decimal Amount { get; set; }
        [DeserializeAs(Name = "interest")]
        public decimal Interest { get; set; }

    }
}