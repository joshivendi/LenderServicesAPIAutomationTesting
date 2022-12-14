using apiPrepTestingFramework.Models.API;
using apiPrepTestingFramework.QA.Extensions;
using apiPrepTestingFramework.QA.Helpers;
using apiPrepTestingFramework.QA.Models;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using static apiPrepTestingFramework.QA.Models.Submissions;

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

        [Given(@"I have added a body with a invalid milage over (.*)")]
        public void GivenIHaveAddedABodyWithAInvalidMilageOver(int p0)
        {
            var restRequest = Helper.CreatePostRequest();

        }

        [When(@"I have added a body without a first name")]
        public void WhenIHaveAddedABodyWithoutAFirstName()
        {
            var restRequest = _context.Get<RestRequest>("request");
            var bodyTest = Helper.ValidSubmission;
            bodyTest.Applicants.First().ApplicantForename = null;
            var test = System.Text.Json.JsonSerializer.Serialize(bodyTest);
            restRequest.AddJsonBody(bodyTest);
        }

        [When(@"I have added a body with a invalid milage over (.*)")]
        public void WhenIHaveAddedABodyWithAInvalidMilageOver(int p0)
        {
            var restRequest = _context.Get<RestRequest>("request");
            var bodyTest = Helper.ValidSubmission;
            bodyTest.Applicants.First().ApplicantForename = null;
            var test = System.Text.Json.JsonSerializer.Serialize(bodyTest);
            restRequest.AddJsonBody(bodyTest);
        }

        [When(@"I have added a body with a first name over the (.*) character limit")]
        public void WhenIHaveAddedABodyWithAFirstNameOverTheCharacterLimit(int p0)
        {
            var restRequest = _context.Get<RestRequest>("request");
            var bodyTest = Helper.ValidSubmission;
            bodyTest.Applicants.First().ApplicantForename = _config.FirstNameCharacterLimitReached();
            var test = System.Text.Json.JsonSerializer.Serialize(bodyTest);
            restRequest.AddJsonBody(bodyTest);
        }

        [When(@"I have added a body without a surname")]
        public void WhenIHaveAddedABodyWithoutASurname()
        {
            var restRequest = _context.Get<RestRequest>("request");
            var bodyTest = Helper.ValidSubmission;
            bodyTest.Applicants.First().ApplicantSurname = null;
            var test = System.Text.Json.JsonSerializer.Serialize(bodyTest);
            restRequest.AddJsonBody(bodyTest);
        }

        [When(@"I have added a body with a valid submission")]
        public void WhenIHaveAddedABodyWithAValidSubmission()
        {
            var restRequest = _context.Get<RestRequest>("request");
            var bodyTest = Helper.ValidSubmission;
            var test = System.Text.Json.JsonSerializer.Serialize(bodyTest);
            restRequest.AddJsonBody(bodyTest);
        }
    }
}