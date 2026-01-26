using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SparePart
{
    public partial class Updateproductform : Form
    {
        private bool newproductpage;
        private string productid;
        public Updateproductform(bool newproductpage)
        {
            InitializeComponent();
            this.newproductpage = newproductpage;
        }
        bool isvalid()
        {

            if (productnametxt.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Product Name", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productnametxt.Focus();
                handletextboxes();
                return false;
            }
            else if (pricetxt.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Price", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pricetxt.Focus();
                handletextboxes();
                return false;
            }
            else if (stocktxt.Text.Trim() == "")
            {
                MessageBox.Show("Please select Stock", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stocktxt.Focus();
                handletextboxes();
                return false;
            }
            else if (lowstocktxt.Text.Trim() == "")
            {
                MessageBox.Show("Please select Lowstock", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lowstocktxt.Focus();
                handletextboxes();
                return false;
            }
            else if (!int.TryParse(pricetxt.Text, out int number))
            {
                MessageBox.Show("Please enter valid price", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pricetxt.Focus();
                handletextboxes();
                return false;
            }
            else if (!int.TryParse(stocktxt.Text, out int number1))
            {
                MessageBox.Show("Please enter valid stock", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stocktxt.Focus();
                handletextboxes();
                return false;
            }
            else if (!int.TryParse(lowstocktxt.Text, out int number2))
            {
                MessageBox.Show("Please enter valid low stock", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lowstocktxt.Focus();
                handletextboxes();
                return false;
            }
            return true;
        }

        void cleartextboxes()
        {
            productnametxt.Text = "";
            pricetxt.Text = "";
            stocktxt.Text = "";
            lowstocktxt.Text = "";
            productnametxt.Focus();
        }
        public void settextboxes(string id, string productname, string price, string stock, string lowstock)
        {
            productid = id;
            productnametxt.Text = productname;
            pricetxt.Text = price;
            stocktxt.Text = stock;
            lowstocktxt.Text = lowstock;
        }
        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            if (newproductpage)
            {
                if (isvalid())
                {
                    string query = $"INSERT INTO Products (ProductName, Price, Stock, lowstock) VALUES ('{productnametxt.Text.Trim()}', {pricetxt.Text.Trim()}, {stocktxt.Text.Trim()}, {lowstocktxt.Text.Trim()})";
                    int result = DatabaseManagement.edit(query);
                    if (result > 0)
                    {
                        MessageBox.Show("Product added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    cleartextboxes();
                }
            }
            else
            {
                if (isvalid())
                {
                    string query = $"UPDATE Products SET ProductName = '{productnametxt.Text.Trim()}', Price = {pricetxt.Text.Trim()}, Stock = {stocktxt.Text.Trim()}, lowstock = {lowstocktxt.Text.Trim()} WHERE ProductID = {productid.Trim()}";
                    int result = DatabaseManagement.edit(query);
                    if (result > 0)
                    {
                        MessageBox.Show("Product updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
        }

        private void Updateproductform_Load(object sender, EventArgs e)
        {
            if (newproductpage)
            {
                Pagetitlelb.Text = "Add New Product";
                Discardbtn.Text = "Cancel";
                Confirmbtn.Text = "Add Product";
            }
            productnametxt.Focus();

        }

        private void Discardbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Updateproductform_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                handletextboxes();
                Confirmbtn.PerformClick();
            }

        }

        void handletextboxes()
        {
            productnametxt.Text = productnametxt.Text.Trim();
            pricetxt.Text = pricetxt.Text.Trim();
            stocktxt.Text = stocktxt.Text.Trim();
            lowstocktxt.Text = lowstocktxt.Text.Trim();
        }

        private void productnametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                pricetxt.Focus();
            }
        }

        private void pricetxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                stocktxt.Focus();
            }
        }

        private void stocktxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                lowstocktxt.Focus();
            }
        }

        private void lowstocktxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                productnametxt.Focus();
            }
        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Updateproductform_Shown(object sender, EventArgs e)
        {
            productnametxt.Focus();
        }

        private void stocktxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
