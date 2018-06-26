namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderError
    {
        public int OrderErrorId { get; set; }

        public int OrderPickId { get; set; }

        [StringLength(20)]
        public string BarCode { get; set; }

        [StringLength(2)]
        public string CustCode { get; set; }

        [StringLength(12)]
        public string ItemCode { get; set; }

        [StringLength(25)]
        public string ErrorCode { get; set; }

        [StringLength(150)]
        public string ErrorDesc { get; set; }

        [Required]
        [StringLength(1)]
        public string EntryTypeCode { get; set; }

        public int PalletId { get; set; }

        public DateTime EntryDateTime { get; set; }

        public int? UserId { get; set; }

        public int NumCases { get; set; }
    }
}
