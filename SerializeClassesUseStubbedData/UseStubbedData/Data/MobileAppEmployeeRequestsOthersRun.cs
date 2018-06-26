namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileAppEmployeeRequestsOthersRun")]
    public partial class MobileAppEmployeeRequestsOthersRun
    {
        [Key]
        public int EmployeeRequestsOthersRunId { get; set; }

        public decimal EmployeeId { get; set; }

        public decimal RequestedEmployeeId { get; set; }

        public decimal RunNumberId { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
