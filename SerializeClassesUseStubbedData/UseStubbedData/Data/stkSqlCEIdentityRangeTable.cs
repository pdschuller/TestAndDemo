namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stkSqlCEIdentityRangeTable")]
    public partial class stkSqlCEIdentityRangeTable
    {
        [Key]
        public int SqlCEIdentityRangeTableID { get; set; }

        [StringLength(25)]
        public string Name { get; set; }

        public int? RangeSize { get; set; }

        public int? Increment { get; set; }

        public double? Threshold { get; set; }

        public int? NextIdentity { get; set; }
    }
}
