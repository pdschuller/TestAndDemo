namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InboundLocation")]
    public partial class InboundLocation
    {
        [Key]
        public int LocationId { get; set; }

        [Required]
        [StringLength(1)]
        public string LocationType { get; set; }

        [Required]
        [StringLength(1)]
        public string LocationCode { get; set; }

        [Required]
        [StringLength(255)]
        public string LocationDescription { get; set; }
    }
}
