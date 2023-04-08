using CustomControl.Properties;
using System;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class CFlatForm : Form
    {
        public CFlatForm()
        {
            InitializeComponent();
        }

        private void cDragAblePanel1__MaximizeClick(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void CFlatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
