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
            foreach (CButton button in cMenuButton1.Controls)
                if(button.Name.ToString() == "NewSubButton4")
                    button.Click += NewSubButton4_Click;
        }

        private void NewSubButton4_Click(object sender, EventArgs e)
        {
            CMessageBox.Show("success");
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
            foreach (CButton button in cMenuButton1.Controls)
                b += button.Name.ToString() + " \n";
            CMessageBox.Show(b);
        }
    }
}
