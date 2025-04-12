using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management_System
{
    internal class Function
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private String ConStr;

        public Function()
        {
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sahan\Documents\HospotaManagementSystem.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(ConStr);
            cmd = con.CreateCommand();
            cmd.Connection = con;
        }

        public DataTable GetData(String Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, ConStr);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(String Query)
        {
            int cnt = 0;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd.CommandText = Query;
            cnt = cmd.ExecuteNonQuery();
            return cnt;
        }



        public object Executescalar(String Query, SqlParameter[] parameters)
        {
            using (SqlConnection con = new SqlConnection(ConStr))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteScalar();
                }
            }
        }

    }
}
