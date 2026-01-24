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
                }
            }
            else
            {
                Admindrawerpnl.Width += 10;
                if (Admindrawerpnl.Width >= 220)
                {
                    sliderbarExpand = true;
                    Slidebartimer.Stop();
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
    }
}
