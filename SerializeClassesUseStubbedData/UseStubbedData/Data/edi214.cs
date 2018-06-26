namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class edi214
    {
        [Key]
        [Column("214ID")]
        public int C214ID { get; set; }

        public int? TransactionID { get; set; }

        [StringLength(20)]
        public string B10_Ref { get; set; }

        [StringLength(20)]
        public string B10_ShipId { get; set; }

        [StringLength(4)]
        public string B10_Scac { get; set; }

        [StringLength(30)]
        public string L11_Po { get; set; }

        [StringLength(30)]
        public string L11_Ma { get; set; }

        [StringLength(50)]
        public string N1_Sf_Name { get; set; }

        [StringLength(2)]
        public string N1_Sf_Qual { get; set; }

        [StringLength(20)]
        public string N1_Sf_Ref { get; set; }

        [StringLength(50)]
        public string N1_Sh_Name { get; set; }

        [StringLength(50)]
        public string N3_Sh_Addr1 { get; set; }

        [StringLength(30)]
        public string N4_Sh_City { get; set; }

        [StringLength(2)]
        public string N4_Sh_St { get; set; }

        [StringLength(10)]
        public string N4_Sh_Zip { get; set; }

        [StringLength(50)]
        public string N1_Cn_Name { get; set; }

        [StringLength(8)]
        public string At7_Xa_Date { get; set; }

        [StringLength(4)]
        public string At7_Xa_Time { get; set; }

        [StringLength(8)]
        public string At7_Aa_Date { get; set; }

        [StringLength(4)]
        public string At7_Aa_Time { get; set; }

        [StringLength(8)]
        public string At7_X9_Date { get; set; }

        [StringLength(4)]
        public string At7_X9_Time { get; set; }

        [StringLength(8)]
        public string At7_Ab_Date { get; set; }

        [StringLength(4)]
        public string At7_Ab_Time { get; set; }

        [StringLength(8)]
        public string At7_X3_Date { get; set; }

        [StringLength(4)]
        public string At7_X3_Time { get; set; }

        [StringLength(8)]
        public string At7_Af_Date { get; set; }

        [StringLength(4)]
        public string At7_Af_Time { get; set; }

        [StringLength(8)]
        public string At7_X1_Date { get; set; }

        [StringLength(4)]
        public string At7_X1_Time { get; set; }

        [StringLength(8)]
        public string At7_D1_Date { get; set; }

        [StringLength(4)]
        public string At7_D1_Time { get; set; }
    }
}
