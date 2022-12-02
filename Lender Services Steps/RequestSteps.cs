using apiPrepTestingFramework.QA.Helpers;
using Microsoft.Extensions.Configuration;
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
    }
}
