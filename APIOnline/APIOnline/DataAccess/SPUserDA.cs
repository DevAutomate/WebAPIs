using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIOnline.Data;
using System.Data.SqlClient;
using System.Data;

namespace APIOnline.DataAccess
{
    public class SPUserDA : SPBase
    {
        public int GetCheckLogin(string username, string password)
        {
            int count = 0;
            SqlCommand com = new SqlCommand();
            SqlDataReader rd = null;
            SqlConnection con = null;

            try
            {

                #region ข้อ 1 การเชื่อมต่อฐานข้อมูล

                con = this.GetConnection();

                com.Connection = con;

                #endregion

                #region ข้อ 2 การยิง Query


                com.CommandType = CommandType.Text;
                com.CommandText = "select count(*) as count from Employee Where UserName = '" + username.Trim() + "' and Password = '" + password.Trim() + "' ";

                #endregion

                #region ข้อ 3 การรีเทินผลลัพ

                rd = com.ExecuteReader();


                if (rd != null && rd.HasRows)
                {

                    while (rd.Read())
                    {
                        count = Convert.ToInt16(rd["count"].ToString().Trim());

                    }

                }
                #endregion


            }
            catch (Exception ex)
            {
                string x = ex.Message;
            }
            finally
            {
                if ((rd != null) && (!rd.IsClosed))
                {
                    rd = null;
                }

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

            return count;
        }

        public DataSet GetUser(string username, string password)
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
                com.CommandType = CommandType.Text;
                com.CommandText = "select EmID, EmFname, EmLname, UserName, Password, admin, addJob, EditJob, Department, SaleName, CHK, DepID, stat, Email from Employee Where UserName = '" + username.Trim() + "' and Password = '" + password.Trim() + "' ";
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


        public bool PostEmployee(Employee E)
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
                com.CommandText = "insert into Employee (EmID, EmFname, EmLname, UserName, Password, admin, addJob, EditJob, Department, SaleName, CHK, DepID, stat, Email) values ('" + E.EmID + "'" +
                    ",'" + E.EmFname + "','" + E.EmLname + "','" + E.UserName + "','" + E.Password + "','" + E.admin + "','" + E.addJob + "','" + E.EditJob + "','" + E.Department + "'" +
                    ",'" + E.SaleName + "','" + E.CHK + "','" + E.DepID + "','" + E.stat + "','" + E.Email + "')";
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


        public bool PutEmployee(String EmID, Employee E)
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
                com.CommandText = "Update Employee set EmID = '" + E.EmID + "', EmFname = '" + E.EmFname + "', EmLname = '" + E.EmLname + "'" +
                    ", UserName = '" + E.UserName + "', Password = '" + E.Password + "', admin = '" + E.admin + "', addJob = '" + E.addJob + "'" +
                    ", EditJob = '" + E.EditJob + "', Department = '" + E.Department + "', SaleName = '" + E.SaleName + "', CHK = '" + E.CHK + "', DepID = '" + E.DepID + "'" +
                    ", stat = '" + E.stat + "', Email = '" + E.Email + "' where  EmID = '" + EmID + "' ";
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


        public bool DeleteUser(string EmID)
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
                com.CommandText = "Delete from Employee where EmID = '" + EmID + "' ";
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