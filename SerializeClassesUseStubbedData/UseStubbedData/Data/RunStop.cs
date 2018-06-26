namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RunStop")]
    public partial class RunStop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RunStop()
        {
            RunOrders = new HashSet<RunOrder>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal RunStopID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RunID { get; set; }

        [Column(TypeName = "numeric")]
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

        public int? StopNum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StopNumberID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DelayStopTime { get; set; }

        public short? PalletsOff { get; set; }

        public short? PalletsOn { get; set; }

        public virtual CompanyLocation CompanyLocation { get; set; }

        public virtual Run Run { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RunOrder> RunOrders { get; set; }
    }
}
