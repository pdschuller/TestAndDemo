namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PalletTag")]
    public partial class PalletTag
    {
        public int PalletTagID { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        [StringLength(10)]
        public string Userid { get; set; }

        [StringLength(50)]
        public string BarCode { get; set; }
    }
}
