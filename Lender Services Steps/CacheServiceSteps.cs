using apiPrepTestingFramework.Models.API;
using apiPrepTestingFramework.QA.Extensions;
using apiPrepTestingFramework.QA.Helpers;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using TechTalk.SpecFlow;

namespace apiPrepTestingFramework.QA.Cache_Service_Steps
{
    [Binding]
    public class CacheServiceSteps
    {
        private readonly IConfiguration _config;
        private readonly ScenarioContext _context;

        public CacheServiceSteps(IConfiguration config, ScenarioContext context)
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
