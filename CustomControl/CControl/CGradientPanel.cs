using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    class CGradientPanel : Panel
    {
        //Fields
        Color tran = Color.Transparent;
        Color topL = Color.White;
        Color topR = Color.White;
        Color botR = Color.White;
        Color botL = Color.White;

        Color top = Color.White;
        Color bot = Color.White;

        Color borderColor = Color.Black;
        int radius = 8;
        int borderSize = 0;

        /*public Color ColorTopLeft
        {
            get { return topL; }
            set
            {
                topL = value;
                Invalidate();
            }
        }
        public Color ColorTopRight
        {
            get { return topR; }
            set
            {
                topR = value;
                Invalidate();
            }
        }
        public Color ColorBotRight
        {
            get { return botR; }
            set
            {
                botR = value;
                Invalidate();
            }
        }
        public Color ColorBotLeft
        {
            get { return botL; }
            set
            {
                botL = value;
                Invalidate();
            }
        }*/

        public Color ColorTop
        {
            get { return top; }
            set
            {
                top = value;
                Invalidate();
            }
        }

        public Color ColorBot
        {
            get { return bot; }
            set
            {
                bot = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            /*LinearGradientBrush lgbT = new LinearGradientBrush(ClientRectangle, ColorTopLeft, tran, 45F);
            LinearGradientBrush lgbB = new LinearGradientBrush(ClientRectangle, ColorTopRight, tran, 135F);
            LinearGradientBrush lgbL = new LinearGradientBrush(ClientRectangle, ColorBotRight, tran, 225F);
            LinearGradientBrush lgbR = new LinearGradientBrush(ClientRectangle, ColorBotLeft, tran, 310F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgbT, ClientRectangle);
            g.FillRectangle(lgbB, ClientRectangle);
            g.FillRectangle(lgbL, ClientRectangle);
            g.FillRectangle(lgbR, ClientRectangle);*/

            LinearGradientBrush lgbTB = new LinearGradientBrush(ClientRectangle, ColorTop, ColorBot, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgbTB, ClientRectangle);

            SharedClass.RoundedControl(this, radius, e.Graphics, borderColor, borderSize);
            base.OnPaint(e);
        }
    }
}
