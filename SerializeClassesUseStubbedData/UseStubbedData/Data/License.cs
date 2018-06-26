namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("License")]
    public partial class License
    {
        [Column(TypeName = "numeric")]
        public decimal LicenseID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RunID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RunStopID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ProformaRunMasterID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RunNumberID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal StopNumberID { get; set; }

        public int EdiControl { get; set; }
    }
}
