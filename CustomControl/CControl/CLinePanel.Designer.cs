namespace CustomControl
{
    partial class CLinePanel
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnBot = new System.Windows.Forms.Panel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnRight = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.IndianRed;
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(200, 3);
            this.pnTop.TabIndex = 0;
            // 
            // pnBot
            // 
            this.pnBot.BackColor = System.Drawing.Color.IndianRed;
            this.pnBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBot.Location = new System.Drawing.Point(0, 197);
            this.pnBot.Name = "pnBot";
            this.pnBot.Size = new System.Drawing.Size(200, 3);
            this.pnBot.TabIndex = 1;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.IndianRed;
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLeft.Location = new System.Drawing.Point(0, 3);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(3, 194);
            this.pnLeft.TabIndex = 2;
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.Color.IndianRed;
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(197, 3);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(3, 194);
            this.pnRight.TabIndex = 3;
            // 
            // CLinePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.pnLeft);
            this.Controls.Add(this.pnBot);
            this.Controls.Add(this.pnTop);
            this.Name = "CLinePanel";
            this.Size = new System.Drawing.Size(200, 200);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnBot;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnRight;
    }
}
