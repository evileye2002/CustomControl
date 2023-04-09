using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl.CControl
{
    public partial class CNumbricLeftRight : UserControl
    {
        private Color fillColor = Color.MediumSlateBlue;
        private Color textBackColor = Color.White;
        private Color textForeColor = Color.Black;
        private Color hoverColor = Color.SandyBrown;
        private int numbericValue = 1;

        [Category("CNumbricLeftRight Setting")]
        public Color FillColor
        {
            get { return fillColor; }
            set
            {
                fillColor = value;
                cButton1.BackColor = fillColor;
                cButton2.BackColor = fillColor;
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
            }
        }
        [Category("CNumbricLeftRight Setting")]
        public int NumbericValue
        {
            get { return numbericValue; }
            set
            {
                numbericValue = value;
                if(numbericValue >= 0 && numbericValue < 10)
                    cTextbox1.Texts = "0" + numbericValue.ToString();
                else
                    cTextbox1.Texts = numbericValue.ToString();
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
        }

        private void cButton2_Click(object sender, EventArgs e)
        {
            NumbericValue += 1;
        }

        private void cButton1_Click(object sender, EventArgs e)
        {
            NumbericValue -= 1;
        }

        private void cTextbox1__TextChanged(object sender, EventArgs e)
        {
            if(cTextbox1.Texts != string.Empty)
                NumbericValue = Int32.Parse(cTextbox1.Texts);
        }
    }
}
