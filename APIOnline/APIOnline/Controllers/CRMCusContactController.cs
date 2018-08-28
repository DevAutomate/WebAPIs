using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using APIOnline.Data;
using APIOnline.DataAccess;
using Newtonsoft.Json;

namespace APIOnline.Controllers
{
    [RoutePrefix("api/CRMCusContact")]
    public class CRMCusContactController : ApiController
    {
        // GET api/CRMCusContact?CusId
        [Route("getid")]
        public string GetCusContactAll(string CusId)
        {
            CRMCusContactDA SPD = new CRMCusContactDA();
            DataSet ds = new DataSet();
            ds = SPD.GetCusContactAll(CusId);
            string json = JsonConvert.SerializeObject(ds);
            return json;
        }

        // GET api/CRMCusContact?CusId&CusContact
        [Route("getidno")]
        public string GetCusContact(string CusId, string CusContact)
        {
            CRMCusContactDA SPD = new CRMCusContactDA();
            DataSet ds = new DataSet();
            ds = SPD.GetCusContact(CusId,CusContact);
            string json = JsonConvert.SerializeObject(ds);
            return json;
        }

        // GET api/CRMCusContact?CusId&ContactName
        [Route("getidname")]
        public string GetCusContactName(string CusId, string ContactName)
        {
            CRMCusContactDA SPD = new CRMCusContactDA();
            DataSet ds = new DataSet();
            ds = SPD.GetCusContactName(CusId, ContactName);
            string json = JsonConvert.SerializeObject(ds);
            return json;
        }


        // POST api/CRMCusContact?tblCuscontact
        public void Post([FromBody]tblCusContact cc)
        {
            CRMCusContactDA SPD = new CRMCusContactDA();
            SPD.PostCusContact(cc);
        }

        // PUT api/CRMCusContact?CusId,ContactId,tblCuscontact
        public void Put(string CusId, string ContactId, [FromBody]tblCusContact cc)
        {
            CRMCusContactDA SPD = new CRMCusContactDA();
            SPD.PutCusContact(CusId, ContactId, cc);
        }


        // DELETE api/CRMCusContact?CusId&ContactId
        public void Delete(string CusId, string ContactId)
        {
            CRMCusContactDA SPD = new CRMCusContactDA();
            SPD.DeleteCusContact(CusId,ContactId);
        }
    }
}