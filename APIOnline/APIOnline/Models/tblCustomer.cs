namespace APIOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCustomer")]
    public partial class tblCustomer
    {
        [Key]
        [StringLength(50)]
        public string CusId { get; set; }

        [StringLength(50)]
        public string CustomerType { get; set; }

        [StringLength(50)]
        public string CusUTitle { get; set; }

        [StringLength(250)]
        public string CusUFName { get; set; }

        [StringLength(50)]
        public string CusULName { get; set; }

        [StringLength(500)]
        public string CusUAddress { get; set; }

        [StringLength(50)]
        public string CusUPhone { get; set; }

        [StringLength(50)]
        public string CusUPhoneM { get; set; }

        [StringLength(50)]
        public string CusUFax { get; set; }

        [StringLength(50)]
        public string CusUEmail { get; set; }

        [StringLength(500)]
        public string CusNote { get; set; }

        [StringLength(50)]
        public string EmId { get; set; }

        [StringLength(50)]
        public string AddPerson { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(50)]
        public string SaleName { get; set; }

        public bool? Careof { get; set; }

        [StringLength(200)]
        public string CareofName { get; set; }

        [StringLength(50)]
        public string ServiceType { get; set; }

        [StringLength(50)]
        public string EmailState { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime? CustomerDate { get; set; }

        public TimeSpan? CustomerTime { get; set; }
    }
}
