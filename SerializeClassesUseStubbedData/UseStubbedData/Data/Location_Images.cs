namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Location_Images
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Location_Images()
        {
            Location_ImageRelationship = new HashSet<Location_ImageRelationship>();
        }

        [Key]
        public int ImageId { get; set; }

        [Required]
        [StringLength(500)]
        public string ImageDescription { get; set; }

        [Required]
        [StringLength(500)]
        public string ImageName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Location_ImageRelationship> Location_ImageRelationship { get; set; }
    }
}
