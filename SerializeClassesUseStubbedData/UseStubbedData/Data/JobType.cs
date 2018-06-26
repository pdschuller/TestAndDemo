namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobType")]
    public partial class JobType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobId { get; set; }

        public int? DepartmentId { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public bool Deleted { get; set; }
    }
}
