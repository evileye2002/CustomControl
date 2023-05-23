namespace CustomControl
{
    partial class CFlatForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cCircularPictureBox1 = new CustomControl.CCircularPictureBox();
            this.cGradientPanel1 = new CustomControl.CGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.cCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(245, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // cCircularPictureBox1
            // 
            this.cCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            this.cCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.cCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.cCircularPictureBox1.BorderSize = 8;
            this.cCircularPictureBox1.GradientAngle = 45F;
            this.cCircularPictureBox1.Image = global::CustomControl.Properties.Resources._307458227_183097110912069_8713095141205203505_n;
            this.cCircularPictureBox1.Location = new System.Drawing.Point(484, 270);
            this.cCircularPictureBox1.Name = "cCircularPictureBox1";
            this.cCircularPictureBox1.Size = new System.Drawing.Size(200, 200);
            this.cCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cCircularPictureBox1.TabIndex = 2;
            this.cCircularPictureBox1.TabStop = false;
            // 
            // cGradientPanel1
            // 
            this.cGradientPanel1.ColorBot = System.Drawing.Color.RoyalBlue;
            this.cGradientPanel1.ColorTop = System.Drawing.Color.HotPink;
            this.cGradientPanel1.GradientAngle = 120F;
            this.cGradientPanel1.Location = new System.Drawing.Point(505, 111);
            this.cGradientPanel1.Name = "cGradientPanel1";
            this.cGradientPanel1.Size = new System.Drawing.Size(200, 100);
            this.cGradientPanel1.TabIndex = 1;
            // 
            // CFlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.cCircularPictureBox1);
            this.Controls.Add(this.cGradientPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CFlatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CFlatForm";
            this.Load += new System.EventHandler(this.CFlatForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CFlatForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.cCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CGradientPanel cGradientPanel1;
        private CCircularPictureBox cCircularPictureBox1;
    }
}

