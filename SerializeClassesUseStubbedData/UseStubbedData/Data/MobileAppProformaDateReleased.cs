namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileAppProformaDateReleased")]
    public partial class MobileAppProformaDateReleased
    {
        [Key]
        public int ProformaDateId { get; set; }

        [Required]
        [StringLength(8)]
        public string ProformaDate { get; set; }

        public bool IsReleased { get; set; }
    }
}
