namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MobileAppException
    {
        public int MobileAppExceptionId { get; set; }

        [Required]
        [StringLength(50)]
        public string MethodName { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string MethodException { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string MethodStackTrace { get; set; }

        public DateTime ExceptionDate { get; set; }
    }
}
