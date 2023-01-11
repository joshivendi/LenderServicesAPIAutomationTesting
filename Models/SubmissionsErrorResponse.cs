using System;
using System.Collections.Generic;
using System.Text;

namespace apiPrepTestingFramework.QA.Models
{
    public class SubmissionsErrorResponse
    {
        public Errors errors { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public int status { get; set; }
        public string traceId { get; set; }
    }

    public class Errors
    {
        public List<string> ApplicantForename { get; set; }
        public List<string> ApplicantSurname { get; set; }
        public string[] EmploymentHistory0EmploymentTelephoneNumber { get; set; }
    }
}