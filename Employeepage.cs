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

        private void CalculateBill()
        {
            decimal subtotal = 0m;
            decimal discount = 0m;

            foreach (DataGridViewRow row in cartview.Rows)
            {
                //if (row.IsNewRow) continue; 

                object cellValue = row.Cells[3].Value;
                if (cellValue != null)
                {
                    subtotal += Convert.ToDecimal(cellValue);
                }
            }

           subtotallb.Text ="RS "+ subtotal.ToString("0.00");

            if (!string.IsNullOrWhiteSpace(discounttxt.Text))
            {
                decimal.TryParse(discounttxt.Text, out discount);
            }

            decimal payable = subtotal - discount;
            if (payable < 0) payable = 0;

            Payablelb.Text = payable.ToString("0.00");
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

        private void Employeepage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else if(e.KeyCode==Keys.Tab && e.Control)
            {
                cartview.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                dataview.Focus();
            }
            else if (e.KeyCode == Keys.X && (!searcchtxt.Focused))
            {
                Logoutbutton.PerformClick();
            }
            else if (e.KeyCode == Keys.F1)
            {
                Returnbtn.PerformClick();
            }
            else if (e.KeyCode == Keys.F && e.Control)
            {
                searcchtxt.Focus();
            }

        }

        private void searcchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                dataview.Focus();
            }
            else if (e.KeyCode == Keys.Tab && e.Control)
            {
                e.SuppressKeyPress = true;
                cartview.Focus();
            }
        }

        private void cartview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

                    Cartandreturn cartBox = new Cartandreturn(id, name, price, stock);

                    if (cartBox.ShowDialog() == DialogResult.OK)
                    {
                        string pName = cartBox.ReturnName;
                        int pPrice = cartBox.ReturnPrice;
                        int pQty = cartBox.ReturnQuantity;
                        int pTotal = cartBox.ReturnTotal;

                        bool productFound = false;

                        foreach (DataGridViewRow row in cartview.Rows)
                        {
                            if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == pName)
                            {
                                int oldQty = Convert.ToInt32(row.Cells[2].Value);
                                int oldTotal = Convert.ToInt32(row.Cells[3].Value);

                                row.Cells[2].Value = oldQty + pQty;
                                row.Cells[3].Value = oldTotal + pTotal;
                                CalculateBill();
                                productFound = true;
                                break; 
                            }
                        }

                        if (!productFound)
                        {
                            cartview.Rows.Add(pName, pPrice, pQty, pTotal);
                            CalculateBill();
                            e.Handled = true;
                            await loadproducts("SELECT * FROM Products WHERE Stock >0");
                            searcchtxt.Clear();
                            searcchtxt.Focus();
                        }

                    }
                }
            }
        }
    }
    
}
