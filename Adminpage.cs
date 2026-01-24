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
                if (Admindrawerpnl.Width <= 55)
                {
                    sliderbarExpand = false;
                    Slidebartimer.Stop();
                    drawerinnerpanel.Size = new Size(220, 45);
                }
            }
            else
            {
                Admindrawerpnl.Width += 10;
                if (Admindrawerpnl.Width >= 220)
                {
                    sliderbarExpand = true;
                    Slidebartimer.Stop();
                    drawerinnerpanel.Size = new Size(220, 202);
                }
            }
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Slidebartimer.Start();
        }

        private void Admindrawerpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Adminpage_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
