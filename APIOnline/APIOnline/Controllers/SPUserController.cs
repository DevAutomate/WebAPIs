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
    [RoutePrefix("api/SPUser")]
    public class SPUserController : ApiController
    {

        // GET api/SPUser/geta?username&password
        [Route("geta")]
        public int GetCheckLogin(string username, string password)
        {
            int count;
            using (var ctx = new SPModel())
            {
                var UserList = ctx.Employees.Where(np => np.UserName == username && np.Password == password).ToList();
                if (UserList != null)
                {
                    count = 1;
                } else
                {
                    count = 0;
                }
            }
            return count;

        }

        // GET api/SPUser/getb?username&password
        [Route("getb")]
        public string GetUser(string username, string password)
        {
            string json;
            using (var ctx = new SPModel())
            {
                var UserList = ctx.Employees.Where(np => np.UserName == username && np.Password == password).ToList();
                json = JsonConvert.SerializeObject(UserList);
            }
            return json;
        }

        // POST api/SPUser?JsonEmployee
        public void Post([FromBody]Employee e)
        {
            using (var ctx = new SPModel())
            {
                var employee = ctx.Set<Employee>();
                employee.Add(new Employee
                {
                    EmID = e.EmID,
                    EmFname = e.EmFname,
                    EmLname = e.EmLname,
                    UserName = e.UserName,
                    Password = e.Password,
                    admin = e.admin,
                    addJob = e.addJob,
                    EditJob = e.EditJob,
                    Department = e.Department,
                    SaleName = e.SaleName,
                    CHK = e.CHK,
                    DepID = e.DepID,
                    stat = e.stat,
                    Email = e.Email
                });

                ctx.SaveChanges();
            }
        }

        // PUT api/SPUser?EmID&JsonEmployee
        public void Put(int EmID, [FromBody]Employee e)
        {
            using (var ctx = new SPModel())
            {

                // Update Statement
                var update = ctx.Employees.Where(ei => ei.EmID == EmID).FirstOrDefault();
                if (update != null)
                {
                    update.EmID = e.EmID;
                    update.EmFname = e.EmFname;
                    update.EmLname = e.EmLname;
                    update.UserName = e.UserName;
                    update.Password = e.Password;
                    update.admin = e.admin;
                    update.addJob = e.addJob;
                    update.EditJob = e.EditJob;
                    update.Department = e.Department;
                    update.SaleName = e.SaleName;
                    update.CHK = e.CHK;
                    update.DepID = e.DepID;
                    update.stat = e.stat;
                    update.Email = e.Email;
                }

                ctx.SaveChanges();
            }
        }


        // DELETE api/SPUser?EmID
        public void Delete(int EmID)
        {
            using (var ctx = new SPModel())
            {
                var del = ctx.Employees.Where(ei => (ei.EmID == EmID)).FirstOrDefault();
                if (del != null)
                {
                    ctx.Employees.Remove(del);
                }
            }
        }





    }
}
