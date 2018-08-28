using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using APIOnline.Data;
using System.Data.SqlClient;
using System.Data;

namespace APIOnline.DataAccess
{
    public class CRMCusBillingDA : CRMBase
    {
        public DataSet GetCusBillingId(string CusId)
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
                com.CommandText = "select CusId, CustomerId, CusCode, Name, ADDR1, ADDR2, ADDR3, TEL, ACCOUNT, LAST, EmailTo, OUTSTND, MTD, YTD, TERM, ACCT, ATTN, INVOICING, WHTax, EmId, AddPerson" +
                    ", Department from tblCusBilling Where CusId = '" + CusId.Trim() + "' ";
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

        public DataSet GetCusBillingName(string CusName)
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
                com.CommandText = "select CusId, CustomerId, CusCode, Name, ADDR1, ADDR2, ADDR3, TEL, ACCOUNT, LAST, EmailTo, OUTSTND, MTD, YTD, TERM, ACCT, ATTN, INVOICING, WHTax, EmId, AddPerson" +
                    ", Department from tblCusBilling Where CusName = '" + CusName.Trim() + "' ";
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


        public bool PostCusBilling(tblCusBilling CB)
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
                com.CommandText = "insert into tblCusBilling (CusId, CustomerId, CusCode, Name, ADDR1, ADDR2, ADDR3, TEL, ACCOUNT, LAST, EmailTo, OUTSTND, MTD, YTD" +
                    ", TERM, ACCT, ATTN, INVOICING, WHTax, EmId, AddPerson, Department) values ('" + CB.CusId + "'" +
                    ",'" + CB.CustomerId + "','" + CB.CusCode + "','" + CB.Name + "','" + CB.ADDR1 + "','" + CB.ADDR2 + "','" + CB.ADDR3 + "','" + CB.TEL + "','" + CB.ACCOUNT + "'" +
                    ",'" + CB.LAST + "','" + CB.EmailTo + "','" + CB.OUTSTND + "','" + CB.MTD + "','" + CB.YTD + "','" + CB.TERM + "','" + CB.ACCT + "','" + CB.ATTN + "','" + CB.INVOICING + "'" +
                    ",'" + CB.WHTax + "','" + CB.EmId + "','" + CB.AddPerson + "','" + CB.Department + "')";
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


        public bool PutCusBilling(String CusId, tblCusBilling CB)
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
                com.CommandText = "Update tblCusBilling set CusId = '" + CB.CusId + "', CustomerId = '" + CB.CustomerId + "', CusCode = '" + CB.CusCode + "'" +
                    ", Name = '" + CB.Name + "', ADDR1 = '" + CB.ADDR1 + "', ADDR2 = '" + CB.ADDR2 + "', ADDR3 = '" + CB.ADDR3 + "'" +
                    ", TEL = '" + CB.TEL + "', ACCOUNT = '" + CB.ACCOUNT + "', LAST = '" + CB.LAST + "', EmailTo = '" + CB.EmailTo + "', OUTSTND = '" + CB.OUTSTND + "'" +
                    ", MTD = '" + CB.MTD + "', YTD = '" + CB.YTD + "', TERM = '" + CB.TERM + "', ACCT = '" + CB.ACCT + "', ATTN = '" + CB.ATTN + "', INVOICING = '" + CB.INVOICING + "'" +
                    ", WHTax = '" + CB.WHTax + "', EmId = '" + CB.EmId + "', AddPerson = '" + CB.AddPerson + "', Department = '" + CB.Department + "', YTD = '" + CB.YTD + "' where  CusId = '" + CusId + "' ";
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


        public bool DeleteCusBilling(string CusId)
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
                com.CommandText = "Delete from tblCusBilling where CusId = '" + CusId + "' ";
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