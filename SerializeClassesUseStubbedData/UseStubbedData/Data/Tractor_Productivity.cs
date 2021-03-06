namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tractor_Productivity
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Tractor_ProductivityID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TractorID { get; set; }

        public DateTime? Tractor_Date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Status { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tractor_Inactive_ReasonID { get; set; }

        public virtual Tractor Tractor { get; set; }
    }
}
