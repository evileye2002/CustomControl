namespace CustomControl
{
    partial class CNumbricLeftRight
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cButton2 = new CustomControl.CButton();
            this.cButton1 = new CustomControl.CButton();
            this.cTextbox1 = new CustomControl.CTextbox();
            this.SuspendLayout();
            // 
            // cButton2
            // 
            this.cButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cButton2.BorderRadius = 0;
            this.cButton2.BorderSize = 0;
            this.cButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton2.CustomTag = "";
            this.cButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.cButton2.FlatAppearance.BorderSize = 0;
            this.cButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton2.ForeColor = System.Drawing.Color.White;
            this.cButton2.HoverBorderColor = System.Drawing.Color.Empty;
            this.cButton2.HoverColor = System.Drawing.Color.SandyBrown;
            this.cButton2.HoverImage = null;
            this.cButton2.Image = global::CustomControl.Properties.Resources.chevron_right_20px;
            this.cButton2.LeaveBorderColor = System.Drawing.Color.PaleVioletRed;
            this.cButton2.LeaveColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton2.LeaveImage = null;
            this.cButton2.Location = new System.Drawing.Point(65, 0);
            this.cButton2.Name = "cButton2";
            this.cButton2.Size = new System.Drawing.Size(25, 31);
            this.cButton2.TabIndex = 3;
            this.cButton2.TextColor = System.Drawing.Color.White;
            this.cButton2.UseVisualStyleBackColor = false;
            this.cButton2.Click += new System.EventHandler(this.cButton2_Click);
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cButton1.BorderRadius = 0;
            this.cButton1.BorderSize = 0;
            this.cButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton1.CustomTag = "";
            this.cButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.ForeColor = System.Drawing.Color.White;
            this.cButton1.HoverBorderColor = System.Drawing.Color.Empty;
            this.cButton1.HoverColor = System.Drawing.Color.SandyBrown;
            this.cButton1.HoverImage = null;
            this.cButton1.Image = global::CustomControl.Properties.Resources.chevron_left_20px;
            this.cButton1.LeaveBorderColor = System.Drawing.Color.PaleVioletRed;
            this.cButton1.LeaveColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton1.LeaveImage = null;
            this.cButton1.Location = new System.Drawing.Point(0, 0);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(25, 31);
            this.cButton1.TabIndex = 2;
            this.cButton1.TextColor = System.Drawing.Color.White;
            this.cButton1.UseVisualStyleBackColor = false;
            this.cButton1.Click += new System.EventHandler(this.cButton1_Click);
            // 
            // cTextbox1
            // 
            this.cTextbox1.BackColor = System.Drawing.SystemColors.Control;
            this.cTextbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.cTextbox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.cTextbox1.BorderRadius = 0;
            this.cTextbox1.BorderSize = 2;
            this.cTextbox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTextbox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTextbox1.Location = new System.Drawing.Point(25, 0);
            this.cTextbox1.Multiline = false;
            this.cTextbox1.Name = "cTextbox1";
            this.cTextbox1.Padding = new System.Windows.Forms.Padding(13, 7, 10, 7);
            this.cTextbox1.PasswordChar = false;
            this.cTextbox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cTextbox1.PlaceholderText = "";
            this.cTextbox1.Size = new System.Drawing.Size(40, 31);
            this.cTextbox1.TabIndex = 1;
            this.cTextbox1.Texts = "01";
            this.cTextbox1.UnderlinedStyle = false;
            this.cTextbox1._TextChanged += new System.EventHandler(this.cTextbox1__TextChanged);
            // 
            // CNumbricLeftRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cTextbox1);
            this.Controls.Add(this.cButton2);
            this.Controls.Add(this.cButton1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CNumbricLeftRight";
            this.Size = new System.Drawing.Size(90, 31);
            this.ResumeLayout(false);

        }

        #endregion
        private CButton cButton1;
        private CButton cButton2;
        private CTextbox cTextbox1;
    }
}
