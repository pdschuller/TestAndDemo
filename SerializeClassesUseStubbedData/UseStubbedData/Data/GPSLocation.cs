namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GPSLocation")]
    public partial class GPSLocation
    {
        public int GPSLocationId { get; set; }

        public decimal EmployeeId { get; set; }

        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime CreatedDatetime { get; set; }

        [Required]
        [StringLength(50)]
        public string IOSVersion { get; set; }
    }
}
