using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Formater : Form
    {
        public Formater()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control ct = (Control)sender;
            if (ct.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtEnterName, "enter the data");
            else
            {
                this.errorProvider1.Clear();
                this.lblLapTrinh.Text = txtEnterName.Text;
                this.lblLapTrinh.Enabled = true;
            }
        }

        private void rbRed_CheckedChanged(object sender, EventArgs e)
        {
            if(rbRed.Checked)
            {
                this.lblLapTrinh.ForeColor = Color.Red;
            }
        }

        private void rbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if( rbGreen.Checked)
            {
                this.lblLapTrinh.ForeColor = Color.Green;
            }
        }

        private void rbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBlue.Checked)
                this.lblLapTrinh.ForeColor = Color.Blue;
        }

        private void rbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if(rbBlack.Checked)
                this.lblLapTrinh.ForeColor = Color.Black;
        }

        private void CbBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Bold);
        }

        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Italic);
        }

        private void cbUnderLine_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Underline);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are youy sure?", "Exit the application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
