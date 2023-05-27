using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CustomControl
{
    public partial class Form_RoundExample : Form
    {
        //Constructor
        public Form_RoundExample()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            //this.pnTitleBar.BackColor = borderColor;
            this.BackColor = borderColor;
            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
        }

        #region <-- Smooth Rounded Form -->
        //Fields
        private int borderRadius = 20;
        private int borderSize = 3;
        private Color borderColor = Color.FromArgb(128, 128, 255);

        #region <-- Drag Form -->
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if(WindowState != FormWindowState.Maximized)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- Minimize borderless form from taskbar
                return cp;
            }
        }

        /*protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0X0083;
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1) { return; }
            base.WndProc(ref m);
        }*/

        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        #endregion

        //Events
        private void Form_RoundExample_Paint(object sender, PaintEventArgs e)
        {
            RoundAForm.FormPaint(e, this, borderRadius, borderColor, borderSize);
        }
        private void Form_RoundExample_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Form_RoundExample_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Form_RoundExample_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void pnContainer_Paint(object sender, PaintEventArgs e)
        {
            RoundAForm.ControlRegionAndBorder(pnContainer, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Normal)
            {
                borderColor = Color.FromArgb(128, 128, 255);
                borderSize = 3;
                borderRadius = 20;
                this.Padding = new Padding(borderSize);
                this.WindowState = FormWindowState.Normal;
                this.Invalidate();
                pnContainer.Invalidate();
            }
            else
            {
                borderColor = Color.Empty;
                borderSize = 0;
                borderRadius = 0;
                this.Padding = new Padding(0);
                MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                this.Invalidate();
                pnContainer.Invalidate();
            }
        }
        #endregion

    }
}
