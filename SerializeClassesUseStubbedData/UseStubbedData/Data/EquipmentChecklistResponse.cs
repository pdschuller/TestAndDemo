namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EquipmentChecklistResponse")]
    public partial class EquipmentChecklistResponse
    {
        public int EquipmentChecklistResponseId { get; set; }

        public int EquipmentClassHeaderId { get; set; }

        public decimal RunNumberId { get; set; }

        public decimal EmployeeId { get; set; }

        public int? EquipmentDetailId { get; set; }

        [StringLength(500)]
        public string Comment { get; set; }

        public DateTime CreateOnDate { get; set; }

        public bool IsDeleted { get; set; }

        public virtual EquipmentClassHeader EquipmentClassHeader { get; set; }

        public virtual EquipmentDetail EquipmentDetail { get; set; }
    }
}
