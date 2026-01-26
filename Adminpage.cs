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
    public partial class Adminpage : Form
    {

        bool sliderbarExpand = true;

        public Adminpage()
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

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Slidebartimer.Start();

        }

        private void Adminpage_Load(object sender, EventArgs e)
        {
            Pagecalling.loadform(new AdminDashboard(), Mainpanel);
        }



        private void Adminpage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Logoutbutton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void Dashboardbtn_Click(object sender, EventArgs e)
        {
            Pagecalling.loadform(new AdminDashboard(), Mainpanel);
        }

        private void Outofstockbtn_Click(object sender, EventArgs e)
        {
            Adminoutofstoke outofstoke = new Adminoutofstoke();
            outofstoke.Show();
            this.Hide();
        }

        private void Mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void partextitlelb_Click(object sender, EventArgs e)
        {

        }

        private void drawerinnerpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Minquantitybtn_Click(object sender, EventArgs e)
        {
            AdminLowStock adminPage = new AdminLowStock();
            adminPage.Show();
            this.Hide();

        }
    }
}
