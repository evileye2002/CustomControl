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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CFlatForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cDragAblePanel1 = new CustomControl.CDragAblePanel();
            this.cSideBarMenu1 = new CustomControl.CSideBarMenu();
            this.cButton2 = new CustomControl.CButton();
            this.cButton1 = new CustomControl.CButton();
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
            // cDragAblePanel1
            // 
            this.cDragAblePanel1.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.cDragAblePanel1.HoverButtonColor = System.Drawing.Color.MediumSlateBlue;
            this.cDragAblePanel1.IconImage = ((System.Drawing.Image)(resources.GetObject("cDragAblePanel1.IconImage")));
            this.cDragAblePanel1.Location = new System.Drawing.Point(90, 17);
            this.cDragAblePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.cDragAblePanel1.MaximumSize = new System.Drawing.Size(3500, 49);
            this.cDragAblePanel1.Name = "cDragAblePanel1";
            this.cDragAblePanel1.Size = new System.Drawing.Size(600, 40);
            this.cDragAblePanel1.TabIndex = 13;
            this.cDragAblePanel1.TargetForm = this;
            this.cDragAblePanel1._MaximizeClick += new System.EventHandler(this.cDragAblePanel1__MaximizeClick);
            // 
            // cSideBarMenu1
            // 
            this.cSideBarMenu1.ActiveBtnColor = System.Drawing.Color.Peru;
            this.cSideBarMenu1.BtnForeColor = System.Drawing.Color.Bisque;
            this.cSideBarMenu1.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.cSideBarMenu1.FooterImage = null;
            this.cSideBarMenu1.HeaderImage = null;
            this.cSideBarMenu1.Location = new System.Drawing.Point(190, 83);
            this.cSideBarMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.cSideBarMenu1.Name = "cSideBarMenu1";
            this.cSideBarMenu1.NumberButton = 4;
            this.cSideBarMenu1.NumberSubButton1 = 3;
            this.cSideBarMenu1.NumberSubButton2 = 3;
            this.cSideBarMenu1.NumberSubButton3 = 3;
            this.cSideBarMenu1.NumberSubButton4 = 3;
            this.cSideBarMenu1.ShowStatus = true;
            this.cSideBarMenu1.Size = new System.Drawing.Size(250, 600);
            this.cSideBarMenu1.SubBtnColor = System.Drawing.Color.Sienna;
            this.cSideBarMenu1.TabIndex = 12;
            // 
            // cButton2
            // 
            this.cButton2.BackColor = System.Drawing.Color.LimeGreen;
            this.cButton2.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.cButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cButton2.BorderRadius = 0;
            this.cButton2.BorderSize = 0;
            this.cButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton2.CustomTag = "";
            this.cButton2.FlatAppearance.BorderSize = 0;
            this.cButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton2.ForeColor = System.Drawing.Color.White;
            this.cButton2.HoverBorderColor = System.Drawing.Color.Empty;
            this.cButton2.HoverColor = System.Drawing.Color.DarkGray;
            this.cButton2.HoverImage = null;
            this.cButton2.LeaveBorderColor = System.Drawing.Color.Empty;
            this.cButton2.LeaveColor = System.Drawing.Color.LimeGreen;
            this.cButton2.LeaveImage = null;
            this.cButton2.Location = new System.Drawing.Point(464, 207);
            this.cButton2.Name = "cButton2";
            this.cButton2.Size = new System.Drawing.Size(150, 40);
            this.cButton2.TabIndex = 3;
            this.cButton2.Text = "cButton2";
            this.cButton2.TextColor = System.Drawing.Color.White;
            this.cButton2.UseVisualStyleBackColor = false;
            // 
            // cButton1
            // 
            this.cButton1.BackColor = System.Drawing.SystemColors.Control;
            this.cButton1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.cButton1.BorderColor = System.Drawing.Color.Orange;
            this.cButton1.BorderRadius = 0;
            this.cButton1.BorderSize = 2;
            this.cButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton1.CustomTag = "";
            this.cButton1.FlatAppearance.BorderSize = 0;
            this.cButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton1.ForeColor = System.Drawing.Color.Black;
            this.cButton1.HoverBorderColor = System.Drawing.Color.Black;
            this.cButton1.HoverColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton1.HoverImage = null;
            this.cButton1.Image = global::CustomControl.Properties.Resources.icons8_logout_32;
            this.cButton1.LeaveBorderColor = System.Drawing.Color.Orange;
            this.cButton1.LeaveColor = System.Drawing.SystemColors.Control;
            this.cButton1.LeaveImage = null;
            this.cButton1.Location = new System.Drawing.Point(418, 129);
            this.cButton1.Name = "cButton1";
            this.cButton1.Size = new System.Drawing.Size(150, 40);
            this.cButton1.TabIndex = 2;
            this.cButton1.Text = "cButton1";
            this.cButton1.TextColor = System.Drawing.Color.Black;
            this.cButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cButton1.UseVisualStyleBackColor = false;
            // 
            // CFlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.cDragAblePanel1);
            this.Controls.Add(this.cSideBarMenu1);
            this.Controls.Add(this.cButton2);
            this.Controls.Add(this.cButton1);
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
        private CButton cButton1;
        private CButton cButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CSideBarMenu cSideBarMenu1;
        private CDragAblePanel cDragAblePanel1;
    }
}

