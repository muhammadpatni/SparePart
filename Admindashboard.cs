using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparePart
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LowStcokPnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            totalinventoryload();
            lowstockload();
            outofstockload();
            loadudhaarstatus();
            WeeklySalepanel.Height = WeeklySalepanel.Height + 150;
            Inventoryhealthpanel.Height = Inventoryhealthpanel.Height + 150;
            uipanel.Height = uipanel.Height + 150;
        }

        private void outofstockload()
        {
            SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Products WHERE Stock < 1;", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                object result = cmd.ExecuteScalar();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                OutofStockTxt.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void lowstockload()
        {
            SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Products WHERE Stock <= lowstock;", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                object result = cmd.ExecuteScalar();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                LowStockTxt.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void totalinventoryload()
        {
            SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(count(ProductID), 0) FROM Products;", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                object result = cmd.ExecuteScalar();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                TotalinventoryTxt.Text = result.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

        }

        private void loadudhaarstatus()
        {
            SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT SUM(GrandTotal) FROM Invoices WHERE InvoiceNumber IN ( SELECT DISTINCT InvoiceNumber FROM Credit );", con);
                SqlCommand cmd2 = new SqlCommand("SELECT count(*) FROM Invoices  WHERE InvoiceNumber IN ( SELECT DISTINCT InvoiceNumber FROM Credit );", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                object result = cmd.ExecuteScalar();
                object result2 = cmd2.ExecuteScalar();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                UdharStatusTxt.Text = result.ToString();
                PendingCustomerTxt.Text = result2.ToString() + " Customer Pending";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

        }

        private void UdharStatusTxt_Click(object sender, EventArgs e)
        {

        }

        private void Inventoryhealthpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}