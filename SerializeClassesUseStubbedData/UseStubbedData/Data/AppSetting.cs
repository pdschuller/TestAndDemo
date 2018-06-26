namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AppSetting
    {
        [Key]
        public int SettingId { get; set; }

        [Required]
        [StringLength(50)]
        public string SettingName { get; set; }

        [Required]
        [StringLength(50)]
        public string SettingValue { get; set; }
    }
}
