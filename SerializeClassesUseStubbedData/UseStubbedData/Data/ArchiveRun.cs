namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArchiveRun")]
    public partial class ArchiveRun
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal RunID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string RunName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Weight { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Cube { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pallets { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Pieces { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        public DateTime? PlannedShipDate { get; set; }

        public DateTime? ActualShipDate { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal RunSequence { get; set; }

        public DateTime? ActualReturnDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StandardMiles { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ActualMiles { get; set; }

        public DateTime? ProformaDate { get; set; }

        [StringLength(800)]
        public string Comments { get; set; }

        public DateTime? ReportDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        [StringLength(10)]
        public string RunNo { get; set; }

        [StringLength(50)]
        public string PickUp { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RunNumberID { get; set; }
    }
}
