namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArchiveOrderDetail")]
    public partial class ArchiveOrderDetail
    {
        [Key]
        [Column("ArchiveOrderDetail", Order = 0, TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ArchiveOrderDetail1 { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal OrderID { get; set; }

        public short? LineSeqNo { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pieces { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cube { get; set; }

        public bool? LisTempControlled { get; set; }

        [StringLength(10)]
        public string ItemCode { get; set; }

        [StringLength(2)]
        public string CustCode { get; set; }
    }
}
