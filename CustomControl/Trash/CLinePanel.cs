using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControl
{
    partial class CLinePanel : UserControl
    {
        private int borderSize = 0;
        private Color borderColor = Color.IndianRed;

        [Category("CLinePanel Setting")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                pnTop.Height = borderSize;
                pnBot.Height = borderSize;
                pnLeft.Width = borderSize;
                pnRight.Width = borderSize;
                Invalidate();
            }
        }
        [Category("CLinePanel Setting")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                pnTop.BackColor = borderColor;
                pnBot.BackColor = borderColor;
                pnLeft.BackColor = borderColor;
                pnRight.BackColor = borderColor;
                Invalidate();
            }
        }
        public CLinePanel()
        {
            InitializeComponent();
        }
    }
}
