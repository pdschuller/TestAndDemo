namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderJobCodeMapping")]
    public partial class OrderJobCodeMapping
    {
        public int OrderJobCodeMappingId { get; set; }

        public int JobCode { get; set; }

        [StringLength(10)]
        public string ShipperShortName { get; set; }

        [StringLength(10)]
        public string ShipperType { get; set; }

        [StringLength(10)]
        public string OrderType { get; set; }

        public int? WorkType { get; set; }
    }
}
