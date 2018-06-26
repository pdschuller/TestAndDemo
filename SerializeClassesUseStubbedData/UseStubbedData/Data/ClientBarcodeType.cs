namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientBarcodeType")]
    public partial class ClientBarcodeType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientBarcodeType()
        {
            ClientBarcodeTypeSpecs = new HashSet<ClientBarcodeTypeSpec>();
        }

        public int ClientBarcodeTypeID { get; set; }

        [Required]
        [StringLength(50)]
        public string ClientName { get; set; }

        [Required]
        [StringLength(16)]
        public string Prefix { get; set; }

        public bool Reviewed { get; set; }

        [StringLength(128)]
        public string ClientDesc { get; set; }

        public bool Deleted { get; set; }

        public DateTime CreatedDatetime { get; set; }

        public DateTime ModifiedDatetime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientBarcodeTypeSpec> ClientBarcodeTypeSpecs { get; set; }
    }
}
