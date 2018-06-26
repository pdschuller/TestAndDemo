namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoggedInfo")]
    public partial class LoggedInfo
    {
        public int LoggedInfoId { get; set; }

        [StringLength(500)]
        public string Importance { get; set; }

        [StringLength(300)]
        public string Message { get; set; }

        public DateTime? TimeStamp { get; set; }
    }
}
