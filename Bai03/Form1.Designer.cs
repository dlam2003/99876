namespace Bai03
{
    partial class Formater
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
            this.txtEnterName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.rbBlack = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.gbFont = new System.Windows.Forms.GroupBox();
            this.cbUnderLine = new System.Windows.Forms.CheckBox();
            this.cbItalic = new System.Windows.Forms.CheckBox();
            this.CbBold = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLapTrinh = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gbColor.SuspendLayout();
            this.gbFont.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LimeGreen;
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên";
            // 
            // txtEnterName
            // 
            this.txtEnterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEnterName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnterName.Location = new System.Drawing.Point(107, 18);
            this.txtEnterName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEnterName.Name = "txtEnterName";
            this.txtEnterName.Size = new System.Drawing.Size(240, 30);
            this.txtEnterName.TabIndex = 1;
            this.txtEnterName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.rbBlack);
            this.gbColor.Controls.Add(this.rbBlue);
            this.gbColor.Controls.Add(this.rbGreen);
            this.gbColor.Controls.Add(this.rbRed);
            this.gbColor.Location = new System.Drawing.Point(22, 108);
            this.gbColor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbColor.Name = "gbColor";
            this.gbColor.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbColor.Size = new System.Drawing.Size(205, 206);
            this.gbColor.TabIndex = 2;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Color";
            // 
            // rbBlack
            // 
            this.rbBlack.AutoSize = true;
            this.rbBlack.Location = new System.Drawing.Point(21, 165);
            this.rbBlack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbBlack.Name = "rbBlack";
            this.rbBlack.Size = new System.Drawing.Size(79, 25);
            this.rbBlack.TabIndex = 3;
            this.rbBlack.TabStop = true;
            this.rbBlack.Text = "Black";
            this.rbBlack.UseVisualStyleBackColor = true;
            this.rbBlack.CheckedChanged += new System.EventHandler(this.rbBlack_CheckedChanged);
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.ForeColor = System.Drawing.Color.Blue;
            this.rbBlue.Location = new System.Drawing.Point(21, 123);
            this.rbBlue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(71, 25);
            this.rbBlue.TabIndex = 3;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            this.rbBlue.CheckedChanged += new System.EventHandler(this.rbBlue_CheckedChanged);
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.ForeColor = System.Drawing.Color.Lime;
            this.rbGreen.Location = new System.Drawing.Point(21, 77);
            this.rbGreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(85, 25);
            this.rbGreen.TabIndex = 3;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            this.rbGreen.CheckedChanged += new System.EventHandler(this.rbGreen_CheckedChanged);
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.ForeColor = System.Drawing.Color.Red;
            this.rbRed.Location = new System.Drawing.Point(21, 35);
            this.rbRed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(66, 25);
            this.rbRed.TabIndex = 3;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            this.rbRed.CheckedChanged += new System.EventHandler(this.rbRed_CheckedChanged);
            // 
            // gbFont
            // 
            this.gbFont.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbFont.Controls.Add(this.cbUnderLine);
            this.gbFont.Controls.Add(this.cbItalic);
            this.gbFont.Controls.Add(this.CbBold);
            this.gbFont.ForeColor = System.Drawing.Color.Blue;
            this.gbFont.Location = new System.Drawing.Point(316, 108);
            this.gbFont.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFont.Name = "gbFont";
            this.gbFont.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFont.Size = new System.Drawing.Size(221, 206);
            this.gbFont.TabIndex = 3;
            this.gbFont.TabStop = false;
            this.gbFont.Text = "Font";
            // 
            // cbUnderLine
            // 
            this.cbUnderLine.AutoSize = true;
            this.cbUnderLine.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUnderLine.Location = new System.Drawing.Point(40, 155);
            this.cbUnderLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbUnderLine.Name = "cbUnderLine";
            this.cbUnderLine.Size = new System.Drawing.Size(127, 25);
            this.cbUnderLine.TabIndex = 0;
            this.cbUnderLine.Text = "Gạch Chân";
            this.cbUnderLine.UseVisualStyleBackColor = true;
            this.cbUnderLine.CheckedChanged += new System.EventHandler(this.cbUnderLine_CheckedChanged);
            // 
            // cbItalic
            // 
            this.cbItalic.AutoSize = true;
            this.cbItalic.Font = new System.Drawing.Font("Arial", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItalic.Location = new System.Drawing.Point(40, 97);
            this.cbItalic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbItalic.Name = "cbItalic";
            this.cbItalic.Size = new System.Drawing.Size(163, 25);
            this.cbItalic.TabIndex = 0;
            this.cbItalic.Text = "Nghiêng (Italic)";
            this.cbItalic.UseVisualStyleBackColor = true;
            this.cbItalic.CheckedChanged += new System.EventHandler(this.cbItalic_CheckedChanged);
            // 
            // CbBold
            // 
            this.CbBold.AutoSize = true;
            this.CbBold.Location = new System.Drawing.Point(40, 40);
            this.CbBold.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CbBold.Name = "CbBold";
            this.CbBold.Size = new System.Drawing.Size(129, 25);
            this.CbBold.TabIndex = 0;
            this.CbBold.Text = "Đậm (Bold)";
            this.CbBold.UseVisualStyleBackColor = true;
            this.CbBold.CheckedChanged += new System.EventHandler(this.CbBold_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lập Trình Bởi :";
            // 
            // lblLapTrinh
            // 
            this.lblLapTrinh.Enabled = false;
            this.lblLapTrinh.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLapTrinh.Location = new System.Drawing.Point(168, 369);
            this.lblLapTrinh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblLapTrinh.Name = "lblLapTrinh";
            this.lblLapTrinh.Size = new System.Drawing.Size(250, 28);
            this.lblLapTrinh.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(475, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(447, 436);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Formater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(575, 497);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbFont);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.lblLapTrinh);
            this.Controls.Add(this.txtEnterName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formater";
            this.Text = "Định Dạng(Formater)";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.gbFont.ResumeLayout(false);
            this.gbFont.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.RadioButton rbBlack;
        private System.Windows.Forms.GroupBox gbFont;
        private System.Windows.Forms.CheckBox cbUnderLine;
        private System.Windows.Forms.CheckBox cbItalic;
        private System.Windows.Forms.CheckBox CbBold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblLapTrinh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button1;
    }
}

