namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReportJob")]
    public partial class ReportJob
    {
        public int ReportJobID { get; set; }

        public int? ReportID { get; set; }

        public DateTime? Created { get; set; }

        public DateTime? Printed { get; set; }

        [StringLength(20)]
        public string Printer { get; set; }

        [StringLength(15)]
        public string Param1Name { get; set; }

        [StringLength(15)]
        public string Param1Value { get; set; }

        [StringLength(5)]
        public string Param1Type { get; set; }

        [StringLength(15)]
        public string Param2Name { get; set; }

        [StringLength(15)]
        public string Param2Value { get; set; }

        [StringLength(5)]
        public string Param2Type { get; set; }

        [StringLength(15)]
        public string Param3Name { get; set; }

        [StringLength(15)]
        public string Param3Value { get; set; }

        [StringLength(5)]
        public string Param3Type { get; set; }

        [StringLength(20)]
        public string Notes { get; set; }
    }
}
