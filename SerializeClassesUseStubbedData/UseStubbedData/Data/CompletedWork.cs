namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompletedWork")]
    public partial class CompletedWork
    {
        [Key]
        [Column(Order = 0)]
        public decimal EmployeeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobId { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime WorkDate { get; set; }

        public decimal? Hours { get; set; }

        [StringLength(5)]
        public string UnitType { get; set; }

        public decimal? Units { get; set; }

        [StringLength(10)]
        public string Source { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }
    }
}
