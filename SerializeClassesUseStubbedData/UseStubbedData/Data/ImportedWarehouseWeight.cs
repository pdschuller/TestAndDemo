namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ImportedWarehouseWeight")]
    public partial class ImportedWarehouseWeight
    {
        public int Id { get; set; }

        public DateTime WorkDate { get; set; }

        public int EmployeeId { get; set; }

        public int JobId { get; set; }

        public decimal Weight { get; set; }
    }
}
