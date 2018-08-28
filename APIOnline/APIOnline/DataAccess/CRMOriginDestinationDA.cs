using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using APIOnline.Data;

namespace APIOnline.DataAccess
{
    public class CRMOriginDestinationDA : CRMBase
    {

        public DataSet GetOriginDestination(String CusId)
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
                com.CommandText = "select CusId, No, Origin, Destination, EmId, AddPerson, Department from tblOriginDestination where CusId = '" + CusId + "' ";
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
        
        public bool PostOriginDestination(tblOriginDestination OD)
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
                com.CommandText = "insert into tblOriginDestination (CusId, No, Origin, Destination, EmId, AddPerson, Department) values ('" + OD.CusId + "'" +
                    ",'" + OD.No + "','" + OD.Origin + "','" + OD.Destination + "','" + OD.EmId + "','" + OD.AddPerson + "','" + OD.Department + "')";
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

        public bool PutOriginDestination(String CusId, int No, tblOriginDestination OD)
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
                com.CommandText = "Update tblOriginDestination set CusId = '" + OD.CusId + "', No = '" + OD.No + "', Origin = '" + OD.Origin + "'" +
                    ", Destination = '" + OD.Destination + "', EmId = '" + OD.EmId + "', AddPerson = '" + OD.AddPerson + "', Department = '" + OD.Department + "'" +
                    " where  CusId = '" + CusId + "' and No = '" + No + "'";
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

        public bool DeleteOriginDestination(String CusId, int No)
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
                com.CommandText = "Delete from tblOriginDestination where CusId = '" + CusId + "' and No = '" + No + "' ";
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