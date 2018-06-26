namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RunStopDetailPhoto")]
    public partial class RunStopDetailPhoto
    {
        [Key]
        public int RunStopPhotoId { get; set; }

        public decimal RunStopId { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        public decimal? StopNumberID { get; set; }

        public int? PhotoLength { get; set; }
    }
}
