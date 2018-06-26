namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderItem
    {
        public int OrderItemId { get; set; }

        public int OrderPickId { get; set; }

        public int OrderId { get; set; }

        [StringLength(1)]
        public string LookupCode { get; set; }

        [StringLength(20)]
        public string ShipNo { get; set; }

        [StringLength(10)]
        public string SourceTable { get; set; }

        public int? BarCodeId { get; set; }

        [StringLength(50)]
        public string BarCode { get; set; }

        [StringLength(2)]
        public string CustCode { get; set; }

        [StringLength(12)]
        public string ItemCode { get; set; }

        public int? EntrySeqNum { get; set; }

        [Required]
        [StringLength(1)]
        public string EntryTypeCode { get; set; }

        [StringLength(3)]
        public string EntryMode { get; set; }

        public int PalletId { get; set; }

        public DateTime EntryDateTime { get; set; }

        public int? UserId { get; set; }

        public int NumCases { get; set; }
    }
}
