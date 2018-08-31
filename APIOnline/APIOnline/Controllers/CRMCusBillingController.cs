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
    [RoutePrefix("api/CRMCusBilling")]
    public class CRMCusBillingController : ApiController
    {
        // GET api/CRMCusBilling?CusId
        [Route("getid")]
        public string GetCustomerId(string CusId)
        {
            string json;
            using (var ctx = new CRMModel())
            {
                var CusBilList = ctx.tblCustomers.Where(ci => ci.CusId == CusId).ToList();
                json = JsonConvert.SerializeObject(CusBilList);
            }
            return json;
        }

        // GET api/CRMCusBilling?CusName
        [Route("getname")]
        public string GetCustomerName(string CusName)
        {
            string json;
            using (var ctx = new CRMModel())
            {
                var CusBilList = ctx.tblCustomers.Where(cn => cn.CusUFName == CusName).ToList();
                json = JsonConvert.SerializeObject(CusBilList);
            }
            return json;
        }

        // POST api/CRMCusBilling?tblCusBilling
        public void Post([FromBody]tblCusBilling cb)
        {
            using (var ctx = new CRMModel())
            {
                var cusbill = ctx.Set<tblCusBilling>();
                cusbill.Add(new tblCusBilling
                {
                    CusId = cb.CusId,
                    CustomerId = cb.CustomerId,
                    CusCode = cb.CusCode,
                    Name = cb.Name,
                    ADDR1 = cb.ADDR1,
                    ADDR2 = cb.ADDR2,
                    ADDR3 = cb.ADDR3,
                    TEL = cb.TEL,
                    ACCOUNT = cb.ACCOUNT,
                    LAST = cb.LAST,
                    EmailTo = cb.EmailTo,
                    OUTSTND = cb.OUTSTND,
                    MTD = cb.MTD,
                    YTD = cb.YTD,
                    TERM = cb.TERM,
                    ACCT = cb.ACCT,
                    ATTN = cb.ATTN,
                    INVOICING = cb.INVOICING,
                    WHTax = cb.WHTax,
                    EmId = cb.EmId,
                    AddPerson = cb.AddPerson,
                    Department = cb.Department
                });

                ctx.SaveChanges();
            }
        }

        // PUT api/CRMCusBilling?tblBilling
        public void Put(string CusId, [FromBody]tblCusBilling cb)
        {
            using (var ctx = new CRMModel())
            {

                // Update Statement
                var update = ctx.tblCusBillings.Where(ci => ci.CusId == CusId).FirstOrDefault();
                if (update != null)
                {
                    update.CusId = cb.CusId;
                    update.CustomerId = cb.CustomerId;
                    update.CusCode = cb.CusCode;
                    update.Name = cb.Name;
                    update.ADDR1 = cb.ADDR1;
                    update.ADDR2 = cb.ADDR2;
                    update.ADDR3 = cb.ADDR3;
                    update.TEL = cb.TEL;
                    update.ACCOUNT = cb.ACCOUNT;
                    update.LAST = cb.LAST;
                    update.EmailTo = cb.EmailTo;
                    update.OUTSTND = cb.OUTSTND;
                    update.MTD = cb.MTD;
                    update.YTD = cb.YTD;
                    update.TERM = cb.TERM;
                    update.ACCT = cb.ACCT;
                    update.ATTN = cb.ATTN;
                    update.INVOICING = cb.INVOICING;
                    update.WHTax = cb.WHTax;
                    update.EmId = cb.EmId;
                    update.AddPerson = cb.AddPerson;
                    update.Department = cb.Department;
                }

                ctx.SaveChanges();
            }
        }


        // DELETE api//CRMCusBilling?CusId
        public void Delete(string CusId)
        {
            using (var ctx = new CRMModel())
            {
                var del = ctx.tblCusBillings.Where(ci => (ci.CusId == CusId)).FirstOrDefault();
                if (del != null)
                {
                    ctx.tblCusBillings.Remove(del);
                }
            }
        }
    }
}