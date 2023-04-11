using CustomControl.Properties;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class CFlatForm : Form
    {
        string b;
        public CFlatForm()
        {
            InitializeComponent();
        }

        private void CFlatForm_Load(object sender, EventArgs e)
        {
            cSideBarMenu1.SetMenuButtonMainText("cMenuButton1", "Anime");
            cSideBarMenu1.SetMenuButtonSubText("cMenuButton1", "cButton1", "Anime 1");
            cSideBarMenu1.SetMenuButtonSubText("cMenuButton1", "cButton2", "Anime 2");
            cSideBarMenu1.SetMenuButtonSubText("cMenuButton1", "cButton3", "Anime 3");
            cSideBarMenu1.SetMenuButtonMainClick("cMenuButton1", clickEvent);

        }

        private void clickEvent(object sender, EventArgs e)
        {
            
        }

        private void cDragAblePanel1__MaximizeClick(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void CFlatForm_Paint(object sender, PaintEventArgs e)
        {

            //SharedClass.RoundedForm(this, 18, e.Graphics, Color.Empty, 0);
        }

        private void cMenuButton1__MainButtonClick(object sender, EventArgs e)
        {
            foreach(Control c in cSideBarMenu1.Controls)
            {
                string a = "";
                if (c.Name == "pnSideBar")
                    foreach(Control c2 in c.Controls)
                        if(c2.Name == "cMenuButton1")
                            foreach(CButton button in c2.Controls)
                                a += button.CustomTag;
                CMessageBox.Show(a);
            }
        }
    }
}
