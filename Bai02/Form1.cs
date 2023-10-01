using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {
            Control ct = (Control)sender;
            if (ct.Text.Trim().Length == 0 || !char.IsDigit(ct.Text, ct.Text.Length - 1))
                this.errorProvider1.SetError(txtNumber1, "invalid number");
            else
                this.errorProvider1.Clear();
        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {
            Control ct = (Control)sender;
            if (ct.Text.Trim().Length == 0 || !char.IsDigit(ct.Text, ct.Text.Length - 1))
                this.errorProvider1.SetError(txtNumber1, "invalid number");
            else
                this.errorProvider1.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                int a = Convert.ToInt32(txtNumber1.Text);
                int b = Convert.ToInt32(txtNumber2.Text);
                string c = Convert.ToString(a + b);
                this.txtKetQua.Text = c;
            }
        }

        private void rbtru_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtru.Checked)
            {
                int a = Convert.ToInt32(txtNumber1.Text);
                int b = Convert.ToInt32(txtNumber2.Text);
                string c = Convert.ToString(a - b);
                this.txtKetQua.Text = c;
            }
        }

        private void rbNhan_CheckedChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNumber1.Text);
            int b = Convert.ToInt32(txtNumber2.Text);
            string c = Convert.ToString(a * b);
            this.txtKetQua.Text = c;
        }

        private void rbChia_CheckedChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtNumber1.Text);
            int b = Convert.ToInt32(txtNumber2.Text);
            string c = Convert.ToString((double)a / b);
            this.txtKetQua.Text = c;
        }
    }
}
