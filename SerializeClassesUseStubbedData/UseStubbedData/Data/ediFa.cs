namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ediFa")]
    public partial class ediFa
    {
        [Key]
        public int FaID { get; set; }

        public int? GroupID { get; set; }

        public int? IsaControl { get; set; }

        public int? GsControl { get; set; }

        public bool? DirectionIn { get; set; }

        public DateTime? EnterDate { get; set; }
    }
}
