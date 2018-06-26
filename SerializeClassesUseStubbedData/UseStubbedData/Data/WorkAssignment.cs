namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WorkAssignment")]
    public partial class WorkAssignment
    {
        public int WorkAssignmentId { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EmployeeId { get; set; }

        public DateTime? WorkDate { get; set; }

        public int WorkType { get; set; }

        public decimal? PercentAssigned { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Modified { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
