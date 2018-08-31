namespace APIOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblCusBilling")]
    public partial class tblCusBilling
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CusId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CustomerId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CusCode { get; set; }

        [StringLength(300)]
        public string Name { get; set; }

        [StringLength(300)]
        public string ADDR1 { get; set; }

        [StringLength(300)]
        public string ADDR2 { get; set; }

        [StringLength(300)]
        public string ADDR3 { get; set; }

        [StringLength(100)]
        public string TEL { get; set; }

        [StringLength(100)]
        public string ACCOUNT { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? LAST { get; set; }

        [StringLength(200)]
        public string EmailTo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OUTSTND { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? MTD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? YTD { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TERM { get; set; }

        [StringLength(50)]
        public string ACCT { get; set; }

        [StringLength(300)]
        public string ATTN { get; set; }

        public bool? INVOICING { get; set; }

        public bool? WHTax { get; set; }

        [StringLength(50)]
        public string EmId { get; set; }

        [StringLength(50)]
        public string AddPerson { get; set; }

        [StringLength(50)]
        public string Department { get; set; }
    }
}
