using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class iniHome : UserControl
    {
        int geser2x = 0;
        public iniHome()
        {
            InitializeComponent();
        }

        private void iniHome_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(geser2x == 1)
            {
                home11.BringToFront();
                geser2x = 0;
            }
            else if(geser2x == 0)
            {
                home21.BringToFront();
                geser2x = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (geser2x == 1)
            {
                home11.BringToFront();
                geser2x = 0;
            }
            else if (geser2x == 0)
            {
                home21.BringToFront();
                geser2x = 1;
            }
        }
    }
}
