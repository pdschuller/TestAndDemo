namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StopPallet")]
    public partial class StopPallet
    {
        [Key]
        [Column(Order = 0)]
        public int StopPalletID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StopNumberID { get; set; }

        public short? PalletsOn { get; set; }

        public short? PalletsOff { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ActualArrivalDate { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? ActualDepartDate { get; set; }
    }
}
