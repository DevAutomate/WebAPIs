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
    public class CRMOriginDestinationController : ApiController
    {
        // GET api/CRMOriginDestination?CusId
        public string GetOriginDestination(string CusId)
        {
            CRMOriginDestinationDA SPD = new CRMOriginDestinationDA();
            DataSet ds = new DataSet();
            ds = SPD.GetOriginDestination(CusId);
            string json = JsonConvert.SerializeObject(ds);
            return json;
        }

        // POST api/CRMOriginDestination?tblOriginDestination
        public void Post([FromBody]tblOriginDestination od)
        {
            CRMOriginDestinationDA SPD = new CRMOriginDestinationDA();
            SPD.PostOriginDestination(od);
        }

        // PUT api/CRMOriginDestination?CusId,No,tblOrigindestination
        public void Put(String CusId, int No, [FromBody]tblOriginDestination od)
        {
            CRMOriginDestinationDA SPD = new CRMOriginDestinationDA();
            SPD.PutOriginDestination(CusId, No, od);
        }


        // DELETE api/CRMOriginDestination?CusId&No
        public void Delete(string CusId, int No)
        {
            CRMOriginDestinationDA SPD = new CRMOriginDestinationDA();
            SPD.DeleteOriginDestination(CusId, No);
        }
    }
}