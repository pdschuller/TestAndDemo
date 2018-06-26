namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proforma")]
    public partial class Proforma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proforma()
        {
            ProformaRunMasters = new HashSet<ProformaRunMaster>();
        }

        public int ProformaId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProformaName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProformaRunMaster> ProformaRunMasters { get; set; }
    }
}
