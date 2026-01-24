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
    }
}
