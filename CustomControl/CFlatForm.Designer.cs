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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cTextbox1 = new CustomControl.CTextbox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 10);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 554);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(923, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 554);
            this.panel3.TabIndex = 11;
            // 
            // cTextbox1
            // 
            this.cTextbox1.BackColor = System.Drawing.SystemColors.Control;
            this.cTextbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextbox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cTextbox1.BorderRadius = 0;
            this.cTextbox1.BorderSize = 2;
            this.cTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cTextbox1.Location = new System.Drawing.Point(370, 110);
            this.cTextbox1.Multiline = false;
            this.cTextbox1.Name = "cTextbox1";
            this.cTextbox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextbox1.PasswordChar = false;
            this.cTextbox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextbox1.PlaceholderText = "";
            this.cTextbox1.Size = new System.Drawing.Size(250, 31);
            this.cTextbox1.TabIndex = 16;
            this.cTextbox1.Texts = "";
            this.cTextbox1.UnderlinedStyle = true;
            // 
            // CFlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.cTextbox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CFlatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CFlatForm";
            this.Load += new System.EventHandler(this.CFlatForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CFlatForm_Paint);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CTextbox cTextbox1;
    }
}

