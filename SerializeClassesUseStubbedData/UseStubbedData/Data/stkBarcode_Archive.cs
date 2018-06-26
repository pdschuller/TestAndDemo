namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class stkBarcode_Archive
    {
        [Key]
        [Column(Order = 0)]
        public int BarcodeID { get; set; }

        [StringLength(20)]
        public string Barcode { get; set; }

        [StringLength(12)]
        public string ItemCode { get; set; }

        [StringLength(2)]
        public string CustCode { get; set; }

        public DateTime? CreateDate { get; set; }

        public short? MobileDeviceID { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Count { get; set; }

        public int? CreateBy { get; set; }

        [StringLength(12)]
        public string OldItemCode { get; set; }

        public bool? IsSubstitute { get; set; }
    }
}
