using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05NC
{
    public partial class frmListSv : Form
    {
        public frmListSv()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Control ct = (Control)sender;
            if (ct.Text.Trim().Length == 0)
            {
                this.errorProvider1.SetError(txtName, "Enter the data");
            }
            else
                this.errorProvider1.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length > 0)
            {
                if (cbChoose.Text.Equals("Lớp A"))
                {
                    string Studentname = txtName.Text;
                    lBclassA.Items.Add(Studentname);
                    txtName.Clear();
                    txtName.Focus();
                }
                else
                if (cbChoose.Text.Equals("Lớp B"))
                {
                    string Studentname = txtName.Text;
                    LBclassB.Items.Add(Studentname);
                    txtName.Clear();
                    txtName.Focus();
                }
                else
                {
                    MessageBox.Show("vui long chon lop");
                }
            }
        }

        private void btnaddB_Click(object sender, EventArgs e)
        {
            for (int i = lBclassA.SelectedItems.Count - 1; i >= 0; i--)
            {
                LBclassB.Items.Add(lBclassA.SelectedItems[i]);
                lBclassA.Items.Remove(lBclassA.SelectedItems[i]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure?", "Exit the app", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnAddAllB_Click(object sender, EventArgs e)
        {
            foreach (string Item in lBclassA.Items)
            {
                LBclassB.Items.Add(Item);
            }
            lBclassA.Items.Clear();
        }

        private void btnAddAllA_Click(object sender, EventArgs e)
        {
            foreach (string Item in LBclassB.Items)
            {
                lBclassA.Items.Add(Item);
            }
            LBclassB.Items.Clear();
        }

        private void btnAddA_Click(object sender, EventArgs e)
        {
            for (int i = LBclassB.SelectedItems.Count - 1; i >= 0; i--)
            {
                lBclassA.Items.Add(LBclassB.SelectedItems[i]);
                LBclassB.Items.Remove(LBclassB.SelectedItems[i]);
            }
        }

        private void btnDell_Click(object sender, EventArgs e)
        {
            for(int i =  LBclassB.SelectedItems.Count -1; i >= 0; i--)
            {
                LBclassB.Items.Remove(LBclassB.SelectedItems[i]);
            }

            for (int i = lBclassA.SelectedItems.Count - 1; i >= 0; i--)
            {
                lBclassA.Items.Remove(lBclassA.SelectedItems[i]);
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtName.Text.Trim().Length > 0)
                {
                    if (cbChoose.Text.Equals("Lớp A"))
                    {
                        string Studentname = txtName.Text;
                        lBclassA.Items.Add(Studentname);
                        txtName.Clear();
                        txtName.Focus();
                    }
                    else
                    if (cbChoose.Text.Equals("Lớp B"))
                    {
                        string Studentname = txtName.Text;
                        LBclassB.Items.Add(Studentname);
                        txtName.Clear();
                        txtName.Focus();
                    }
                    else
                    {
                        MessageBox.Show("vui long chon lop");
                    }
                }
            }
        }
    }
}
