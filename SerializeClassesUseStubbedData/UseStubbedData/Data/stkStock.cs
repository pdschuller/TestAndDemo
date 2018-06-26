namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stkStock")]
    public partial class stkStock
    {
        [Key]
        public int StockID { get; set; }

        [StringLength(25)]
        public string Barcode { get; set; }

        [StringLength(12)]
        public string Itemcode { get; set; }

        [StringLength(2)]
        public string CustCode { get; set; }

        public int? StackSize { get; set; }

        public int? Stacks { get; set; }

        public int? Cases { get; set; }

        [StringLength(10)]
        public string Location { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ScanTime { get; set; }

        public int? FlagID { get; set; }

        public Guid rowguid { get; set; }

        [StringLength(1)]
        public string Status { get; set; }
    }
}
