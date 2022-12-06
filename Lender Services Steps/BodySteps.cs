using apiPrepTestingFramework.Models.API;
using apiPrepTestingFramework.QA.Extensions;
using apiPrepTestingFramework.QA.Helpers;
using apiPrepTestingFramework.QA.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
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

        [Given(@"I have added a body without a first name with a valid api key")]
        public void GivenIHaveAddedABodyWithoutAFirstNameWithAValidApiKey()
        {
            var restRequest = Helper.CreatePostRequest();
            restRequest.AddHeader("ApiKey", _config.lenderServiceV3ValidApiKey());
            restRequest.AddJsonBody(new Submissions()
            {
                AddOnCosts = 0.0,
                //Affordability    
                AnnualDistanceQuoted = 10000,
                ApplicantAccountName = "Michael Test",
                ApplicantAccountNumber = "71070177",
                SettlementSource = "",
                ApplicantMonthsWithBank = 120,
                ApplicantSortcode = "403810",
                ApplicantBankName = "BARCLAYS BANK PLC",
                ApplicantBankAddressLine1 = "",
                ApplicantBankAddressLine2 = "",
                ApplicantBankPostTown = "Leicester",
                ApplicantBankPostcode = "LE87 2BB",
                ApplicantBankPhone = "0345 7345345",
                ApplicantIsBoardMemberOrDirector = null,
                ApplicantCountryOfOperation = null,
                ApplicantMarketingDisclaimerVersionId = null,
                //Applicants

                IARProspectId = null,
                ArrangedByPhone = false,
                ArrangedInShowroom = false,
                ArrangedOnline = true,
                BusinessUse = false,
                ChargePerOverDistanceUnit = 0.0,
                DealershipId = "c4991e72-eb51-42a1-959d-239917a5ae52",
                DistanceMarketed = false,
                FinanceDepositAllowance = 0.0,
                FunderCode = "STE",
                FunderProductCode = "CLOHP1",
                GlassModelId = null,
                GlassQualifyModelId = null, 
                HighNetWorth = false,
                NoDependants = "0",
                Notes = null,
                NotesAuthor = null,
                OutstandingSettlement = 0.0,
                QuoteAPR = 11.9,
                QuoteAcceptanceFeeFirst = 0.0,
                QuoteAcceptanceFeeLast = null,
                QuoteAcceptanceFeeSpread = false,
                QuoteAdvance = 15900.0,
                QuoteBalloon = 0.0,
                QuoteBaseRate = 10.9,
                QuoteCashPrice = 15900.0,
                QuoteActualCashDeposit = 0.0,
                QuoteVehiclePrice = 15900.0,
                QuoteCondition = "Used",
                IsUsedVehicle = true,
                QuoteCustomerRate = 11.9,
                RateType = "APR",
                FlatRate = 6.18,
                QuoteDeposit = 0.0,
                QuoteFinalPaymentAmount = 423.07,
                QuoteFinanceType = "HP",
                QuoteFirstPaymentAmount = 413.07,
                QuoteFollowedBy = 46,
                QuoteId = "12031200-19a6-4aa4-aeed-62034fb7ac75",
                QuoteInterestCharges = 3927.36,
                TotalAmountPayable = 19837.36,
                QuoteInitialPauseMonths = 0,
                QuoteInterestRate = 6.18,
                QuotePartExchange = 0.0,
                QuotePurchaseFee = 10.0,
                QuotePurchaseFeeSpread = false,
                QuoteRegularPaymentAmount = 413.07,
                QuoteTerm = 48,
                QuoteTermQuoted = 48,
                QuoteVATIncluded = false,
                QuoteVATQualifying = false,
                QuoteVehicleCapCode = "VAGX12SE 5HPTM",
                QuoteVehicleCapId = "81212",
                QuoteVehicleClass = "Car",
                QuoteVehicleDerivative = "1.2 Turbo SE 5dr",
                QuoteVehicleMileage = 1100,
                QuoteVehicleModel = "GRANDLAND X HATCHBACK",
                QuoteVehicleRegDate = "2020-03-31T00:00:00Z",
                QuoteVehicleVrm = "DY20FAM",
                QuoteeProductCode = "HP1",
                SubmittersEmail = "",
                SubmittersName = null,
                SubmittersPhone = null,
                SourceUrl = null,
                Commission = 1374.58,
                //Commissions
                ValueAddedProduct = null,
                VehicleMake = "VAUXHALL",
                VehicleVin = "W0VZRHNS0L6016258",
                ClientAppName = "ivendi-dealer-platform",
                ClientAppVersion = "2",
                Warranty = 0.0,
                OtherAccessories = 0.0,
                Insurance = 0.0,
                SubsidyRate = null,
                SubsidyType = 0,
                //KnowYourCustomer
                //PrivacyPolicy
                VatNumber = "",
                MetaDataCashPrice = 15900.00,
                MetaDataVehiclePrice = 15900.00,
                MetadataHasNegativeEquityLoan = false,
                MetadataHasVapsLoan = false,
            }); 
        }

    }
}