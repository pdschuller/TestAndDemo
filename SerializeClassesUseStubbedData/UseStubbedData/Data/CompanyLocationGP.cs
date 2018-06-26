namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyLocationGPS")]
    public partial class CompanyLocationGP
    {
        [Key]
        public decimal CompanyLocationId { get; set; }

        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }
    }
}
