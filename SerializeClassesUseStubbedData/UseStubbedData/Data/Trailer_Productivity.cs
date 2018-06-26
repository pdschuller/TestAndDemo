namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Trailer_Productivity
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Trailer_ProductivityID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal TrailerID { get; set; }

        public DateTime? Trailer_Date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Status { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Trailer_Inactive_ReasonID { get; set; }

        public virtual Trailer Trailer { get; set; }
    }
}
