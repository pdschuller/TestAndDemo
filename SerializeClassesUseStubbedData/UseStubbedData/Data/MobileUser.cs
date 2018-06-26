namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileUser")]
    public partial class MobileUser
    {
        public int MobileUserID { get; set; }

        [StringLength(25)]
        public string Lastname { get; set; }

        [StringLength(25)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(3)]
        public string Initials { get; set; }

        [StringLength(10)]
        public string PIN { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDatetime { get; set; }

        public DateTime ModifiedDatetime { get; set; }

        public bool? Deleted { get; set; }
    }
}
