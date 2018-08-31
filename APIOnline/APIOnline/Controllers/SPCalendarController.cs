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
    public class SPCalendarController : ApiController
    {
        // GET api/SPCalendar?jobdate
        public string GetDate(DateTime jobdate)
        {
            string json;
            using (var ctx = new SPModel())
            {
                var JobList = ctx.Jobs.Where(d => d.JobDate == jobdate).ToList();
                json = JsonConvert.SerializeObject(JobList);
            }
            return json;
        }

        // GET api/SPCalendar?jobdate1&jobdate2
        public string GetBetween(DateTime jobdate1, DateTime jobdate2)
        {
            string json;
            using (var ctx = new SPModel())
            {
                var JobList = ctx.Jobs.Where(d => d.JobDate > jobdate1 && d.JobDate < jobdate2).ToList();
                json = JsonConvert.SerializeObject(JobList);
            }
            return json;
        }

        // POST api/SPCalendar?JsonJob
        public void Post([FromBody]Job J)
        {
            using (var ctx = new SPModel())
            {
                var calendar = ctx.Set<Job>();
                calendar.Add(new Job
                {
                    JobID = J.JobID,
                    JobDate = J.JobDate,
                    CustFname = J.CustFname,
                    CustLname = J.CustLname,
                    JobType = J.JobType,
                    JobCuft = J.JobCuft,
                    TruckTrip = J.TruckTrip,
                    Trip = J.Trip,
                    EmID = J.EmID,
                    JobStatus = J.JobStatus,
                    Location = J.Location,
                    Remark = J.Remark,
                    Sale = J.Sale,
                    Origin = J.Origin,
                    Tel = J.Tel,
                    StatusCon = J.StatusCon,
                    JobRefNo = J.JobRefNo,
                    ConId = J.ConId,
                    VUnit = J.VUnit,
                    TT1 = J.TT1,
                    TT2 = J.TT2,
                    TT3 = J.TT3,
                    TT4 = J.TT4,
                    TT5 = J.TT5,
                    TEAM = J.TEAM,
                    CRTIME = J.CRTIME,
                    CRNAME = J.CRNAME,
                    TEAMCO = J.TEAMCO,
                    TEAMNAME = J.TEAMNAME,
                    Book1 = J.Book1,
                    Department1 = J.Department1,
                    Direction1 = J.Direction1,
                    Book2 = J.Book2,
                    Department2 = J.Department2,
                    Direction2 = J.Direction2,
                    Book3 = J.Book3,
                    Department3 = J.Department3,
                    Direction3 = J.Direction3,
                    TeamUnit = J.TeamUnit,
                    InqId = J.InqId,
                    AppointTime = J.AppointTime,
                    ComId = J.ComId,
                    CusId = J.CusId,
                    SJobRefNo = J.SJobRefNo,
                    SConId = J.SConId,
                    CusPhone = J.CusPhone
                });

                ctx.SaveChanges();
            }
        }

        // PUT api/SPCalendar?jobid&JsonJob
        public void Put(int JobID, [FromBody]Job J)
        {
            using (var ctx = new SPModel())
            {

                // Update Statement
                var update = ctx.Jobs.Where(ji => ji.JobID == JobID).FirstOrDefault();
                if (update != null)
                {
                    update.JobID = J.JobID;
                    update.JobDate = J.JobDate;
                    update.CustFname = J.CustFname;
                    update.CustLname = J.CustLname;
                    update.JobType = J.JobType;
                    update.JobCuft = J.JobCuft;
                    update.TruckTrip = J.TruckTrip;
                    update.Trip = J.Trip;
                    update.EmID = J.EmID;
                    update.JobStatus = J.JobStatus;
                    update.Location = J.Location;
                    update.Remark = J.Remark;
                    update.Sale = J.Sale;
                    update.Origin = J.Origin;
                    update.Tel = J.Tel;
                    update.StatusCon = J.StatusCon;
                    update.JobRefNo = J.JobRefNo;
                    update.ConId = J.ConId;
                    update.VUnit = J.VUnit;
                    update.TT1 = J.TT1;
                    update.TT2 = J.TT2;
                    update.TT3 = J.TT3;
                    update.TT4 = J.TT4;
                    update.TT5 = J.TT5;
                    update.TEAM = J.TEAM;
                    update.CRTIME = J.CRTIME;
                    update.CRNAME = J.CRNAME;
                    update.TEAMCO = J.TEAMCO;
                    update.TEAMNAME = J.TEAMNAME;
                    update.Book1 = J.Book1;
                    update.Department1 = J.Department1;
                    update.Direction1 = J.Direction1;
                    update.Book2 = J.Book2;
                    update.Department2 = J.Department2;
                    update.Direction2 = J.Direction2;
                    update.Book3 = J.Book3;
                    update.Department3 = J.Department3;
                    update.Direction3 = J.Direction3;
                    update.TeamUnit = J.TeamUnit;
                    update.InqId = J.InqId;
                    update.AppointTime = J.AppointTime;
                    update.ComId = J.ComId;
                    update.CusId = J.CusId;
                    update.SJobRefNo = J.SJobRefNo;
                    update.SConId = J.SConId;
                    update.CusPhone = J.CusPhone;
                }

                ctx.SaveChanges();
            }

        }

        // DELETE api/SPCalendar?jobid
        public void Delete(int JobID)
        {
            using (var ctx = new SPModel())
            {
                var del = ctx.Jobs.Where(ji => (ji.JobID == JobID)).FirstOrDefault();
                if (del != null)
                {
                    ctx.Jobs.Remove(del);
                }
            }
        }
    }
}