namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XPObjectType")]
    public partial class XPObjectType
    {
        [Key]
        public int OID { get; set; }

        [StringLength(254)]
        public string TypeName { get; set; }

        [StringLength(254)]
        public string AssemblyName { get; set; }
    }
}
