namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InboundPalletDetail_Beta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PalletDetailId { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PalletId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemSeqNum { get; set; }

        [Required]
        [StringLength(10)]
        public string ItemCode { get; set; }

        public int? NumPieces { get; set; }

        [StringLength(2)]
        public string CustCode { get; set; }

        public int? BarCodeId { get; set; }

        public DateTime? ScanTime { get; set; }
    }
}
