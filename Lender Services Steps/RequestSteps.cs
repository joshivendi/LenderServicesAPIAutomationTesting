using apiPrepTestingFramework.QA.Extensions;
using apiPrepTestingFramework.QA.Helpers;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace apiPrepTestingFramework.QA.Lender_Services_Steps
{
    [Binding]
    public class RequestSteps
    {
        private readonly IConfiguration _config;
        private readonly ScenarioContext _context;
        public static RestRequest restRequest;

        public RequestSteps(IConfiguration config, ScenarioContext context)
        {
            _config = config;
            _context = context;
        }

        [Given(@"I have created a GET request")]
        public void GivenIHaveCreatedAGETRequest()
        {
            Helper.CreateGetRequest();
        }

        [When(@"I create a POST request")]
        public void WhenICreateAPOSTRequest()
        {
            Helper.CreatePostRequest();
        }

        [When(@"I have set the api key in the header")]
        public static void WhenIHaveSetTheApiKeyInTheHeader()
        {
            var client = new RestClient("http://lender-services-v3-api.lender-services-v3-dev.svc.cluster.local/api/consumersubmission/send");
            var request = new RestRequest("", Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("ApiKey", "dGhlaG9seXRyaW5pdHktZGV2");
            IRestResponse response = client.Execute(request);
            var statusCode = response.StatusCode;
            Console.WriteLine(statusCode);
            var content = response.Content;
            Console.WriteLine(content);
        }
    }
}