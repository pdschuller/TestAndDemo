namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyShipper")]
    public partial class CompanyShipper
    {
        public int CompanyShipperID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CompanyLocationID { get; set; }

        [StringLength(10)]
        public string Type { get; set; }

        [StringLength(2)]
        public string CustCode { get; set; }

        public bool? NotChecked { get; set; }

        public bool? DetailNotChecked { get; set; }

        public bool? DetailPromoNotChecked { get; set; }

        [StringLength(3)]
        public string HotButton { get; set; }

        [StringLength(3)]
        public string MfgDateType { get; set; }

        public virtual CompanyLocation CompanyLocation { get; set; }
    }
}
