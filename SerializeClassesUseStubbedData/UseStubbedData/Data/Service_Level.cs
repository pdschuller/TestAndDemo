namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service_Level
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Service_LevelID { get; set; }

        [Key]
        [Column("Service_Level", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Service_Level1 { get; set; }
    }
}
