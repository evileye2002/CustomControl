using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CustomControl.Properties;

namespace CustomControl
{
    public partial class CDragAblePanel : UserControl
    {
        private Form form;
        private Color backColor = Color.MediumSlateBlue;
        private Color hoverBtnColor = Color.MediumSlateBlue;

        public event EventHandler _MaximizeClick;

        [Category("CDragAblePanel Setting")]
        public Color HoverButtonColor
        {
            get { return hoverBtnColor; }
            set
            {
                hoverBtnColor = value;
                btnMinimize.HoverColor = hoverBtnColor;
                btnMaximize.HoverColor = hoverBtnColor;
            }
        }
        [Category("CDragAblePanel Setting")]
        public Color FillColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                panel1.BackColor = backColor;
                btnClose.BackColor = backColor;
                btnMaximize.BackColor = backColor;
                btnMinimize.BackColor = backColor;
                btnClose.LeaveColor = backColor;
                btnMaximize.LeaveColor = backColor;
                btnMinimize.LeaveColor= backColor;

                if (backColor.GetBrightness() >= 0.6F) 
                {
                    btnMinimize.Image = Resources.subtract10_20px1;
                    btnMaximize.Image = Resources.maximize_button10_20px1;
                    btnClose.Image = Resources.close10_20px1;
                }
                else
                {
                    btnMinimize.Image = Resources.subtract10_20px;
                    btnMaximize.Image = Resources.maximize_button10_20px;
                    btnClose.Image = Resources.close10_20px;
                }
            }
        }
        [Category("CDragAblePanel Setting")]
        public Form TargetForm
        {
            get { return form; }
            set { form = value; }
        }
        

        public CDragAblePanel()
        {
            InitializeComponent();
            MaximumSize = new Size(3000, 40);
            Size = new Size(600, 40);
            Dock = DockStyle.Top;
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void CDragAblePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (form != null)
            {
                ReleaseCapture();
                SendMessage(form.Handle, 0x112, 0xf012, 0);
            }
        }

        private void btnCloseClick_Click(object sender, EventArgs e)
        {
            if (form != null)
                form.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (_MaximizeClick != null)
            {
                _MaximizeClick.Invoke(sender, e);

                if (form.WindowState == FormWindowState.Maximized && form != null)
                {
                    if (FillColor.GetBrightness() >= 0.6F)
                        btnMaximize.Image = Resources.restore_down_18px1;
                    else
                        btnMaximize.Image = Resources.restore_down_18px;
                }
                else
                {
                    if (FillColor.GetBrightness() >= 0.6F)
                        btnMaximize.Image = Resources.maximize_button10_20px1;
                    else
                        btnMaximize.Image = Resources.maximize_button10_20px;
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            if (form != null)
                form.WindowState = FormWindowState.Minimized;
        }
    }
}
