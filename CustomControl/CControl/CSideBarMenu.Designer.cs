namespace CustomControl
{
    partial class CSideBarMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSideBarMenu));
            this.pnSideBar = new System.Windows.Forms.Panel();
            this.pnFooter = new System.Windows.Forms.Panel();
            this.lbDetail = new System.Windows.Forms.Label();
            this.btnFooter = new CustomControl.CButton();
            this.lbNameFooter = new System.Windows.Forms.Label();
            this.pbFooter = new System.Windows.Forms.PictureBox();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.lbNameHeader = new System.Windows.Forms.Label();
            this.pbHeader = new System.Windows.Forms.PictureBox();
            this.btnMenu = new CustomControl.CButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cMenuButton1 = new CustomControl.CMenuButton();
            this.cMenuButton2 = new CustomControl.CMenuButton();
            this.cMenuButton3 = new CustomControl.CMenuButton();
            this.cMenuButton4 = new CustomControl.CMenuButton();
            this.pnSideBar.SuspendLayout();
            this.pnFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooter)).BeginInit();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSideBar
            // 
            this.pnSideBar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnSideBar.Controls.Add(this.cMenuButton4);
            this.pnSideBar.Controls.Add(this.cMenuButton3);
            this.pnSideBar.Controls.Add(this.cMenuButton2);
            this.pnSideBar.Controls.Add(this.cMenuButton1);
            this.pnSideBar.Controls.Add(this.pnFooter);
            this.pnSideBar.Controls.Add(this.pnHeader);
            this.pnSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnSideBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnSideBar.Name = "pnSideBar";
            this.pnSideBar.Size = new System.Drawing.Size(292, 738);
            this.pnSideBar.TabIndex = 0;
            // 
            // pnFooter
            // 
            this.pnFooter.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnFooter.Controls.Add(this.lbDetail);
            this.pnFooter.Controls.Add(this.btnFooter);
            this.pnFooter.Controls.Add(this.lbNameFooter);
            this.pnFooter.Controls.Add(this.pbFooter);
            this.pnFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnFooter.Location = new System.Drawing.Point(0, 689);
            this.pnFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnFooter.Name = "pnFooter";
            this.pnFooter.Size = new System.Drawing.Size(292, 49);
            this.pnFooter.TabIndex = 6;
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetail.ForeColor = System.Drawing.Color.White;
            this.lbDetail.Location = new System.Drawing.Point(48, 26);
            this.lbDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(62, 14);
            this.lbDetail.TabIndex = 3;
            this.lbDetail.Text = "Label Detail";
            // 
            // btnFooter
            // 
            this.btnFooter.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFooter.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFooter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFooter.BorderRadius = 0;
            this.btnFooter.BorderSize = 0;
            this.btnFooter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFooter.CustomTag = "";
            this.btnFooter.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFooter.FlatAppearance.BorderSize = 0;
            this.btnFooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFooter.ForeColor = System.Drawing.Color.White;
            this.btnFooter.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnFooter.HoverColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFooter.HoverImage = null;
            this.btnFooter.Image = global::CustomControl.Properties.Resources.Logout_32;
            this.btnFooter.LeaveBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnFooter.LeaveColor = System.Drawing.Color.MediumSlateBlue;
            this.btnFooter.LeaveImage = null;
            this.btnFooter.Location = new System.Drawing.Point(245, 0);
            this.btnFooter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFooter.Name = "btnFooter";
            this.btnFooter.Size = new System.Drawing.Size(47, 49);
            this.btnFooter.TabIndex = 2;
            this.btnFooter.TextColor = System.Drawing.Color.White;
            this.btnFooter.UseVisualStyleBackColor = false;
            this.btnFooter.Click += new System.EventHandler(this.btnFooter_Click);
            // 
            // lbNameFooter
            // 
            this.lbNameFooter.AutoSize = true;
            this.lbNameFooter.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameFooter.ForeColor = System.Drawing.Color.White;
            this.lbNameFooter.Location = new System.Drawing.Point(48, 6);
            this.lbNameFooter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameFooter.Name = "lbNameFooter";
            this.lbNameFooter.Size = new System.Drawing.Size(91, 18);
            this.lbNameFooter.TabIndex = 1;
            this.lbNameFooter.Text = "Label Name";
            // 
            // pbFooter
            // 
            this.pbFooter.Image = global::CustomControl.Properties.Resources._307458227_183097110912069_8713095141205203505_n;
            this.pbFooter.Location = new System.Drawing.Point(6, 6);
            this.pbFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pbFooter.Name = "pbFooter";
            this.pbFooter.Size = new System.Drawing.Size(35, 37);
            this.pbFooter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFooter.TabIndex = 0;
            this.pbFooter.TabStop = false;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnHeader.Controls.Add(this.lbNameHeader);
            this.pnHeader.Controls.Add(this.pbHeader);
            this.pnHeader.Controls.Add(this.btnMenu);
            this.pnHeader.Controls.Add(this.panel5);
            this.pnHeader.Controls.Add(this.panel6);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(292, 80);
            this.pnHeader.TabIndex = 0;
            // 
            // lbNameHeader
            // 
            this.lbNameHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNameHeader.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameHeader.ForeColor = System.Drawing.Color.White;
            this.lbNameHeader.Location = new System.Drawing.Point(115, 6);
            this.lbNameHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameHeader.Name = "lbNameHeader";
            this.lbNameHeader.Size = new System.Drawing.Size(177, 68);
            this.lbNameHeader.TabIndex = 1;
            this.lbNameHeader.Text = "Label Name";
            this.lbNameHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbHeader
            // 
            this.pbHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbHeader.Image = global::CustomControl.Properties.Resources._307458227_183097110912069_8713095141205203505_n;
            this.pbHeader.Location = new System.Drawing.Point(47, 6);
            this.pbHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pbHeader.Name = "pbHeader";
            this.pbHeader.Size = new System.Drawing.Size(68, 68);
            this.pbHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHeader.TabIndex = 0;
            this.pbHeader.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMenu.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMenu.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMenu.BorderRadius = 0;
            this.btnMenu.BorderSize = 0;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.CustomTag = "";
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.ForeColor = System.Drawing.Color.White;
            this.btnMenu.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnMenu.HoverColor = System.Drawing.Color.DarkSlateBlue;
            this.btnMenu.HoverImage = null;
            this.btnMenu.Image = global::CustomControl.Properties.Resources.bulleted_list_32px;
            this.btnMenu.LeaveBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMenu.LeaveColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMenu.LeaveImage = null;
            this.btnMenu.Location = new System.Drawing.Point(0, 6);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(47, 68);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.TextColor = System.Drawing.Color.White;
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 74);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(292, 6);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(292, 6);
            this.panel6.TabIndex = 4;
            // 
            // cMenuButton1
            // 
            this.cMenuButton1.ActiveButtonColor = System.Drawing.Color.Red;
            this.cMenuButton1.ButtonForeColor = System.Drawing.Color.White;
            this.cMenuButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cMenuButton1.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.cMenuButton1.HoverButtonColor = System.Drawing.Color.SlateBlue;
            this.cMenuButton1.Location = new System.Drawing.Point(0, 80);
            this.cMenuButton1.MainButtonImage = ((System.Drawing.Image)(resources.GetObject("cMenuButton1.MainButtonImage")));
            this.cMenuButton1.MainButtonText = "cButtonMain";
            this.cMenuButton1.Margin = new System.Windows.Forms.Padding(0);
            this.cMenuButton1.Name = "cMenuButton1";
            this.cMenuButton1.ShowStatus = true;
            this.cMenuButton1.Size = new System.Drawing.Size(292, 49);
            this.cMenuButton1.SubButtonFillColor = System.Drawing.Color.SlateBlue;
            this.cMenuButton1.SubButtonQuantity = 3;
            this.cMenuButton1.TabIndex = 7;
            // 
            // cMenuButton2
            // 
            this.cMenuButton2.ActiveButtonColor = System.Drawing.Color.Red;
            this.cMenuButton2.ButtonForeColor = System.Drawing.Color.White;
            this.cMenuButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.cMenuButton2.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.cMenuButton2.HoverButtonColor = System.Drawing.Color.SlateBlue;
            this.cMenuButton2.Location = new System.Drawing.Point(0, 129);
            this.cMenuButton2.MainButtonImage = ((System.Drawing.Image)(resources.GetObject("cMenuButton2.MainButtonImage")));
            this.cMenuButton2.MainButtonText = "cButtonMain";
            this.cMenuButton2.Margin = new System.Windows.Forms.Padding(0);
            this.cMenuButton2.Name = "cMenuButton2";
            this.cMenuButton2.ShowStatus = true;
            this.cMenuButton2.Size = new System.Drawing.Size(292, 49);
            this.cMenuButton2.SubButtonFillColor = System.Drawing.Color.SlateBlue;
            this.cMenuButton2.SubButtonQuantity = 3;
            this.cMenuButton2.TabIndex = 8;
            // 
            // cMenuButton3
            // 
            this.cMenuButton3.ActiveButtonColor = System.Drawing.Color.Red;
            this.cMenuButton3.ButtonForeColor = System.Drawing.Color.White;
            this.cMenuButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.cMenuButton3.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.cMenuButton3.HoverButtonColor = System.Drawing.Color.SlateBlue;
            this.cMenuButton3.Location = new System.Drawing.Point(0, 178);
            this.cMenuButton3.MainButtonImage = ((System.Drawing.Image)(resources.GetObject("cMenuButton3.MainButtonImage")));
            this.cMenuButton3.MainButtonText = "cButtonMain";
            this.cMenuButton3.Margin = new System.Windows.Forms.Padding(0);
            this.cMenuButton3.Name = "cMenuButton3";
            this.cMenuButton3.ShowStatus = true;
            this.cMenuButton3.Size = new System.Drawing.Size(292, 49);
            this.cMenuButton3.SubButtonFillColor = System.Drawing.Color.SlateBlue;
            this.cMenuButton3.SubButtonQuantity = 3;
            this.cMenuButton3.TabIndex = 9;
            // 
            // cMenuButton4
            // 
            this.cMenuButton4.ActiveButtonColor = System.Drawing.Color.Red;
            this.cMenuButton4.ButtonForeColor = System.Drawing.Color.White;
            this.cMenuButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.cMenuButton4.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.cMenuButton4.HoverButtonColor = System.Drawing.Color.SlateBlue;
            this.cMenuButton4.Location = new System.Drawing.Point(0, 227);
            this.cMenuButton4.MainButtonImage = ((System.Drawing.Image)(resources.GetObject("cMenuButton4.MainButtonImage")));
            this.cMenuButton4.MainButtonText = "cButtonMain";
            this.cMenuButton4.Margin = new System.Windows.Forms.Padding(0);
            this.cMenuButton4.Name = "cMenuButton4";
            this.cMenuButton4.ShowStatus = true;
            this.cMenuButton4.Size = new System.Drawing.Size(292, 49);
            this.cMenuButton4.SubButtonFillColor = System.Drawing.Color.SlateBlue;
            this.cMenuButton4.SubButtonQuantity = 3;
            this.cMenuButton4.TabIndex = 10;
            // 
            // CSideBarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnSideBar);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CSideBarMenu";
            this.Size = new System.Drawing.Size(292, 738);
            this.pnSideBar.ResumeLayout(false);
            this.pnFooter.ResumeLayout(false);
            this.pnFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFooter)).EndInit();
            this.pnHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnSideBar;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.PictureBox pbHeader;
        private CButton btnMenu;
        public System.Windows.Forms.Label lbNameHeader;
        private System.Windows.Forms.Panel pnFooter;
        public System.Windows.Forms.Label lbDetail;
        private CButton btnFooter;
        public System.Windows.Forms.Label lbNameFooter;
        private System.Windows.Forms.PictureBox pbFooter;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private CMenuButton cMenuButton4;
        private CMenuButton cMenuButton3;
        private CMenuButton cMenuButton2;
        private CMenuButton cMenuButton1;
    }
}
