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


        //[Then(@"I should be displayed Users in the response")]
        //public void ThenIShouldBeDisplayedUsersInTheResponse()
        //{
        //    var response = Helper.GetResponse();
        //    var getUserDetails = Helper.GetContent<ListOfUsers>(response);
        //    Assert.AreEqual(2, getUserDetails.Page);
        //    Assert.AreEqual("Michael", getUserDetails.Data[0].first_name);
        //    Assert.AreEqual("Lawson", getUserDetails.Data[0].last_name);
        //    Console.WriteLine("User data is returning");
        //}
    }
}