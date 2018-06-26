namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Results_old
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string runname { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal CompanyLocationID { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal StopSequence { get; set; }
    }
}
