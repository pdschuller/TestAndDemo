namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stkInfoFlag")]
    public partial class stkInfoFlag
    {
        [Key]
        public int FlagID { get; set; }

        public bool? Ready { get; set; }

        public bool? Processed { get; set; }

        public int? NumRecords { get; set; }

        public int? MobileDeviceID { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? ReadyDate { get; set; }

        public DateTime? ProcessedDate { get; set; }

        public int? UserID { get; set; }
    }
}
