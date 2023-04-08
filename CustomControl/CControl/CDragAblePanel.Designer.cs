namespace CustomControl
{
    partial class CDragAblePanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new CustomControl.CButton();
            this.btnMaximize = new CustomControl.CButton();
            this.btnClose = new CustomControl.CButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnMaximize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(0, 40);
            this.panel1.MinimumSize = new System.Drawing.Size(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 40);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CDragAblePanel_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMinimize.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMinimize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMinimize.BorderRadius = 0;
            this.btnMinimize.BorderSize = 0;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverColor = System.Drawing.Color.SlateBlue;
            this.btnMinimize.Image = global::CustomControl.Properties.Resources.subtract_20px;
            this.btnMinimize.LeaveColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMinimize.Location = new System.Drawing.Point(480, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TextColor = System.Drawing.Color.White;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMaximize.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMaximize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMaximize.BorderRadius = 0;
            this.btnMaximize.BorderSize = 0;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.HoverColor = System.Drawing.Color.SlateBlue;
            this.btnMaximize.Image = global::CustomControl.Properties.Resources.maximize_button_15px;
            this.btnMaximize.LeaveColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMaximize.Location = new System.Drawing.Point(520, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnMaximize.Size = new System.Drawing.Size(40, 40);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TextColor = System.Drawing.Color.White;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClose.BorderRadius = 0;
            this.btnClose.BorderSize = 0;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverColor = System.Drawing.Color.Red;
            this.btnClose.Image = global::CustomControl.Properties.Resources.close_20px;
            this.btnClose.LeaveColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClose.Location = new System.Drawing.Point(560, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextColor = System.Drawing.Color.White;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnCloseClick_Click);
            // 
            // CDragAblePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(3000, 40);
            this.MinimumSize = new System.Drawing.Size(600, 40);
            this.Name = "CDragAblePanel";
            this.Size = new System.Drawing.Size(600, 40);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CButton btnClose;
        private CButton btnMinimize;
        private CButton btnMaximize;
    }
}
