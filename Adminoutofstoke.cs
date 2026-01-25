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
        private bool sliderbarExpand = true;
        DataTable? productsoutofstock = new DataTable();

        public Adminoutofstoke()
        {
            InitializeComponent();
        }

        private void Slidebartimer_Tick(object sender, EventArgs e)
        {
            if (sliderbarExpand)
            {
                Admindrawerpnl.Width -= 10;
                if (Admindrawerpnl.Width <= 61)
                {
                    sliderbarExpand = false;
                    Slidebartimer.Stop();
                    drawerinnerpanel.Size = new Size(220, 0);
                    panel3.Size = new Size(220, 265);
                }
            }
            else
            {
                Admindrawerpnl.Width += 10;
                if (Admindrawerpnl.Width >= 220)
                {

                    sliderbarExpand = true;
                    Slidebartimer.Stop();
                    drawerinnerpanel.Size = new Size(220, 225);
                    panel3.Size = new Size(220, 40);

                }
            }
        }

        private void MenubtnDrawer_Click(object sender, EventArgs e)
        {
            Slidebartimer.Start();
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

        private void Adminoutofstoke_Load(object sender, EventArgs e)
        {
            loadproducts("SELECT * FROM Products WHERE Stock = 0 ");
        }

        private void LoadProductCards(DataTable productoutofstock)
        {
            Mainpanel.Controls.Clear();

            foreach (DataRow row in productoutofstock.Rows)
            {
                Productcard card = new Productcard();

                int productID = Convert.ToInt32(row["ProductID"]);
                string productName = row["ProductName"].ToString();
                int price = Convert.ToInt32(row["Price"]);
                int minQuantity = Convert.ToInt32(row["lowstock"]);
                int stock = Convert.ToInt32(row["Stock"]);

                Image productImage = Properties.Resources.block_1000dp_FFFFFF;
                card.getproductcarddetais(
                    productID,
                    productName,
                    price,
                    minQuantity,
                    stock,
                    productImage
                );

                card.Margin = new Padding(80, 10, 0, 10);
                Mainpanel.Controls.Add(card);
            }
        }


        void loadproducts(string query)
        {
            productsoutofstock = DatabaseManagement.retrieve(query);
            if (productsoutofstock != null && productsoutofstock.Rows.Count > 0)
            {
                LoadProductCards(productsoutofstock);
            }
            else
            {
                all_stocks_are.Visible = true;

            }



        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
