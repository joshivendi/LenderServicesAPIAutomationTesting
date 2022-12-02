using apiPrepTestingFramework.Models.API;
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
    public class BodySteps
    {
        private readonly IConfiguration _config;
        private readonly ScenarioContext _context;

        public BodySteps(IConfiguration config, ScenarioContext context)
        {
            _config = config;
            _context = context;
        }

        [Given(@"I have added a body with a DealershipId")]
        public void GivenIHaveAddedABodyWithADealershipId()
        {
            var restRequest = Helper.CreatePostRequest();
            restRequest.AddJsonBody(new DealershipIdList()
            {
                DealershipId = _config.DealershipId()
            });
        }
    }
}
