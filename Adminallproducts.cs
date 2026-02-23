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
    public partial class Adminallproducts : Form
    {
        DataTable? productsoutofstock = new DataTable();
        public Adminallproducts()
        {
            InitializeComponent();
            typeof(DataGridView).InvokeMember("DoubleBuffered",
              System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
              null, dataview, new object[] { true });
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Adminpage adminpage = new Adminpage();
            adminpage.Show();
            this.Hide();
        }

        private void Adminallproducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Adminpage adminpage = new Adminpage();
                adminpage.Show();
                this.Hide();
            }
            else if (e.KeyCode == Keys.F && e.Control)
            {
                searcchtxt.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                dataview.Focus();
            }
        }

        private void searcchtxt_TextChanged(object sender, EventArgs e)
        {
            Searchproduct($"SELECT * FROM Products WHERE ProductName LIKE '%{searcchtxt.Text}%' ");
        }

        void Searchproduct(string query)
        {
            dataview.Visible = false;
            lbstatus.Visible = true;
            DataTable? dt = null;
            try
            {
                using (SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString()))
                {
                    con.Open();
                    dt = DatabaseManagement.retrieve(query, con);
                }

                if (dt != null && dt.Rows.Count > 0)
                {
                    productsoutofstock = dt;
                    dataview.DataSource = productsoutofstock;
                    dataview.Visible = true;
                    lbstatus.Visible = false;
                }
                else
                {
                    lbstatus.Text = "All stock are healthy by this name";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        async Task loadproducts(string query)
        {
            dataview.Visible = false;
            lbstatus.Visible = true;
            try
            {
                SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
                DataTable dt = await Task.Run(() => DatabaseManagement.retrieve(query, con));

                if (dt != null && dt.Rows.Count > 0)
                {
                    productsoutofstock = dt;
                    dataview.DataSource = productsoutofstock;
                    dataview.Visible = true;
                    lbstatus.Visible = false;
                }
                else
                {
                    lbstatus.Text = "All stock are healthy!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private async void dataview_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (dataview.CurrentRow != null)
                {
                    string id = dataview.CurrentRow.Cells[0].Value.ToString();
                    string name = dataview.CurrentRow.Cells[1].Value.ToString();
                    string price = dataview.CurrentRow.Cells[2].Value.ToString();
                    string stock = dataview.CurrentRow.Cells[3].Value.ToString();
                    string lowstock = dataview.CurrentRow.Cells[4].Value.ToString();

                    Updateproductform updateForm = new Updateproductform(false);
                    updateForm.settextboxes(id, name, price, stock, lowstock);
                    updateForm.ShowDialog();
                    e.Handled = true;
                    await loadproducts("SELECT * FROM Products");
                    searcchtxt.Clear();
                    searcchtxt.Focus();
                }
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

        private async void Adminallproducts_Load(object sender, EventArgs e)
        {
            await loadproducts("SELECT * FROM Products");
        }

        private void dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
