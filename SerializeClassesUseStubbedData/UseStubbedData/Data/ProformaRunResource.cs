namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProformaRunResource")]
    public partial class ProformaRunResource
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal ProformaRunResourceID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Driver1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Driver2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tractor { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Trailer1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Trailer2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ProformaRunMasterID { get; set; }

        public bool? SecondRun { get; set; }

        public virtual ProformaRunMaster ProformaRunMaster { get; set; }
    }
}
