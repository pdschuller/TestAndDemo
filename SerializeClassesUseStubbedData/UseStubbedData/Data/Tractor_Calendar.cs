namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tractor_Calendar
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Tractor_CalendarID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TractorID { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tractor_Inactive_Reason_ListID { get; set; }
    }
}
