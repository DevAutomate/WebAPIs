using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using APIOnline.Data;
using Newtonsoft.Json;
using System.Text;

namespace APIOnline.DataAccess
{
    public class SPCalendarDA : SPBase
    {
        public DataSet GetCalendar(DateTime jobdate)
        {
            DataSet result = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand com = new SqlCommand();
            SqlConnection con = null;
            try
            {
                #region ข้อ 1 การเชื่อมต่อฐานข้อมูล
                con = this.GetConnection();
                com.Connection = con;
                #endregion
                #region ข้อ 2 การยิง Query

                com.CommandType = CommandType.Text;
                com.CommandText = "select JobID, JobDate, CustFname, CustLname, JobType, JobCuft, TruckTrip, Trip, EmID, JobStatus, Location, Remark, Sale , Origin, Tel" +
                    ", StatusCon, JobRefNo, ConId, VUnit, EmFname, TT1, TT2, TT3, TT4, TT5, TEAM, Department CRTIME, CRNAME, TEAMCO, TEAMNAME, Book1, Department1, Direction1" +
                    ", Book2, Department2, Direction2, Book3, Department3, Direction3, TeamUnit, InqId, AppointTime, ComId, CusId, SJobRefNo, SConId, CusPhone from JobView where  JobDate= '" + jobdate + "' ";
                #endregion

                #region ข้อ 3 การรีเทินผลลัพ
                adapter.SelectCommand = com;
                adapter.Fill(result);



                #endregion
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (com != null)
                {
                    com = null;

                }
                if ((con != null) && (con.State == ConnectionState.Open))
                {
                    con.Close();
                    con = null;

                }
            }

            return result;

        }

        public DataSet GetCalendarBetween(DateTime jobdate1, DateTime jobdate2)
        {
            DataSet result = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand com = new SqlCommand();
            SqlConnection con = null;
            try
            {
                #region ข้อ 1 การเชื่อมต่อฐานข้อมูล
                con = this.GetConnection();
                com.Connection = con;
                #endregion
                #region ข้อ 2 การยิง Query

                com.CommandType = CommandType.Text;
                com.CommandText = "select JobID, JobDate, CustFname, CustLname, JobType, JobCuft, TruckTrip, Trip, EmID, JobStatus, Location, Remark, Sale , Origin, Tel" +
                    ", StatusCon, JobRefNo, ConId, VUnit, EmFname, TT1, TT2, TT3, TT4, TT5, TEAM, Department CRTIME, CRNAME, TEAMCO, TEAMNAME, Book1, Department1, Direction1" +
                    ", Book2, Department2, Direction2, Book3, Department3, Direction3, TeamUnit, InqId, AppointTime, ComId, CusId, SJobRefNo, SConId, CusPhone from JobView where JobDate Between '" + jobdate1 + "' And '" + jobdate2 + "' ";
                #endregion

                #region ข้อ 3 การรีเทินผลลัพ
                adapter.SelectCommand = com;
                adapter.Fill(result);
                #endregion
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (com != null)
                {
                    com = null;

                }
                if ((con != null) && (con.State == ConnectionState.Open))
                {
                    con.Close();
                    con = null;

                }
            }
            return result;
        }

        /*int JobID, DateTime JobDate, string CustFname, string CustLname, string JobType, double JobCuft, string TruckTrip, double Trip, int EmID, string JobStatus
            , string Location, string Remark, string Sale, string Origin, string Tel, int StatusCon, string JobRefNo, string ConId, string VUnit, string EmFname, double TT1, double TT2
            , double TT3, double TT4, double TT5, double TEAM, string Department, DateTime CRTIME, string CRNAME, string TEAMCO, string TEAMNAME, string Book1, string Department1, string Direction1
            , string Book2, string Department2, string Direction2, string Book3, string Department3, string Direction3, string TeamUnit, string InqId, string AppointTime, string ComId
            , string CusId, string SJobRefNo, string SConId, string CusPhone*/

        public bool PostCalendar(Job J)
        {
            int count = 0;

            bool result = false;

            SqlConnection con = null;
            SqlCommand com = new SqlCommand();
            SqlTransaction tran;

            try
            {

                #region ข้อ 1 การ connection db

                con = this.GetConnection();
                com.Connection = con;

                #endregion

                #region ข้อ 2 การยิง Query

                tran = con.BeginTransaction(IsolationLevel.ReadCommitted);

                com.CommandType = CommandType.Text;
                com.CommandText = "insert into Job (JobID, JobDate, CustFname, CustLname, JobType, JobCuft, TruckTrip, Trip, EmID, JobStatus, Location, Remark, Sale , Origin, Tel" +
                    "StatusCon, JobRefNo, ConId, VUnit, TT1, TT2, TT3, TT4, TT5, TEAM, CRTIME, CRNAME, TEAMCO, TEAMNAME, Book1, Department1, Direction1" +
                    "Book2, Department2, Direction2, Book3, Department3, Direction3, TeamUnit, InqId, AppointTime, ComId, CusId, SJobRefNo, SConId, CusPhone) values ('" + J.JobID + "'" +
                    ",'" + J.JobDate + "','" + J.CustFname + "','" + J.CustLname + "','" + J.JobType + "','" + J.JobCuft + "','" + J.TruckTrip + "','" + J.Trip + "','" + J.EmID + "'" +
                    ",'" + J.JobStatus + "','" + J.Location + "','" + J.Remark + "','" + J.Sale + "','" + J.Origin + "','" + J.Tel + "','" + J.StatusCon + "','" + J.JobRefNo + "'" +
                    ",'" + J.ConId + "','" + J.VUnit + "','" + J.TT1 + "','" + J.TT2 + "','" + J.TT3 + "','" + J.TT4 + "','" + J.TT5 + "'" +
                    ",'" + J.TEAM + "','" + J.CRTIME + "','" + J.CRNAME + "','" + J.TEAMCO + "','" + J.TEAMNAME + "','" + J.Book1 + "','" + J.Department1 + "'" +
                     ",'" + J.Direction1 + "','" + J.Book2 + "','" + J.Department2 + "','" + J.Direction2 + "','" + J.Book3 + "','" + J.Department3 + "','" + J.Direction3 + "','" + J.TeamUnit + "'" +
                    ",'" + J.InqId + "','" + J.AppointTime + "','" + J.ComId + "','" + J.CusId + "','" + J.SJobRefNo + "','" + J.SConId + "','" + J.CusPhone + "')";
                com.Transaction = tran;

                #endregion

                #region ข้อ 3 การคืนค่า

                count = com.ExecuteNonQuery();

                if (count > 0)
                {
                    result = true;

                    tran.Commit();
                }
                else
                {
                    result = false;

                    tran.Rollback();
                }

                #endregion
            }
            catch (Exception ex)
            {

                //save log
            }
            finally
            {
                if (com != null)
                {
                    com = null;

                }

                if ((con != null) && (con.State == ConnectionState.Open))
                {
                    con.Close();
                    con = null;

                }
            }
            return result;
        }

        public bool PutCalendar(String JobID, Job J)
        {
            int count = 0;

            bool result = false;

            SqlConnection con = null;
            SqlCommand com = new SqlCommand();
            SqlTransaction tran;


            try
            {

                #region ข้อ 1 การ connection db

                con = this.GetConnection();
                com.Connection = con;


                #endregion



                #region ข้อ 2 การยิง Query

                tran = con.BeginTransaction(IsolationLevel.ReadCommitted);


                com.CommandType = CommandType.Text;
                com.CommandText = "Update Job set JobID = '" + J.JobID + "', JobDate = '" + J.JobDate +"', CustFname = '" + J.CustFname + "'" +
                    ", CustLname = '" + J.CustLname + "', JobType = '" + J.JobType + "', JobCuft = '" + J.JobCuft + "', TruckTrip = '" + J.TruckTrip + "'" +
                    ", Trip = '" + J.Trip + "', EmID = '" + J.EmID + "', JobStatus = '" + J.JobStatus + "', Location = '" + J.Location + "', Remark = '" + J.Remark + "'" +
                    ", Sale = '" + J.Sale + "', Origin = '" + J.Origin + "', Tel = '" + J.Tel + "', StatusCon = '" + J.StatusCon + "', JobRefNo = '" + J.JobRefNo + "'" +
                    ", ConId = '" + J.ConId + "', Vunit = '" + J.VUnit + "', TT1 = '" + J.TT1 + "', TT2 = '" + J.TT2 + "', TT3 = '" + J.TT3 + "'" +
                    ", TT4 = '" + J.TT4 + "', TT5 = '" + J.TT5 + "', TEAM = '" + J.TEAM + "', CRTIME = '" + J.CRTIME + "', CRName = '" + J.CRNAME + "'" +
                    ", TEAMCO = '" + J.TEAMCO + "', TEAMNAME = '" + J.TEAMNAME + "', Book1 = '" + J.Book1 + "', Department1 = '" + J.Department1 + "', Direction1 = '" + J.Direction1 + "'" +
                    ", Book2 = '" + J.Book2 + "', Department2 = '" + J.Department2 + "', Direction2 = '" + J.Direction2 + "', Book3 = '" + J.Book3 + "', Department3 = '" + J.Department3 + "'" +
                    ", Direction3 = '" + J.Direction3 + "', TeamUnit = '" + J.TeamUnit + "', InqId = '" + J.InqId + "', AppointTime = '" + J.AppointTime + "', ComId = '" + J.ComId + "'" +
                    ", CusId = '" + J.CusId + "', SJobRefNo = '" + J.SJobRefNo + "', SConId = '" + J.SConId + "', CusPhone = '" + J.CusPhone + "' where  JobID = '" + JobID + "' ";
                com.Transaction = tran;


                #endregion

                #region ข้อ 3 การคืนค่า


                count = com.ExecuteNonQuery();

                if (count > 0)
                {
                    result = true;

                    tran.Commit();


                }
                else
                {
                    result = false;

                    tran.Rollback();

                }

                #endregion
            }
            catch (Exception ex)
            {

                //save log



            }
            finally
            {


                if (com != null)
                {
                    com = null;

                }

                if ((con != null) && (con.State == ConnectionState.Open))
                {
                    con.Close();
                    con = null;

                }



            }

            return result;



        }

        public bool DeleteCalenda(string jobid)
        {
            int count = 0;

            bool result = false;

            SqlConnection con = null;
            SqlCommand com = new SqlCommand();
            SqlTransaction tran;


            try
            {

                #region ข้อ 1 การ connection db

                con = this.GetConnection();
                com.Connection = con;


                #endregion



                #region ข้อ 2 การยิง Query

                tran = con.BeginTransaction(IsolationLevel.ReadCommitted);


                com.CommandType = CommandType.Text;
                com.CommandText = "Delete from Job where JobID = '" + jobid + "' ";
                com.Transaction = tran;


                #endregion

                #region ข้อ 3 การคืนค่า


                count = com.ExecuteNonQuery();

                if (count > 0)
                {
                    result = true;

                    tran.Commit();


                }
                else
                {
                    result = false;

                    tran.Rollback();

                }

                #endregion
            }
            catch (Exception ex)
            {

                //save log



            }
            finally
            {


                if (com != null)
                {
                    com = null;

                }

                if ((con != null) && (con.State == ConnectionState.Open))
                {
                    con.Close();
                    con = null;

                }



            }

            return result;



        }
    }
}