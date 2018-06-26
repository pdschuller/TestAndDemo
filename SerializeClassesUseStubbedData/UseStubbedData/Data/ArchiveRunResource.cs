namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArchiveRunResource")]
    public partial class ArchiveRunResource
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal RunResourceID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal RunID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CarrierID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TractorID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TrailerID1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TrailerID2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TrailerID3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Driver1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Driver2 { get; set; }

        public bool? SecondRun { get; set; }
    }
}
