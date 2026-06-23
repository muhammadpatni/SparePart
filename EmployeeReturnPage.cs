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
    public partial class EmployeeReturnPage : Form
    {
        public EmployeeReturnPage()
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

        private async void EmployeeReturnPage_Load(object sender, EventArgs e)
        {
            await loadproducts("SELECT * FROM Products");
        }

        async Task loadproducts(string query)
        {
            dataview.Visible = false;
            lbstatus.Visible = true;
            try
            {
                SqlConnection? con = new SqlConnection(DatabaseManagement.getConnectionString());
                DataTable? dt = await Task.Run(() => DatabaseManagement.retrieve(query, con));

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
        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Billingbtn_Click(object sender, EventArgs e)
        {
            Employeepage? emp = new Employeepage();
            emp.Show();
            this.Hide();
        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            LoginPage? login = new LoginPage();
            login.Show();
            this.Hide();

        }

        private void EmployeeReturnPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            else if (e.KeyCode == Keys.Tab && e.Control)
            {
                cartview.Focus();
            }
            else if (e.KeyCode == Keys.I && e.Control)
            {
                invoicenumbertxt.Focus();
            }
            else if (e.KeyCode == Keys.R && e.Control)
            {
                if (cartview.Rows.Count > 0)
                {
                    ConfirmReturn.PerformClick();
                }
                else
                {
                    MessageBox.Show("No products in the return cart!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
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
            else if (e.KeyCode == Keys.F2)
            {
                Returnbtn.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                Savedbillsbtn.PerformClick();
            }
        }

        private void searcchtxt_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Tab && e.Control)
            {
                e.SuppressKeyPress = true;
                cartview.Focus();
            }
            if (e.KeyCode == Keys.I && e.Control)
            {
                e.SuppressKeyPress = true;
                invoicenumbertxt.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                dataview.Focus();
            }
        }

        private void CalculateBill()
        {
            decimal subtotal = 0m;
            foreach (DataGridViewRow row in cartview.Rows)
            {
                object? cellValue = row.Cells[4].Value;
                if (cellValue != null)
                {
                    subtotal += Convert.ToDecimal(cellValue);
                }
            }

            Payablelb.Text = subtotal.ToString("0");
        }

        private async void dataview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dataview.CurrentRow != null)
                {
                    string? id = dataview.CurrentRow.Cells[0].Value.ToString();
                    string? name = dataview.CurrentRow.Cells[1].Value.ToString();
                    string? price = dataview.CurrentRow.Cells[2].Value.ToString();
                    string? stock = dataview.CurrentRow.Cells[3].Value.ToString();

                    Cartandreturn?  cartBox = new Cartandreturn(true, id!, name!, price!, stock!);

                    if (cartBox.ShowDialog() == DialogResult.OK)
                    {
                        string? pName = cartBox.ReturnName;
                        int? pPrice = cartBox.ReturnPrice;
                        int? pQty = cartBox.ReturnQuantity;
                        int? pTotal = cartBox.ReturnTotal;

                        bool productFound = false;

                        foreach (DataGridViewRow row in cartview.Rows)
                        {
                            if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == id)
                            {
                                int? oldQty = Convert.ToInt32(row.Cells[3].Value);
                                int? oldTotal = Convert.ToInt32(row.Cells[4].Value);

                                row.Cells[3].Value = oldQty + pQty;
                                row.Cells[4].Value = oldTotal + pTotal;

                                productFound = true;
                                CalculateBill();
                                break;
                            }
                        }

                        if (!productFound)
                        {
                            cartview.Rows.Add(id, pName, pPrice, pQty, pTotal);
                        }

                        e.Handled = true;
                        searcchtxt.Clear();
                        searcchtxt.Focus();
                        CalculateBill();
                        await loadproducts("SELECT * FROM Products ");
                    }
                }
            }
        }
        void Searchproduct(string query)
        {
            dataview.Visible = false;
            lbstatus.Visible = true;
            try
            {
                SqlConnection? con = new SqlConnection(DatabaseManagement.getConnectionString());
                DataTable? dt = DatabaseManagement.retrieve(query, con);

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

        private void searcchtxt_TextChanged(object sender, EventArgs e)
        {
            Searchproduct($"SELECT * FROM Products WHERE ProductName LIKE '%{searcchtxt.Text}%'");

        }

        private void cartview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cartview.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                DiscardItem(e.RowIndex);
            }
        }

        private void DiscardItem(int rowIndex)
        {
            try
            {
                string? pID = cartview.Rows[rowIndex].Cells[0].Value.ToString();
                int? pQty = Convert.ToInt32(cartview.Rows[rowIndex].Cells[3].Value);
                cartview.Rows.RemoveAt(rowIndex);
                CalculateBill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cartview_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (cartview.CurrentRow != null)
                {
                    e.Handled = true;

                    int rowIndex = cartview.CurrentRow.Index;
                    DiscardItem(rowIndex);
                }
            }
        }

        private async void ConfirmReturn_Click(object sender, EventArgs e)
        {
            if (cartview.Rows.Count==0)
            {
            MessageBox.Show("No products in the return cart!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            }
            else if (string.IsNullOrWhiteSpace(invoicenumbertxt.Text))
            {
                MessageBox.Show("Please enter the invoice number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                invoicenumbertxt.Focus();
                return;
            }

            string? query = $"SELECT COUNT(*) FROM Invoices WHERE InvoiceNumber = {invoicenumbertxt.Text} AND InvoiceNumber NOT IN ( SELECT DISTINCT InvoiceNumber FROM Credit );";
             SqlConnection? con = new SqlConnection(DatabaseManagement.getConnectionString());

            if (!DatabaseManagement.IsInvoiceAvailable(query, con))
            {
                MessageBox.Show("Invoice number not found! Please check and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                invoicenumbertxt.Focus();
                return;
            }

            foreach (DataGridViewRow row in cartview.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[3].Value != null)
                {
                    int? productID = Convert.ToInt32(row.Cells[0].Value);
                    int? quantity = Convert.ToInt32(row.Cells[3].Value);
                    string? query1 = $"UPDATE Products SET Stock = Stock + {quantity} WHERE ProductID = {productID}";
                    SqlConnection? con1 = new SqlConnection(DatabaseManagement.getConnectionString());
                    DatabaseManagement.edit(query1, con1);
                }
            }
            string? query2 = $"UPDATE Invoices SET Grandtotal = Grandtotal - {Payablelb.Text} where InvoiceNumber={invoicenumbertxt.Text}";
            SqlConnection? con2 = new SqlConnection(DatabaseManagement.getConnectionString());
            DatabaseManagement.edit(query2, con2);
            cartview.Rows.Clear();
            invoicenumbertxt.Clear();
            Payablelb.Text = "0.0";
            searcchtxt.Focus();
            await loadproducts("SELECT * FROM Products");
            MessageBox.Show("Products are successfully returned", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Savedbillsbtn_Click(object sender, EventArgs e)
        {
            Employeesavedbills? savedbills = new Employeesavedbills();
            savedbills.Show();
            this.Hide();
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            EmployeeReturnPage? returnPage = new EmployeeReturnPage();
            returnPage.Show();
            this.Hide();
        }

        private void inovicenumbertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inovicenumbertxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
