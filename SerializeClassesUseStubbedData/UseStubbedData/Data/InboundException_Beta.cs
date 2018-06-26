namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InboundException_Beta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExceptionId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PalletDetailId { get; set; }

        public int? NumPieces { get; set; }

        public int? DistanceInTrailer { get; set; }

        public int? VerticalLocationId { get; set; }

        public int? HorizontalLocationId { get; set; }
    }
}
