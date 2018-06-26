namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProformaRunStop
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ProformaRunStopsID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ProformaRunMasterID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CompanyLocationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal StopSequence { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AveWeight { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AveCube { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AvePieces { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AvePallets { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MilesTo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? AveStopTime { get; set; }

        public virtual CompanyLocation CompanyLocation { get; set; }

        public virtual ProformaRunMaster ProformaRunMaster { get; set; }
    }
}
