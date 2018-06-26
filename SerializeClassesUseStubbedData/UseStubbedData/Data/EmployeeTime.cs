namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeTime")]
    public partial class EmployeeTime
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TimeId { get; set; }

        [Required]
        [StringLength(50)]
        public string EmployeeId { get; set; }

        public DateTime? WorkDate { get; set; }

        [StringLength(50)]
        public string InTime { get; set; }

        [StringLength(50)]
        public string OutTime { get; set; }

        [StringLength(50)]
        public string InCode { get; set; }

        [StringLength(50)]
        public string OutCode { get; set; }

        public bool? InMod { get; set; }

        public bool? OutMod { get; set; }

        public decimal? RegHour { get; set; }

        public decimal? OverTime1 { get; set; }

        public decimal? OverTime2 { get; set; }

        public int? JobId { get; set; }

        public bool? Deleted { get; set; }

        [StringLength(50)]
        public string Shift { get; set; }

        public DateTime? EventDate { get; set; }
    }
}
