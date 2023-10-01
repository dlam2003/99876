using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class PTBN : Form
    {
        private bool isDataValid = false;
        private void ValidateData()
        {
            // Kiểm tra dữ liệu nhập vào
            
            if (string.IsNullOrEmpty(txtA.Text) || string.IsNullOrEmpty(txtB.Text))
            {
                errorProvider1.SetError(btnGiai, "Vui lòng nhập đủ dữ liệu.");
                isDataValid = false;
            }
            else
            {
                errorProvider1.Clear();
                isDataValid = true;
                this.btnGiai.Enabled = true;
            }
        }
        public PTBN()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 2 nút xóa và giải bị mờ
            btnClear.Enabled = false;
            btnGiai.Enabled = false;
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            //kt entered the data
            Control ct = (Control)sender;
            if (ct.Text.Trim().Length == 0 || !char.IsDigit(ct.Text, ct.Text.Length - 1))
                this.errorProvider1.SetError(txtA, "invalid number");
            else
            {
                btnGiai.Enabled = true;
                this.errorProvider1.Clear();
            } 
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            Control ct = (Control)sender;
            if (ct.Text.Trim().Length == 0 || !char.IsDigit(ct.Text, ct.Text.Length - 1))
                this.errorProvider1.SetError(txtB, "invalid number");
            else
                this.errorProvider1.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // xóa dữ liệu ở các ô
            this.txtA.Clear();
            this.txtB.Clear();
            this.txtEquation.Clear();
            // đặt con trỏ vào ô nhập A
            txtA.Focus();
            // sau khi xoá nút xóa bị lu mờ
            btnClear.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?","Exit",MessageBoxButtons.OK,MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            ValidateData();

            if (isDataValid)
            {
                int a = Convert.ToInt32(txtA.Text);
                int b = Convert.ToInt32(txtB.Text);

                if (a == 0 && b != 0)
                    this.txtEquation.Text = string.Format("PT Vô nghiệm");

                if (a == 0 && b == 0)
                    this.txtEquation.Text = string.Format("PT Vô số nghiệm");

                if (a != 0 && b != 0)
                    this.txtEquation.Text = string.Format("PT có 1 nghiệm");

                this.btnGiai.Enabled = false;
                this.btnClear.Enabled = true;
            }
        }
    }
}
