using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07NC
{
    public partial class trackbar : Form
    {
        public trackbar()
        {
            InitializeComponent();
        }

        private void trackbar_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void red_Scroll(object sender, EventArgs e)
        {
            lbred.Text = "R = " + red.Value.ToString();
            color.BackColor = Color.Red;
        }
        private void green_Scroll(object sender, EventArgs e)
        {
            lbGreen.Text = "G = " + green.Value.ToString();
            color.BackColor = Color.Green;
        }

        private void Blue_Scroll(object sender, EventArgs e)
        {
            lbblue.Text = "B = " + Blue.Value.ToString();
            color.BackColor = Color.Blue;
        }
    }
}
