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

        public event EventHandler _Button1_Click;
        public event EventHandler _Button2_Click;
        public event EventHandler _Button3_Click;
        public event EventHandler _Button4_Click;

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
                else if (value <= 0)
                    numberSubButton1 = 1;
                else
                    numberSubButton1 = value;
                /*switch (numberSubButton1)
                {
                    case 1:
                        SubButton1 = 50;
                        break;
                    case 2:
                        SubButton1 = 100;
                        break;
                    case 3:
                        SubButton1 = 150;
                        break;
                    default:
                        SubButton1 = 200;
                        break;
                }*/
            }
        }

        [Category("CSideBar - Header Setting")]
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
            panel1.Height = 40;
            panel2.Height = 40;
            panel3.Height = 40;
            panel4.Height = 40;
        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            if (_Button1_Click != null)
                _Button1_Click.Invoke(sender, e);
            else
            {
                if (panel1.Height != 200)
                {
                    OffSize();
                    panel1.Height = 200;
                }
                else
                    panel1.Height = 50;
            }
        }

        private void cButton5_Click(object sender, EventArgs e)
        {
            if (_Button2_Click != null)
                _Button2_Click.Invoke(sender, e);
            else
            {
                if (panel2.Height != 200)
                {
                    OffSize();
                    panel2.Height = 200;
                }
                else
                    panel2.Height = 50;
            }
        }

        private void cButton9_Click(object sender, EventArgs e)
        {
            if (_Button3_Click != null)
                _Button3_Click.Invoke(sender, e);
            else
            {
                if (panel3.Height != 200)
                {
                    OffSize();
                    panel3.Height = 200;
                }
                else
                    panel3.Height = 50;
            }
        }

        private void cButton13_Click(object sender, EventArgs e)
        {
            if (_Button4_Click != null)
                _Button4_Click.Invoke(sender, e);
            else
            {
                if (panel4.Height != 200)
                {
                    OffSize();
                    panel4.Height = 200;
                }
                else
                    panel4.Height = 50;
            }
        }
        private void OffSize()
        {
            foreach (Panel panel in pnSideBar.Controls)
                if (panel != pnFooter && panel != pnHeader && panel.Height != 50)
                    panel.Height = 50;
        }
    }
}
