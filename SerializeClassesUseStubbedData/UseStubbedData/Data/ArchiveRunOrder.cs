namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArchiveRunOrder")]
    public partial class ArchiveRunOrder
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal RunOrderID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal RunStopID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OrderID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RunOrderSequence { get; set; }
    }
}
