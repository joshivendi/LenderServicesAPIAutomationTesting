using apiPrepTestingFramework.Models.API;
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
    public class QuoteWareBodySteps
    {
        private readonly IConfiguration _config;
        private readonly ScenarioContext _context;

        public QuoteWareBodySteps(IConfiguration config, ScenarioContext context)
        {
            
        }


    }
}