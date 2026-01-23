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
        private static string ConnectionString = "Data Source=DESKTOP-GJBQRB1\\SQLEXPRESS;Initial Catalog=SpareParts;Integrated Security=True;Trust Server Certificate=True";
         static  SqlConnection con = new SqlConnection(ConnectionString);

        public  static DataTable? retrieve(string query) {

            try {                 
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
              SqlDataReader sqlDataReader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
               dt.Load(sqlDataReader);
                con.Close();
                return dt;
            }
            catch (Exception ex)
            {
               MessageBox.Show("Something Went Wrong\n" + ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            return null;
        }
            


    }
}
