namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Location_ImageRelationship
    {
        [Key]
        public int ImageRelationId { get; set; }

        public int ImageId { get; set; }

        public int LocationId { get; set; }

        public bool IsActive { get; set; }

        public bool IsDelete { get; set; }

        public virtual Location_Images Location_Images { get; set; }
    }
}
