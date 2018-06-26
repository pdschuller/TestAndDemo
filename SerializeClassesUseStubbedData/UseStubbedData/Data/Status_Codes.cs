namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Status_Codes
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Status_codeID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Order_Status { get; set; }

        [StringLength(50)]
        public string Order_Description { get; set; }
    }
}
