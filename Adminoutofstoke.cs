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

    public partial class Adminoutofstoke : Form
    {
        DataTable? productsoutofstock = new DataTable();

        public Adminoutofstoke()
        {
            InitializeComponent();

            typeof(DataGridView).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetProperty,
                null, dataview, new object[] { true });
        }

        

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            Adminpage adminPage = new Adminpage();
            adminPage.Show();
            this.Hide();
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private async void Adminoutofstoke_Load(object sender, EventArgs e)
        {
            await loadproducts("SELECT * FROM Products WHERE Stock = 0");
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

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Minquantitybtn_Click(object sender, EventArgs e)
        {
            AdminLowStock adminPage = new AdminLowStock();
            adminPage.Show();
            this.Hide();
        }

        private void Outofstockbtn_Click(object sender, EventArgs e)
        {

        }

        private void Adminoutofstoke_KeyDown(object sender, KeyEventArgs e)
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
                Minquantitybtn.PerformClick();
            }
            else if (e.KeyCode == Keys.F && e.Control)
            {
                searcchtxt.Focus();
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

        private void searcchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                dataview.Focus();
            }
        }

        private void searcchtxt_TextChanged(object sender, EventArgs e)
        {
            Searchproduct($"SELECT * FROM Products WHERE ProductName LIKE '%{searcchtxt.Text}%' AND Stock <= lowstock ");
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
    }
}
