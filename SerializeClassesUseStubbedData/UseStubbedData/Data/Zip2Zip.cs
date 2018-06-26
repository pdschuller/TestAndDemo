namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zip2Zip
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string Origin { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string Dest { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Miles { get; set; }

        public short? DriveTime { get; set; }
    }
}
