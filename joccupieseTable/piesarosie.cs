using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace joccupieseTable
{
    public partial class piesarosie : UserControl
    {
        public piesarosie()
        {
            InitializeComponent();
        }
        public int ismd = 0;
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = 0;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == 1)
            {
                Left += e.X;
                Top += e.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = 1;
        }
    }
}
