namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyLocationAppointment")]
    public partial class CompanyLocationAppointment
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal CompanyLocationAppointmentID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CompanyLocationID { get; set; }

        public bool? NegativeStartOffset { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? StartOffset { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? EndOffset { get; set; }

        public int? StartOffsetInMin { get; set; }

        public int? EndOffsetInMin { get; set; }

        public bool? MustFinishWithinWindow { get; set; }

        public bool? MustStartWithinWindow { get; set; }

        public int? weekday { get; set; }

        public virtual CompanyLocation CompanyLocation { get; set; }
    }
}
