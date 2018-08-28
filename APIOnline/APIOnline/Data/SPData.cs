using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIOnline.Data
{
    public class Job
    {
        public int JobID { get; set; }
        public Nullable<System.DateTime> JobDate { get; set; }
        public string CustFname { get; set; }
        public string CustLname { get; set; }
        public string JobType { get; set; }
        public Nullable<double> JobCuft { get; set; }
        public string TruckTrip { get; set; }
        public Nullable<double> Trip { get; set; }
        public Nullable<int> EmID { get; set; }
        public string JobStatus { get; set; }
        public string Location { get; set; }
        public string Remark { get; set; }
        public string Sale { get; set; }
        public string Origin { get; set; }
        public string Tel { get; set; }
        public Nullable<int> StatusCon { get; set; }
        public string JobRefNo { get; set; }
        public string ConId { get; set; }
        public string VUnit { get; set; }
        public Nullable<double> TT1 { get; set; }
        public Nullable<double> TT2 { get; set; }
        public Nullable<double> TT3 { get; set; }
        public Nullable<double> TT4 { get; set; }
        public Nullable<double> TT5 { get; set; }
        public Nullable<double> TEAM { get; set; }
        public string TEAMCO { get; set; }
        public Nullable<System.DateTime> CRTIME { get; set; }
        public string CRNAME { get; set; }
        public string TEAMNAME { get; set; }
        public string Book1 { get; set; }
        public string Department1 { get; set; }
        public string Direction1 { get; set; }
        public string Book2 { get; set; }
        public string Department2 { get; set; }
        public string Direction2 { get; set; }
        public string Book3 { get; set; }
        public string Department3 { get; set; }
        public string Direction3 { get; set; }
        public string TeamUnit { get; set; }
        public string InqId { get; set; }
        public string AppointTime { get; set; }
        public string ComId { get; set; }
        public string CusId { get; set; }
        public string SJobRefNo { get; set; }
        public string SConId { get; set; }
        public string CusPhone { get; set; }
    }


    public class JobView
        {
            public int JobID { get; set; }
            public Nullable<System.DateTime> JobDate { get; set; }
            public string CustFname { get; set; }
            public string CustLname { get; set; }
            public string JobType { get; set; }
            public Nullable<double> JobCuft { get; set; }
            public string TruckTrip { get; set; }
            public Nullable<double> Trip { get; set; }
            public Nullable<int> EmID { get; set; }
            public string JobStatus { get; set; }
            public string Location { get; set; }
            public string Remark { get; set; }
            public string Sale { get; set; }
            public string Origin { get; set; }
            public string Tel { get; set; }
            public Nullable<int> StatusCon { get; set; }
            public string JobRefNo { get; set; }
            public string ConId { get; set; }
            public string VUnit { get; set; }
            public string EmFname { get; set; }
            public Nullable<double> TT1 { get; set; }
            public Nullable<double> TT2 { get; set; }
            public Nullable<double> TT3 { get; set; }
            public Nullable<double> TT4 { get; set; }
            public Nullable<double> TT5 { get; set; }
            public Nullable<double> TEAM { get; set; }
            public string Department { get; set; }
            public Nullable<System.DateTime> CRTIME { get; set; }
            public string CRNAME { get; set; }
            public string TEAMCO { get; set; }
            public string TEAMNAME { get; set; }
            public string Book1 { get; set; }
            public string Department1 { get; set; }
            public string Direction1 { get; set; }
            public string Book2 { get; set; }
            public string Department2 { get; set; }
            public string Direction2 { get; set; }
            public string Book3 { get; set; }
            public string Department3 { get; set; }
            public string Direction3 { get; set; }
            public string TeamUnit { get; set; }
            public string InqId { get; set; }
            public string AppointTime { get; set; }
            public string ComId { get; set; }
            public string CusId { get; set; }
            public string SJobRefNo { get; set; }
            public string SConId { get; set; }
            public string CusPhone { get; set; }
        }
        public class Employee
        {
            public int EmID { get; set; }
            public string EmFname { get; set; }
            public string EmLname { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
            public Nullable<bool> admin { get; set; }
            public Nullable<bool> addJob { get; set; }
            public Nullable<bool> EditJob { get; set; }
            public string Department { get; set; }
            public string SaleName { get; set; }
            public Nullable<bool> CHK { get; set; }
            public string DepID { get; set; }
            public string stat { get; set; }
            public string Email { get; set; }
        }
    }
