namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InboundSealDisposition")]
    public partial class InboundSealDisposition
    {
        [Key]
        public int SealDispositionId { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }
    }
}
