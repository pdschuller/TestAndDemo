namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tractor")]
    public partial class Tractor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tractor()
        {
            RunResources = new HashSet<RunResource>();
            ScannedPalletConfirms = new HashSet<ScannedPalletConfirm>();
            Tractor_Productivity = new HashSet<Tractor_Productivity>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TractorID { get; set; }

        [Required]
        [StringLength(50)]
        public string Tractor_Name { get; set; }

        [StringLength(10)]
        public string Tractor_Weight { get; set; }

        [StringLength(10)]
        public string Tractor_Axles { get; set; }

        public bool? LisStraight_Truck { get; set; }

        public bool? LisActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RunResource> RunResources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScannedPalletConfirm> ScannedPalletConfirms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tractor_Productivity> Tractor_Productivity { get; set; }
    }
}
