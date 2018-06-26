namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RunSub")]
    public partial class RunSub
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal RunSubID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RunStopID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RunID { get; set; }
    }
}
