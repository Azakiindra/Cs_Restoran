using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Home_Click(object sender, EventArgs e)
        {
            GeserGeser.Location = new Point(1, 27);
            iniHome1.BringToFront();
        }

        private void Foods_Click(object sender, EventArgs e)
        {
            GeserGeser.Location = new Point(1, 138);
            iniFoods1.BringToFront();
        }

        private void Drinks_Click(object sender, EventArgs e)
        {
            GeserGeser.Location = new Point(1, 244);
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            GeserGeser.Location = new Point(1, 355);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iniHome1.BringToFront();
        }
    }
}
