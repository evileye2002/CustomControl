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
    public partial class CRoundGradientPanel : Panel
    {
        //Fields
        private int radius = 8;
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
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectBorder = Rectangle.Inflate(ClientRectangle, -1, -1);
            int smoothSize = 2;

            if (radius > 2) //Rounded Panel
            {
                using (GraphicsPath pathSurface = SharedClass.GetRoundedPath(ClientRectangle, radius))
                using (GraphicsPath pathBorder = SharedClass.GetRoundedPath(rectBorder, radius - 0))
                using (Pen penSurface = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(Color.Empty, 0))
                {
                    //Panel surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    g.DrawPath(penSurface, pathSurface);
                    //Panel border             
                    g.DrawPath(penBorder, pathBorder);
                }

                //Gradient
                LinearGradientBrush lgbTB = new LinearGradientBrush(ClientRectangle, gradientColor, gradientColor2, gradientAngle);
                g.FillRectangle(lgbTB, ClientRectangle);
            }
            else //Normal Panel
            {
                //Panel surface
                this.Region = new Region(ClientRectangle);
                //Panel border
                using (Pen penBorder = new Pen(Color.Empty, 0))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    g.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }

                //Gradient
                LinearGradientBrush lgbTB = new LinearGradientBrush(ClientRectangle, gradientColor, gradientColor2, gradientAngle);
                g.FillRectangle(lgbTB, ClientRectangle);
            }
        }
    }
}

