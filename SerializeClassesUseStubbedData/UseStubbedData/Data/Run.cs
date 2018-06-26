namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Run")]
    public partial class Run
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Run()
        {
            RunResources = new HashSet<RunResource>();
            RunStops = new HashSet<RunStop>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal RunID { get; set; }

        [Required]
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

        [Column(TypeName = "numeric")]
        public decimal RunSequence { get; set; }

        public DateTime? ActualReturnDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? StandardMiles { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ActualMiles { get; set; }

        public DateTime? ProformaDate { get; set; }

        [StringLength(800)]
        public string Comments { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? ReportDate { get; set; }

        [StringLength(10)]
        public string RunNo { get; set; }

        [StringLength(50)]
        public string PickUp { get; set; }

        public int? RunNum { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RunNumberID { get; set; }

        public short? PalletsOff { get; set; }

        public short? PalletsOn { get; set; }

        public int? ProformaRunMasterID { get; set; }

        [StringLength(800)]
        public string WarehouseNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RunResource> RunResources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RunStop> RunStops { get; set; }
    }
}
