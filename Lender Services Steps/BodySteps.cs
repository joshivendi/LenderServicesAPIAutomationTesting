using apiPrepTestingFramework.Models.API;
using apiPrepTestingFramework.QA.Extensions;
using apiPrepTestingFramework.QA.Helpers;
using apiPrepTestingFramework.QA.Models;
using Microsoft.Extensions.Configuration;
using RestSharp;
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
        
        [When(@"I have added a body without a first name with a valid api key")]
        [Given(@"I have added a body without a first name with a valid api key")]
        public void GivenIHaveAddedABodyWithoutAFirstNameWithAValidApiKey()
        {
            var restRequest = Helper.CreatePostRequest();
            var bodyTest = new Submissions()
            {
                AddOnCosts = 0.0,
                Affordability = new Affordability
                {
                    ForeseeFutureDownturnInFinances = false,
                    GrossAnnualIncome = "30000.00",
                    DownturnReason = null,
                    MortageOrRentExpenditure = "1200.00",
                    OtherCommittedMonthlyOutgoings = "100.00",
                    ReplacementLoanAmount = null,
                    ReplacementLoan = false,
                    ExpectedChangesInCircumstances = false,
                    NetMonthlyIncome = "2000.00"
                },
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
                Applicants = new List<Applicant>
                {
                        new Applicant
                        {
                           ApplicantTitle = "",
                           ApplicantMiddlename = "",
                           ApplicantForename = "Tester",
                           ApplicantGender = "Male",
                           ApplicantLandline = "",
                           ApplicantMaritalStatus = "Married",
                           ApplicantMobile = "07654321012",
                           Nationality = "GB",
                           PlaceOfBirth = null,
                           ApplicantSurname = "Sooner",
                           ApplicantEmail = "to@dot.com",
                           ApplicantSalary = "30000.00",
                           NoDependants = "0",
                           ApplicantNetMonthlyIncome = null,
                           ApplicantDateOfBirth = "1970-01-01T00:00:00",
                           LicenceType = 1,
                           LicenceNumber = "12345678",
                           DPNProvided = "2020-12-03T12:06:21.83898Z",

                             AddressesHistory = new List<Addresseshistory>
                             {
                                 new Addresseshistory
                                 {
                                    BuildingName = "building",
                                    BuildingNumber = "",
                                    Country = null,
                                    County = "Lancashire",
                                    District = "Hyndburn",
                                    Postcode = "OL98QD",
                                    PostTown = "Ay Street",
                                    Street = "Ay Street",
                                    SubBuilding = "",
                                    MonthsAtAddress = 120,
                                    Residency = "HomeOwner"
                                 }
                             },
                             EmploymentHistory = new List<Employmenthistory>
                             {
                                 new Employmenthistory
                                 {
                                    GrossAnnualIncome = null,
                                    NetMonthlyIncome = null,
                                    MonthsInJob = 120,
                                    Company = "iVendi",
                                    OccupationBasis = "EmployedFullTime",
                                    OccupationType = "MiddleManager",
                                    TelephoneNumber = "01254654987",
                                    Occupation = "Tester",
                                    Terms = 1,
                                    Status = 1
                                 }
                             }

                        }
                },
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
                Commissions = new Commission[]
                {
                    new Commission
                    {
                        Amount = 1374.58,
                        Method = "RRPDiscounting",
                        Type = "PercentageOfAdvance",
                        Value = 10.0,
                        VolumeBonus = 0.0

                    }
                },
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
                KnowYourCustomer = new Knowyourcustomer
                {
                    ApplicantCountryOfBirth = "GB",
                    ApplicantDirectorOrBoardMemberCountryOfOperation = null,
                    ApplicantDirectorOrBoardMemberPosition = "",
                    ApplicantDirectorOrBoardMemberCompanySector = null,
                },
                PrivacyPolicy = new Privacypolicy
                {
                    ApplicantLenderMarketingByEmailConsent = false,
                    ApplicantLenderMarketingDisclaimerVersionId = null
                },
                VatNumber = "",
                MetaDataCashPrice = 15900.00,
                MetaDataVehiclePrice = 15900.00,
                MetadataHasNegativeEquityLoan = false,
                MetadataHasVapsLoan = false,
            };
            var test = System.Text.Json.JsonSerializer.Serialize(bodyTest);
            restRequest.AddJsonBody(bodyTest);
        }
    }
}