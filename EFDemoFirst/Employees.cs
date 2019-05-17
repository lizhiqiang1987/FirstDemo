namespace EFDemoFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        [Key]
        public int EmpId { get; set; }

        [Required]
        [StringLength(50)]
        public string EmpName { get; set; }

        [StringLength(2)]
        public string EmpGender { get; set; }

        public int? EmpAge { get; set; }

        [StringLength(50)]
        public string EmpEmail { get; set; }

        public int? EmpDepId { get; set; }

        [StringLength(100)]
        public string EmpAddr { get; set; }

        public virtual Department Department { get; set; }
    }
}
