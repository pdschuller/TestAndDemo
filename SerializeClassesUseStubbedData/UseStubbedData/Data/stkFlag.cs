namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stkFlag")]
    public partial class stkFlag
    {
        [Key]
        public int FlagID { get; set; }

        public bool? Ready { get; set; }

        public bool? Processed { get; set; }

        public int? NumRecords { get; set; }

        public int? MobileDeviceID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? CreateDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ReadyDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ProcessedDate { get; set; }

        public int? UserID { get; set; }
    }
}
