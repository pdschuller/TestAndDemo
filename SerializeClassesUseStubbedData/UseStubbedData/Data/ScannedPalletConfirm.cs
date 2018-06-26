namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ScannedPalletConfirm")]
    public partial class ScannedPalletConfirm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ScannedPalletConfirm()
        {
            ScannedPalletLoads = new HashSet<ScannedPalletLoad>();
        }

        [Key]
        public int ScannedPalletLoadConfirmID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal StopNumberID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TrailerID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TractorID { get; set; }

        public DateTime ConfirmDatetime { get; set; }

        public decimal TotalPieces { get; set; }

        [Required]
        [StringLength(128)]
        public string TrailerBarcode { get; set; }

        [Required]
        [StringLength(32)]
        public string TrailerNumber { get; set; }

        public int MobileUserID { get; set; }

        public bool Deleted { get; set; }

        public DateTime CreatedDatetime { get; set; }

        public DateTime ModifiedDatetime { get; set; }

        public virtual Tractor Tractor { get; set; }

        public virtual Trailer Trailer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ScannedPalletLoad> ScannedPalletLoads { get; set; }
    }
}
