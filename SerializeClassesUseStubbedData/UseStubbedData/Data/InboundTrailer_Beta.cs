namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class InboundTrailer_Beta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TrailerId { get; set; }

        [Key]
        [StringLength(10)]
        public string URNumber { get; set; }

        public DateTime UnloadDate { get; set; }

        public DateTime? CloseDate { get; set; }

        [StringLength(1)]
        public string ReportPrinted { get; set; }

        [Required]
        [StringLength(1)]
        public string UnloadStatus { get; set; }

        public int? UserId { get; set; }

        [StringLength(20)]
        public string ReSealNumber { get; set; }

        [StringLength(20)]
        public string SealNumber { get; set; }

        public int? SealDispositionID { get; set; }

        [StringLength(1)]
        public string Dunnage { get; set; }
    }
}
