using Microsoft.Data.SqlClient;
using System;
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
    public partial class Employeesavedbills : Form
    {
        DataTable Savedbills = new DataTable();

        public Employeesavedbills()
        {
            InitializeComponent();
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            EmployeeReturnPage returnPage = new EmployeeReturnPage();
            returnPage.Show();
            this.Hide();

        }

        private void Billingbtn_Click(object sender, EventArgs e)
        {
            Employeepage emp = new Employeepage();
            emp.Show();
            this.Hide();

        }

        private async void Employeesavedbills_Load(object sender, EventArgs e)
        {
            await loadproducts("SELECT 'PARTEX' + CAST(InvoiceNumber AS NVARCHAR) AS InvoiceNumber,Date ,CustomerName,Discount ,GrandTotal FROM Invoices WHERE InvoiceNumber IN ( SELECT DISTINCT InvoiceNumber FROM Credit );");

        }


        async Task loadproducts(string query)
        {
            dataview.Visible = false;
            lbstatus.Visible = true;
            try
            {
                SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
                DataTable dt = await Task.Run(() => DatabaseManagement.retrieve(query,con));

                if (dt != null && dt.Rows.Count > 0)
                {
                    Savedbills = dt;
                    dataview.DataSource = Savedbills;
                    AddActionColumn();
                    dataview.Visible = true;
                    lbstatus.Visible = false;
                }
                else
                {
                    lbstatus.Text = "NO bill saved!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void AddActionColumn()
        {
            if (dataview.Columns.Contains("Add"))
                return;

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.Name = "Add";
            imgCol.HeaderText = "";
            imgCol.Image = Properties.Resources.add_1000dp_1E293B;
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            imgCol.DefaultCellStyle.BackColor = Color.White;


            dataview.Columns.Add(imgCol);
        }

        private void Savedbillsbtn_Click(object sender, EventArgs e)
        {
            Employeesavedbills employeepage = new Employeesavedbills();
            employeepage.Show();
            this.Hide();
        }

        private void searcchtxt_TextChanged(object sender, EventArgs e)
        {
            Searchproduct($"SELECT 'PARTEX' + CAST(InvoiceNumber AS NVARCHAR) AS InvoiceNumber,Date,CustomerName,Discount,  GrandTotal FROM Invoices WHERE InvoiceNumber IN ( SELECT DISTINCT InvoiceNumber FROM Credit ) AND customerName LIKE '%{searcchtxt.Text}%'");

        }
        void Searchproduct(string query)
        {
            dataview.Visible = false;
            lbstatus.Visible = true;
            try
            {
                SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
                DataTable dt = DatabaseManagement.retrieve(query,con);

                if (dt != null && dt.Rows.Count > 0)
                {
                    Savedbills = dt;
                    dataview.DataSource = Savedbills;
                    AddActionColumn();
                    dataview.Visible = true;
                    lbstatus.Visible = false;
                }
                else
                {
                    lbstatus.Text = "NO bill saved!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void searcchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                dataview.Focus();
            }
        }

        private void Employeesavedbills_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                dataview.Focus();
            }
            else if (e.KeyCode == Keys.X && (!searcchtxt.Focused))
            {
                Logoutbutton.PerformClick();
            }
            else if (e.KeyCode == Keys.F && e.Control)
            {
                searcchtxt.Clear();
                searcchtxt.Focus();
            }
            else if (e.KeyCode == Keys.F1)
            {
                Billingbtn.PerformClick();
            }
            else if (e.KeyCode == Keys.F1)
            {
                Billingbtn.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                Returnbtn.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                Savedbillsbtn.PerformClick();
            }
        }

        private async void dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataview.Columns[e.ColumnIndex].Name == "Add")
            {
                openbill(e.RowIndex);
            }
        }

        void openbill(int rowindex)
        {
            string Invoice = dataview.Rows[rowindex].Cells["InvoiceNumber"].Value.ToString().Replace("PARTEX", "").Trim();
            SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
            DataTable? credit = DatabaseManagement.retrieve($"SELECT ProductID,ProductName,price,Quantity,Total FROM Credit WHERE InvoiceNumber={Invoice};",con);
            DataTable? invoiceinfo = DatabaseManagement.retrieve($"SELECT * FROM Invoices WHERE InvoiceNumber={Invoice};",con);
            string query1 = $"DELETE FROM Credit WHERE InvoiceNumber={Invoice};";
            string query2 = $"DELETE FROM Invoices WHERE InvoiceNumber={Invoice};";
            DatabaseManagement.edit(query1, con);
            DatabaseManagement.edit(query2, con);
            Employeepage emppage = new Employeepage(credit, invoiceinfo);
            emppage.Show();
            this.Hide();
        }

        private void dataview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                openbill(dataview.CurrentRow.Index);
            }
        }
    }
}
