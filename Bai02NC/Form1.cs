using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02NC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbItalian_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\quoc-ky-chinh-thuc-cua-cong-hoa-y.jpg");
        }

        private void rbVn_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\VNFlag.png");
        }

        private void rbUSA_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\Flag_of_the_United_States.svg.png");
        }

        private void rbPhilip_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(Application.StartupPath + "\\Resources\\tải xuống.png");
        }
    }
}
