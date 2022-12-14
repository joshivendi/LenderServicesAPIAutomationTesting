using apiPrepTestingFramework.QA.Helpers;
using apiPrepTestingFramework.QA.Models;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using TechTalk.SpecFlow;

namespace apiPrepTestingFramework.QA.Lender_Services_Steps
{
    [Binding]
    public class ResponseSteps
    {
        private readonly IConfiguration _config;
        private readonly ScenarioContext _context;

        public ResponseSteps(IConfiguration config, ScenarioContext context)
        {
            _config = config;
            _context = context;
        }

        [When(@"I get a response back")]
        public void WhenIGetAResponseBack()
        {
            var response = Helper.GetResponse();
            _context.Add("apiResponse", response);
            Console.WriteLine(response.Content);
        }

        [Then(@"I should receive a OK response code")]
        public void ThenIShouldReceiveAOKResponseCode()
        {
            var response = _context.Get<IRestResponse>("apiResponse");
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }

        [Then(@"I should receive a Bad request response code")]
        public void ThenIShouldReceiveABadRequestResponseCode()
        {
            var response = Helper.GetResponse();
            _context.Add("apiResponse", response);
            Console.WriteLine(response.Content);
            _context.Get<IRestResponse>("apiResponse");
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.BadRequest));
        }

        [Then(@"I am displayed the correct error message for null first name field")]
        public void ThenIAmDisplayedTheCorrectErrorMessageForNullFirstNameField()
        {
            var response = Helper.GetResponse();
            var firstNameNullField = Helper.GetContent<SubmissionsErrorResponse>(response);
            Assert.AreEqual("'Applicant Forename' must not be empty.", firstNameNullField.errors.ApplicantForename.First());
        }

        [Then(@"I am displayed the correct error message for first name character limit being reached")]
        public void ThenIAmDisplayedTheCorrectErrorMessageForFirstNameCharacterLimitBeingReached()
        {
            var response = Helper.GetResponse();
            var firstNameNullField = Helper.GetContent<SubmissionsErrorResponse>(response);
            Assert.AreEqual("The length of 'Applicant Forename' must be 25 characters or fewer. You entered 63 characters.", firstNameNullField.errors.ApplicantForename.First());
        }

        [Then(@"I am displayed the correct error message for null surname field")]
        public void ThenIAmDisplayedTheCorrectErrorMessageForNullSurnameField()
        {
            var response = Helper.GetResponse();
            var firstNameNullField = Helper.GetContent<SubmissionsErrorResponse>(response);
            Assert.AreEqual("'Applicant Surname' must not be empty.", firstNameNullField.errors.ApplicantSurname.First());
        }
    }
}