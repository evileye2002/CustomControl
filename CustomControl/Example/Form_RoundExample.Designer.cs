namespace CustomControl
{
    partial class Form_RoundExample
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
            this.pnContainer = new System.Windows.Forms.Panel();
            this.btnMaximize = new CustomControl.CButton();
            this.pnContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnContainer.Controls.Add(this.btnMaximize);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(800, 450);
            this.pnContainer.TabIndex = 1;
            this.pnContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContainer_Paint);
            this.pnContainer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitleBar_MouseDown);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMaximize.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnMaximize.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMaximize.BorderRadius = 0;
            this.btnMaximize.BorderSize = 0;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.CustomTag = "";
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.HoverBorderColor = System.Drawing.Color.Empty;
            this.btnMaximize.HoverColor = System.Drawing.Color.Empty;
            this.btnMaximize.HoverImage = null;
            this.btnMaximize.LeaveBorderColor = System.Drawing.Color.Empty;
            this.btnMaximize.LeaveColor = System.Drawing.Color.Empty;
            this.btnMaximize.LeaveImage = null;
            this.btnMaximize.Location = new System.Drawing.Point(280, 320);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(150, 40);
            this.btnMaximize.TabIndex = 0;
            this.btnMaximize.Text = "Maximize";
            this.btnMaximize.TextColor = System.Drawing.Color.White;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // Form_RoundExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnContainer);
            this.Name = "Form_RoundExample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form_RoundExample_Activated);
            this.ResizeEnd += new System.EventHandler(this.Form_RoundExample_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.Form_RoundExample_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_RoundExample_Paint);
            this.pnContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnContainer;
        private CButton btnMaximize;
    }
}