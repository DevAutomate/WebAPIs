namespace APIOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmID { get; set; }

        [StringLength(50)]
        public string EmFname { get; set; }

        [StringLength(50)]
        public string EmLname { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public bool? admin { get; set; }

        public bool? addJob { get; set; }

        public bool? EditJob { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(50)]
        public string SaleName { get; set; }

        public bool? CHK { get; set; }

        [StringLength(5)]
        public string DepID { get; set; }

        [StringLength(1)]
        public string stat { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
