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

        private void CFlatForm_Load(object sender, EventArgs e)
        {
            /*cSideBarMenu1.cButton1.Text = "Anime";
            cSideBarMenu1.cButton5.Text = "Manga";
            cSideBarMenu1.cButton9.Text = "Manhwa";
            cSideBarMenu1.cButton13.Text = "Manhua";*/
            cDragAblePanel1.btnMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            cDragAblePanel1.btnMinimize.Padding = new Padding(0, 9, 0, 0);
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

        private void cSideBarMenu1__Logout_Click(object sender, EventArgs e)
        {

        }
    }
}
