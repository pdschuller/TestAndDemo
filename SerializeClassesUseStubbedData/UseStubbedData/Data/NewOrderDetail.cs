namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NewOrderDetail")]
    public partial class NewOrderDetail
    {
        [Column(TypeName = "numeric")]
        public decimal? OrderDetailID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OrderID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LineSeqNo { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pieces { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cube { get; set; }

        public bool? LisTempControlled { get; set; }

        [StringLength(10)]
        public string Itemcode { get; set; }

        [StringLength(2)]
        public string Custcode { get; set; }

        [Key]
        [Column(Order = 0)]
        public decimal OrderNumber { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal FlagID { get; set; }

        public virtual Flag Flag { get; set; }
    }
}
