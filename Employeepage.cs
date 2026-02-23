using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SparePart
{
    public partial class Employeepage : Form
    {
        DataTable? credit = null, invoices = null;
        public Employeepage()
        {
            InitializeComponent();
        }
        public Employeepage(DataTable credit, DataTable invoices)
        {
            InitializeComponent();
            this.credit = credit;
            this.invoices = invoices;
        }

        DataTable? products = new DataTable();

        void loadsavedbills()
        {
            customernametxt.Text = invoices.Rows[0]["CustomerName"].ToString();
            Invoicelb.Text = "#PARTEX " + invoices.Rows[0]["InvoiceNumber"].ToString();
            Datetimelb.Text = invoices.Rows[0]["Date"].ToString();
            discounttxt.Text = invoices.Rows[0]["Discount"].ToString();
            foreach (DataRow row in credit.Rows)
            {
                cartview.Rows.Add(row["ProductID"], row["ProductName"], row["Price"], row["Quantity"], row["Total"]);
            }
            CalculateBill();
        }



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
            Datetimelb.Text = currentDate;
        }

        private async void Employeepage_Load(object sender, EventArgs e)
        {
            // Receipt.PrinterSettings.PrinterName = "EPSON TM-T20";

            Receipt.DefaultPageSettings.PaperSize =
                new System.Drawing.Printing.PaperSize("Custom", 315, 1000);

            if (credit != null && invoices != null)
            {
                loadsavedbills();
                DateTimeLoad();
                await loadproducts("SELECT * FROM Products WHERE Stock > 0");
                return;
            }
            DateTimeLoad();
            await loadproducts("SELECT * FROM Products WHERE Stock > 0");
            getInvoiceNumber();


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
        private void CalculateBill()
        {
            decimal subtotal = 0m;
            decimal discount = 0m;

            foreach (DataGridViewRow row in cartview.Rows)
            {
                object cellValue = row.Cells[4].Value;
                if (cellValue != null)
                {
                    subtotal += Convert.ToDecimal(cellValue);
                }
            }

            subtotallb.Text = "RS " + subtotal.ToString("0.00");

            if (!string.IsNullOrWhiteSpace(discounttxt.Text))
            {
                decimal.TryParse(discounttxt.Text, out discount);
            }

            decimal payable = subtotal - discount;
            if (payable < 0) payable = 0;

            Payablelb.Text = payable.ToString("0");
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
                SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
                DataTable dt = DatabaseManagement.retrieve(query, con);

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
            else if (e.KeyCode == Keys.Tab && e.Control)
            {
                cartview.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                dataview.Focus();
            }
            else if (e.KeyCode == Keys.C && e.Alt)
            {
                customernametxt.Focus();
            }
            else if (e.KeyCode == Keys.X && (!searcchtxt.Focused))
            {
                Logoutbutton.PerformClick();
            }
            else if (e.KeyCode == Keys.S && e.Control)
            {
                Savebtn.PerformClick();
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
            else if (e.KeyCode == Keys.F && e.Control)
            {
                searcchtxt.Clear();
                searcchtxt.Focus();

            }
            else if (e.KeyCode == Keys.D && e.Control)
            {
                discounttxt.Focus();
                discounttxt.SelectAll();
            }
            else if (e.KeyCode == Keys.F1)
            {
                Returnbtn.PerformClick();
            }

        }
        private void searcchtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab && e.Control)
            {
                e.SuppressKeyPress = true;
                cartview.Focus();
            }
            else if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                dataview.Focus();
            }
            else if (e.KeyCode == Keys.D && e.Control)
            {
                e.SuppressKeyPress = true;
                discounttxt.Focus();
                discounttxt.SelectAll();
            }
        }

        private void cartview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cartview.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0)
            {
                DiscardItem(e.RowIndex);
            }
        }

        private async void DiscardItem(int rowIndex)
        {
            try
            {
                string pID = cartview.Rows[rowIndex].Cells[0].Value.ToString();
                int pQty = Convert.ToInt32(cartview.Rows[rowIndex].Cells[3].Value);
                string query = "UPDATE Products SET Stock = Stock + " + pQty + " WHERE ProductID = '" + pID + "'";
                SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
                DatabaseManagement.edit(query, con);
                cartview.Rows.RemoveAt(rowIndex);
                CalculateBill();
                await loadproducts("SELECT * FROM Products WHERE Stock > 0");
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

                    Cartandreturn cartBox = new Cartandreturn(false, id, name, price, stock);

                    if (cartBox.ShowDialog() == DialogResult.OK)
                    {
                        string pName = cartBox.ReturnName;
                        int pPrice = cartBox.ReturnPrice;
                        int pQty = cartBox.ReturnQuantity;
                        int pTotal = cartBox.ReturnTotal;

                        bool productFound = false;

                        foreach (DataGridViewRow row in cartview.Rows)
                        {
                            if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == id)
                            {
                                int oldQty = Convert.ToInt32(row.Cells[3].Value);
                                int oldTotal = Convert.ToInt32(row.Cells[4].Value);

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
                        await loadproducts("SELECT * FROM Products WHERE Stock > 0");
                    }
                }
            }

        }


        private void discounttxt_TextChanged(object sender, EventArgs e)
        {
            decimal subtotal = 0m;
            decimal discount = 0m;

            string subtotalText = subtotallb.Text.Replace("RS", "").Trim();
            decimal.TryParse(subtotalText, out subtotal);

            decimal.TryParse(discounttxt.Text, out discount);

            decimal payable = subtotal - discount;
            if (payable < 0) payable = 0;

            Payablelb.Text = payable.ToString("0");
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

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            EmployeeReturnPage employeeReturnPage = new EmployeeReturnPage();
            employeeReturnPage.Show();
            this.Hide();
        }

        public void savebill()
        {
            try
            {
                string rawInvoice = Invoicelb.Text;

                long invoiceNumber = long.Parse(rawInvoice.ToUpper().Replace("#PARTEX", "").Trim());
                foreach (DataGridViewRow row in cartview.Rows)
                {
                    int pID = Convert.ToInt32(row.Cells[0].Value);
                    string pName = row.Cells[1].Value.ToString();
                    int price = Convert.ToInt32(row.Cells[2].Value);
                    int qty = Convert.ToInt32(row.Cells[3].Value);
                    int total = Convert.ToInt32(row.Cells[4].Value);

                    string creditQuery = $"INSERT INTO Credit (InvoiceNumber, ProductID, ProductName,price, Quantity, Total) VALUES ({invoiceNumber}, {pID}, '{pName}','{price}', {qty}, {total})";
                    SqlConnection conn = new SqlConnection(DatabaseManagement.getConnectionString());
                    DatabaseManagement.edit(creditQuery, conn);
                }

                string custName = customernametxt.Text;
                long grandTotal = long.Parse(Payablelb.Text);

                long discount = 0;
                if (!string.IsNullOrEmpty(discounttxt.Text))
                {
                    discount = long.Parse(discounttxt.Text);
                }
                string Date = Datetimelb.Text;


                string invoiceQuery = $"INSERT INTO Invoices (InvoiceNumber,Date, CustomerName, Discount, Grandtotal) VALUES ({invoiceNumber}, '{Date}','{custName}', {discount}, {grandTotal})";
                SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
                DatabaseManagement.edit(invoiceQuery, con);
                cartview.Rows.Clear();
                customernametxt.Clear();
                discounttxt.Clear();
                subtotallb.Text = "Rs 0.0";

                MessageBox.Show("Bill saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving bill: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void getInvoiceNumber()
        {
            string query = "SELECT * from InvoiceNumber";
            long invoice = 0;
            using (SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString()))
            {
                con.Open();
                invoice = DatabaseManagement.getInvoice(query, con);
            }
            Invoicelb.Text = "#PARTEX " + invoice.ToString();
        }

        void updateInvoiceNumber()
        {
            long maxinvoice = 0;
            using (SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString()))
            {
                con.Open();
                maxinvoice = Convert.ToInt64(
          DatabaseManagement.getInvoice("SELECT ISNULL(MAX(InvoiceNumber), 0) FROM InvoiceNumber;", con));
            }
            long invoiceNumber = long.Parse(Invoicelb.Text.ToUpper().Replace("#PARTEX", "").Trim());

            if (maxinvoice <= invoiceNumber)
            {
                string query = "UPDATE InvoiceNumber SET InvoiceNumber = InvoiceNumber + 1";
                using (SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString()))
                {
                    con.Open();
                    DatabaseManagement.edit(query, con);
                }
            }
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (cartview.Rows.Count == 0)
            {
                MessageBox.Show("Cart is empty. Please add items to the cart before saving the bill.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(customernametxt.Text))
            {
                MessageBox.Show("Please enter the customer's name before saving the bill.", "Customer Name Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                customernametxt.Focus();
                return;
            }
            else
            {
                savebill();
                updateInvoiceNumber();
                getInvoiceNumber();
                Payablelb.Text = "0.0";

            }
        }

        private void Billingbtn_Click(object sender, EventArgs e)
        {
            Employeepage employeepage = new Employeepage();
            employeepage.Show();
            this.Hide();
        }

        private void Savedbillsbtn_Click(object sender, EventArgs e)
        {
            Employeesavedbills employeesavedbills = new Employeesavedbills();
            employeesavedbills.Show();
            this.Hide();
        }

        private void drawerinnerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Printbtn_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = Receipt;
            printPreviewDialog1.ShowDialog();

        }

        private void Receipt_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image image = Properties.Resources.receiptpic;
            e.Graphics.DrawImage(image, 70, 20, image.Width, image.Height);
            e.Graphics.DrawString(" Sell Receipt  ", new System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(100, 80));
            e.Graphics.DrawString("Invoice# : " + Invoicelb.Text.Replace("#", ""), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, 120));
            e.Graphics.DrawString("Inv Date/Time : " + DateTime.Now.ToString("dd-MM-yyyy") + "  " + DateTime.Now.ToShortTimeString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, 145));
            e.Graphics.DrawString("Customer Name :  " + customernametxt.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(10, 170));
            e.Graphics.DrawString("---------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 200));
            e.Graphics.DrawString("Product Name", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(0, 215));
            e.Graphics.DrawString("Price", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(135, 215));
            e.Graphics.DrawString("Quantity", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(195, 215));
            e.Graphics.DrawString("Total", new Font("Arial", 7, FontStyle.Bold), Brushes.Black, new Point(265, 215));
            e.Graphics.DrawString("---------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, 220));
            int y = 240;
            for (int i = 0; i < cartview.Rows.Count; i++)
            {
                e.Graphics.DrawString(cartview.Rows[i].Cells[1].Value.ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(0, y));
                e.Graphics.DrawString(cartview.Rows[i].Cells[2].Value.ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(135, y));
                e.Graphics.DrawString(cartview.Rows[i].Cells[3].Value.ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(210, y));
                e.Graphics.DrawString(cartview.Rows[i].Cells[4].Value.ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(270, y));
                if (i < cartview.Rows.Count - 1)
                {
                    e.Graphics.DrawString(".....................................................................", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(0, y + 5));
                }
                y += 25;
            }
            e.Graphics.DrawString("---------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, y-20));
            e.Graphics.DrawString("# OF ITEMS : " + cartview.Rows.Count.ToString(), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, y));
            e.Graphics.DrawString("SUBTOTAL : " + subtotallb.Text.Replace(".0",""), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(140, y + 40));
            e.Graphics.DrawString("DISCOUNT : "+discounttxt.Text, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(140, y + 60));
            e.Graphics.DrawString("TOTAL : " +Payablelb.Text.Replace(".0",""), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(140, y + 80));
            e.Graphics.DrawString("CASH RECEICED : " + Payablelb.Text.Replace(".0", ""), new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(140, y + 100));
            e.Graphics.DrawString("NET BALANCE : 0 ", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(140, y + 120));
            e.Graphics.DrawString("------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, y + 130));
            //e.Graphics.DrawString("Please check goods & expiry date.", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, y + 140));
            //e.Graphics.DrawString("No responsibility after delivery.", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(0, y + 160));
            //e.Graphics.DrawString("THANKS", new Font("Arial", 9, FontStyle.Regular), Brushes.Black, new Point(330, y + 160));
            //e.Graphics.DrawString("------------------------------------------------------------------------", new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(0, y + 180));
            e.Graphics.DrawString("Software By MUHAMMAD PATNI 0316-2406968 Muhammad.", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(0, y + 150));
            e.Graphics.DrawString("SHOP PTCL        32435482        32446329", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(0, y + 170));

        }
    }

}
