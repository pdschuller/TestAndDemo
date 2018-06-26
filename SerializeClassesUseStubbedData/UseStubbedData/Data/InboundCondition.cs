namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InboundCondition")]
    public partial class InboundCondition
    {
        [Key]
        public int ConditionId { get; set; }

        [Required]
        [StringLength(255)]
        public string ConditionDescription { get; set; }
    }
}
