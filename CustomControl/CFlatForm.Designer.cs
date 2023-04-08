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
            this.cDragAblePanel1 = new CustomControl.CDragAblePanel();
            this.SuspendLayout();
            // 
            // cDragAblePanel1
            // 
            this.cDragAblePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.cDragAblePanel1.FillColor = System.Drawing.Color.MediumPurple;
            this.cDragAblePanel1.HoverButtonColor = System.Drawing.Color.SeaGreen;
            this.cDragAblePanel1.Location = new System.Drawing.Point(0, 0);
            this.cDragAblePanel1.Margin = new System.Windows.Forms.Padding(4);
            this.cDragAblePanel1.MaximizeImage = ((System.Drawing.Image)(resources.GetObject("cDragAblePanel1.MaximizeImage")));
            this.cDragAblePanel1.MaximumSize = new System.Drawing.Size(3500, 40);
            this.cDragAblePanel1.MinimumSize = new System.Drawing.Size(700, 40);
            this.cDragAblePanel1.Name = "cDragAblePanel1";
            this.cDragAblePanel1.Size = new System.Drawing.Size(933, 40);
            this.cDragAblePanel1.TabIndex = 1;
            this.cDragAblePanel1.TargetForm = this;
            this.cDragAblePanel1._MaximizeClick += new System.EventHandler(this.cDragAblePanel1__MaximizeClick);
            // 
            // CFlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 554);
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
        private CDragAblePanel cDragAblePanel1;
    }
}

