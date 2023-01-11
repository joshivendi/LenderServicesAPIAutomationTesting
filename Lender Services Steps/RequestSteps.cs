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
        public void WhenIHaveSetTheApiKeyInTheHeader()
        {
            var restRequest = Helper.CreatePostRequest();
            restRequest.AddHeader("ApiKey", "dGhlaG9seXRyaW5pdHktZGV2");
            _context.Add("request", restRequest);
        }
    }
}