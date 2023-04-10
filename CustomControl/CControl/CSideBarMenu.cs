using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CustomControl
{
    public partial class CSideBarMenu : UserControl
    {
        private int numberButton = 4;
        private int numberSubButton1 = 3;
        private int numberSubButton2 = 3;
        private int numberSubButton3 = 3;
        private int numberSubButton4 = 3;
        private int subButton1 = 200;
        private int subButton2 = 200;
        private int subButton3 = 200;
        private int subButton4 = 200;

        private bool isShow = false;
        private Color activeBtnColor = Color.Red;
        private Color fillColor = Color.MediumSlateBlue;
        private Color btnForeColor = Color.White;
        private Color subBtnColor = Color.SlateBlue;
        private Image headerImage = null;
        private Image footerImage = null;
        private CButton currencyButton;

        private Font font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
        private string fontName = "Arial";
        private float fontSize = 10F;
        private FontStyle fontStyle = FontStyle.Regular;
        private GraphicsUnit graphicsUnit = GraphicsUnit.Point;

        #region Event
        public event EventHandler _Logout_Click;
        public event EventHandler _MenuClick;
        public event EventHandler _Button1_Click;
        public event EventHandler _Button2_Click;
        public event EventHandler _Button3_Click;
        public event EventHandler _Button4_Click;
        #endregion

        [Category("CSideBar Setting")]
        public Color FillColor
        {
            get { return fillColor; }
            set
            {
                fillColor = value;
                foreach (Panel pn in pnSideBar.Controls)
                {
                    pn.BackColor = fillColor;
                    pnSideBar.BackColor = fillColor;
                    btnMenu.BackgroundColor = fillColor;
                    btnFooter.BackgroundColor = fillColor;
                    if (pn != pnFooter && pn != pnHeader)
                        foreach (CButton cButton in pn.Controls)
                        {
                            if (cButton.CustomTag == "MainBtn")
                                cButton.BackgroundColor = fillColor;
                            else
                                cButton.BackgroundColor = subBtnColor;
                        }
                            
                }
            }
        }
        [Category("CSideBar Setting")]
        public Color BtnForeColor
        {
            get { return btnForeColor; }
            set
            {
                btnForeColor = value;
                foreach (Panel pn in pnSideBar.Controls)
                {
                    pn.ForeColor = btnForeColor;
                    lbDetail.ForeColor = btnForeColor;
                    lbNameFooter.ForeColor = btnForeColor;
                    lbNameHeader.ForeColor = btnForeColor;
                    if (pn != pnFooter && pn != pnHeader)
                        foreach (CButton cButton in pn.Controls)
                            cButton.ForeColor = btnForeColor;
                }
            }
        }
        [Category("CSideBar Setting")]
        public Color ActiveBtnColor
        {
            get { return activeBtnColor; }
            set
            {
                activeBtnColor = value;
            }
        }
        [Category("CSideBar Setting")]
        public Color SubBtnColor
        {
            get { return subBtnColor; }
            set
            {
                subBtnColor = value;
                foreach(Panel panel in pnSideBar.Controls)
                    if (panel != pnFooter && panel != pnHeader)
                        foreach(CButton cButton in panel.Controls)
                        {
                            if(cButton.CustomTag != "MainBtn")
                                cButton.BackgroundColor = subBtnColor;
                        }

                    
            }
        }

        [Category("CSideBar Setting")]
        public int NumberButton
        {
            get { return numberButton; }
            set
            {
                if(value > 4)
                    numberButton = 4;
                else if(value <= 0)
                    numberButton = 1;
                else
                    numberButton = value;
                switch (numberButton)
                {
                    case 1:
                        panel2.Visible  = false;
                        panel3.Visible  = false;
                        panel4.Visible  = false;
                        break;
                    case 2:
                        panel3.Visible = false;
                        panel4.Visible = false;
                        break;
                    case 3:
                        panel4.Visible = false;
                        break;
                    default:
                        panel1.Visible = true;
                        panel2.Visible = true;
                        panel3.Visible = true;
                        panel4.Visible = true;
                        break;
                }
            }
        }
        [Category("CSideBar Setting")]
        public int NumberSubButton1
        {
            get { return numberSubButton1; }
            set
            {
                numberSubButton1 = ValidationValue(value);
                AvtivatePanelBtn(numberSubButton1, 1);
            }
        }
        [Category("CSideBar Setting")]
        public int NumberSubButton2
        {
            get { return numberSubButton2; }
            set
            {
                numberSubButton2 = ValidationValue(value);
                AvtivatePanelBtn(numberSubButton2, 2);
            }
        }
        [Category("CSideBar Setting")]
        public int NumberSubButton3
        {
            get { return numberSubButton3; }
            set
            {
                numberSubButton3 = ValidationValue(value);
                AvtivatePanelBtn(numberSubButton3,3);
            }
        }
        [Category("CSideBar Setting")]
        public int NumberSubButton4
        {
            get { return numberSubButton4; }
            set
            {
                numberSubButton4 = ValidationValue(value);
                AvtivatePanelBtn(numberSubButton4,4);
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
            pnFooter.Size = new Size(250, 40);
            
            panel1.Height = 40;
            panel2.Height = 40;
            panel3.Height = 40;
            panel4.Height = 40;
            cButton1.CustomTag = "MainBtn";
            cButton2.CustomTag = "MainBtn";
            cButton3.CustomTag = "MainBtn";
            cButton4.CustomTag = "MainBtn";
            HideSideBar();
        }
        private void DisablePanelBtn()
        {
            foreach (Panel panel in pnSideBar.Controls)
                if (panel != pnFooter && panel != pnHeader && panel.Height != 48)
                    panel.Height = 48;
        }
        private int PnHeight(int a)
        {
            switch (a)
            {
                case 0:
                    return 49;
                case 1:
                    return 98;
                case 2:
                    return 147;
                default:
                    return 196;
            }
        }
        private int ValidationValue(int incoming)
        {
            if (incoming > 3)
                return 3;
            else if (incoming < 0)
                return 0;
            else
                return incoming;
        }
        private void AvtivatePanelBtn(int n,int btn)
        {
            switch (btn)
            {
                case 1:
                    subButton1 = PnHeight(n);
                    break;
                case 2:
                    subButton2 = PnHeight(n);
                    break;
                case 3:
                    subButton3 = PnHeight(n);
                    break;
                default:
                    subButton4 = PnHeight(n);
                    break;
            }
        }

        #region Click Event
        private void cButton1_Click(object sender, EventArgs e)
        {
            if (_Button1_Click != null)
                _Button1_Click.Invoke(sender, e);
            else
            {
                if (panel1.Height != subButton1)
                {
                    DisablePanelBtn();
                    ActivateButton(sender);
                    panel1.Height = subButton1;
                }
                else
                {
                    panel1.Height = 49;
                }
            }
        }

        private void cButton5_Click(object sender, EventArgs e)
        {
            if (_Button2_Click != null)
                _Button2_Click.Invoke(sender, e);
            else
            {
                if (panel2.Height != subButton2)
                {
                    DisablePanelBtn();
                    ActivateButton(sender);
                    panel2.Height = subButton2;
                }
                else
                    panel2.Height = 49;
            }
        }

        private void cButton9_Click(object sender, EventArgs e)
        {
            if (_Button3_Click != null)
                _Button3_Click.Invoke(sender, e);
            else
            {
                if (panel3.Height != subButton3)
                {
                    DisablePanelBtn();
                    ActivateButton(sender);
                    panel3.Height = subButton3;
                }
                else
                    panel3.Height = 49;
            }
        }

        private void cButton13_Click(object sender, EventArgs e)
        {
            if (_Button4_Click != null)
                _Button4_Click.Invoke(sender, e);
            else
            {
                if (panel4.Height != subButton4)
                {
                    DisablePanelBtn();
                    ActivateButton(sender);
                    panel4.Height = subButton4;
                }
                else
                    panel4.Height = 49;
            }
        }

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
                if(this.Width != 60)
                    HideSideBar();
                else
                    ShowSideBar();
            }
        }
        #endregion
        public void HideSideBar()
        {
            this.Width = 60;
            pbHeader.Visible = false;
            pbFooter.Visible = false;
            lbDetail.Visible = false;
            lbNameFooter.Visible = false;
            lbNameHeader.Visible = false;

            btnFooter.Dock = DockStyle.Fill;
            btnMenu.Dock = DockStyle.Fill;

            foreach (Panel panel in pnSideBar.Controls)
            {
                if (panel != pnFooter && panel != pnHeader)
                {
                    foreach (CButton button in panel.Controls)
                    {
                        button.Tag = button.Text;
                        button.Text = "";
                        button.Padding = new Padding(0);
                        button.TextImageRelation = TextImageRelation.Overlay;
                        button.ImageAlign = ContentAlignment.MiddleCenter;
                    }
                }
            }
        }
        public void ShowSideBar()
        {
            this.Width = 250;
            pbHeader.Visible = true;
            pbFooter.Visible = true;
            lbDetail.Visible = true;
            lbNameFooter.Visible = true;
            lbNameHeader.Visible = true;

            btnFooter.Dock = DockStyle.Right;
            btnFooter.Width = 50;

            btnMenu.Dock = DockStyle.Left;
            btnMenu.Width = 50;
            pbHeader.Dock = DockStyle.Left;
            pbHeader.BringToFront();
            lbNameHeader.Dock = DockStyle.Fill;
            lbNameHeader.BringToFront();

            foreach (Panel panel in pnSideBar.Controls)
            {
                if (panel != pnFooter && panel != pnHeader)
                {
                    foreach (CButton button in panel.Controls)
                    {
                        if(button.CustomTag == "MainBtn")
                        {
                            button.Text = button.Tag.ToString();
                            button.Padding = new Padding(5, 0, 0, 0);
                            button.TextImageRelation = TextImageRelation.ImageBeforeText;
                            button.ImageAlign = ContentAlignment.MiddleLeft;
                        }
                        else
                        {
                            button.Text = button.Tag.ToString();
                            button.BackgroundColor = subBtnColor;
                            button.Padding = new Padding(31, 0, 0, 0);
                        }
                        
                    }
                }
            }
        }
        public void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currencyButton != (CButton)btnSender)
                {
                    DisableButton();
                    currencyButton = (CButton)btnSender;
                    currencyButton.BackgroundColor = activeBtnColor;
                    currencyButton.Font = new Font(fontName, fontSize, FontStyle.Bold, graphicsUnit);

                }
            }
        }

        public void DisableButton()
        {
            foreach (Panel pn in pnSideBar.Controls)
                if(pn != pnFooter && pn != pnHeader)
                    foreach (CButton previousBtn in pn.Controls)
                    {
                        if(previousBtn.CustomTag == "MainBtn")
                        {
                            previousBtn.BackgroundColor = fillColor;
                            previousBtn.Font = font;
                        }
                    }
        }

        private void CSideBarMenu_FontChanged(object sender, EventArgs e)
        {
            fontName = Font.Name;
            fontSize = Font.Size;
            fontStyle = Font.Style;
            graphicsUnit = Font.Unit;
            font = Font;
        }
    }
}
