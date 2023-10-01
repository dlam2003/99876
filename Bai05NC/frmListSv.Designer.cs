namespace Bai05NC
{
    partial class frmListSv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnaddB = new System.Windows.Forms.Button();
            this.btnAddAllB = new System.Windows.Forms.Button();
            this.btnAddA = new System.Windows.Forms.Button();
            this.btnAddAllA = new System.Windows.Forms.Button();
            this.btnDell = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lBclassA = new System.Windows.Forms.ListBox();
            this.LBclassB = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.cbChoose = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(-5, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(727, 42);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "DANH SÁCH SINH VIÊN";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và Tên :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(191, 101);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(295, 27);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(515, 101);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(167, 28);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnaddB
            // 
            this.btnaddB.Location = new System.Drawing.Point(334, 241);
            this.btnaddB.Margin = new System.Windows.Forms.Padding(4);
            this.btnaddB.Name = "btnaddB";
            this.btnaddB.Size = new System.Drawing.Size(74, 28);
            this.btnaddB.TabIndex = 2;
            this.btnaddB.Text = ">";
            this.btnaddB.UseVisualStyleBackColor = true;
            this.btnaddB.Click += new System.EventHandler(this.btnaddB_Click);
            // 
            // btnAddAllB
            // 
            this.btnAddAllB.Location = new System.Drawing.Point(334, 306);
            this.btnAddAllB.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAllB.Name = "btnAddAllB";
            this.btnAddAllB.Size = new System.Drawing.Size(74, 28);
            this.btnAddAllB.TabIndex = 3;
            this.btnAddAllB.Text = ">>";
            this.btnAddAllB.UseVisualStyleBackColor = true;
            this.btnAddAllB.Click += new System.EventHandler(this.btnAddAllB_Click);
            // 
            // btnAddA
            // 
            this.btnAddA.Location = new System.Drawing.Point(334, 390);
            this.btnAddA.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddA.Name = "btnAddA";
            this.btnAddA.Size = new System.Drawing.Size(74, 28);
            this.btnAddA.TabIndex = 4;
            this.btnAddA.Text = "<";
            this.btnAddA.UseVisualStyleBackColor = true;
            this.btnAddA.Click += new System.EventHandler(this.btnAddA_Click);
            // 
            // btnAddAllA
            // 
            this.btnAddAllA.Location = new System.Drawing.Point(334, 469);
            this.btnAddAllA.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddAllA.Name = "btnAddAllA";
            this.btnAddAllA.Size = new System.Drawing.Size(74, 28);
            this.btnAddAllA.TabIndex = 5;
            this.btnAddAllA.Text = "<<";
            this.btnAddAllA.UseVisualStyleBackColor = true;
            this.btnAddAllA.Click += new System.EventHandler(this.btnAddAllA_Click);
            // 
            // btnDell
            // 
            this.btnDell.Location = new System.Drawing.Point(60, 550);
            this.btnDell.Margin = new System.Windows.Forms.Padding(4);
            this.btnDell.Name = "btnDell";
            this.btnDell.Size = new System.Drawing.Size(192, 28);
            this.btnDell.TabIndex = 6;
            this.btnDell.Text = "Xóa";
            this.btnDell.UseVisualStyleBackColor = true;
            this.btnDell.Click += new System.EventHandler(this.btnDell_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(477, 550);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(192, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Kết thúc";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lBclassA
            // 
            this.lBclassA.FormattingEnabled = true;
            this.lBclassA.ItemHeight = 20;
            this.lBclassA.Items.AddRange(new object[] {
            "Nguyen Van A",
            "Nguyen Van B"});
            this.lBclassA.Location = new System.Drawing.Point(20, 26);
            this.lBclassA.Margin = new System.Windows.Forms.Padding(4);
            this.lBclassA.Name = "lBclassA";
            this.lBclassA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lBclassA.Size = new System.Drawing.Size(224, 264);
            this.lBclassA.TabIndex = 5;
            // 
            // LBclassB
            // 
            this.LBclassB.FormattingEnabled = true;
            this.LBclassB.ItemHeight = 20;
            this.LBclassB.Items.AddRange(new object[] {
            "Du thi A"});
            this.LBclassB.Location = new System.Drawing.Point(25, 19);
            this.LBclassB.Margin = new System.Windows.Forms.Padding(4);
            this.LBclassB.Name = "LBclassB";
            this.LBclassB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LBclassB.Size = new System.Drawing.Size(224, 264);
            this.LBclassB.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lBclassA);
            this.groupBox1.Location = new System.Drawing.Point(35, 207);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 316);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBclassB);
            this.groupBox2.Location = new System.Drawing.Point(435, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 300);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbChoose
            // 
            this.cbChoose.FormattingEnabled = true;
            this.cbChoose.Items.AddRange(new object[] {
            "Lớp A",
            "Lớp B"});
            this.cbChoose.Location = new System.Drawing.Point(250, 154);
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.Size = new System.Drawing.Size(191, 28);
            this.cbChoose.TabIndex = 8;
            // 
            // frmListSv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 653);
            this.Controls.Add(this.cbChoose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDell);
            this.Controls.Add(this.btnAddAllA);
            this.Controls.Add(this.btnAddA);
            this.Controls.Add(this.btnAddAllB);
            this.Controls.Add(this.btnaddB);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmListSv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListSv";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnaddB;
        private System.Windows.Forms.Button btnAddAllB;
        private System.Windows.Forms.Button btnAddA;
        private System.Windows.Forms.Button btnAddAllA;
        private System.Windows.Forms.Button btnDell;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lBclassA;
        private System.Windows.Forms.ListBox LBclassB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbChoose;
    }
}

