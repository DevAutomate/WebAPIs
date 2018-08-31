using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using APIOnline.Models;
using Newtonsoft.Json;
namespace APIOnline.Controllers
{
    public class CRMOriginDestinationController : ApiController
    {
        // GET api/CRMOriginDestination?CusId
        public string GetOriginDestination(string CusId)
        {
            string json;
            using (var ctx = new CRMModel())
            {
                var ODList = ctx.tblOriginDestinations.Where(ci => ci.CusId == CusId).ToList();
                json = JsonConvert.SerializeObject(ODList);
            }
            return json;
        }

        // POST api/CRMOriginDestination?tblOriginDestination
        public void Post([FromBody]tblOriginDestination od)
        {
            using (var ctx = new CRMModel())
            {
                var cuscon = ctx.Set<tblOriginDestination>();
                cuscon.Add(new tblOriginDestination
                {
                    CusId = od.CusId,
                    No = od.No,
                    Origin = od.Origin,
                    Destination = od.Destination,
                    EmId = od.EmId,
                    AddPerson = od.AddPerson,
                    Department = od.Department
                });

                ctx.SaveChanges();
            }
        }

        // PUT api/CRMOriginDestination?CusId,No,tblOrigindestination
        public void Put(String CusId, int No, [FromBody]tblOriginDestination od)
        {
            using (var ctx = new CRMModel())
            {

                // Update Statement
                var update = ctx.tblOriginDestinations.Where(ci => ci.CusId == CusId).FirstOrDefault();
                if (update != null)
                {
                    update.CusId = od.CusId;
                    update.No = od.No;
                    update.Origin = od.Origin;
                    update.Destination = od.Destination;
                    update.EmId = od.EmId;
                    update.AddPerson = od.AddPerson;
                    update.Department = od.Department;
                }

                ctx.SaveChanges();
            }
        }


        // DELETE api/CRMOriginDestination?CusId&No
        public void Delete(string CusId, int No)
        {
            using (var ctx = new CRMModel())
            {
                var del = ctx.tblOriginDestinations.Where(ci => ci.CusId == CusId && ci.No == No).FirstOrDefault();
                if (del != null)
                {
                    ctx.tblOriginDestinations.Remove(del);
                }
            }
        }
    }
}