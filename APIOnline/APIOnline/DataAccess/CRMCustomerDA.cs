using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using APIOnline.Data;


namespace APIOnline.DataAccess
{
    public class CRMCustomerDA : CRMBase
    {
        public DataSet GetCustomerId(String CusId)
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
                com.CommandText = "select CusId, CustomerType, CusUTitle, CusUFName, CusULName, CusUAddress, CusUPhone, CusUPhoneM, CusUFax" +
                    ", CusUEmail, CusNote, EmId, AddPerson, Department, SaleName, Careof, CareofName, ServiceType, EmailState, Status, CustomerDate" +
                    ", CustomerTime from tblCustomer where  CusId= '" + CusId + "' ";
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

        public DataSet GetCustomerName(String CusName)
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
                com.CommandText = "select CusId, CustomerType, CusUTitle, CusUFName, CusULName, CusUAddress, CusUPhone, CusUPhoneM, CusUFax" +
                    ", CusUEmail, CusNote, EmId, AddPerson, Department, SaleName, Careof, CareofName, ServiceType, EmailState, Status, CustomerDate" +
                    ", CustomerTime from tblCustomer where  CusUFName= '" + CusName + "' ";
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

       public bool PostCustomer(tblCustomer C)
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
                com.CommandText = "insert into tblCustomer (CusId, CustomerType, CusUTitle, CusUFName, CusULName, CusUAddress, CusUPhone, CusUPhoneM, CusUFax" +
                    ", CusUEmail, CusNote, EmId, AddPerson, Department, SaleName, Careof, CareofName, ServiceType, EmailState, Status, CustomerDate" +
                    ", CustomerTime) values ('" + C.CusId + "'" +
                    ",'" + C.CustomerType + "','" + C.CusUTitle + "','" + C.CusUFName + "','" + C.CusULName + "','" + C.CusUAddress + "','" + C.CusUPhone + "','" + C.CusUPhoneM + "','" + C.CusUFax + "'" +
                    ",'" + C.CusUEmail + "','" + C.CusNote + "','" + C.EmId + "','" + C.AddPerson + "','" + C.Department + "','" + C.SaleName + "','" + C.Careof + "','" + C.CareofName + "'" +
                    ",'" + C.ServiceType + "','" + C.EmailState + "','" + C.Status + "','" + C.CustomerDate + "')";
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

        public bool PutCustomer(String CusId, tblCustomer C)
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
                com.CommandText = "Update tblCustomer set CusId = '" + C.CusId + "', CustomerType = '" + C.CustomerType + "', CusUTitle = '" + C.CusUTitle + "'" +
                    ", CusUFName = '" + C.CusUFName + "', CusULName = '" + C.CusULName + "', CusUAddress = '" + C.CusUAddress + "', CusUPhone = '" + C.CusUPhone + "'" +
                    ", CusUPhoneM = '" + C.CusUPhoneM + "', CusUFax = '" + C.CusUFax + "', CusUEmail = '" + C.CusUEmail + "', CusNote = '" + C.CusNote + "', EmId = '" + C.EmId + "'" +
                    ", AddPerson = '" + C.AddPerson + "', Department = '" + C.Department + "', SaleName = '" + C.SaleName + "', Careof = '" + C.Careof + "', CareofName = '" + C.CareofName + "'" +
                    ", ServiceType = '" + C.ServiceType + "', EmailState = '" + C.EmailState + "', Status = '" + C.Status + "', CustomerDate = '" + C.CustomerDate + "', CustomerTime = '" + C.CustomerTime + "'" +
                    " where  CusId = '" + CusId + "' ";
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

        public bool DeleteCustomer(string CusId)
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
                com.CommandText = "Delete from tblCustomer where CusId = '" + CusId + "' ";
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