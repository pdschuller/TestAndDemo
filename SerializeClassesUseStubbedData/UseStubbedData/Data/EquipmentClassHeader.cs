namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EquipmentClassHeader")]
    public partial class EquipmentClassHeader
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EquipmentClassHeader()
        {
            EquipmentChecklistResponses = new HashSet<EquipmentChecklistResponse>();
            EquipmentDetails = new HashSet<EquipmentDetail>();
        }

        public int EquipmentClassHeaderId { get; set; }

        [Required]
        [StringLength(500)]
        public string EquipmentClassDescription { get; set; }

        public bool IsActive { get; set; }

        public bool IsComments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquipmentChecklistResponse> EquipmentChecklistResponses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquipmentDetail> EquipmentDetails { get; set; }
    }
}
