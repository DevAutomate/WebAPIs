namespace APIOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblPS")]
    public partial class tblP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CusID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string PSRefNo { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PSubID { get; set; }

        [StringLength(50)]
        public string Plot { get; set; }

        public DateTime? Isudt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? MoveDate { get; set; }

        [StringLength(1)]
        public string PSId { get; set; }

        public int? ProjectID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ExPDate { get; set; }
    }
}
