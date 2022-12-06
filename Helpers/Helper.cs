using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System.IO;
using System.Collections.Generic;
using apiPrepTestingFramework.QA.Extensions;
using System.Collections.Specialized;
using System;

namespace apiPrepTestingFramework.QA.Helpers
{
    public class Helper
    {
        private readonly IConfiguration _config;

        public Helper(IConfiguration config)
        {
            _config = config;
        }

        public static RestClient Client;
        public static RestRequest restRequest;

        public static RestClient SetURL(string endpoint)
        {
            Client = new RestClient(endpoint);
            Client.UseNewtonsoftJson(new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore
            });
            Client.RemoteCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            return Client;
        }

        public static string SetValidAPIKey(IConfiguration _config, string environment)
        {
            var url = _config.baseUrl().ToString();
            var Client = new RestClient();
            Client.BaseUrl = new Uri(_config.baseUrl());

            var tokenClient = new RestClient(url);
            var request = new RestRequest(Method.POST);

            request.Parameters.ToString();
            request.AddHeader("ApiKey", _config.lenderServiceV3ValidApiKey());

            IRestResponse response = tokenClient.Execute(request);

            if (response.Content.Contains("access_token"))
            {
                var token = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Content)["access_token"].ToString();
                return token;
            }

            else
                return response.ToString();
        }

        public static string GetToken(string clientId, string clientSecret, string apiKey, string apiPassword, IConfiguration _config)
        {
            var url = _config.SSOTokenUrl().ToString();

            var tokenClient = new RestClient(url);
            var request = new RestRequest(Method.POST);

            request.Parameters.ToString();
            request.AddParameter("grant_type", "password");
            request.AddParameter("username", apiKey);
            request.AddParameter("password", apiPassword);
            request.AddParameter("client_id", clientId);
            request.AddParameter("client_secret", clientSecret);

            IRestResponse response = tokenClient.Execute(request);

            if (response.Content.Contains("access_token"))
            {
                var token = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Content)["access_token"].ToString();
                return token;
            }

            else
                return response.ToString();
        }

        public static RestRequest CreateGetRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static IRestResponse GetResponse()
        {
            return Client.Execute(restRequest);
        }

        public static RestRequest CreatePostRequest()
        {
            restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", ParameterType.RequestBody);
            return restRequest;
        }

        public static T GetContent<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public static RestClient SetCombinedURL(string baseURL, string endpoint)
        {
            var url = Path.Combine(baseURL, endpoint);
            Client = new RestClient(url);
            Client.RemoteCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            return Client;
        }
    }
}