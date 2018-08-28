using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using APIOnline.Data;
using APIOnline.DataAccess;
using Newtonsoft.Json;

namespace APIOnline.Controllers
{
    public class SPCalendarController : ApiController
    {
        // GET api/SPCalendar?jobdate
        public string GetDate(DateTime jobdate)
        {
            SPCalendarDA SPD = new SPCalendarDA();
            DataSet ds = new DataSet();
            ds = SPD.GetCalendar(jobdate);
            string json = JsonConvert.SerializeObject(ds);
            return json;

        }

        // GET api/SPCalendar?jobdate1&jobdate2
        public string GetBetween(DateTime jobdate1, DateTime jobdate2)
        {
            SPCalendarDA SPD = new SPCalendarDA();
            DataSet ds = SPD.GetCalendarBetween(jobdate1, jobdate2);
            string json = JsonConvert.SerializeObject(ds);
            return json;

        }

        // POST api/SPCalendar?JsonJob
        public void Post([FromBody]Job J)
        {
            SPCalendarDA SPD = new SPCalendarDA();
            SPD.PostCalendar(J);
        }

        // PUT api/SPCalendar?jobid&JsonJob
        public void Put(string JobID, [FromBody]Job J)
        {
            SPCalendarDA SPD = new SPCalendarDA();
            SPD.PutCalendar(JobID,J);
        }

        // DELETE api/SPCalendar?jobid
        public void Delete(string JobID)
        {
            SPCalendarDA SPD = new SPCalendarDA();
            SPD.DeleteCalenda(JobID);
        }
    }
}