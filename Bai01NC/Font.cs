using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01NC
{
    public partial class Font : Form
    {
        public Font()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you Sure","Exit the app",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void rbTimes_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTimes.Checked)
            {
                txtText.Font = new System.Drawing.Font("Time New Roman", 28);
            }
        }

        private void rbArial_CheckedChanged(object sender, EventArgs e)
        {
            if( rbArial.Checked)
            {
                txtText.Font = new System.Drawing.Font("Arial", 28);
            }
        }

        private void rbtahoma_CheckedChanged(object sender, EventArgs e)
        {
            if( (rbtahoma.Checked) ) 
            {
                txtText.Font = new System.Drawing.Font("Tahoma", 28);
            }
        }

        private void rbCourier_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCourier.Checked)
                txtText.Font = new System.Drawing.Font("Courier New", 28);
        }
    }
}
