namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NewOrder
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal NewOrdersID { get; set; }

        public decimal? OrderID { get; set; }

        public decimal? OrderNumber { get; set; }

        [StringLength(20)]
        public string ShipperNumber { get; set; }

        public decimal ShipperID { get; set; }

        public decimal? Consignor { get; set; }

        public decimal? Consignee { get; set; }

        public DateTime? ShipperShipDate { get; set; }

        public DateTime? ShipperDeliveryDate { get; set; }

        public DateTime? PlannedShipDate { get; set; }

        public DateTime? ActualShipDate { get; set; }

        public DateTime? PlannedDeliveryDate { get; set; }

        public DateTime? ActualDeliveryDate { get; set; }

        public decimal TotalOrderWeight { get; set; }

        public decimal TotalOrderCube { get; set; }

        public decimal TotalOrderPieces { get; set; }

        public decimal TotalOrderPallets { get; set; }

        [StringLength(10)]
        public string Status { get; set; }

        [StringLength(5)]
        public string OrderOrientation { get; set; }

        [StringLength(20)]
        public string PO_Number { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateOrderDate { get; set; }

        [StringLength(100)]
        public string Notes { get; set; }

        [StringLength(5)]
        public string Condition { get; set; }

        public int? ServiceLevel { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FlagID { get; set; }

        [StringLength(1)]
        public string AddDeleteEdit { get; set; }

        [StringLength(100)]
        public string Error { get; set; }

        public virtual Flag Flag { get; set; }
    }
}
