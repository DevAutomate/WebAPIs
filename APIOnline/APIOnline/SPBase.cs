using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace APIOnline
{
    public class SPBase
    {
        string conn = ConfigurationManager.ConnectionStrings["StaffPlanEntities"].ToString();
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