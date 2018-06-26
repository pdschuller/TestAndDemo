namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stkCodeDate")]
    public partial class stkCodeDate
    {
        [Key]
        public int CodeDateID { get; set; }

        public int? StockID { get; set; }

        public DateTime? CodeDate { get; set; }

        public bool? Active { get; set; }

        [StringLength(1)]
        public string Status { get; set; }

        public int? DateNo { get; set; }
    }
}
