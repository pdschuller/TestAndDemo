namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chkPalletLog")]
    public partial class chkPalletLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PalletID { get; set; }

        public int? ItemCount { get; set; }

        public short? UserID { get; set; }

        [StringLength(3)]
        public string Initials { get; set; }

        public DateTime? FinishedAt { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Action { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime ActionDate { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(35)]
        public string ActionUser { get; set; }
    }
}
