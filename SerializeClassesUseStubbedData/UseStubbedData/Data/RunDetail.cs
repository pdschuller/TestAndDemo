namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RunDetail
    {
        [Column(TypeName = "numeric")]
        public decimal RunId { get; set; }

        public decimal EmployeeID { get; set; }

        public DateTime? RunStartTime { get; set; }

        [Required]
        [StringLength(100)]
        public string TruckNumber { get; set; }

        public int TruckStartMiles { get; set; }

        public int TruckEndMiles { get; set; }

        [Required]
        [StringLength(100)]
        public string TrailerNumber { get; set; }

        public int TrailerStartMiles { get; set; }

        public int TrailerEndMiles { get; set; }

        public DateTime? RunEndTime { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string Comments { get; set; }

        [Key]
        public decimal RunNumberID { get; set; }

        public DateTime CreatedDatetime { get; set; }

        public DateTime? ModifiedDatetime { get; set; }

        public DateTime? RunDepartTime { get; set; }
    }
}
