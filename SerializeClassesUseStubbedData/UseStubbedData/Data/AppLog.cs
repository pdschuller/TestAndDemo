namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppLog")]
    public partial class AppLog
    {
        public int AppLogId { get; set; }

        public DateTime LogEntryTime { get; set; }

        [Required]
        [StringLength(50)]
        public string TraceType { get; set; }

        [Required]
        [StringLength(200)]
        public string AppName { get; set; }

        [Required]
        [StringLength(5000)]
        public string Context { get; set; }

        [Column(TypeName = "text")]
        public string SQLStmt { get; set; }

        public DateTime? ExecuteStartTime { get; set; }

        public DateTime? ExecuteEndTime { get; set; }

        public decimal? ExecuteAsHours { get; set; }

        public decimal? ExecuteAsMinutes { get; set; }

        public decimal? ExecuteAsSeconds { get; set; }

        public decimal? ExecuteAsMilliseconds { get; set; }
    }
}
