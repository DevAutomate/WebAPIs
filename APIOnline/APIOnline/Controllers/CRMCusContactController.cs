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
    [RoutePrefix("api/CRMCusContact")]
    public class CRMCusContactController : ApiController
    {
        // GET api/CRMCusContact?CusId
        [Route("getid")]
        public string GetCusContactAll(string CusId)
        {
            string json;
            using (var ctx = new CRMModel())
            {
                var CusConList = ctx.tblCusContacts.Where(ci => ci.CusId == CusId).ToList();
                json = JsonConvert.SerializeObject(CusConList);
            }
            return json;
        }

        // GET api/CRMCusContact?CusId&CusContact
        [Route("getidno")]
        public string GetCusContact(string CusId, string ContactId)
        {
            string json;
            using (var ctx = new CRMModel())
            {
                var CusConList = ctx.tblCusContacts.Where(ci => ci.CusId == CusId && ci.ContactId == ContactId).ToList();
                json = JsonConvert.SerializeObject(CusConList);
            }
            return json;
        }

        // GET api/CRMCusContact?CusId&ContactName
        [Route("getidname")]
        public string GetCusContactName(string CusId, string ContactName)
        {
            string json;
            using (var ctx = new CRMModel())
            {
                var CusConList = ctx.tblCusContacts.Where(ci => ci.CusId == CusId && ci.ContactName == ContactName).ToList();
                json = JsonConvert.SerializeObject(CusConList);
            }
            return json;
        }


        // POST api/CRMCusContact?tblCuscontact
        public void Post([FromBody]tblCusContact cc)
        {
            using (var ctx = new CRMModel())
            {
                var cuscon = ctx.Set<tblCusContact>();
                cuscon.Add(new tblCusContact
                {
                    CusId = cc.CusId,
                    ContactId = cc.ContactId,
                    ContactName = cc.ContactName,
                    ContactPhoneH = cc.ContactPhoneH,
                    ContactPhoneO = cc.ContactPhoneO,
                    ContactPhoneM = cc.ContactPhoneM,
                    ContactFax = cc.ContactFax,
                    ContactEmail = cc.ContactEmail,
                    EmId = cc.EmId,
                    AddPerson = cc.AddPerson,
                    Department = cc.Department
                });

                ctx.SaveChanges();
            }
        }

        // PUT api/CRMCusContact?CusId,ContactId,tblCuscontact
        public void Put(string CusId, string ContactId, [FromBody]tblCusContact cc)
        {
            using (var ctx = new CRMModel())
            {

                // Update Statement
                var update = ctx.tblCusContacts.Where(ci => ci.CusId == CusId).FirstOrDefault();
                if (update != null)
                {
                    update.CusId = cc.CusId;
                    update.ContactId = cc.ContactId;
                    update.ContactName = cc.ContactName;
                    update.ContactPhoneH = cc.ContactPhoneH;
                    update.ContactPhoneO = cc.ContactPhoneO;
                    update.ContactPhoneM = cc.ContactPhoneM;
                    update.ContactFax = cc.ContactFax;
                    update.ContactEmail = cc.ContactEmail;
                    update.EmId = cc.EmId;
                    update.AddPerson = cc.AddPerson;
                    update.Department = cc.Department;
                }

                ctx.SaveChanges();
            }
        }


        // DELETE api/CRMCusContact?CusId&ContactId
        public void Delete(string CusId, string ContactId)
        {
            using (var ctx = new CRMModel())
            {
                var del = ctx.tblCusContacts.Where(ci => ci.CusId == CusId && ci.ContactId == ContactId).FirstOrDefault();
                if (del != null)
                {
                    ctx.tblCusContacts.Remove(del);
                }
            }
        }
    }
}