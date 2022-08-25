namespace UniversityGrading.Models.DB_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactEmail")]
    public partial class ContactEmail
    {
        public int Id { get; set; }

        public int ContactId { get; set; }

        public int EmailAddressId { get; set; }
    }
}
