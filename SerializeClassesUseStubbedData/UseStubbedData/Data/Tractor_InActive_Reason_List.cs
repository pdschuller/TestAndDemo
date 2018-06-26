namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tractor_InActive_Reason_List
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Tractor_Inactive_Reason_ListID { get; set; }

        [StringLength(50)]
        public string Inactive_Reason { get; set; }

        public bool? lisNotActive { get; set; }
    }
}
