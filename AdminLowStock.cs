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
    public partial class AdminLowStock : Form
    {
        //private bool sliderbarExpand = true;
        DataTable? productslowstock = new DataTable();

        public AdminLowStock()
        {
            InitializeComponent();

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dataview, new object[] { true });
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {

            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            Adminpage adminPage = new Adminpage();
            adminPage.Show();
            this.Hide();
        }

        private void Outofstockbtn_Click(object sender, EventArgs e)
        {
            Adminoutofstoke outofstoke = new Adminoutofstoke();
            outofstoke.Show();
            this.Hide();
        }
        async Task loadproducts(string query)
        {
            dataview.Visible = false;
            lbstatus.Visible = true;
            try
            {
                DataTable dt = await Task.Run(() => DatabaseManagement.retrieve(query));

                if (dt != null && dt.Rows.Count > 0)
                {
                    productslowstock = dt;
                    dataview.DataSource = productslowstock;
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
        void Searchproduct(string query)
        {
            dataview.Visible = false;
            lbstatus.Visible = true;
            try
            {
                DataTable dt = DatabaseManagement.retrieve(query);

                if (dt != null && dt.Rows.Count > 0)
                {
                    productslowstock = dt;
                    dataview.DataSource = productslowstock;
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

        private async void AdminLowStock_Load(object sender, EventArgs e)
        {
            await loadproducts("SELECT * FROM Products WHERE Stock <= lowstock ");

        }

        private void AdminLowStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else if (e.KeyCode == Keys.X)
            {
                Logoutbutton.PerformClick();
            }
            else if (e.KeyCode == Keys.F1)
            {
                Dashboardbtn.PerformClick();
            }
            else if (e.Control && e.KeyCode == Keys.F)
            {
                searchtxt.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                dataview.Focus();
            }
        }

        private void searchtxt_TextChanged(object sender, EventArgs e)
        {
            Searchproduct($"SELECT * FROM Products WHERE ProductName LIKE '%{searchtxt.Text}%' AND Stock <= lowstock ");
        }

        private void searchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                dataview.Focus();
            }
        }

        private void dataview_KeyDown(object sender, KeyEventArgs e)
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
                }
            }
        }
    }
}

