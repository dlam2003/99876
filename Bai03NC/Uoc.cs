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

namespace Bai03NC
{
    public partial class Uoc : Form
    {
        public Uoc()
        {
            InitializeComponent();
        }

        public void Enterdata(string s)
        {
            cbNumbers.Items.Add(s);
            cbNumbers.Text = s;
            txtData.Clear();
            txtData.Focus();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure?", "Exit the app", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtData_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && txtData.Text.Trim().Length > 0) 
            {
                Enterdata(txtData.Text);
            }
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {
            Control ct = (Control)sender;
            if(ct.Text.Trim().Length == 0 || !char.IsDigit(ct.Text,ct.Text.Length - 1))
            {
                this.errorProvider1.SetError(txtData, "value is isvalid");
            }
            else
                this.errorProvider1.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Enterdata(txtData.Text);
        }

        private void cbNumbers_SelectedValueChanged(object sender, EventArgs e)
        {
            lbUoc.Items.Clear();
            int a = Convert.ToInt32(cbNumbers.Text);
            for (int i = 2; i <= a; i++)
            {
                if(a % i == 0)
                {
                    lbUoc.Items.Add(i);
                }
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach(int i in lbUoc.Items)
            {
                tong += i;
            }
            MessageBox.Show("Tổng của các ước là : " + tong);
        }

        private void btnUocChan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            foreach(int i in lbUoc.Items)
            {
                if(i % 2 == 0)
                {
                    dem ++;
                }
            }
            MessageBox.Show("Số lượng các ước chẵn là : " + dem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dem = 0;
            int nguyento = 0;
            foreach (int i in lbUoc.Items)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        dem++;
                    }

                }
                if(dem == 0)
                    nguyento++;
            }
            MessageBox.Show("Số lượng các ước là số nguyên tố : " + nguyento);
        }
    }
}
