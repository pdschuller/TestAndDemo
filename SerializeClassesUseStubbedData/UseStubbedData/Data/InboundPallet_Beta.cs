namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InboundPallet_Beta
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

        public DateTime? ManufactureDate { get; set; }

        public int? ManufactureYear { get; set; }

        public int? ManufactureMonth { get; set; }

        public int? ManufactureDay { get; set; }

        public int? UserId { get; set; }
    }
}
