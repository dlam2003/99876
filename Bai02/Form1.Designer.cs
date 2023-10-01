namespace Bai02
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumber1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rbtru = new System.Windows.Forms.RadioButton();
            this.rbNhan = new System.Windows.Forms.RadioButton();
            this.rbChia = new System.Windows.Forms.RadioButton();
            this.gbPhepTinh = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPhepTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1";
            // 
            // txtNumber1
            // 
            this.txtNumber1.Location = new System.Drawing.Point(154, 27);
            this.txtNumber1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber1.Name = "txtNumber1";
            this.txtNumber1.Size = new System.Drawing.Size(644, 30);
            this.txtNumber1.TabIndex = 1;
            this.txtNumber1.TextChanged += new System.EventHandler(this.txtNumber1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số 2";
            // 
            // txtNumber2
            // 
            this.txtNumber2.Location = new System.Drawing.Point(154, 84);
            this.txtNumber2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(644, 30);
            this.txtNumber2.TabIndex = 2;
            this.txtNumber2.TextChanged += new System.EventHandler(this.txtNumber2_TextChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 53);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 28);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Cộng";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtru
            // 
            this.rbtru.AutoSize = true;
            this.rbtru.Location = new System.Drawing.Point(203, 53);
            this.rbtru.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtru.Name = "rbtru";
            this.rbtru.Size = new System.Drawing.Size(56, 28);
            this.rbtru.TabIndex = 4;
            this.rbtru.TabStop = true;
            this.rbtru.Text = "Trừ";
            this.rbtru.UseVisualStyleBackColor = true;
            this.rbtru.CheckedChanged += new System.EventHandler(this.rbtru_CheckedChanged);
            // 
            // rbNhan
            // 
            this.rbNhan.AutoSize = true;
            this.rbNhan.Location = new System.Drawing.Point(382, 53);
            this.rbNhan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbNhan.Name = "rbNhan";
            this.rbNhan.Size = new System.Drawing.Size(72, 28);
            this.rbNhan.TabIndex = 5;
            this.rbNhan.TabStop = true;
            this.rbNhan.Text = "Nhân";
            this.rbNhan.UseVisualStyleBackColor = true;
            this.rbNhan.CheckedChanged += new System.EventHandler(this.rbNhan_CheckedChanged);
            // 
            // rbChia
            // 
            this.rbChia.AutoSize = true;
            this.rbChia.Location = new System.Drawing.Point(582, 53);
            this.rbChia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbChia.Name = "rbChia";
            this.rbChia.Size = new System.Drawing.Size(66, 28);
            this.rbChia.TabIndex = 6;
            this.rbChia.TabStop = true;
            this.rbChia.Text = "Chia";
            this.rbChia.UseVisualStyleBackColor = true;
            this.rbChia.CheckedChanged += new System.EventHandler(this.rbChia_CheckedChanged);
            // 
            // gbPhepTinh
            // 
            this.gbPhepTinh.Controls.Add(this.radioButton1);
            this.gbPhepTinh.Controls.Add(this.rbNhan);
            this.gbPhepTinh.Controls.Add(this.rbChia);
            this.gbPhepTinh.Controls.Add(this.rbtru);
            this.gbPhepTinh.Location = new System.Drawing.Point(82, 166);
            this.gbPhepTinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPhepTinh.Name = "gbPhepTinh";
            this.gbPhepTinh.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPhepTinh.Size = new System.Drawing.Size(716, 110);
            this.gbPhepTinh.TabIndex = 7;
            this.gbPhepTinh.TabStop = false;
            this.gbPhepTinh.Text = "Phép Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 339);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kết Quả :";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(178, 334);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(620, 30);
            this.txtKetQua.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(888, 401);
            this.Controls.Add(this.gbPhepTinh);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phép Tính";
            this.gbPhepTinh.ResumeLayout(false);
            this.gbPhepTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumber1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbtru;
        private System.Windows.Forms.RadioButton rbNhan;
        private System.Windows.Forms.RadioButton rbChia;
        private System.Windows.Forms.GroupBox gbPhepTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

