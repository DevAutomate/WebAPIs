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
    public class CRMPsController : ApiController
    {
        // GET api/CRMPs?CusId
        public string GetPs(string CusId)
        {
            CRMPsDA SPD = new CRMPsDA();
            DataSet ds = new DataSet();
            ds = SPD.GetPs(CusId);
            string json = JsonConvert.SerializeObject(ds);
            return json;
        }

        // POST api/CRMPs?tblPS
        public void Post([FromBody]tblPS PS)
        {
            CRMPsDA SPD = new CRMPsDA();
            SPD.PostPs(PS);
        }

        // PUT api/CRMPs?CusId,tblPS
        public void Put(String CusId, [FromBody]tblPS PS)
        {
            CRMPsDA SPD = new CRMPsDA();
            SPD.PutPs(CusId, PS);
        }


        // DELETE api/CRMPs?CusId
        public void Delete(string CusId)
        {
            CRMPsDA SPD = new CRMPsDA();
            SPD.DeletePs(CusId);
        }
    }
}