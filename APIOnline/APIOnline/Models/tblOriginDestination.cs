namespace APIOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblOriginDestination")]
    public partial class tblOriginDestination
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CusId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int No { get; set; }

        [StringLength(500)]
        public string Origin { get; set; }

        [StringLength(500)]
        public string Destination { get; set; }

        [StringLength(50)]
        public string EmId { get; set; }

        [StringLength(50)]
        public string AddPerson { get; set; }

        [StringLength(50)]
        public string Department { get; set; }
    }
}
