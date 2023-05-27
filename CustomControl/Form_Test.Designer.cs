namespace CustomControl
{
    partial class Form_Test
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
            this.cTextbox2 = new CustomControl.CTextbox();
            this.cTextbox1 = new CustomControl.CTextbox();
            this.SuspendLayout();
            // 
            // cTextbox2
            // 
            this.cTextbox2.BackColor = System.Drawing.Color.White;
            this.cTextbox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextbox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cTextbox2.BorderRadius = 0;
            this.cTextbox2.BorderSize = 2;
            this.cTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cTextbox2.Location = new System.Drawing.Point(467, 122);
            this.cTextbox2.Multiline = false;
            this.cTextbox2.Name = "cTextbox2";
            this.cTextbox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextbox2.PasswordChar = false;
            this.cTextbox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextbox2.PlaceholderText = "456";
            this.cTextbox2.Size = new System.Drawing.Size(250, 31);
            this.cTextbox2.TabIndex = 1;
            this.cTextbox2.Texts = "";
            this.cTextbox2.UnderlinedStyle = false;
            // 
            // cTextbox1
            // 
            this.cTextbox1.BackColor = System.Drawing.Color.White;
            this.cTextbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextbox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cTextbox1.BorderRadius = 0;
            this.cTextbox1.BorderSize = 2;
            this.cTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.cTextbox1.Location = new System.Drawing.Point(417, 210);
            this.cTextbox1.Multiline = false;
            this.cTextbox1.Name = "cTextbox1";
            this.cTextbox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cTextbox1.PasswordChar = false;
            this.cTextbox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextbox1.PlaceholderText = "567";
            this.cTextbox1.Size = new System.Drawing.Size(250, 31);
            this.cTextbox1.TabIndex = 0;
            this.cTextbox1.Texts = "";
            this.cTextbox1.UnderlinedStyle = false;
            // 
            // Form_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.cTextbox2);
            this.Controls.Add(this.cTextbox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CFlatForm";
            this.Load += new System.EventHandler(this.CFlatForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CFlatForm_Paint);
            this.ResumeLayout(false);

        }
        #endregion

        private CTextbox cTextbox1;
        private CTextbox cTextbox2;
    }
}

