namespace APIOnline.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Job")]
    public partial class Job
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int JobID { get; set; }

        public DateTime? JobDate { get; set; }

        [StringLength(700)]
        public string CustFname { get; set; }

        [StringLength(100)]
        public string CustLname { get; set; }

        [StringLength(50)]
        public string JobType { get; set; }

        public double? JobCuft { get; set; }

        [Required]
        [StringLength(500)]
        public string TruckTrip { get; set; }

        public double? Trip { get; set; }

        public int? EmID { get; set; }

        [StringLength(500)]
        public string JobStatus { get; set; }

        [StringLength(1000)]
        public string Location { get; set; }

        [StringLength(500)]
        public string Remark { get; set; }

        [StringLength(50)]
        public string Sale { get; set; }

        [StringLength(1000)]
        public string Origin { get; set; }

        [StringLength(500)]
        public string Tel { get; set; }

        public int? StatusCon { get; set; }

        [StringLength(50)]
        public string JobRefNo { get; set; }

        [StringLength(50)]
        public string ConId { get; set; }

        [StringLength(50)]
        public string VUnit { get; set; }

        public double? TT1 { get; set; }

        public double? TT2 { get; set; }

        public double? TT3 { get; set; }

        public double? TT4 { get; set; }

        public double? TT5 { get; set; }

        public double? TEAM { get; set; }

        [StringLength(50)]
        public string TEAMCO { get; set; }

        public DateTime? CRTIME { get; set; }

        [StringLength(50)]
        public string CRNAME { get; set; }

        [StringLength(500)]
        public string TEAMNAME { get; set; }

        [StringLength(50)]
        public string Book1 { get; set; }

        [StringLength(50)]
        public string Department1 { get; set; }

        [StringLength(200)]
        public string Direction1 { get; set; }

        [StringLength(50)]
        public string Book2 { get; set; }

        [StringLength(50)]
        public string Department2 { get; set; }

        [StringLength(200)]
        public string Direction2 { get; set; }

        [StringLength(50)]
        public string Book3 { get; set; }

        [StringLength(50)]
        public string Department3 { get; set; }

        [StringLength(200)]
        public string Direction3 { get; set; }

        [StringLength(50)]
        public string TeamUnit { get; set; }

        [StringLength(50)]
        public string InqId { get; set; }

        [StringLength(50)]
        public string AppointTime { get; set; }

        [StringLength(50)]
        public string ComId { get; set; }

        [StringLength(50)]
        public string CusId { get; set; }

        [StringLength(50)]
        public string SJobRefNo { get; set; }

        [StringLength(50)]
        public string SConId { get; set; }

        [StringLength(100)]
        public string CusPhone { get; set; }
    }
}
