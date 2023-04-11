using CustomControl.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class CSideBarMenu : UserControl
    {
        private int menuButtonQuantity = 4;
        private bool isShow = false;

        private Color activeButtonColor = Color.Red;
        private Color fillColor = Color.MediumSlateBlue;
        private Color buttonForeColor = Color.White;
        private Color hoverButtonColor = Color.SlateBlue;
        private Color subButtonFillColor = Color.SlateBlue;

        private Image headerImage = null;
        private Image footerImage = null;

        #region Event
        public event EventHandler _Logout_Click;
        public event EventHandler _MenuClick;
        #endregion

        [Category("CSideBar Setting")]
        public Color FillColor
        {
            get { return fillColor; }
            set
            {
                fillColor = value;
                foreach (Control c in pnSideBar.Controls)
                {
                    if(c.GetType() == typeof(Panel))
                    {
                        c.BackColor = fillColor;
                        pnSideBar.BackColor = fillColor;
                        btnMenu.BackgroundColor = fillColor;
                        btnFooter.BackgroundColor = fillColor;
                    }
                    if (c.GetType() == typeof(CMenuButton))
                        ((CMenuButton)c).FillColor = fillColor;
                }
            }
        }
        [Category("CSideBar Setting")]
        public Color SubButtonFillColor
        {
            get { return subButtonFillColor; }
            set
            {
                subButtonFillColor = value;
                foreach (Control c in pnSideBar.Controls)
                {
                    if (c.GetType() == typeof(CMenuButton))
                        ((CMenuButton)c).SubButtonFillColor = subButtonFillColor;
                }
            }
        }
        [Category("CSideBar Setting")]
        public Color HoverButtonColor
        {
            get { return hoverButtonColor; }
            set
            {
                hoverButtonColor = value;
                foreach (Control c in pnSideBar.Controls)
                {
                    if (c.GetType() == typeof(CMenuButton))
                        ((CMenuButton)c).HoverButtonColor = hoverButtonColor;
                }
            }
        }
        [Category("CSideBar Setting")]
        public Color BtnForeColor
        {
            get { return buttonForeColor; }
            set
            {
                buttonForeColor = value;
                foreach (Control c in pnSideBar.Controls)
                {
                    if(c.GetType() == typeof(Panel))
                    {
                        c.ForeColor = buttonForeColor;
                        lbDetail.ForeColor = buttonForeColor;
                        lbNameFooter.ForeColor = buttonForeColor;
                        lbNameHeader.ForeColor = buttonForeColor;
                    }
                    if (c.GetType() == typeof(CMenuButton))
                        ((CMenuButton)c).ButtonForeColor = buttonForeColor;
                }
            }
        }
        [Category("CSideBar Setting")]
        public Color ActiveBtnColor
        {
            get { return activeButtonColor; }
            set
            {
                activeButtonColor = value;
                foreach (Control c in pnSideBar.Controls)
                    if (c.GetType() == typeof(CMenuButton))
                        ((CMenuButton)c).ActiveButtonColor = activeButtonColor;
            }
        }

        [Category("CSideBar Setting")]
        public int MenuButtonQuantity
        {
            get { return menuButtonQuantity; }
            set
            {
                if (value > 4 && value != menuButtonQuantity)
                {
                    foreach(Control control in pnSideBar.Controls)
                    {
                        if (control.GetType() == typeof(CMenuButton))
                            if (control.Name != "cMenuButton1" && control.Name != "cMenuButton2" && control.Name != "cMenuButton3" && control.Name != "cMenuButton4") 
                                pnSideBar.Controls.Remove(control);
                    }

                    menuButtonQuantity = value;
                    for(int i = 4; i < menuButtonQuantity; i++)
                    {
                        AddMenuButton(i + 1);
                    }
                }
                else if (value <= 4)
                {
                    foreach(Control control in pnSideBar.Controls)
                    {
                        if (control.Name != "cMenuButton1" && control.Name != "cMenuButton2" && control.Name != "cMenuButton3" && control.Name != "cMenuButton4")
                            pnSideBar.Controls.Remove(control);
                    }
                    menuButtonQuantity = value;
                }
                Invalidate();
            }
        }
        [Category("CSideBar Setting")]
        public bool ShowStatus
        {
            get { return isShow; }
            set
            {
                isShow = value;
                if (isShow)
                    ShowSideBar();
                else
                    HideSideBar();
            }
        }

        [Category("CSideBar Setting")]
        public Image HeaderImage
        {
            get { return headerImage; }
            set
            {
                headerImage = value;
                pbHeader.Image = headerImage;
            }
        }
        [Category("CSideBar Setting")]
        public Image FooterImage
        {
            get { return footerImage; }
            set
            {
                footerImage = value;
                pbFooter.Image = footerImage;
            }
        }

        public CSideBarMenu()
        {
            InitializeComponent();
            pnHeader.Size = new Size(250, 70);
            pnFooter.Size = new Size(250, 50);
            HideSideBar();
        }

        #region Click Event
        private void btnFooter_Click(object sender, EventArgs e)
        {
            if (_Logout_Click != null)
                _Logout_Click.Invoke(sender, e);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (_MenuClick != null)
                _MenuClick.Invoke(sender, e);
            else
            {
                if (Width != 60)
                    HideSideBar();
                else
                    ShowSideBar();
            }
        }
        #endregion
        public void HideSideBar()
        {
            Width = 60;
            pbHeader.Visible = false;
            pbFooter.Visible = false;
            lbDetail.Visible = false;
            lbNameFooter.Visible = false;
            lbNameHeader.Visible = false;
            btnFooter.Dock = DockStyle.Fill;
            btnMenu.Dock = DockStyle.Fill;

            foreach (Control c in pnSideBar.Controls)
                if (c.GetType() == typeof(CMenuButton))
                    ((CMenuButton)c).ShowStatus = false;
        }
        public void ShowSideBar()
        {
            Width = 250;
            pbHeader.Visible = true;
            pbFooter.Visible = true;
            lbDetail.Visible = true;
            lbNameFooter.Visible = true;
            lbNameHeader.Visible = true;
            btnFooter.Dock = DockStyle.Right;
            btnFooter.Width = 40;
            btnMenu.Dock = DockStyle.Left;
            btnMenu.Width = 50;
            pbHeader.Dock = DockStyle.Left;
            pbHeader.BringToFront();
            lbNameHeader.Dock = DockStyle.Fill;
            lbNameHeader.BringToFront();

            foreach (Control c in pnSideBar.Controls)
                if (c.GetType() == typeof(CMenuButton))
                    ((CMenuButton)c).ShowStatus = true;
        }

        private void AddMenuButton(int n)
        {
            CMenuButton menuButton = new CMenuButton
            {
                ActiveButtonColor = activeButtonColor,
                ButtonForeColor = buttonForeColor,
                HoverButtonColor = hoverButtonColor,
                Dock = DockStyle.Top,
                FillColor = fillColor,
                MainButtonImage = Resources.Cutlery_32,
                Margin = new Padding(0),
                Name = "cMenuButton" + n,
                ShowStatus = isShow,
                Height = 40,
                SubButtonFillColor = subButtonFillColor,
                SubButtonQuantity = 3,
            };
            pnSideBar.Controls.Add(menuButton);
            menuButton.BringToFront();
        }
    }
}
