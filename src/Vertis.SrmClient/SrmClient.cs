using System;
using RestSharp;
using RestSharp.Authenticators;
using Vertis.SrmClient.Helpers;
// ReSharper disable UnusedMember.Global

namespace Vertis.SrmClient
{
    public class SrmClient
    {
        #region Constructors

        public SrmClient(Settings settings)
        {
            _settings = settings ?? throw new ArgumentNullException(nameof(settings), "Settings is null or invalid.");
            _client = new RestClient(settings.BaseEndpoint)
            {
                Authenticator = new JwtAuthenticator(_settings.AuthorizationToken)
            };

            _client.Timeout = settings.DefaultTimeoutInSeconds ?? _client.Timeout;
            _client.ReadWriteTimeout = settings.DefaultTimeoutInSeconds ?? _client.ReadWriteTimeout;
        }

        #endregion

        #region Fields

        private readonly Settings _settings;
        private readonly RestClient _client;

        #endregion

        #region InternalMethods

        private static RestRequest CreateRequest(string resource, Method method, int? requestTimeoutInSeconds)
        {
            var restRequest = new RestRequest(resource, method);
            restRequest.AddHeader("Content-Type", "application/json");
            restRequest.AddHeader("Accept", "application/json");
            restRequest.RequestFormat = DataFormat.Json;

            restRequest.Timeout = requestTimeoutInSeconds ?? restRequest.Timeout;
            restRequest.ReadWriteTimeout = requestTimeoutInSeconds ?? restRequest.ReadWriteTimeout;

            return restRequest;
        }

        #endregion

        #region Methods

        #region Order Simulation
        public Models.Operations.Response.OrderSimulation Simulate(Models.Operations.Request.OrderSimulationRequest request)
        {
            var restRequest = CreateRequest(_settings.OrderSimulationEndpoint, Method.POST, request.TimeoutInSeconds);
            
            try
            {
                restRequest.AddParameter("application/json", request.SerializedData, ParameterType.RequestBody);
                
                var response = _client.Execute<Models.Operations.Response.OrderSimulation>(restRequest);
                return response.Data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }

            return null;

        }
        #endregion

        #region Create Order
        public Models.Operations.Response.BaseResponse CreateOrder(Models.Operations.Request.CreateOrder request)
        {
            var restRequest = CreateRequest(_settings.CreateOrderEndpoint, Method.POST, request.TimeoutInSeconds);
            try
            {
                restRequest.AddParameter("application/json", request.SerializedData, ParameterType.RequestBody);

                var response = _client.Execute<Models.Operations.Response.BaseResponse>(restRequest);
                return response.Data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        #endregion

        #region OrderStatus
        public Models.Operations.Response.OrderStatus GetOrderStatus(string merchantDocument, string orderId, int? requestTimeoutInSeconds = null)
        {
            var restRequest = CreateRequest($"{_settings.OrderStatusEndpoint}/{merchantDocument.GetNumbers()}/{orderId}", Method.GET, requestTimeoutInSeconds);

            try
            {
                var response = _client.Execute<Models.Operations.Response.OrderStatus>(restRequest);
                return response.Data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

            return null;
        }
        #endregion

        #region Invoice
        public Models.Operations.Response.BaseResponse SendOrderInvoices(Models.Operations.Request.OrderInvoice request)
        {
            var restRequest = CreateRequest(_settings.SendOrderInvoicesEndpoint, Method.POST, request.TimeoutInSeconds);
            try
            {
                restRequest.AddParameter("application/json", request.SerializedData, ParameterType.RequestBody);

                var response = _client.Execute<Models.Operations.Response.BaseResponse>(restRequest);
                return response.Data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        #endregion

        #endregion
    }
}