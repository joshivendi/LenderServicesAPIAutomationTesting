using System;
using System.Collections.Generic;
using System.Text;

namespace apiPrepTestingFramework.QA.Models
{
    public class Submissions
    {
            public double AddOnCosts { get; set; }
            public Affordability Affordability { get; set; }
            public int AnnualDistanceQuoted { get; set; }
            public string ApplicantAccountName { get; set; }
            public string ApplicantAccountNumber { get; set; }
            public string SettlementSource { get; set; }
            public int ApplicantMonthsWithBank { get; set; }
            public string ApplicantSortcode { get; set; }
            public string ApplicantBankName { get; set; }
            public string ApplicantBankAddressLine1 { get; set; }
            public string ApplicantBankAddressLine2 { get; set; }
            public string ApplicantBankPostTown { get; set; }
            public string ApplicantBankPostcode { get; set; }
            public string ApplicantBankPhone { get; set; }
            public object ApplicantIsBoardMemberOrDirector { get; set; }
            public object ApplicantCountryOfOperation { get; set; }
            public object ApplicantMarketingDisclaimerVersionId { get; set; }
            public List<Applicant> Applicants { get; set; }
            public object IARProspectId { get; set; }
            public bool ArrangedByPhone { get; set; }
            public bool ArrangedInShowroom { get; set; }
            public bool ArrangedOnline { get; set; }
            public bool BusinessUse { get; set; }
            public double ChargePerOverDistanceUnit { get; set; }
            public string DealershipId { get; set; }
            public bool DistanceMarketed { get; set; }
            public double FinanceDepositAllowance { get; set; }
            public string FunderCode { get; set; }
            public string FunderProductCode { get; set; }
            public object GlassModelId { get; set; }
            public object GlassQualifyModelId { get; set; }
            public bool HighNetWorth { get; set; }
            public string NoDependants { get; set; }
            public object Notes { get; set; }
            public object NotesAuthor { get; set; }
            public double OutstandingSettlement { get; set; }
            public double QuoteAPR { get; set; }
            public double QuoteAcceptanceFeeFirst { get; set; }
            public object QuoteAcceptanceFeeLast { get; set; }
            public bool QuoteAcceptanceFeeSpread { get; set; }
            public double QuoteAdvance { get; set; }
            public double QuoteBalloon { get; set; }
            public double QuoteBaseRate { get; set; }
            public double QuoteCashPrice { get; set; }
            public double QuoteActualCashDeposit { get; set; }
            public double QuoteVehiclePrice { get; set; }
            public string QuoteCondition { get; set; }
            public bool IsUsedVehicle { get; set; }
            public double QuoteCustomerRate { get; set; }
            public string RateType { get; set; }
            public double FlatRate { get; set; }
            public double QuoteDeposit { get; set; }
            public double QuoteFinalPaymentAmount { get; set; }
            public string QuoteFinanceType { get; set; }
            public double QuoteFirstPaymentAmount { get; set; }
            public int QuoteFollowedBy { get; set; }
            public string QuoteId { get; set; }
            public double QuoteInterestCharges { get; set; }
            public double TotalAmountPayable { get; set; }
            public int QuoteInitialPauseMonths { get; set; }
            public double QuoteInterestRate { get; set; }
            public double QuotePartExchange { get; set; }
            public double QuotePurchaseFee { get; set; }
            public bool QuotePurchaseFeeSpread { get; set; }
            public double QuoteRegularPaymentAmount { get; set; }
            public int QuoteTerm { get; set; }
            public int QuoteTermQuoted { get; set; }
            public bool QuoteVATIncluded { get; set; }
            public bool QuoteVATQualifying { get; set; }
            public string QuoteVehicleCapCode { get; set; }
            public string QuoteVehicleCapId { get; set; }
            public string QuoteVehicleClass { get; set; }
            public string QuoteVehicleDerivative { get; set; }
            public int QuoteVehicleMileage { get; set; }
            public string QuoteVehicleModel { get; set; }
            public string QuoteVehicleRegDate { get; set; }
            public string QuoteVehicleVrm { get; set; }
            public string QuoteeProductCode { get; set; }
            public string SubmittersEmail { get; set; }
            public object SubmittersName { get; set; }
            public object SubmittersPhone { get; set; }
            public object SourceUrl { get; set; }
            public double Commission { get; set; }
            public Commission[] Commissions { get; set; }
            public object[] ValueAddedProduct { get; set; }
            public string VehicleMake { get; set; }
            public string VehicleVin { get; set; }
            public string ClientAppName { get; set; }
            public string ClientAppVersion { get; set; }
            public double Warranty { get; set; }
            public double OtherAccessories { get; set; }
            public double Insurance { get; set; }
            public object SubsidyRate { get; set; }
            public int SubsidyType { get; set; }
            public Knowyourcustomer KnowYourCustomer { get; set; }
            public Privacypolicy PrivacyPolicy { get; set; }
            public string VatNumber { get; set; }
            public double MetaDataCashPrice { get; set; }
            public double MetaDataVehiclePrice { get; set; }
            public bool MetadataHasNegativeEquityLoan { get; set; }
            public bool MetadataHasVapsLoan { get; set; }
        }

        public class Affordability
        {
            public bool ForeseeFutureDownturnInFinances { get; set; }
            public string GrossAnnualIncome { get; set; }
            public object DownturnReason { get; set; }
            public string MortageOrRentExpenditure { get; set; }
            public string OtherCommittedMonthlyOutgoings { get; set; }
            public object ReplacementLoanAmount { get; set; }
            public bool ReplacementLoan { get; set; }
            public bool ExpectedChangesInCircumstances { get; set; }
            public string NetMonthlyIncome { get; set; }
        }

        public class Knowyourcustomer
        {
            public string ApplicantCountryOfBirth { get; set; }
            public object ApplicantDirectorOrBoardMemberCountryOfOperation { get; set; }
            public string ApplicantDirectorOrBoardMemberPosition { get; set; }
            public object ApplicantDirectorOrBoardMemberCompanySector { get; set; }
        }

        public class Privacypolicy
        {
            public bool ApplicantLenderMarketingByEmailConsent { get; set; }
            public object ApplicantLenderMarketingDisclaimerVersionId { get; set; }
        }

        public class Applicant
        {
            public List<Addresseshistory> AddressesHistory { get; set; }
            public List<Employmenthistory> EmploymentHistory { get; set; }
            public string ApplicantTitle { get; set; }
            public string ApplicantMiddlename { get; set; }
            public string ApplicantForename { get; set; }
            public string ApplicantGender { get; set; }
            public string ApplicantLandline { get; set; }
            public string ApplicantMaritalStatus { get; set; }
            public string ApplicantMobile { get; set; }
            public string Nationality { get; set; }
            public object PlaceOfBirth { get; set; }
            public string ApplicantSurname { get; set; }
            public string ApplicantEmail { get; set; }
            public string ApplicantSalary { get; set; }
            public string NoDependants { get; set; }
            public object ApplicantNetMonthlyIncome { get; set; }
            public string ApplicantDateOfBirth { get; set; }
            public int LicenceType { get; set; }
            public string LicenceNumber { get; set; }
            public string DPNProvided { get; set; }
        }

        public class Addresseshistory
        {
            public string BuildingName { get; set; }
            public string BuildingNumber { get; set; }
            public object Country { get; set; }
            public string County { get; set; }
            public string District { get; set; }
            public string Postcode { get; set; }
            public string PostTown { get; set; }
            public string Street { get; set; }
            public string SubBuilding { get; set; }
            public int MonthsAtAddress { get; set; }
            public string Residency { get; set; }
        }

        public class Employmenthistory
        {
            public Address Address { get; set; }
            public object GrossAnnualIncome { get; set; }
            public object NetMonthlyIncome { get; set; }
            public int MonthsInJob { get; set; }
            public string Company { get; set; }
            public string OccupationBasis { get; set; }
            public string OccupationType { get; set; }
            public string TelephoneNumber { get; set; }
            public string Occupation { get; set; }
            public int Terms { get; set; }
            public int Status { get; set; }
        }

        public class Address
        {
            public string BuildingName { get; set; }
            public string BuildingNumber { get; set; }
            public object Country { get; set; }
            public string County { get; set; }
            public string District { get; set; }
            public string Postcode { get; set; }
            public string PostTown { get; set; }
            public string Street { get; set; }
            public string SubBuilding { get; set; }
        }

        public class Commission
        {
            public double Amount { get; set; }
            public string Method { get; set; }
            public string Type { get; set; }
            public double Value { get; set; }
            public double VolumeBonus { get; set; }
        }
    }