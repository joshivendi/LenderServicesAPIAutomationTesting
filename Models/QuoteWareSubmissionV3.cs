using System;
using System.Collections.Generic;
using System.Text;

namespace apiPrepTestingFramework.QA.Models
{
    public class QuoteWareSubmissionV3
    {
        public Credentials Credentials { get; set; }
        public Quoterequest[] QuoteRequests { get; set; }
    }

    public class Credentials
    {
        public string Username { get; set; }
        public int Mode { get; set; }
    }

    public class Quoterequest
    {
        public string QuoteeUID { get; set; }
        public Request[] Requests { get; set; }
    }

    public class Request
    {
        public Figures Figures { get; set; }
        public Requestparameters RequestParameters { get; set; }
    }

    public class Figures
    {
        public int CashPrice { get; set; }
        public int CashDeposit { get; set; }
        public Asset Asset { get; set; }
    }

    public class Asset
    {
        public int ManualResidualValue { get; set; }
        public int AnnualDistance { get; set; }
        public int CurrentOdometerReading { get; set; }
        public string RegistrationDate { get; set; }
        public string Identity { get; set; }
        public string IdentityType { get; set; }
        public Valueaddedproduct[] ValueAddedProducts { get; set; }
    }

    public class Valueaddedproduct
    {
        public string Description { get; set; }
        public decimal GrossPrice { get; set; }
        public string ID { get; set; }
        public string Name { get; set; }
        public int TaxCode { get; set; }
        public string Type { get; set; }
        public int TypeCode { get; set; }
    }

    //public class Asset1
    //{
    //    public int CurrentOdometerReading { get; set; }
    //    public string RegistrationDate { get; set; }
    //    public string Identity { get; set; }
    //    public string IdentityType { get; set; }
    //}

    public class Requestparameters
    {
        public int Term { get; set; }
    }
}