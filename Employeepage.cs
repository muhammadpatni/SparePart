using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparePart
{
    public partial class Employeepage : Form
    {
        public Employeepage()
        {
            InitializeComponent();
        }
        DataTable? products = new DataTable();


        private void SetGridColumnLayout()
        {
            dataview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dataview.Columns.Count > 1)
            {
                foreach (DataGridViewColumn col in dataview.Columns)
                {
                    col.FillWeight = 100;
                }
                dataview.Columns[1].FillWeight = 350;
            }
        }

        private void DateTimeLoad()
        {
            string currentDate = DateTime.Now.ToString("dd-MM-yyyy");
            string currentTime = DateTime.Now.ToString("hh:mm:ss tt");

            Datetimelb.Text = currentDate + "  " + currentTime;
        }

        private async void Employeepage_Load(object sender, EventArgs e)
        {
            DateTimeLoad();
            await loadproducts("SELECT * FROM Products WHERE Stock > 0");

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
                    products = dt;
                    dataview.DataSource = products;
                    SetGridColumnLayout();
                    dataview.Visible = true;
                    lbstatus.Visible = false;
                }
                else
                {
                    lbstatus.Text = "All products are out of stock!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void Outofstokelb1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {

        }

        private void Cartpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Billingbtn_Click(object sender, EventArgs e)
        {

        }

        private void Employeepage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }

        private void searcchtxt_TextChanged(object sender, EventArgs e)
        {
            Searchproduct($"SELECT * FROM Products WHERE ProductName LIKE '%{searcchtxt.Text}%' AND Stock > 0 ");

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
                    products = dt;
                    dataview.DataSource = products;
                    dataview.Visible = true;
                    lbstatus.Visible = false;
                }
                else
                {
                    lbstatus.Text = "All products are out of stock!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
