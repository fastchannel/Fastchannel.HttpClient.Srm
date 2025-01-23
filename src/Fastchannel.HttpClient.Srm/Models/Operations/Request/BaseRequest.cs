using Newtonsoft.Json;

namespace Fastchannel.HttpClient.Srm.Models.Operations.Request
{
    public class BaseRequest<T> where T : class
    {
        public T Data { get; set; }

        public int? TimeoutInSeconds { get; set; }

        public string SerializedData => JsonConvert.SerializeObject(Data);

        public BaseRequest(T requestData)
        {
            Data = requestData;
        }
    }
}