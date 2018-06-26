namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ediGroup")]
    public partial class ediGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ediGroup()
        {
            ediTransactions = new HashSet<ediTransaction>();
        }

        [Key]
        public int GroupID { get; set; }

        [StringLength(2)]
        public string IsaSendQual { get; set; }

        [StringLength(15)]
        public string IsaSendID { get; set; }

        [StringLength(2)]
        public string IsaRecvQual { get; set; }

        [StringLength(15)]
        public string IsaRecvID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? IsaDate { get; set; }

        public int? IsaControl { get; set; }

        [StringLength(1)]
        public string IsaAck { get; set; }

        [StringLength(1)]
        public string IsaUsage { get; set; }

        [StringLength(2)]
        public string GsCode { get; set; }

        [StringLength(15)]
        public string GsSendID { get; set; }

        [StringLength(15)]
        public string GsRecvID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? GsDate { get; set; }

        public int? GsControl { get; set; }

        public int? TsCountGe { get; set; }

        public int? TsCountActual { get; set; }

        public int? TsCountAck { get; set; }

        [StringLength(1)]
        public string AckCode { get; set; }

        public bool? DirectionIn { get; set; }

        public DateTime? EnterDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ediTransaction> ediTransactions { get; set; }
    }
}
