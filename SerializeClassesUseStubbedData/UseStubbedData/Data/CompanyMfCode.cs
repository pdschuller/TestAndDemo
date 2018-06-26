namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyMfCode")]
    public partial class CompanyMfCode
    {
        public int CompanyMfCodeID { get; set; }

        public int? CompanyID { get; set; }

        [StringLength(7)]
        public string MfCode { get; set; }
    }
}
