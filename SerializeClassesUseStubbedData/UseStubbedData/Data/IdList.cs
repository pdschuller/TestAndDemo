namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IdList")]
    public partial class IdList
    {
        [Column(TypeName = "numeric")]
        public decimal Id { get; set; }
    }
}
