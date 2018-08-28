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
    [RoutePrefix("api/CRMCusBilling")]
    public class CRMCusBillingController : ApiController
    {
        // GET api/CRMCusBilling?CusId
        [Route("getid")]
        public string GetCustomerId(string CusId)
        {
            CRMCusBillingDA SPD = new CRMCusBillingDA();
            DataSet ds = new DataSet();
            ds = SPD.GetCusBillingId(CusId);
            string json = JsonConvert.SerializeObject(ds);
            return json;
        }

        // GET api/CRMCusBilling?CusName
        [Route("getname")]
        public string GetCustomerName(string CusName)
        {
            CRMCusBillingDA SPD = new CRMCusBillingDA();
            DataSet ds = new DataSet();
            ds = SPD.GetCusBillingName(CusName);
            string json = JsonConvert.SerializeObject(ds);
            return json;
        }

        // POST api/CRMCusBilling?tblCusBilling
        public void Post([FromBody]tblCusBilling cb)
        {
            CRMCusBillingDA SPD = new CRMCusBillingDA();
            SPD.PostCusBilling(cb);
        }

        // PUT api/CRMCusBilling?tblBilling
        public void Put(string CusId, [FromBody]tblCusBilling cb)
        {
            CRMCusBillingDA SPD = new CRMCusBillingDA();
            SPD.PutCusBilling(CusId, cb);
        }


        // DELETE api//CRMCusBilling?CusId
        public void Delete(string CusId)
        {
            CRMCusBillingDA SPD = new CRMCusBillingDA();
            SPD.DeleteCusBilling(CusId);
        }
    }
}