namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ediTransaction")]
    public partial class ediTransaction
    {
        [Key]
        public int TransactionID { get; set; }

        public int? GroupID { get; set; }

        [StringLength(3)]
        public string StCode { get; set; }

        public int? StControl { get; set; }

        public int? SegCountSe { get; set; }

        public int? SegCountActual { get; set; }

        [StringLength(1)]
        public string AckCode { get; set; }

        public DateTime? EnterDate { get; set; }

        [StringLength(10)]
        public string Ref1 { get; set; }

        [StringLength(10)]
        public string Ref2 { get; set; }

        public virtual ediGroup ediGroup { get; set; }
    }
}
