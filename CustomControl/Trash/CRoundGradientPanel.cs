using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    class CRoundGradientPanel : Panel
    {
        //Fields
        private int radius = 16;
        private int borderSize = 0;
        private Color gradientColor = Color.RoyalBlue;
        private Color gradientColor2 = Color.HotPink;
        private float gradientAngle = 45F;

        //Properties
        [Category("Custom Control")]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                Invalidate();//Redraw control
            }
        }

        [Category("Custom Control")]
        public Color GradientColor
        {
            get
            {
                return gradientColor;
            }

            set
            {
                gradientColor = value;
                Invalidate();
            }
        }

        [Category("Custom Control")]
        public Color GradientColor2
        {
            get
            {
                return gradientColor2;
            }

            set
            {
                gradientColor2 = value;
                Invalidate();
            }
        }

        [Category("Custom Control")]
        public float GradientAngle
        {
            get
            {
                return gradientAngle;
            }

            set
            {
                gradientAngle = value;
                Invalidate();
            }
        }

        //Events
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (radius > 2) //Rounded Panel
            {
                //Gradient
                LinearGradientBrush lgbTB = new LinearGradientBrush(rectSurface, gradientColor, gradientColor2, gradientAngle);
                g.FillRectangle(lgbTB, rectSurface);

                using (GraphicsPath pathSurface = SharedClass.GetRoundedPath(rectSurface, radius))
                using (GraphicsPath pathBorder = SharedClass.GetRoundedPath(rectBorder, radius - borderSize))
                using (Pen penSurface = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(Color.Empty, borderSize))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    //Panel surface
                    Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    g.DrawPath(penSurface, pathSurface);
                }
            }
            else //Normal Panel
            {
                //Gradient
                LinearGradientBrush lgbTB = new LinearGradientBrush(rectSurface, gradientColor, gradientColor2, gradientAngle);
                g.FillRectangle(lgbTB, rectSurface);

                g.SmoothingMode = SmoothingMode.None;
                //Panel surface
                Region = new Region(rectSurface);
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}

