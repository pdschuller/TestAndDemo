namespace UseStubbedData.StubData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    // using System.Data.Entity.Spatial;
    
    [Serializable]
    public partial class StubEmployee
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Employee()
        //{
        //    Employee_Department = new HashSet<Employee_Department>();
        //    Employee_Productivity = new HashSet<Employee_Productivity>();
        //    RunResources = new HashSet<RunResource>();
        //    RunResources1 = new HashSet<RunResource>();
        //    WorkAssignments = new HashSet<WorkAssignment>();
        //}
        //}

        [Column(TypeName = "numeric")]
        public decimal EmployeeID { get; set; }

        [StringLength(10)]
        public string SurName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string SuffixName { get; set; }

        public bool? LisActive { get; set; }

        public DateTime? HireDate { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Ref1 { get; set; }

        [StringLength(50)]
        public string Ref2 { get; set; }

        public bool? Active { get; set; }

        [StringLength(50)]
        public string Ref3 { get; set; }

     
    }
}
