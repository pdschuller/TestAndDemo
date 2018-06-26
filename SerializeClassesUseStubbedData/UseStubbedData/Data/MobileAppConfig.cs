namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileAppConfig")]
    public partial class MobileAppConfig
    {
        [Key]
        public int ConfigurationDataId { get; set; }

        public DateTime StartTime { get; set; }

        [Required]
        [StringLength(100)]
        public string MinVersionLock { get; set; }

        public int GPSPollTime { get; set; }

        [Required]
        [StringLength(100)]
        public string DispatchPhoneNumber { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
