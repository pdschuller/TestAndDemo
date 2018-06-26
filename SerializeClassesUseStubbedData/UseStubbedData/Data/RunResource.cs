namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RunResource")]
    public partial class RunResource
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal RunResourceID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RunID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CarrierID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TractorID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TrailerID1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TrailerID2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TrailerID3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Driver1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Driver2 { get; set; }

        public bool? SecondRun { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Employee Employee1 { get; set; }

        public virtual Run Run { get; set; }

        public virtual Tractor Tractor { get; set; }

        public virtual Trailer Trailer { get; set; }

        public virtual Trailer Trailer1 { get; set; }

        public virtual Trailer Trailer2 { get; set; }
    }
}
