namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InboundPallet")]
    public partial class InboundPallet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PalletId { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TrailerId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PalletSeqNum { get; set; }

        [StringLength(20)]
        public string LicensePlate { get; set; }

        [Required]
        [StringLength(10)]
        public string ItemCode { get; set; }

        public int? NumPieces { get; set; }

        public DateTime? ManufactureDate { get; set; }

        public int? ManufactureYear { get; set; }

        public int? ManufactureMonth { get; set; }

        public int? ManufactureDay { get; set; }

        [StringLength(10)]
        public string CustCode { get; set; }

        public int? BarCodeId { get; set; }

        public int? UserId { get; set; }

        public DateTime? ScanTime { get; set; }
    }
}
