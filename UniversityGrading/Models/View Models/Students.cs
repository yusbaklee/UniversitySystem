using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UniversityGrading.Models.View_Models
{
    public class Students
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MatricNo { get; set; }
        public string SchoolFees { get; set; }
        public string AmountPaid { get; }
        public string UniType { get; set; }
    }
}