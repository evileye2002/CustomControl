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
            this.cMenuButton1 = new CustomControl.CMenuButton();
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
            this.cDragAblePanel1.Location = new System.Drawing.Point(72, 28);
            this.cDragAblePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.cDragAblePanel1.MaximumSize = new System.Drawing.Size(3500, 49);
            this.cDragAblePanel1.Name = "cDragAblePanel1";
            this.cDragAblePanel1.Size = new System.Drawing.Size(600, 40);
            this.cDragAblePanel1.TabIndex = 13;
            this.cDragAblePanel1.TargetForm = this;
            this.cDragAblePanel1._MaximizeClick += new System.EventHandler(this.cDragAblePanel1__MaximizeClick);
            // 
            // cMenuButton1
            // 
            this.cMenuButton1.AtiveButtonColor = System.Drawing.Color.Red;
            this.cMenuButton1.ButtonForeColor = System.Drawing.Color.White;
            this.cMenuButton1.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.cMenuButton1.Location = new System.Drawing.Point(501, 161);
            this.cMenuButton1.MainButtonImage = ((System.Drawing.Image)(resources.GetObject("cMenuButton1.MainButtonImage")));
            this.cMenuButton1.Margin = new System.Windows.Forms.Padding(0);
            this.cMenuButton1.Name = "cMenuButton1";
            this.cMenuButton1.ShowStatus = true;
            this.cMenuButton1.Size = new System.Drawing.Size(250, 49);
            this.cMenuButton1.SubButtonFillColor = System.Drawing.Color.SlateBlue;
            this.cMenuButton1.SubButtonQuantity = 5;
            this.cMenuButton1.TabIndex = 14;
            this.cMenuButton1._MainButtonClick += new System.EventHandler(this.cMenuButton1__MainButtonClick);
            // 
            // CFlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
            this.Controls.Add(this.cMenuButton1);
            this.Controls.Add(this.cDragAblePanel1);
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
        private CDragAblePanel cDragAblePanel1;
        private CMenuButton cMenuButton1;
    }
}

