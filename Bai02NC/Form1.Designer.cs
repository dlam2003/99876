namespace Bai02NC
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
            this.rbVn = new System.Windows.Forms.RadioButton();
            this.gbcountry = new System.Windows.Forms.GroupBox();
            this.rbPhilip = new System.Windows.Forms.RadioButton();
            this.rbItalian = new System.Windows.Forms.RadioButton();
            this.rbUSA = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbcountry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbVn
            // 
            this.rbVn.AutoSize = true;
            this.rbVn.Location = new System.Drawing.Point(41, 44);
            this.rbVn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbVn.Name = "rbVn";
            this.rbVn.Size = new System.Drawing.Size(55, 24);
            this.rbVn.TabIndex = 0;
            this.rbVn.TabStop = true;
            this.rbVn.Text = "VN";
            this.rbVn.UseVisualStyleBackColor = true;
            this.rbVn.Click += new System.EventHandler(this.rbVn_Click);
            // 
            // gbcountry
            // 
            this.gbcountry.Controls.Add(this.rbPhilip);
            this.gbcountry.Controls.Add(this.rbItalian);
            this.gbcountry.Controls.Add(this.rbUSA);
            this.gbcountry.Controls.Add(this.rbVn);
            this.gbcountry.Location = new System.Drawing.Point(49, 124);
            this.gbcountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbcountry.Name = "gbcountry";
            this.gbcountry.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbcountry.Size = new System.Drawing.Size(323, 360);
            this.gbcountry.TabIndex = 1;
            this.gbcountry.TabStop = false;
            this.gbcountry.Text = "Country";
            // 
            // rbPhilip
            // 
            this.rbPhilip.AutoSize = true;
            this.rbPhilip.Location = new System.Drawing.Point(41, 254);
            this.rbPhilip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbPhilip.Name = "rbPhilip";
            this.rbPhilip.Size = new System.Drawing.Size(92, 24);
            this.rbPhilip.TabIndex = 0;
            this.rbPhilip.TabStop = true;
            this.rbPhilip.Text = "Philipin";
            this.rbPhilip.UseVisualStyleBackColor = true;
            this.rbPhilip.CheckedChanged += new System.EventHandler(this.rbPhilip_CheckedChanged);
            // 
            // rbItalian
            // 
            this.rbItalian.AutoSize = true;
            this.rbItalian.Location = new System.Drawing.Point(41, 181);
            this.rbItalian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbItalian.Name = "rbItalian";
            this.rbItalian.Size = new System.Drawing.Size(81, 24);
            this.rbItalian.TabIndex = 0;
            this.rbItalian.TabStop = true;
            this.rbItalian.Text = "Italian";
            this.rbItalian.UseVisualStyleBackColor = true;
            this.rbItalian.Click += new System.EventHandler(this.rbItalian_Click);
            // 
            // rbUSA
            // 
            this.rbUSA.AutoSize = true;
            this.rbUSA.Location = new System.Drawing.Point(41, 111);
            this.rbUSA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbUSA.Name = "rbUSA";
            this.rbUSA.Size = new System.Drawing.Size(67, 24);
            this.rbUSA.TabIndex = 0;
            this.rbUSA.TabStop = true;
            this.rbUSA.Text = "USA";
            this.rbUSA.UseVisualStyleBackColor = true;
            this.rbUSA.CheckedChanged += new System.EventHandler(this.rbUSA_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bai02NC.Properties.Resources.tải_xuống;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(408, 155);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(436, 290);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(1, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(918, 54);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "COUNTRY FLAGS";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 518);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbcountry);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "FrmFlag";
            this.gbcountry.ResumeLayout(false);
            this.gbcountry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbVn;
        private System.Windows.Forms.GroupBox gbcountry;
        private System.Windows.Forms.RadioButton rbUSA;
        private System.Windows.Forms.RadioButton rbPhilip;
        private System.Windows.Forms.RadioButton rbItalian;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

