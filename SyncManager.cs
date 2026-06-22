using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SparePart
{
    public class SyncManager
    {
        // Apni connection strings yahan dalein
        private static string localConnectionString = DatabaseManagement.getConnectionString();
        private static string azureConnectionString = @"Server=tcp:partex.database.windows.net,1433;Initial Catalog=SpareParts;Persist Security Info=False;User ID=CloudSA5c0f1ba1;Password=client#1@covitro;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        // 1. Internet Check karne ka function
        private static bool IsInternetAvailable()
        {
            try
            {
                // Kisi reliable server ko ping karke check karte hain
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send("8.8.8.8", 3000); // 3 seconds timeout
                    return reply.Status == IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }

        // 2. Main Sync Function
        public static void SyncLocalToAzure()
        {
            // Pehle check karein internet hai ya nahi
            if (!IsInternetAvailable())
            {
                // Agar internet nahi hai toh chup-chap return ho jaye (Form load par error na aye)
                return;
            }

            string[] tables = { "Users", "Products", "Credit", "Invoices", "InvoiceNumber" };

            try
            {
                using (SqlConnection localConn = new SqlConnection(localConnectionString))
                using (SqlConnection azureConn = new SqlConnection(azureConnectionString))
                {
                    localConn.Open();
                    azureConn.Open();

                    // Azure par saara purana data delete karne ke liye
                    using (SqlTransaction azureTxn = azureConn.BeginTransaction())
                    {
                        try
                        {
                            foreach (string table in tables)
                            {
                                string deleteQuery = $"DELETE FROM {table};";
                                using (SqlCommand cmd = new SqlCommand(deleteQuery, azureConn, azureTxn))
                                {
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            azureTxn.Commit();
                        }
                        catch (Exception ex)
                        {
                            azureTxn.Rollback();
                            throw new Exception("there is an issue in deleting in azure: " + ex.Message);
                        }
                    }

                    // Har table ka data local sa utha kar Azure par bulk insert karna
                    foreach (string table in tables)
                    {
                        DataTable dt = new DataTable();
                        string selectQuery = $"SELECT * FROM {table};";

                        using (SqlCommand cmd = new SqlCommand(selectQuery, localConn))
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                        if (dt.Rows.Count > 0)
                        {
                            // Products table mein Identity column (ProductID) hai, uski numbering same rakhne ke liye KeepIdentity option zaroori hai
                            SqlBulkCopyOptions options = SqlBulkCopyOptions.Default;
                            if (table == "Products")
                            {
                                options = SqlBulkCopyOptions.KeepIdentity;
                            }

                            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(azureConn, options, null))
                            {
                                bulkCopy.DestinationTableName = table;

                                // Column mapping (Taake sequence agay peechay na ho)
                                foreach (DataColumn column in dt.Columns)
                                {
                                    bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                                }

                                bulkCopy.WriteToServer(dt);
                            }
                        }
                    }

                    // Optional: Aap chahein toh user ko pata chalay ke sync hogya
                    // MessageBox.Show("Data successfully synced to Cloud!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Background errors ko log karein ya debug ke liye handle karein
                MessageBox.Show("Sync Error: " + ex.Message, "Sync Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
