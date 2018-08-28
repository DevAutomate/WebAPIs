using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace APIOnline
{
    public class CRMBase
    {
        string conn = ConfigurationManager.ConnectionStrings["JVKCRMEntities"].ToString();
        public SqlConnection GetConnection()
        {
            SqlConnection sqlconnection = null;
            if (!conn.Equals(""))
            {
                sqlconnection = new SqlConnection(conn); //สร้าง การ connection

                if (sqlconnection != null && sqlconnection.State == ConnectionState.Closed)
                {
                    sqlconnection.Open();
                }

            }

            return sqlconnection;
        }
    }
}