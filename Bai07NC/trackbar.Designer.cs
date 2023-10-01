namespace Bai07NC
{
    partial class trackbar
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
            this.red = new System.Windows.Forms.TrackBar();
            this.green = new System.Windows.Forms.TrackBar();
            this.Blue = new System.Windows.Forms.TrackBar();
            this.color = new System.Windows.Forms.Panel();
            this.lbred = new System.Windows.Forms.Label();
            this.lbGreen = new System.Windows.Forms.Label();
            this.lbblue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // red
            // 
            this.red.Location = new System.Drawing.Point(33, 124);
            this.red.Margin = new System.Windows.Forms.Padding(4);
            this.red.Maximum = 255;
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(234, 56);
            this.red.TabIndex = 0;
            this.red.Scroll += new System.EventHandler(this.red_Scroll);
            // 
            // green
            // 
            this.green.Location = new System.Drawing.Point(33, 188);
            this.green.Margin = new System.Windows.Forms.Padding(4);
            this.green.Maximum = 255;
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(234, 56);
            this.green.TabIndex = 0;
            this.green.Scroll += new System.EventHandler(this.green_Scroll);
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(33, 252);
            this.Blue.Margin = new System.Windows.Forms.Padding(4);
            this.Blue.Maximum = 255;
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(234, 56);
            this.Blue.TabIndex = 0;
            this.Blue.Scroll += new System.EventHandler(this.Blue_Scroll);
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.Color.Black;
            this.color.Location = new System.Drawing.Point(446, 124);
            this.color.Margin = new System.Windows.Forms.Padding(4);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(182, 171);
            this.color.TabIndex = 1;
            // 
            // lbred
            // 
            this.lbred.AutoSize = true;
            this.lbred.ForeColor = System.Drawing.Color.Red;
            this.lbred.Location = new System.Drawing.Point(323, 124);
            this.lbred.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbred.Name = "lbred";
            this.lbred.Size = new System.Drawing.Size(55, 20);
            this.lbred.TabIndex = 2;
            this.lbred.Text = "R = 0";
            // 
            // lbGreen
            // 
            this.lbGreen.AutoSize = true;
            this.lbGreen.ForeColor = System.Drawing.Color.Green;
            this.lbGreen.Location = new System.Drawing.Point(323, 188);
            this.lbGreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGreen.Name = "lbGreen";
            this.lbGreen.Size = new System.Drawing.Size(56, 20);
            this.lbGreen.TabIndex = 2;
            this.lbGreen.Text = "G = 0";
            // 
            // lbblue
            // 
            this.lbblue.AutoSize = true;
            this.lbblue.ForeColor = System.Drawing.Color.Blue;
            this.lbblue.Location = new System.Drawing.Point(324, 252);
            this.lbblue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbblue.Name = "lbblue";
            this.lbblue.Size = new System.Drawing.Size(55, 20);
            this.lbblue.TabIndex = 2;
            this.lbblue.Text = "B = 0";
            // 
            // trackbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 397);
            this.Controls.Add(this.lbblue);
            this.Controls.Add(this.lbGreen);
            this.Controls.Add(this.lbred);
            this.Controls.Add(this.color);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "trackbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorPanel";
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.trackbar_Scroll);
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar red;
        private System.Windows.Forms.TrackBar green;
        private System.Windows.Forms.TrackBar Blue;
        private System.Windows.Forms.Panel color;
        private System.Windows.Forms.Label lbred;
        private System.Windows.Forms.Label lbGreen;
        private System.Windows.Forms.Label lbblue;
    }
}

