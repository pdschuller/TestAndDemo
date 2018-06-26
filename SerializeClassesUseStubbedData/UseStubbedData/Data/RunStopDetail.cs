namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RunStopDetail")]
    public partial class RunStopDetail
    {
        public decimal RunID { get; set; }

        public decimal RunStopID { get; set; }

        [Key]
        public decimal StopNumberID { get; set; }

        public decimal EmployeeID { get; set; }

        public DateTime? ActualArrivalDate { get; set; }

        public DateTime? ActualDepartDate { get; set; }

        public DateTime? UnloadLoadFirstscan { get; set; }

        [Required]
        [StringLength(200)]
        public string Type { get; set; }

        public bool Late { get; set; }

        public int PalletsTaken { get; set; }

        public DateTime? UnloadStartDate { get; set; }

        public int CasesOnBills { get; set; }

        public int DeliveredCases { get; set; }

        public bool OverShort { get; set; }

        public bool Damage { get; set; }

        [Column(TypeName = "image")]
        public byte[] Photo { get; set; }

        public bool CalledInOSD { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string OSDComments { get; set; }

        public int PalletsDelivered { get; set; }

        public int PalletsReturned { get; set; }

        public bool Delayed { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string GeneralComments { get; set; }

        public decimal GPSLatitude { get; set; }

        public decimal GPSLongitude { get; set; }

        public decimal RunNumberID { get; set; }

        public DateTime CreatedDatetime { get; set; }

        public DateTime? ModifiedDatetime { get; set; }
    }
}
