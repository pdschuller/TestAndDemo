namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stkCust")]
    public partial class stkCust
    {
        [Key]
        public int CustID { get; set; }

        [StringLength(2)]
        public string CustCode { get; set; }
    }
}
