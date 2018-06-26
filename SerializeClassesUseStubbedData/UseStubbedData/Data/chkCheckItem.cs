namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chkCheckItem")]
    public partial class chkCheckItem
    {
        [Key]
        public int CheckItemID { get; set; }

        [StringLength(14)]
        public string Barcode { get; set; }

        [StringLength(12)]
        public string Itemcode { get; set; }

        [StringLength(2)]
        public string Custcode { get; set; }

        public int? PalletID { get; set; }

        public int? StopNumberID { get; set; }

        public short? Pieces { get; set; }

        public DateTime? ScanTime { get; set; }

        public byte? ScanSequence { get; set; }

        public byte? PalletStopSequence { get; set; }

        public bool? NewItem { get; set; }

        public bool? Promo { get; set; }
    }
}
