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
    public class CRMPsController : ApiController
    {
        // GET api/CRMPs?CusId
        public string GetPs(string CusId)
        {
            string json;
            using (var ctx = new CRMModel())
            {
                var PSList = ctx.tblPS.Where(ci => ci.CusID == CusId).ToList();
                json = JsonConvert.SerializeObject(PSList);
            }
            return json;
        }

        // POST api/CRMPs?tblPS
        public void Post([FromBody]tblP PS)
        {
            using (var ctx = new CRMModel())
            {
                var cuscon = ctx.Set<tblP>();
                cuscon.Add(new tblP
                {
                    CusID = PS.CusID,
                    PSRefNo = PS.PSRefNo,
                    PSubID = PS.PSubID,
                    Plot = PS.Plot,
                    Isudt = PS.Isudt,
                    MoveDate = PS.MoveDate,
                    PSId = PS.PSId,
                    ProjectID = PS.ProjectID,
                    ExPDate = PS.ExPDate
                });

                ctx.SaveChanges();
            }
        }

        // PUT api/CRMPs?CusId,tblPS
        public void Put(String CusId, [FromBody]tblP PS)
        {
            using (var ctx = new CRMModel())
            {

                // Update Statement
                var update = ctx.tblPS.Where(ci => ci.CusID == CusId).FirstOrDefault();
                if (update != null)
                {
                    update.CusID = PS.CusID;
                    update.PSRefNo = PS.PSRefNo;
                    update.PSubID = PS.PSubID;
                    update.Plot = PS.Plot;
                    update.Isudt = PS.Isudt;
                    update.MoveDate = PS.MoveDate;
                    update.PSId = PS.PSId;
                    update.ProjectID = PS.ProjectID;
                    update.ExPDate = PS.ExPDate;
                }

                ctx.SaveChanges();
            }
        }


        // DELETE api/CRMPs?CusId
        public void Delete(string CusId)
        {
            using (var ctx = new CRMModel())
            {
                var del = ctx.tblPS.Where(ci => ci.CusID == CusId).FirstOrDefault();
                if (del != null)
                {
                    ctx.tblPS.Remove(del);
                }
            }
        }
    }
}