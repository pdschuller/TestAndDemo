namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClientBarcodeTypeSpec")]
    public partial class ClientBarcodeTypeSpec
    {
        public int ClientBarcodeTypeSpecID { get; set; }

        public int ClientBarcodeTypeID { get; set; }

        [Required]
        [StringLength(32)]
        public string BarcodeTypeName { get; set; }

        public bool Required { get; set; }

        public bool ContainsStore { get; set; }

        [StringLength(128)]
        public string RegexIdentExtract { get; set; }

        public int Length { get; set; }

        public int? ndxStore1Start { get; set; }

        public int? ndxStore1End { get; set; }

        public int? ndxStore2Start { get; set; }

        public int? ndxStore2End { get; set; }

        [StringLength(1)]
        public string StoreConcatChar { get; set; }

        public int ZeroPadLeft { get; set; }

        public int ZeroPadRight { get; set; }

        public bool Reviewed { get; set; }

        public bool Deleted { get; set; }

        public DateTime CreatedDatetime { get; set; }

        public DateTime ModifiedDatetime { get; set; }

        public virtual ClientBarcodeType ClientBarcodeType { get; set; }
    }
}
