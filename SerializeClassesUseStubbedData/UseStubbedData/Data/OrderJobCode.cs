namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderJobCode")]
    public partial class OrderJobCode
    {
        [Key]
        [Column(Order = 0)]
        public decimal OrderId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkType { get; set; }

        public int JobCode { get; set; }
    }
}
