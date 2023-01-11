using apiPrepTestingFramework.QA.Extensions;
using apiPrepTestingFramework.QA.Helpers;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace apiPrepTestingFramework.QA.QuoteWareSteps
{
    [Binding]
    public class QuoteWareEndpointSteps
    {
        private readonly IConfiguration _config;
        private readonly ScenarioContext _context;

        public QuoteWareEndpointSteps(IConfiguration config, ScenarioContext context)
        {
            _config = config;
            _context = context;
        }

        [Given(@"I have set the endpoint to quoteware/v(.*)/quotes")]
        public void GivenIHaveSetTheEndpointToQuotewareVQuotes(int p0)
        {
            var v3QuoteUrl = _config.QuoteWareVersionThreeQuoteEndpoint();
            Helper.SetURL(v3QuoteUrl);
        }
    }
}
