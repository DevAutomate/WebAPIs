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
    [RoutePrefix("api/SPUser")]
    public class SPUserController : ApiController
    {

        // GET api/SPUser/geta?username&password
        [Route("geta")]
        public int GetCheckLogin(string username, string password)
        {
            SPUserDA SPD = new SPUserDA();
            int Check = SPD.GetCheckLogin(username, password);
            return Check;

        }

        // GET api/SPUser/getb?username&password
        [Route("getb")]
        public string GetUser(string username, string password)
        {
            SPUserDA SPD = new SPUserDA();
            DataSet ds = new DataSet();
            ds = SPD.GetUser(username, password);
            string json = JsonConvert.SerializeObject(ds);
            return json;
        }

        // POST api/SPUser?JsonEmployee
        public void Post([FromBody]Employee e)
        {
            SPUserDA SPD = new SPUserDA();
            SPD.PostEmployee(e);
        }

        // PUT api/SPUser?EmID&JsonEmployee
        public void Put(string EmID, [FromBody]Employee e)
        {
            SPUserDA SPD = new SPUserDA();
            SPD.PutEmployee(EmID, e);
        }


        // DELETE api/SPUser?EmID
        public void Delete(string EmID)
        {
            SPUserDA SPD = new SPUserDA();
            SPD.DeleteUser(EmID);
        }





    }
}
