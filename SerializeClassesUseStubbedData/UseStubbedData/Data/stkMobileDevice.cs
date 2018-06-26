namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stkMobileDevice")]
    public partial class stkMobileDevice
    {
        [Key]
        public int MobileDeviceID { get; set; }

        [StringLength(17)]
        public string MacAddress { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(20)]
        public string SerialNumber { get; set; }
    }
}
