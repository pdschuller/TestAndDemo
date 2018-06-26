namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyStandard")]
    public partial class CompanyStandard
    {
        [Column(TypeName = "numeric")]
        public decimal CompanyStandardID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CompanyLocationID { get; set; }

        [StringLength(10)]
        public string MinTime { get; set; }

        [StringLength(10)]
        public string PoundsPerHour { get; set; }

        public virtual CompanyLocation CompanyLocation { get; set; }
    }
}
