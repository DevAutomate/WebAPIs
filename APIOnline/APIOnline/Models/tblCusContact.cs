namespace APIOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCusContact")]
    public partial class tblCusContact
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CusId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ContactId { get; set; }

        [StringLength(100)]
        public string ContactName { get; set; }

        [StringLength(50)]
        public string ContactPhoneH { get; set; }

        [StringLength(50)]
        public string ContactPhoneO { get; set; }

        [StringLength(50)]
        public string ContactPhoneM { get; set; }

        [StringLength(50)]
        public string ContactFax { get; set; }

        [StringLength(100)]
        public string ContactEmail { get; set; }

        [StringLength(50)]
        public string EmId { get; set; }

        [StringLength(50)]
        public string AddPerson { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(300)]
        public string CompanyofContact { get; set; }
    }
}
