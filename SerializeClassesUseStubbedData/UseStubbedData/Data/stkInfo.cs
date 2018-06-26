namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stkInfo")]
    public partial class stkInfo
    {
        [Key]
        public int InfoID { get; set; }

        public int? BarcodeID { get; set; }

        public short? Barcode { get; set; }

        [StringLength(2)]
        public string CustCode { get; set; }

        [StringLength(10)]
        public string ItemCode { get; set; }

        public int? LocationID { get; set; }

        public int? Tie { get; set; }

        public int? High { get; set; }

        public int? ItemLenID { get; set; }

        public int? ItemPackID { get; set; }

        public DateTime? CreateDate { get; set; }

        public int? CreateBy { get; set; }

        public int? FlagID { get; set; }

        [StringLength(2)]
        public string Suffix { get; set; }
    }
}
