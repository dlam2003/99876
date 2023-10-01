namespace Bai01NC
{
    partial class Font
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.rbTimes = new System.Windows.Forms.RadioButton();
            this.rbArial = new System.Windows.Forms.RadioButton();
            this.rbtahoma = new System.Windows.Forms.RadioButton();
            this.rbCourier = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập văn Bản : ";
            // 
            // txtText
            // 
            this.txtText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.ForeColor = System.Drawing.Color.Blue;
            this.txtText.Location = new System.Drawing.Point(50, 77);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(262, 265);
            this.txtText.TabIndex = 1;
            // 
            // rbTimes
            // 
            this.rbTimes.AutoSize = true;
            this.rbTimes.Location = new System.Drawing.Point(342, 77);
            this.rbTimes.Name = "rbTimes";
            this.rbTimes.Size = new System.Drawing.Size(143, 20);
            this.rbTimes.TabIndex = 2;
            this.rbTimes.TabStop = true;
            this.rbTimes.Text = "Times New Roman";
            this.rbTimes.UseVisualStyleBackColor = true;
            this.rbTimes.CheckedChanged += new System.EventHandler(this.rbTimes_CheckedChanged);
            // 
            // rbArial
            // 
            this.rbArial.AutoSize = true;
            this.rbArial.Location = new System.Drawing.Point(342, 146);
            this.rbArial.Name = "rbArial";
            this.rbArial.Size = new System.Drawing.Size(55, 20);
            this.rbArial.TabIndex = 2;
            this.rbArial.TabStop = true;
            this.rbArial.Text = "Arial";
            this.rbArial.UseVisualStyleBackColor = true;
            this.rbArial.CheckedChanged += new System.EventHandler(this.rbArial_CheckedChanged);
            // 
            // rbtahoma
            // 
            this.rbtahoma.AutoSize = true;
            this.rbtahoma.Location = new System.Drawing.Point(342, 224);
            this.rbtahoma.Name = "rbtahoma";
            this.rbtahoma.Size = new System.Drawing.Size(79, 20);
            this.rbtahoma.TabIndex = 2;
            this.rbtahoma.TabStop = true;
            this.rbtahoma.Text = "Tahoma";
            this.rbtahoma.UseVisualStyleBackColor = true;
            this.rbtahoma.CheckedChanged += new System.EventHandler(this.rbtahoma_CheckedChanged);
            // 
            // rbCourier
            // 
            this.rbCourier.AutoSize = true;
            this.rbCourier.Location = new System.Drawing.Point(342, 298);
            this.rbCourier.Name = "rbCourier";
            this.rbCourier.Size = new System.Drawing.Size(101, 20);
            this.rbCourier.TabIndex = 2;
            this.rbCourier.TabStop = true;
            this.rbCourier.Text = "Courier New";
            this.rbCourier.UseVisualStyleBackColor = true;
            this.rbCourier.CheckedChanged += new System.EventHandler(this.rbCourier_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(222, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 31);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 404);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.rbCourier);
            this.Controls.Add(this.rbtahoma);
            this.Controls.Add(this.rbArial);
            this.Controls.Add(this.rbTimes);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.RadioButton rbTimes;
        private System.Windows.Forms.RadioButton rbArial;
        private System.Windows.Forms.RadioButton rbtahoma;
        private System.Windows.Forms.RadioButton rbCourier;
        private System.Windows.Forms.Button btnExit;
    }
}

