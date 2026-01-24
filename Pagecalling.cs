using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SparePart
{
    internal class Pagecalling
    {
        public static void loadform(object Form, Panel panelmain)
        {


            if (panelmain.Controls.Count > 0)
            {
                panelmain.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelmain.Controls.Add(f);
            panelmain.Tag = f;
            f.Show();
        }
    }
}
