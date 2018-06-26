namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RunOrder")]
    public partial class RunOrder
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal RunOrderID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal RunStopID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OrderID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RunOrderSequence { get; set; }

        [StringLength(10)]
        public string pdsCol { get; set; }

        public virtual Order Order { get; set; }

        public virtual RunStop RunStop { get; set; }
    }
}
