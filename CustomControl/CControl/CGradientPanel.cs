using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class CGradientPanel : Panel
    {
        //Fields
        Color tran = Color.Transparent;
        Color topL = Color.White;
        Color topR = Color.White;
        Color botR = Color.White;
        Color botL = Color.White;

        Color top = Color.White;
        Color bot = Color.White;
        float gradientAngle = 90F;

        int radius = 8;
        int borderSize = 0;
        Color borderColor = Color.Black;

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

        [Category("Custom Control")]
        public Color ColorTop
        {
            get { return top; }
            set
            {
                top = value;
                Invalidate();
            }
        }

        [Category("Custom Control")]
        public Color ColorBot
        {
            get { return bot; }
            set
            {
                bot = value;
                Invalidate();
            }
        }

        [Category("Custom Control")]
        public float GradientAngle
        {
            get { return gradientAngle; }
            set
            {
                gradientAngle = value;
                Invalidate();
            }
        }

       /* [Category("Custom Control")]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate();
            }
        }*/

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            LinearGradientBrush lgbTB = new LinearGradientBrush(ClientRectangle, ColorTop, ColorBot, gradientAngle);
            Graphics g = e.Graphics;
            g.FillRectangle(lgbTB, ClientRectangle);

            /*LinearGradientBrush lgbT = new LinearGradientBrush(ClientRectangle, ColorTopLeft, tran, 45F);
            LinearGradientBrush lgbB = new LinearGradientBrush(ClientRectangle, ColorTopRight, tran, 135F);
            LinearGradientBrush lgbL = new LinearGradientBrush(ClientRectangle, ColorBotRight, tran, 225F);
            LinearGradientBrush lgbR = new LinearGradientBrush(ClientRectangle, ColorBotLeft, tran, 310F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgbT, ClientRectangle);
            g.FillRectangle(lgbB, ClientRectangle);
            g.FillRectangle(lgbL, ClientRectangle);
            g.FillRectangle(lgbR, ClientRectangle);*/

            //SharedClass.RoundedControl(this, radius, e.Graphics, Color.Empty, 0);
            base.OnPaint(e);
        }
    }
}
