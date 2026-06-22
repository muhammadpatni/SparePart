using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace SparePart
{
    internal class DatabaseManagement
    {
        private static string ConnectionString = "Data Source=WIN-9GCSBBJOLMN\\SQLEXPRESS;Initial Catalog=SpareParts;Integrated Security=True;Trust Server Certificate=True";

        public static string getConnectionString()
        {
            return ConnectionString;
        }

        public static DataTable? retrieve(string query, SqlConnection con)
        {

            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
        public static int edit(string query, SqlConnection con)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                int result = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return -1;
            }
        }

        public static long getInvoice(string query, SqlConnection con)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                object result = cmd.ExecuteScalar();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return Convert.ToInt64(result);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                return -1;
            }
        }


        public static bool  IsInvoiceAvailable(string query, SqlConnection con)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand(query, con);
            int count = (int)cmd.ExecuteScalar();
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            return count != 0;  
        }
    }




}

