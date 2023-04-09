using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class CSideBarMenu : UserControl
    {
        private Color fillColor = Color.MediumSlateBlue;
        private int numberButton = 4;
        private int numberSubButton1 = 3;
        private int numberSubButton2 = 3;
        private int numberSubButton3 = 3;
        private int numberSubButton4 = 3;
        private int SubButton1 = 200;
        private int SubButton2 = 200;
        private int SubButton3 = 200;
        private int SubButton4 = 200;
        private Image headerImage = Properties.Resources._307458227_183097110912069_8713095141205203505_n;

        public event EventHandler _Logout_Click;
        public event EventHandler _MenuClick;
        public event EventHandler _Button1_Click;
        public event EventHandler _Button2_Click;
        public event EventHandler _Button3_Click;
        public event EventHandler _Button4_Click;

        public event EventHandler _SubButton1_Click1;
        public event EventHandler _SubButton1_Click2;
        public event EventHandler _SubButton1_Click3;

        public event EventHandler _SubButton2_Click1;
        public event EventHandler _SubButton2_Click2;
        public event EventHandler _SubButton2_Click3;

        public event EventHandler _SubButton3_Click1;
        public event EventHandler _SubButton3_Click2;
        public event EventHandler _SubButton3_Click3;

        public event EventHandler _SubButton4_Click1;
        public event EventHandler _SubButton4_Click2;
        public event EventHandler _SubButton4_Click3;

        [Category("CSideBar Setting")]
        public Color FillColor
        {
            get { return fillColor; }
            set
            {
                fillColor = value;
                pnFooter.BackColor = fillColor;
                btnFooter.BackColor = fillColor;
                lbNameFooter.BackColor = fillColor;
                lbDetail.BackColor = fillColor;
                pnHeader.BackColor = fillColor;
                btnMenu.BackColor = fillColor;
                lbNameHeader.BackColor = fillColor;
                pnSideBar.BackColor = fillColor;

                foreach(CButton cButton in panel1.Controls)
                    cButton.BackgroundColor = fillColor;
                foreach (CButton cButton in panel2.Controls)
                    cButton.BackgroundColor = fillColor;
                foreach (CButton cButton in panel3.Controls)
                    cButton.BackgroundColor = fillColor;
                foreach (CButton cButton in panel4.Controls)
                    cButton.BackgroundColor = fillColor;
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
                if (value > 3)
                    numberSubButton1 = 3;
                else if (value < 0)
                    numberSubButton1 = 0;
                else
                    numberSubButton1 = value;

                SetSubButton(numberSubButton1, 1);
            }
        }
        [Category("CSideBar Setting")]
        public int NumberSubButton2
        {
            get { return numberSubButton2; }
            set
            {
                if (value > 3)
                    numberSubButton2 = 3;
                else if (value < 0)
                    numberSubButton1 = 0;
                else
                    numberSubButton2 = value;

                SetSubButton(numberSubButton2, 2);
            }
        }
        [Category("CSideBar Setting")]
        public int NumberSubButton3
        {
            get { return numberSubButton3; }
            set
            {
                if (value > 3)
                    numberSubButton3 = 3;
                else if (value < 0)
                    numberSubButton3 = 0;
                else
                    numberSubButton3 = value;

                SetSubButton(numberSubButton3,3);
            }
        }
        [Category("CSideBar Setting")]
        public int NumberSubButton4
        {
            get { return numberSubButton4; }
            set
            {
                if (value > 3)
                    numberSubButton4 = 3;
                else if (value < 0)
                    numberSubButton4 = 0;
                else
                    numberSubButton4 = value;

                SetSubButton(numberSubButton4,4);
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


        public CSideBarMenu()
        {
            InitializeComponent();
            pnHeader.Size = new Size(300, 70);
            pnFooter.Size = new Size(300, 40);
            panel1.Height = 49;
            panel2.Height = 49;
            panel3.Height = 49;
            panel4.Height = 49;
        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            if (_Button1_Click != null)
                _Button1_Click.Invoke(sender, e);
            else
            {
                if (panel1.Height != SubButton1)
                {
                    OffSize();
                    panel1.Height = SubButton1;
                }
                else
                    panel1.Height = 49;
            }
        }

        private void cButton5_Click(object sender, EventArgs e)
        {
            if (_Button2_Click != null)
                _Button2_Click.Invoke(sender, e);
            else
            {
                if (panel2.Height != SubButton2)
                {
                    OffSize();
                    panel2.Height = SubButton2;
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
                if (panel3.Height != SubButton3)
                {
                    OffSize();
                    panel3.Height = SubButton3;
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
                if (panel4.Height != SubButton4)
                {
                    OffSize();
                    panel4.Height = SubButton4;
                }
                else
                    panel4.Height = 49;
            }
        }
        private void OffSize()
        {
            foreach (Panel panel in pnSideBar.Controls)
                if (panel != pnFooter && panel != pnHeader && panel.Height != 50)
                    panel.Height = 50;
        }
        private void SetSubButton(int n,int btn)
        {
            switch (btn)
            {
                case 1:
                    switch (n)
                    {
                        case 0:
                            SubButton1 = 49;
                            break;
                        case 1:
                            SubButton1 = 98;
                            break;
                        case 2:
                            SubButton1 = 147;
                            break;
                        default:
                            SubButton1 = 200;
                            break;
                    }
                    break;
                case 2:
                    switch (n)
                    {
                        case 0:
                            SubButton2 = 49;
                            break;
                        case 1:
                            SubButton2 = 98;
                            break;
                        case 2:
                            SubButton2 = 147;
                            break;
                        default:
                            SubButton2 = 200;
                            break;
                    }
                    break;
                case 3:
                    switch (n)
                    {
                        case 0:
                            SubButton3 = 49;
                            break;
                        case 1:
                            SubButton3 = 98;
                            break;
                        case 2:
                            SubButton3 = 147;
                            break;
                        default:
                            SubButton3 = 200;
                            break;
                    }
                    break;
                default:
                    switch (n)
                    {
                        case 0:
                            SubButton4 = 49;
                            break;
                        case 1:
                            SubButton4 = 98;
                            break;
                        case 2:
                            SubButton4 = 147;
                            break;
                        default:
                            SubButton4 = 200;
                            break;
                    }
                    break;
            }
        }

        #region Click Event
        private void cButton2_Click(object sender, EventArgs e)
        {
            if (_SubButton1_Click1 != null)
                _SubButton1_Click1.Invoke(sender, e);
        }

        private void cButton3_Click(object sender, EventArgs e)
        {
            if (_SubButton1_Click2 != null)
                _SubButton1_Click2.Invoke(sender, e);
        }

        private void cButton4_Click(object sender, EventArgs e)
        {
            if (_SubButton1_Click3 != null)
                _SubButton1_Click3.Invoke(sender, e);
        }

        private void cButton6_Click(object sender, EventArgs e)
        {
            if (_SubButton2_Click1 != null)
                _SubButton2_Click1.Invoke(sender, e);
        }

        private void cButton7_Click(object sender, EventArgs e)
        {
            if (_SubButton2_Click2 != null)
                _SubButton2_Click2.Invoke(sender, e);
        }

        private void cButton8_Click(object sender, EventArgs e)
        {
            if (_SubButton2_Click3 != null)
                _SubButton2_Click3.Invoke(sender, e);
        }

        private void cButton10_Click(object sender, EventArgs e)
        {
            if (_SubButton3_Click1 != null)
                _SubButton3_Click1.Invoke(sender, e);
        }

        private void cButton11_Click(object sender, EventArgs e)
        {
            if (_SubButton3_Click2 != null)
                _SubButton3_Click2.Invoke(sender, e);
        }

        private void cButton12_Click(object sender, EventArgs e)
        {
            if (_SubButton3_Click3 != null)
                _SubButton3_Click3.Invoke(sender, e);
        }

        private void cButton14_Click(object sender, EventArgs e)
        {
            if (_SubButton4_Click1 != null)
                _SubButton4_Click1.Invoke(sender, e);
        }

        private void cButton15_Click(object sender, EventArgs e)
        {
            if (_SubButton4_Click2 != null)
                _SubButton4_Click2.Invoke(sender, e);
        }

        private void cButton16_Click(object sender, EventArgs e)
        {
            if (_SubButton4_Click3 != null)
                _SubButton4_Click3.Invoke(sender, e);
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
        }
        #endregion

    }
}
