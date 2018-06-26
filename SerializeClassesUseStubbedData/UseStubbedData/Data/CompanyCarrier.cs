namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyCarrier")]
    public partial class CompanyCarrier
    {
        [Column(TypeName = "numeric")]
        public decimal CompanyCarrierID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CompanyLocationID { get; set; }

        public bool lisPreferred { get; set; }

        [StringLength(10)]
        public string Rank { get; set; }

        public virtual CompanyLocation CompanyLocation { get; set; }
    }
}
