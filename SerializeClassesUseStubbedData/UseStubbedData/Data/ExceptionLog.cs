namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExceptionLog")]
    public partial class ExceptionLog
    {
        public int ExceptionLogId { get; set; }

        public DateTime? LogDate { get; set; }

        public int? UserId { get; set; }

        [StringLength(50)]
        public string ScannerId { get; set; }

        [StringLength(255)]
        public string MsgSource { get; set; }

        [StringLength(25)]
        public string MsgType { get; set; }

        [Column(TypeName = "text")]
        public string MsgText { get; set; }
    }
}
