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
    [RoutePrefix("api/CRMCustomer")]
    public class CRMCustomerController : ApiController
    {
        // GET api/CRMCustomer?CusId
        [Route("getid")]
        public string GetCustomerId(string CusId)
        {
            CRMCustomerDA SPD = new CRMCustomerDA();
            DataSet ds = new DataSet();
            ds = SPD.GetCustomerId(CusId);
            string json = JsonConvert.SerializeObject(ds);
            return json;
        }

        // GET api/CRMCustomer?CusId
        [Route("getname")]
        public string GetCustomerName(string CusName)
        {
            CRMCustomerDA SPD = new CRMCustomerDA();
            DataSet ds = new DataSet();
            ds = SPD.GetCustomerName(CusName);
            string json = JsonConvert.SerializeObject(ds);
            return json;
        }

        // POST api/CRMCustomer?tblCustomer
        public void Post([FromBody]tblCustomer c)
        {
            CRMCustomerDA SPD = new CRMCustomerDA();
            SPD.PostCustomer(c);
        }

        // PUT api/CRMCustomer?tblCustomer
        public void Put(string EmID, [FromBody]tblCustomer c)
        {
            CRMCustomerDA SPD = new CRMCustomerDA();
            SPD.PutCustomer(EmID, c);
        }


        // DELETE api//CRMCustomer?CusId
        public void Delete(string CusId)
        {
            CRMCustomerDA SPD = new CRMCustomerDA();
            SPD.DeleteCustomer(CusId);
        }
    }
}