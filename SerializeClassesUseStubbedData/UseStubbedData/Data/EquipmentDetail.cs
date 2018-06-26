namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EquipmentDetail")]
    public partial class EquipmentDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EquipmentDetail()
        {
            EquipmentChecklistResponses = new HashSet<EquipmentChecklistResponse>();
        }

        public int EquipmentDetailId { get; set; }

        public int EquipmentClassHeaderId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(100)]
        public string SerialNo { get; set; }

        [Required]
        [StringLength(100)]
        public string EquipmentNo { get; set; }

        public DateTime? InServiceDate { get; set; }

        public DateTime? OutOfServiceDate { get; set; }

        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EquipmentChecklistResponse> EquipmentChecklistResponses { get; set; }

        public virtual EquipmentClassHeader EquipmentClassHeader { get; set; }
    }
}
