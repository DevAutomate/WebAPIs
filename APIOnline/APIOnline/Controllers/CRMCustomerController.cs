using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using Newtonsoft.Json;
using APIOnline.Models;

namespace APIOnline.Controllers
{
    [RoutePrefix("api/CRMCustomer")]
    public class CRMCustomerController : ApiController
    {
        // GET api/CRMCustomer?CusId
        [Route("getid")]
        public string GetCustomerId(string CusId)
        {
            string json;
            using (var ctx = new CRMModel())
            {
                var CustomerList = ctx.tblCustomers.Where(ci => ci.CusId == CusId).ToList();
                json = JsonConvert.SerializeObject(CustomerList);
            }
            return json;
        }

        // GET api/CRMCustomer?CusId
        [Route("getname")]
        public string GetCustomerName(string CusName)
        {
            string json;
            using (var ctx = new CRMModel())
            {
                var CustomerList = ctx.tblCustomers.Where(cn => cn.CusUFName == CusName).ToList();
                json = JsonConvert.SerializeObject(CustomerList);
            }
            return json;
        }

        // POST api/CRMCustomer?tblCustomer
        public void Post([FromBody]tblCustomer c)
        {
            using (var ctx = new CRMModel())
            {
                var customer = ctx.Set<tblCustomer>();
                customer.Add(new tblCustomer
                {
                    CusId = c.CusId,
                    CustomerType = c.CustomerType,
                    CusUTitle = c.CusUTitle,
                    CusUFName = c.CusUFName,
                    CusULName = c.CusULName,
                    CusUAddress = c.CusUAddress,
                    CusUPhone = c.CusUPhone,
                    CusUPhoneM = c.CusUPhoneM,
                    CusUFax = c.CusUFax,
                    CusUEmail = c.CusUEmail,
                    CusNote = c.CusNote,
                    EmId = c.EmId,
                    AddPerson = c.AddPerson,
                    Department = c.Department,
                    SaleName = c.SaleName,
                    Careof = c.Careof,
                    CareofName = c.CareofName,
                    ServiceType = c.ServiceType,
                    EmailState = c.EmailState,
                    Status = c.Status,
                    CustomerDate = c.CustomerDate,
                    CustomerTime = c.CustomerTime
                });

                ctx.SaveChanges();
            }
        }

        // PUT api/CRMCustomer?tblCustomer
        public void Put(string CusId, [FromBody]tblCustomer c)
        {
            using (var ctx = new CRMModel())
            {

                // Update Statement
                var update = ctx.tblCustomers.Where(ci => ci.CusId == CusId).FirstOrDefault();
                if (update != null)
                {
                    update.CusId = c.CusId;
                    update.CustomerType = c.CustomerType;
                    update.CusUTitle = c.CusUTitle;
                    update.CusUFName = c.CusUFName;
                    update.CusULName = c.CusULName;
                    update.CusUAddress = c.CusUAddress;
                    update.CusUPhone = c.CusUPhone;
                    update.CusUPhoneM = c.CusUPhoneM;
                    update.CusUFax = c.CusUFax;
                    update.CusUEmail = c.CusUEmail;
                    update.CusNote = c.CusNote;
                    update.EmId = c.EmId;
                    update.AddPerson = c.AddPerson;
                    update.Department = c.Department;
                    update.SaleName = c.SaleName;
                    update.Careof = c.Careof;
                    update.CareofName = c.CareofName;
                    update.ServiceType = c.ServiceType;
                    update.EmailState = c.EmailState;
                    update.Status = c.Status;
                    update.CustomerDate = c.CustomerDate;
                    update.CustomerTime = c.CustomerTime;
                }

                ctx.SaveChanges();
            }
        }


        // DELETE api//CRMCustomer?CusId
        public void Delete(string CusId)
        {
            using (var ctx = new CRMModel())
            {
                var del = ctx.tblCustomers.Where(ci => (ci.CusId == CusId)).FirstOrDefault();
                if (del != null)
                {
                    ctx.tblCustomers.Remove(del);
                }
            }
        }
    }
}