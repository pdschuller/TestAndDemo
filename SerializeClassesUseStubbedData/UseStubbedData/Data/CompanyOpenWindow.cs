namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyOpenWindow")]
    public partial class CompanyOpenWindow
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal CompanyOpenWindowID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CompanyLocationID { get; set; }

        [StringLength(10)]
        public string DayofWeek { get; set; }

        public DateTime? OpenTime { get; set; }

        public DateTime? CloseTime { get; set; }

        public DateTime? AppointmentTime { get; set; }

        public DateTime? LunchTime { get; set; }

        public virtual CompanyLocation CompanyLocation { get; set; }
    }
}
