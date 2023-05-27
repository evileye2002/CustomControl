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
    public partial class CGradientPanel : Panel
    {
        //Fields
        private int radius = 14;
        private Color gradientColor = Color.RoyalBlue;
        private Color gradientColor2 = Color.HotPink;
        private float gradientAngle = 45F;

        private int borderSize = 0;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;

        //Properties - Fill
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

        //Properties - Border
        [Category("Custom Control")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                if (value < radius || radius == 0)
                {
                    borderSize = value;
                    Invalidate();
                }
            }
        }

        [Category("Custom Control")]
        public DashStyle BorderLineStyle
        {
            get
            {
                return borderLineStyle;
            }

            set
            {
                if (radius > 2)
                {
                    borderLineStyle = value;
                    this.Invalidate();
                }
            }
        }

        [Category("Custom Control")]
        public DashCap BorderCapStyle
        {
            get
            {
                return borderCapStyle;
            }

            set
            {
                if(radius > 2)
                {
                    borderCapStyle = value;
                    this.Invalidate();
                }
            }
        }

        //Events Override
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
                if(borderSize == 0)
                {
                    LinearGradientBrush lgbTB = new LinearGradientBrush(rectSurface, gradientColor, gradientColor2, gradientAngle);
                    g.FillRectangle(lgbTB, rectSurface);
                }

                using (GraphicsPath pathSurface = SharedClass.GetRoundedPath(rectSurface, radius))
                using (GraphicsPath pathBorder = SharedClass.GetRoundedPath(rectBorder, radius - borderSize))

                //Gradient Border
                using (var borderGColor = new LinearGradientBrush(rectBorder, gradientColor, gradientColor2, gradientAngle))
                using (Pen penSurface = new Pen(Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderGColor, borderSize))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    //Panel surface
                    Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    g.DrawPath(penSurface, pathSurface);
                    penBorder.DashStyle = borderLineStyle;
                    penBorder.DashCap = borderCapStyle;
                    //Panel border                    
                    if (borderSize >= 1)
                        //Draw control border
                        g.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal Panel
            {
                //Gradient
                if (borderSize == 0)
                {
                    LinearGradientBrush lgbTB = new LinearGradientBrush(rectSurface, gradientColor, gradientColor2, gradientAngle);
                    g.FillRectangle(lgbTB, rectSurface);
                }

                g.SmoothingMode = SmoothingMode.None;
                //Panel surface
                Region = new Region(rectSurface);
                //Panel border
                if (borderSize >= 1)
                {
                    using (var borderGColor = new LinearGradientBrush(rectBorder, gradientColor, gradientColor2, gradientAngle))
                    using (Pen penBorder = new Pen(borderGColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;

                        g.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
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
