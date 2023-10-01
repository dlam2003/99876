using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace bai01WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ErrorProvider error = new ErrorProvider();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Xóa thông tin
            this.txtYourName.Clear();
            this.txtYearofB.Clear();

            txtYourName.Focus();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string Name = txtYourName.Text;
            int currenyear = DateTime.Now.Year;
            int age = currenyear - Convert.ToInt32(txtYearofB.Text);

            string message = $"Tên: {Name}\nTuổi: {age}";
            MessageBox.Show(message, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult reasult = MessageBox.Show("are you sure","Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(reasult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void txtYourName_Leave(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control.Text.Trim().Length == 0)
                this.errorProvider1.SetError(txtYourName, "enter the Name");
            else
                this.errorProvider1.Clear();
        }

        private void txtYearofB_TextChanged(object sender, EventArgs e)
        {
            Control control1 = sender as Control;
            if(control1.Text.Trim().Length == 0 || !char.IsDigit(control1.Text,control1.Text.Length - 1))
            {
                this.errorProvider1.SetError(txtYearofB,"not invaild number");
            }
            else
                this.errorProvider1.Clear(); 
        }
    }
}
