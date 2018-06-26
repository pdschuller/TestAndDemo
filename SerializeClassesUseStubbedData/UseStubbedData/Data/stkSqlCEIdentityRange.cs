namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stkSqlCEIdentityRange")]
    public partial class stkSqlCEIdentityRange
    {
        [Key]
        public int SqlCEIdentityRangeID { get; set; }

        [StringLength(10)]
        public string SqlCEIdentityRangeTableID { get; set; }

        public int? MobileDeviceID { get; set; }

        public int? IdentityMin { get; set; }

        public int? IdentityMax { get; set; }

        public int? Threshold { get; set; }

        public int? LastIdentity { get; set; }

        public DateTime? LastSyncDate { get; set; }

        public bool? IsCurrent { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
