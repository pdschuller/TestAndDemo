namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zip2ZipHistory
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string Origin { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string Dest { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal OriginalMiles { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short OriginDriveTime { get; set; }

        [Key]
        [Column(Order = 4)]
        public decimal Miles { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short DriveTime { get; set; }
    }
}
