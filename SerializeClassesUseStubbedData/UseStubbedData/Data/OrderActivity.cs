namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderActivity")]
    public partial class OrderActivity
    {
        public int OrderActivityId { get; set; }

        public int OrderPickId { get; set; }

        public int? OrderID { get; set; }

        public int OrderActionId { get; set; }

        public DateTime ActivityDateTime { get; set; }

        public int? UserId { get; set; }

        public int? PalletId { get; set; }

        public int? UserCaseCount { get; set; }

        public int? ScannerCaseCount { get; set; }

        [StringLength(25)]
        public string SupervisorCode { get; set; }
    }
}
