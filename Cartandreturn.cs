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
    public partial class Cartandreturn : Form
    {
        int price, stock;
        string id, name;
        public int ReturnQuantity { get; private set; }
        public int ReturnTotal { get; private set; }
        public string ReturnName { get { return name; } }
        public int ReturnPrice { get { return price; } }

        TextBox qtyTextBox;

        public Cartandreturn(string id, string name, string price, string stock)
        {
            InitializeComponent();
            this.id = id;
            this.price = int.Parse(price);
            this.stock = int.Parse(stock);
            this.name = name;

        }
        void loadproductdetails()
        {
            Productnamelb.Text = name;
            Pricetxt.Text = "Price : " + price.ToString();
            Instocklb.Text = "In Stock : " + stock.ToString();
            totallb.Text = "Total : " + price.ToString();
        }

        private void Cartandreturn_Load(object sender, EventArgs e)
        {
            //quantitycount.Maximum = stock;
            loadproductdetails();
            this.BeginInvoke((Action)(() =>
            {
                quantitycount.Focus();
                quantitycount.Select(0, quantitycount.Text.Length);
            }));
            qtyTextBox = quantitycount.Controls.OfType<TextBox>().FirstOrDefault();

            if (qtyTextBox != null)
            {
                qtyTextBox.TextChanged += QtyTextBox_TextChanged;
            }
        }

        private void QtyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(qtyTextBox.Text, out decimal qty))
            {
                if (qty < 1) qty = 1;
                if (qty > stock) qty = stock;

                quantitycount.Value = qty;
                totalcalculation();
            }
        }


        void totalcalculation()
        {
            int quantity = int.Parse(quantitycount.Value.ToString());
            int total = price * quantity;
            totallb.Text = "Total : " + total.ToString();
        }

        void databaseupdate()
        {
            int quantity = int.Parse(quantitycount.Value.ToString());
            int newstock = stock - quantity;
            string query = $"UPDATE Products SET Stock = {newstock} WHERE ProductID = {id}";
            DatabaseManagement.edit(query);
        }

        private void quantitycount_ValueChanged(object sender, EventArgs e)
        {
            if (quantitycount.Value > stock)
            {
                quantitycount.Value = stock;
            }
            else if (quantitycount.Value < 1)
            {
                quantitycount.Value = 1;
            }
            totalcalculation();
        }

        private void ConfirmAddbtn_Click(object sender, EventArgs e)
        {
            ReturnQuantity = int.Parse(quantitycount.Value.ToString());
            ReturnTotal = price * ReturnQuantity;
            databaseupdate();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Cartandreturn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Cancelbtn.PerformClick();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                ConfirmAddbtn.PerformClick();
            }
        }
    }
}
