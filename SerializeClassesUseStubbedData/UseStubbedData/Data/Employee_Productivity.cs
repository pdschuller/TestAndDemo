namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Productivity
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Employee_ProductivityID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal EmployeeID { get; set; }

        public DateTime? Employee_Date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Status { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Employee_Inactive_ReasonID { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Employee_InActive_Reason_List Employee_InActive_Reason_List { get; set; }
    }
}
