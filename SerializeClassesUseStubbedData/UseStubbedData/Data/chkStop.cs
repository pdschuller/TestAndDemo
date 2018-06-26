namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("chkStop")]
    public partial class chkStop
    {
        [Key]
        public int StopID { get; set; }

        public int? StopNumberID { get; set; }

        public bool? Exceptions { get; set; }

        public DateTime? ClosedAt { get; set; }

        public short? UserID { get; set; }

        [StringLength(3)]
        public string Initials { get; set; }

        public DateTime? PrintedAt { get; set; }

        [StringLength(2)]
        public string Cust { get; set; }
    }
}
