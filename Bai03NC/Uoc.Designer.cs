namespace Bai03NC
{
    partial class Uoc
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.cbNumbers = new System.Windows.Forms.ComboBox();
            this.lbUoc = new System.Windows.Forms.ListBox();
            this.btnUocChan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNumbers);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtData);
            this.groupBox1.Location = new System.Drawing.Point(43, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(363, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập số";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbUoc);
            this.groupBox2.Location = new System.Drawing.Point(434, 63);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(363, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(43, 60);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(158, 27);
            this.txtData.TabIndex = 0;
            this.txtData.TextChanged += new System.EventHandler(this.txtData_TextChanged);
            this.txtData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtData_KeyDown);
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSum.Location = new System.Drawing.Point(434, 301);
            this.btnSum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(337, 29);
            this.btnSum.TabIndex = 3;
            this.btnSum.Text = "Tổng các ước";
            this.btnSum.UseVisualStyleBackColor = false;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // cbNumbers
            // 
            this.cbNumbers.FormattingEnabled = true;
            this.cbNumbers.Location = new System.Drawing.Point(43, 122);
            this.cbNumbers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNumbers.Name = "cbNumbers";
            this.cbNumbers.Size = new System.Drawing.Size(291, 28);
            this.cbNumbers.TabIndex = 2;
            this.cbNumbers.SelectedValueChanged += new System.EventHandler(this.cbNumbers_SelectedValueChanged);
            // 
            // lbUoc
            // 
            this.lbUoc.FormattingEnabled = true;
            this.lbUoc.ItemHeight = 20;
            this.lbUoc.Location = new System.Drawing.Point(32, 43);
            this.lbUoc.Name = "lbUoc";
            this.lbUoc.ScrollAlwaysVisible = true;
            this.lbUoc.Size = new System.Drawing.Size(304, 144);
            this.lbUoc.TabIndex = 0;
            // 
            // btnUocChan
            // 
            this.btnUocChan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUocChan.Location = new System.Drawing.Point(434, 338);
            this.btnUocChan.Margin = new System.Windows.Forms.Padding(4);
            this.btnUocChan.Name = "btnUocChan";
            this.btnUocChan.Size = new System.Drawing.Size(337, 29);
            this.btnUocChan.TabIndex = 4;
            this.btnUocChan.Text = "Số lượng các ước chẵn";
            this.btnUocChan.UseVisualStyleBackColor = false;
            this.btnUocChan.Click += new System.EventHandler(this.btnUocChan_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(434, 375);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(337, 29);
            this.button2.TabIndex = 5;
            this.button2.Text = "Số lượng các ước số nguyên tố ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(303, 362);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(103, 42);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(231, 58);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Uoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 433);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUocChan);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Uoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UocC";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbNumbers;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbUoc;
        private System.Windows.Forms.Button btnUocChan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

