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
    public partial class Productcard : UserControl
    {
        int productID, price, minquantity, stock;
        string productName; 
        Image productImage;

        public Productcard()
        {
            InitializeComponent();

        }

        public void getproductcarddetais(int productID, string productName, int price, int minquantity, int stock, Image productImage)
        {
            this.productID = productID;
            this.productName = productName;
            this.price = price;
            this.minquantity = minquantity;
            this.stock = stock;
            this.productImage = productImage;
        }

        private void Productcard_Load(object sender, EventArgs e)
        {

            namelb.Text = productName;
            Pricelb.Text = "Rs. " + price.ToString();
            quantitylb.Text = stock.ToString()+" Pcs";
            Minquantitylb.Text = "Min: " + minquantity.ToString();
            Bigicon.Image = productImage;

        }
    }
}
