namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trailer")]
    public partial class Trailer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trailer()
        {
            RunResources = new HashSet<RunResource>();
            RunResources1 = new HashSet<RunResource>();
            RunResources2 = new HashSet<RunResource>();
            ScannedPalletConfirms = new HashSet<ScannedPalletConfirm>();
            Trailer_Productivity = new HashSet<Trailer_Productivity>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TrailerID { get; set; }

        [StringLength(50)]
        public string Trailer_Name { get; set; }

        [StringLength(10)]
        public string Trailer_Length { get; set; }

        [StringLength(10)]
        public string Trailer_Weight { get; set; }

        [StringLength(10)]
        public string Trailer_MaxOrderWeight { get; set; }

        [StringLength(10)]
        public string Trailer_Axles { get; set; }

        public bool? LisDryVan { get; set; }

        public bool? LisTempControlled { get; set; }

        public bool? LisActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RunResource> RunResources { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RunResource> RunResources1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RunResource> RunResources2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScannedPalletConfirm> ScannedPalletConfirms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trailer_Productivity> Trailer_Productivity { get; set; }
    }
}
