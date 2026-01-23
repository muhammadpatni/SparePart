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
    public partial class Employeepage : Form
    {

        bool sliderbarExpand =true;

        public Employeepage()
        {
            InitializeComponent();
        }

        private void Slidebartimer_Tick(object sender, EventArgs e)
        {
            if (sliderbarExpand)
            {
                Employeedrawerpnl.Width -= 10;
                if (Employeedrawerpnl.Width <= 80)
                {
                    sliderbarExpand = false;
                    Slidebartimer.Stop();
                }
            }
            else
            {
                Employeedrawerpnl.Width += 10;
                if (Employeedrawerpnl.Width >= 220)
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
    }
}
