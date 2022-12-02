using apiPrepTestingFramework.QA.Extensions;
using apiPrepTestingFramework.QA.Helpers;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace apiPrepTestingFramework.QA.Lender_Services_Steps
{
    [Binding]
    public class EndpointSteps
    {
        private readonly IConfiguration _config;
        private readonly ScenarioContext _context;

        public EndpointSteps(IConfiguration config, ScenarioContext context)
        {
            _config = config;
            _context = context;
        }

        [Given(@"I have set the endpoint to baseURL/cache/dealerships")]
        public void GivenIHaveSetTheEndpointToBaseURLCacheDealerships()
        {
            var baseURl = _config.baseUrl();
            var cacheDealerships = "cache/dealerships";
            Helper.SetCombinedURL(baseURl, cacheDealerships);
        }

        [Given(@"I have set the endpoint to baseURL/cache/dealershipByList")]
        public void GivenIHaveSetTheEndpointToBaseURLCacheDealershipByList()
        {
            var baseURl = _config.baseUrl();
            var cacheDealershipsByList = "cache/dealershipsbylist";
            Helper.SetCombinedURL(baseURl, cacheDealershipsByList);
        }

        [Given(@"I have set the endpoint to <template>")]
        public void GivenIHaveSetTheEndpointToTemplate()
        {
            var stellantisURL = _config.baseUrl();
            Helper.SetURL(stellantisURL);
        }

    }
}
