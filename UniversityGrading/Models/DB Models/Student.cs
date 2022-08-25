namespace UniversityGrading.Models.DB_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MatricNo { get; set; }

        public decimal SchoolFees { get; set; }

        public int UniType { get; set; }
    }
}
