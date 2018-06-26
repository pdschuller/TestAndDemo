namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Server")]
    public partial class Server
    {
        [Column("Server")]
        [StringLength(20)]
        public string Server1 { get; set; }

        [StringLength(10)]
        public string Database_Name { get; set; }

        [Key]
        [StringLength(10)]
        public string UserID { get; set; }

        [StringLength(10)]
        public string Password { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Timer { get; set; }
    }
}
