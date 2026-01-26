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
        private bool sliderbarExpand = true;
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

        private void MenubtnDrawer_Click(object sender, EventArgs e)
        {
            dataview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            Slidebartimer.Start();
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

        private void FinishAnimation()
        {
            dataview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            drawerinnerpanel.Size = new Size(220, sliderbarExpand ? 225 : 0);
            panel3.Size = new Size(220, sliderbarExpand ? 40 : 265);
        }

        private void Slidebartimer_Tick(object sender, EventArgs e)
        {
            dataview.SuspendLayout();
            if (sliderbarExpand)
            {
                Admindrawerpnl.Width -= 10;
                if (Admindrawerpnl.Width <= 61)
                {
                    sliderbarExpand = false;
                    Slidebartimer.Stop();
                    FinishAnimation();
                }
            }
            else
            {
                Admindrawerpnl.Width += 10;
                if (Admindrawerpnl.Width >= 220)
                {

                    sliderbarExpand = true;
                    Slidebartimer.Stop();
                    FinishAnimation();

                }
            }
            dataview.ResumeLayout();
        }

        private async void AdminLowStock_Click(object sender, EventArgs e)
        {
            await loadproducts("SELECT * FROM Products WHERE Stock = 0 ");

        }
    }
}
