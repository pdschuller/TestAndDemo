namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NonDispatchedStop")]
    public partial class NonDispatchedStop
    {
        public int NonDispatchedStopId { get; set; }

        public decimal RunId { get; set; }

        public int TypeId { get; set; }

        public decimal EmployeeID { get; set; }

        public DateTime? StopDateTime { get; set; }

        [Required]
        [StringLength(500)]
        public string LocationDescription { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        [Required]
        [StringLength(50)]
        public string PostalCode { get; set; }

        public int CallInStop { get; set; }

        public int CallInDepart { get; set; }

        public DateTime? DepartDateTime { get; set; }

        [Required]
        [StringLength(500)]
        public string Comments { get; set; }

        public decimal Longitude { get; set; }

        public decimal Latitude { get; set; }

        public decimal RunNumberID { get; set; }

        public virtual NonDispatchedStopType NonDispatchedStopType { get; set; }
    }
}
