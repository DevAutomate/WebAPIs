using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIOnline.Data
{
    public class tblCustomer
        {
            public string CusId { get; set; }
            public string CustomerType { get; set; }
            public string CusUTitle { get; set; }
            public string CusUFName { get; set; }
            public string CusULName { get; set; }
            public string CusUAddress { get; set; }
            public string CusUPhone { get; set; }
            public string CusUPhoneM { get; set; }
            public string CusUFax { get; set; }
            public string CusUEmail { get; set; }
            public string CusNote { get; set; }
            public string EmId { get; set; }
            public string AddPerson { get; set; }
            public string Department { get; set; }
            public string SaleName { get; set; }
            public Nullable<bool> Careof { get; set; }
            public string CareofName { get; set; }
            public string ServiceType { get; set; }
            public string EmailState { get; set; }
            public string Status { get; set; }
            public Nullable<System.DateTime> CustomerDate { get; set; }
            public Nullable<System.TimeSpan> CustomerTime { get; set; }
        }

        public class tblCusContact
        {
            public string CusId { get; set; }
            public string ContactId { get; set; }
            public string ContactName { get; set; }
            public string ContactPhoneH { get; set; }
            public string ContactPhoneO { get; set; }
            public string ContactPhoneM { get; set; }
            public string ContactFax { get; set; }
            public string ContactEmail { get; set; }
            public string EmId { get; set; }
            public string AddPerson { get; set; }
            public string Department { get; set; }
            public string CompanyofContact { get; set; }
        }

        public class tblCusBilling
        {
            public string CusId { get; set; }
            public Nullable<int> CustomerId { get; set; }
            public string CusCode { get; set; }
            public string Name { get; set; }
            public string ADDR1 { get; set; }
            public string ADDR2 { get; set; }
            public string ADDR3 { get; set; }
            public string TEL { get; set; }
            public string ACCOUNT { get; set; }
            public Nullable<System.DateTime> LAST { get; set; }
            public string EmailTo { get; set; }
            public Nullable<decimal> OUTSTND { get; set; }
            public Nullable<decimal> MTD { get; set; }
            public Nullable<decimal> YTD { get; set; }
            public Nullable<decimal> TERM { get; set; }
            public string ACCT { get; set; }
            public string ATTN { get; set; }
            public Nullable<bool> INVOICING { get; set; }
            public Nullable<bool> WHTax { get; set; }
            public string EmId { get; set; }
            public string AddPerson { get; set; }
            public string Department { get; set; }
        }

        public class tblOriginDestination
        {
            public string CusId { get; set; }
            public int No { get; set; }
            public string Origin { get; set; }
            public string Destination { get; set; }
            public string EmId { get; set; }
            public string AddPerson { get; set; }
            public string Department { get; set; }
        }

        public class tblPS
        {
            public string CusID { get; set; }
            public string PSRefNo { get; set; }
            public int PSubID { get; set; }
            public string Plot { get; set; }
            public Nullable<System.DateTime> Isudt { get; set; }
            public Nullable<System.DateTime> MoveDate { get; set; }
            public string PSId { get; set; }
            public Nullable<int> ProjectID { get; set; }
            public Nullable<System.DateTime> ExPDate { get; set; }
        }

    }
