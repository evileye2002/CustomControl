using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class CGradientBorderRoundPanel : Panel
    {
        //Fields
        private int borderRadius = 14;
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 45F;

        //Properties
        [Category("Custom Control")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value == 0 || value > borderSize)
                {
                    borderRadius = value;
                    Invalidate();//Redraw control
                }
            }
        }

        [Category("Custom Control")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                if (value >= 1 && value < borderRadius)
                {
                    borderSize = value;
                    Invalidate();
                }
            }
        }

        [Category("Custom Control")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Custom Control")]
        public Color BorderColor2
        {
            get
            {
                return borderColor2;
            }

            set
            {
                borderColor2 = value;
                this.Invalidate();
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
                borderLineStyle = value;
                this.Invalidate();
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
                borderCapStyle = value;
                this.Invalidate();
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
                this.Invalidate();
            }
        }


        //Events
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded Panel
            {
                using (GraphicsPath pathSurface = SharedClass.GetRoundedPath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = SharedClass.GetRoundedPath(rectBorder, borderRadius - borderSize))
                using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))//Gradient Border
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderGColor, borderSize))
                {
                    //Panel surface
                    this.Region = new Region(pathSurface);
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
                //Panel surface
                this.Region = new Region(rectSurface);
                //Panel border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.DashStyle = borderLineStyle;
                        penBorder.DashCap = borderCapStyle;
                        penBorder.Alignment = PenAlignment.Inset;
                        g.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
            
        }
    }
}
