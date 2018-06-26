namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProformaRunMaster")]
    public partial class ProformaRunMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProformaRunMaster()
        {
            ProformaRunResources = new HashSet<ProformaRunResource>();
            ProformaRunStops = new HashSet<ProformaRunStop>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ProformaRunMasterID { get; set; }

        [Required]
        [StringLength(25)]
        public string RunName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RunSequence { get; set; }

        [Required]
        [StringLength(25)]
        public string ProformaName { get; set; }

        [StringLength(10)]
        public string DayOfWeek { get; set; }

        public bool? LisAllowDelete { get; set; }

        [StringLength(10)]
        public string RunNo { get; set; }

        public int? ProformaId { get; set; }

        public int? RunID { get; set; }

        public virtual Proforma Proforma { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProformaRunResource> ProformaRunResources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProformaRunStop> ProformaRunStops { get; set; }
    }
}
