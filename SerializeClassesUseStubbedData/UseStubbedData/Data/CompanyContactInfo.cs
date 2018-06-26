namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyContactInfo")]
    public partial class CompanyContactInfo
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal CompanyContactInfoID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CompanyLocationID { get; set; }

        [StringLength(10)]
        public string ContactType { get; set; }

        [StringLength(50)]
        public string ContactBlnk { get; set; }

        [StringLength(200)]
        public string Notes { get; set; }

        [StringLength(30)]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ContactTypeID { get; set; }

        public virtual ContactType ContactType1 { get; set; }

        public virtual CompanyLocation CompanyLocation { get; set; }
    }
}
