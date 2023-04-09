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
            this.cSideBarMenu1 = new CustomControl.CSideBarMenu();
            this.cButton2 = new CustomControl.CButton();
            this.cButton1 = new CustomControl.CButton();
            this.cDragAblePanel1 = new CustomControl.CDragAblePanel();
            this.SuspendLayout();
            // 
            // cSideBarMenu1
            // 
            this.cSideBarMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.cSideBarMenu1.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.cSideBarMenu1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("cSideBarMenu1.HeaderImage")));
            this.cSideBarMenu1.Location = new System.Drawing.Point(0, 24);
            this.cSideBarMenu1.Margin = new System.Windows.Forms.Padding(4);
            this.cSideBarMenu1.Name = "cSideBarMenu1";
            this.cSideBarMenu1.NumberButton = 4;
            this.cSideBarMenu1.NumberSubButton1 = 0;
            this.cSideBarMenu1.NumberSubButton2 = 0;
            this.cSideBarMenu1.NumberSubButton3 = 0;
            this.cSideBarMenu1.NumberSubButton4 = 0;
            this.cSideBarMenu1.Size = new System.Drawing.Size(60, 530);
            this.cSideBarMenu1.TabIndex = 4;
            this.cSideBarMenu1._Logout_Click += new System.EventHandler(this.cSideBarMenu1__Logout_Click);
            // 
            // cButton2
            // 
            this.cButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cButton2.BorderRadius = 0;
            this.cButton2.BorderSize = 0;
            this.cButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cButton2.FlatAppearance.BorderSize = 0;
            this.cButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton2.ForeColor = System.Drawing.Color.White;
            this.cButton2.HoverBorderColor = System.Drawing.Color.Empty;
            this.cButton2.HoverColor = System.Drawing.Color.Empty;
            this.cButton2.HoverImage = null;
            this.cButton2.LeaveBorderColor = System.Drawing.Color.Empty;
            this.cButton2.LeaveColor = System.Drawing.Color.Empty;
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
            // cDragAblePanel1
            // 
            this.cDragAblePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cDragAblePanel1.FillColor = System.Drawing.Color.MediumPurple;
            this.cDragAblePanel1.HoverButtonColor = System.Drawing.Color.DarkSlateBlue;
            this.cDragAblePanel1.Location = new System.Drawing.Point(0, 0);
            this.cDragAblePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.cDragAblePanel1.MaximizeImage = ((System.Drawing.Image)(resources.GetObject("cDragAblePanel1.MaximizeImage")));
            this.cDragAblePanel1.MaximumSize = new System.Drawing.Size(3500, 49);
            this.cDragAblePanel1.Name = "cDragAblePanel1";
            this.cDragAblePanel1.Size = new System.Drawing.Size(933, 24);
            this.cDragAblePanel1.TabIndex = 5;
            this.cDragAblePanel1.TargetForm = this;
            this.cDragAblePanel1._MaximizeClick += new System.EventHandler(this.cDragAblePanel1__MaximizeClick);
            // 
            // CFlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.cSideBarMenu1);
            this.Controls.Add(this.cButton2);
            this.Controls.Add(this.cButton1);
            this.Controls.Add(this.cDragAblePanel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CFlatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CFlatForm";
            this.Load += new System.EventHandler(this.CFlatForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private CButton cButton1;
        private CButton cButton2;
        private CSideBarMenu cSideBarMenu1;
        private CDragAblePanel cDragAblePanel1;
    }
}

