namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ScannedPalletLoad")]
    public partial class ScannedPalletLoad
    {
        public int ScannedPalletLoadID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal StopNumberID { get; set; }

        [Required]
        [StringLength(50)]
        public string WMSCode { get; set; }

        [Required]
        [StringLength(32)]
        public string Store { get; set; }

        public int ClientBarcodeType { get; set; }

        public int? CompanyLocationID { get; set; }

        public decimal PalletCount { get; set; }

        [Required]
        [StringLength(128)]
        public string BarcodeScan { get; set; }

        public DateTime ScanDatetime { get; set; }

        public int ScannedPalletLoadConfirmID { get; set; }

        public int MobileUserID { get; set; }

        public bool Deleted { get; set; }

        public DateTime CreatedDatetime { get; set; }

        public DateTime ModifiedDatetime { get; set; }

        public virtual ScannedPalletConfirm ScannedPalletConfirm { get; set; }
    }
}
