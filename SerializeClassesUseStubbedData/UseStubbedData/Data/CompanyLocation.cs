namespace UseStubbedData.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyLocation")]
    public partial class CompanyLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyLocation()
        {
            CompanyCarriers = new HashSet<CompanyCarrier>();
            CompanyContactInfoes = new HashSet<CompanyContactInfo>();
            CompanyLocationAppointments = new HashSet<CompanyLocationAppointment>();
            CompanyOpenWindows = new HashSet<CompanyOpenWindow>();
            CompanyShippers = new HashSet<CompanyShipper>();
            CompanyStandards = new HashSet<CompanyStandard>();
            Orders = new HashSet<Order>();
            Orders1 = new HashSet<Order>();
            Orders2 = new HashSet<Order>();
            ProformaRunStops = new HashSet<ProformaRunStop>();
            RunStops = new HashSet<RunStop>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal CompanyLocationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal CompanyID { get; set; }

        [Required]
        [StringLength(10)]
        public string Type { get; set; }

        [Required]
        [StringLength(10)]
        public string Type1 { get; set; }

        [StringLength(10)]
        public string AlternateName { get; set; }

        [StringLength(25)]
        public string Street1 { get; set; }

        [StringLength(25)]
        public string Street2 { get; set; }

        [StringLength(25)]
        public string Street3 { get; set; }

        [StringLength(15)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(10)]
        public string PostalCode { get; set; }

        [StringLength(10)]
        public string Appointment { get; set; }

        [StringLength(2000)]
        public string Notes { get; set; }

        [StringLength(30)]
        public string PhoneNumber { get; set; }

        public bool? PO_Fax { get; set; }

        [StringLength(30)]
        public string FaxNumber { get; set; }

        [StringLength(2000)]
        public string SpecialInstructions { get; set; }

        [StringLength(3000)]
        public string Directions { get; set; }

        public bool? Require_Audit { get; set; }

        public bool? PrintDirections { get; set; }

        public bool? PrintNotes { get; set; }

        [StringLength(5)]
        public string PMCustNo { get; set; }

        [StringLength(1)]
        public string Lane { get; set; }

        public virtual Company Company { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyCarrier> CompanyCarriers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyContactInfo> CompanyContactInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyLocationAppointment> CompanyLocationAppointments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyOpenWindow> CompanyOpenWindows { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyShipper> CompanyShippers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CompanyStandard> CompanyStandards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProformaRunStop> ProformaRunStops { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RunStop> RunStops { get; set; }
    }
}
