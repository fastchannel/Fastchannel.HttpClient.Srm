namespace Vertis.SrmClient
{
    public class Settings
    {
        public string BaseEndpoint { get; set; }

        public string OrderSimulationEndpoint { get; set; }

        public string CreateOrderEndpoint { get; set; }

        public string OrderStatusEndpoint { get; set; }

        public string SendOrderInvoicesEndpoint { get; set; }

        public string AuthorizationToken { get; set; }

        public int? DefaultTimeoutInSeconds { get; set; }
    }
}