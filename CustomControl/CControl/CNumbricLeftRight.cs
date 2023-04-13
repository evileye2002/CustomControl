using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class CNumbricLeftRight : UserControl
    {
        private Color fillColor = Color.MediumSlateBlue;
        private Color textBackColor = Color.White;
        private Color textForeColor = Color.Black;
        private Color hoverColor = Color.SandyBrown;
        private int numbericValue = 1;
        private int minValue = 1;

        public event EventHandler _ValueChange;

        [Category("CNumbricLeftRight Setting")]
        public Color FillColor
        {
            get { return fillColor; }
            set
            {
                fillColor = value;
                cButton1.BackColor = fillColor;
                cButton2.BackColor = fillColor;
                cButton1.LeaveColor = fillColor;
                cButton2.LeaveColor = fillColor;
                cTextbox1.BorderColor = fillColor;
            }
        }
        [Category("CNumbricLeftRight Setting")]
        public Color TextBackColor
        {
            get { return textBackColor; }
            set
            {
                textBackColor = value;
                cTextbox1.BackColor = textBackColor;
            }
        }
        [Category("CNumbricLeftRight Setting")]
        public Color TextForeColor
        {
            get { return textForeColor; }
            set
            {
                textForeColor = value;
                cTextbox1.ForeColor = textForeColor;
            }
        }
        [Category("CNumbricLeftRight Setting")]
        public Color HoverColor
        {
            get { return hoverColor; }
            set
            {
                hoverColor = value;
                cTextbox1.BorderFocusColor = hoverColor;
                cButton1.HoverBorderColor = hoverColor;
                cButton1.HoverColor = hoverColor;
                cButton2.HoverBorderColor = hoverColor;
                cButton2.HoverColor = hoverColor;
            }
        }
        [Category("CNumbricLeftRight Setting")]
        public int NumbericValue
        {
            get { return numbericValue; }
            set
            {
                numbericValue = value;
                if(numbericValue >= minValue)
                {
                    if (numbericValue >= 0 && numbericValue < 10)
                        cTextbox1.Texts = "0" + numbericValue.ToString();
                    else
                        cTextbox1.Texts = numbericValue.ToString();
                }
                else
                {
                    if (minValue >= 0 && minValue < 10)
                        cTextbox1.Texts = "0" + minValue.ToString();
                    else
                        cTextbox1.Texts = minValue.ToString();
                }
                Invalidate();
            }
        }

        [Category("CNumbricLeftRight Setting")]
        public int MinValue
        {
            get { return minValue; }
            set
            {
                minValue = value;
                Invalidate();
            }
        }
        public CNumbricLeftRight()
        {
            InitializeComponent();
            NumbericValue = numbericValue;
            FillColor = fillColor;
            TextBackColor = textBackColor;
            TextForeColor = textForeColor;
            HoverColor = hoverColor;
            Size = new Size(90, cTextbox1.Height);
            MaximumSize = new Size(900, cTextbox1.Height);
            MinimumSize = new Size(90, cTextbox1.Height);
            this.MouseWheel += ThisMouseWheelEvent;
        }

        private void ThisMouseWheelEvent(object sender, MouseEventArgs e)
        {
            if(e.Delta > 0)
            {
                NumbericValue += 1;
            }
            else
            {
                if (numbericValue > minValue)
                    NumbericValue -= 1;
            }
        }

        private void cButton2_Click(object sender, EventArgs e)
        {
            NumbericValue += 1;
        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            if(numbericValue > minValue)
                NumbericValue -= 1;
        }

        private void cTextbox1__TextChanged(object sender, EventArgs e)
        {
            if(cTextbox1.Texts != string.Empty)
            {
                NumbericValue = Int32.Parse(cTextbox1.Texts);
                if(_ValueChange != null)
                    _ValueChange.Invoke(sender, e);
            }
        }
    }
}
