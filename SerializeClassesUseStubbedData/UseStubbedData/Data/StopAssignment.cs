namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StopAssignment")]
    public partial class StopAssignment
    {
        [Key]
        [Column(Order = 0)]
        public decimal StopNumberId { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal EmployeeId { get; set; }

        public DateTime ProformaDate { get; set; }

        public decimal PercentPick { get; set; }

        public decimal PercentLoad { get; set; }

        public DateTime? WorkDate { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkType { get; set; }

        public decimal? PercentAssigned { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }
    }
}
