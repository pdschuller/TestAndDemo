namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stkLocation")]
    public partial class stkLocation
    {
        [Key]
        public int LocationID { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

        [StringLength(10)]
        public string SortOrder { get; set; }

        [StringLength(10)]
        public string PickSortOrder { get; set; }

        public bool? Rack { get; set; }
    }
}
