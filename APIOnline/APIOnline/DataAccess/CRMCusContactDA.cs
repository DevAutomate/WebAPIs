using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIOnline.Data;
using System.Data.SqlClient;
using System.Data;

namespace APIOnline.DataAccess
{
    public class CRMCusContactDA : CRMBase
    { 

        public DataSet GetCusContactAll(string CusId)
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
                com.CommandText = "select CusId, ContactId, ContactName, ContactPhoneH, ContactPhoneO, ContactPhoneM, ContactFax, ContactEmail, EmId, AddPerson, Department" +
                    ", CompanyofContact from tblCusContact Where CusId = '" + CusId.Trim() + "' ";
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

        public DataSet GetCusContact(string CusId, string ContactId)
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
                com.CommandText = "select CusId, ContactId, ContactName, ContactPhoneH, ContactPhoneO, ContactPhoneM, ContactFax, ContactEmail, EmId, AddPerson, Department" +
                    ", CompanyofContact from tblCusContact Where CusId = '" + CusId + "' and ContactId = '" + ContactId.Trim() + "' ";
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

        public DataSet GetCusContactName(string CusId, string ContactName)
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
                com.CommandText = "select CusId, ContactId, ContactName, ContactPhoneH, ContactPhoneO, ContactPhoneM, ContactFax, ContactEmail, EmId, AddPerson, Department" +
                    ", CompanyofContact from tblCusContact Where CusId = '" + CusId.Trim() + "' and ContactName = '" + ContactName.Trim() + "' ";
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


        public bool PostCusContact(tblCusContact CC)
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
                com.CommandText = "insert into tblCusContact (CusId, ContactId, ContactName, ContactPhoneH, ContactPhoneO, ContactPhoneM, ContactFax, ContactEmail, EmId, AddPerson, Department" +
                    ", CompanyofContact) values ('" + CC.CusId + "','" + CC.ContactId + "','" + CC.ContactName + "','" + CC.ContactPhoneH + "','" + CC.ContactPhoneO + "','" + CC.ContactPhoneM + "'" +
                    ",'" + CC.ContactFax + "','" + CC.ContactEmail + "','" + CC.EmId + "','" + CC.AddPerson + "','" + CC.Department + "','" + CC.CompanyofContact + "')";
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


        public bool PutCusContact(string CusId, string ContactId, tblCusContact CC)
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
                com.CommandText = "Update tblCusContact set CusId = '" + CC.CusId + "', ContactId = '" + CC.ContactId + "', ContactName = '" + CC.ContactName + "'" +
                    ", ContactPhoneH = '" + CC.ContactPhoneH + "', ContactPhoneO = '" + CC.ContactPhoneO + "', ContactPhoneM = '" + CC.ContactPhoneM + "', ContactFax = '" + CC.ContactFax + "'" +
                    ", ContactEmail = '" + CC.ContactEmail + "', EmId = '" + CC.EmId + "', AddPerson = '" + CC.AddPerson + "', Department = '" + CC.Department + 
                    "' where  CusId = '" + CusId + "' and ContactId = '" + ContactId + "' ";
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


        public bool DeleteCusContact(string CusId, string ContactId)
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
                com.CommandText = "Delete from tblCusContact where CusId = '" + CusId + "' and ContactId = '" + ContactId + "' ";
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