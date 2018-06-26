namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chkPallet")]
    public partial class chkPallet
    {
        [Key]
        public int PalletID { get; set; }

        public int? ItemCount { get; set; }

        public short? UserID { get; set; }

        [StringLength(3)]
        public string Initials { get; set; }

        public DateTime? FinishedAt { get; set; }
    }
}
