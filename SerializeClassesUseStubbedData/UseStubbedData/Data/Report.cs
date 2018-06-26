namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Report")]
    public partial class Report
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ReportID { get; set; }

        [Required]
        [StringLength(30)]
        public string Menu_Name { get; set; }

        [StringLength(50)]
        public string Path { get; set; }

        [Column("Report")]
        [StringLength(30)]
        public string Report1 { get; set; }

        [StringLength(5)]
        public string SortOrder { get; set; }

        public bool? IsByRun { get; set; }

        public bool? IsPoByStop { get; set; }

        public bool? HasEndDate { get; set; }
    }
}
