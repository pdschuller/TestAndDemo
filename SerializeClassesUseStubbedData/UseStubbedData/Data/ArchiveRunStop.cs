namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArchiveRunStop")]
    public partial class ArchiveRunStop
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal RunStopID { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal RunID { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "numeric")]
        public decimal StopSequence { get; set; }

        public DateTime? PlannedArrivalDate { get; set; }

        public DateTime? ActualArrivalDate { get; set; }

        public DateTime? PlannedDepartDate { get; set; }

        public DateTime? ActualDepartDate { get; set; }

        public bool? lisSubRun { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RunSubID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CompanyLocationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StandardMilesTo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ActualMilesTo { get; set; }

        [StringLength(200)]
        public string Notes { get; set; }

        public bool? PO_Fax { get; set; }

        public bool? Require_Audit { get; set; }

        public bool? PrintNotes { get; set; }

        public bool? PrintDirections { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StopNumberID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DelayStopTime { get; set; }
    }
}
