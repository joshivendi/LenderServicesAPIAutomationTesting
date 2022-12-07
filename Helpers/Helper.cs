using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serializers.NewtonsoftJson;
using System.IO;
using System.Collections.Generic;
using apiPrepTestingFramework.QA.Extensions;
using System.Collections.Specialized;
using System;
using apiPrepTestingFramework.QA.Models;

namespace apiPrepTestingFramework.QA.Helpers
{
    public class Helper
    {
        private readonly IConfiguration _config;

        public Helper(IConfiguration config)
        {
            _config = config;
        }

        public static RestClient Client;
        public static RestRequest restRequest;

        public static RestClient SetURL(string endpoint)
        {
            Client = new RestClient(endpoint);
            Client.UseNewtonsoftJson(new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore
            });
            Client.RemoteCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            return Client;
        }

        public static string SetValidAPIKey(IConfiguration _config, string environment)
        {
            var url = _config.baseUrl().ToString();
            var Client = new RestClient();
            Client.BaseUrl = new Uri(_config.baseUrl());

            var tokenClient = new RestClient(url);
            var request = new RestRequest(Method.POST);

            request.Parameters.ToString();
            request.AddHeader("ApiKey", _config.lenderServiceV3ValidApiKey());

            IRestResponse response = tokenClient.Execute(request);

            if (response.Content.Contains("access_token"))
            {
                var token = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Content)["access_token"].ToString();
                return token;
            }

            else
                return response.ToString();
        }

        public static string GetToken(string clientId, string clientSecret, string apiKey, string apiPassword, IConfiguration _config)
        {
            var url = _config.SSOTokenUrl().ToString();

            var tokenClient = new RestClient(url);
            var request = new RestRequest(Method.POST);

            request.Parameters.ToString();
            request.AddParameter("grant_type", "password");
            request.AddParameter("username", apiKey);
            request.AddParameter("password", apiPassword);
            request.AddParameter("client_id", clientId);
            request.AddParameter("client_secret", clientSecret);

            IRestResponse response = tokenClient.Execute(request);

            if (response.Content.Contains("access_token"))
            {
                var token = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Content)["access_token"].ToString();
                return token;
            }

            else
                return response.ToString();
        }

        public static RestRequest CreateGetRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "application/json");
            return restRequest;
        }

        public static IRestResponse GetResponse()
        {
            return Client.Execute(restRequest);
        }

        public static RestRequest CreatePostRequest()
        {
            restRequest = new RestRequest(Method.POST);
            restRequest.AddHeader("Accept", "application/json");
            restRequest.AddParameter("application/json", ParameterType.RequestBody);
            return restRequest;
        }

        public static T GetContent<T>(IRestResponse response)
        {
            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public static RestClient SetCombinedURL(string baseURL, string endpoint)
        {
            var url = Path.Combine(baseURL, endpoint);
            Client = new RestClient(url);
            Client.RemoteCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            return Client;
        }

        public static Submissions ValidSubmission => new Submissions()
        {
            AddOnCosts = 0.0m,
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
                           ApplicantTitle = "Mr",
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
                                     Address = new Address
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
                                     },
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
                ChargePerOverDistanceUnit = 0.0m,
                DealershipId = "c4991e72-eb51-42a1-959d-239917a5ae52",
                DistanceMarketed = false,
                FinanceDepositAllowance = 0.0m,
                FunderCode = "STE",
                FunderProductCode = "CLOHP1",
                GlassModelId = null,
                GlassQualifyModelId = null,
                HighNetWorth = false,
                NoDependants = "0",
                Notes = null,
                NotesAuthor = null,
                OutstandingSettlement = 0.0m,
                QuoteAPR = 11.9m,
                QuoteAcceptanceFeeFirst = 0.0m,
                QuoteAcceptanceFeeLast = null,
                QuoteAcceptanceFeeSpread = false,
                QuoteAdvance = 15900.0m,
                QuoteBalloon = 0.0m,
                QuoteBaseRate = 10.9m,
                QuoteCashPrice = 15900.0m,
                QuoteActualCashDeposit = 0.0m,
                QuoteVehiclePrice = 15900.0m,
                QuoteCondition = "Used",
                IsUsedVehicle = true,
                QuoteCustomerRate = 11.9m,
                RateType = "APR",
                FlatRate = 6.18m,
                QuoteDeposit = 0.0m,
                QuoteFinalPaymentAmount = 423.07m,
                QuoteFinanceType = "HP",
                QuoteFirstPaymentAmount = 413.07m,
                QuoteFollowedBy = 46,
                QuoteId = "12031200-19a6-4aa4-aeed-62034fb7ac75",
                QuoteInterestCharges = 3927.36m,
                TotalAmountPayable = 19837.36m,
                QuoteInitialPauseMonths = 0,
                QuoteInterestRate = 6.18m,
                QuotePartExchange = 0.0m,
                QuotePurchaseFee = 10.0m,
                QuotePurchaseFeeSpread = false,
                QuoteRegularPaymentAmount = 413.07m,
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
                Commission = 1374.58m,
                Commissions = new Commission[]
                {
                    new Commission
                    {
                        Amount = 1374.58m,
                        Method = "RRPDiscounting",
                        Type = "PercentageOfAdvance",
                        Value = 10.0m,
                        VolumeBonus = 0.0m

                    }
                },
                ValueAddedProduct = null,
                VehicleMake = "VAUXHALL",
                VehicleVin = "W0VZRHNS0L6016258",
                ClientAppName = "ivendi-dealer-platform",
                ClientAppVersion = "2",
                Warranty = 0.0m,
                OtherAccessories = 0.0m,
                Insurance = 0.0m,
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
                MetaDataCashPrice = 15900.00m,
                MetaDataVehiclePrice = 15900.00m,
                MetadataHasNegativeEquityLoan = false,
                MetadataHasVapsLoan = false,
            };
    }
}