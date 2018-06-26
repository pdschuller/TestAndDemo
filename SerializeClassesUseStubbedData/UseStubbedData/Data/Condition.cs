namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Condition")]
    public partial class Condition
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ConditionID { get; set; }

        [Column("Condition")]
        [Required]
        [StringLength(5)]
        public string Condition1 { get; set; }
    }
}
