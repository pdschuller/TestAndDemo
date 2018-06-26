namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NonDispatchedStopType")]
    public partial class NonDispatchedStopType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NonDispatchedStopType()
        {
            NonDispatchedStops = new HashSet<NonDispatchedStop>();
        }

        [Key]
        public int TypeID { get; set; }

        [Required]
        [StringLength(100)]
        public string Type { get; set; }

        public int SortOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NonDispatchedStop> NonDispatchedStops { get; set; }
    }
}
