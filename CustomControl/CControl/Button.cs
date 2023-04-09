using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace CustomControl
{
    public class CButton : Button
    {
        //Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.PaleVioletRed;
        private Color hoverColor = Color.Empty;
        private Color leaveColor = Color.Empty;
        private Color hoverBorderColor = Color.Empty;
        private Color leaveBorderColor = Color.Empty;
        private Image hoverImage;
        private Image leaveImage;

        //Properties
        [Category("CButton Setting")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("CButton Setting")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("CButton Setting")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                LeaveBorderColor = borderColor;
                this.Invalidate();
            }
        }

        [Category("CButton Setting")]
        public Color BackgroundColor
        {
            get { return BackColor; }
            set
            {
                BackColor = value;
                LeaveColor = BackColor;
            }
        }

        [Category("CButton Setting")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        [Category("CButton Setting")]
        public Color HoverColor
        {
            get { return hoverColor; }
            set { hoverColor = value; }
        }

        [Category("CButton Setting")]
        public Color LeaveColor
        {
            get { return leaveColor; }
            set { leaveColor = value; }
        }
        [Category("CButton Setting")]
        public Color HoverBorderColor
        {
            get { return hoverBorderColor; }
            set { hoverBorderColor = value; }
        }

        [Category("CButton Setting")]
        public Color LeaveBorderColor
        {
            get { return leaveBorderColor; }
            set { leaveBorderColor = value; }
        }
        [Category("CButton Setting")]
        public Image HoverImage
        {
            get { return hoverImage; }
            set { hoverImage = value; }
        }
        [Category("CButton Setting")]
        public Image LeaveImage
        {
            get { return leaveImage; }
            set { leaveImage = value; }
        }

        //Constructor
        public CButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
            this.Cursor = Cursors.Hand;
            this.Resize += new EventHandler(Button_Resize);
            this.MouseEnter += new EventHandler(Button_MouseEnter);
            this.MouseLeave += new EventHandler(Button_MouseLeave);
        }

        //Methods
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);


            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            if (HoverColor != Color.Empty)
                this.BackColor = HoverColor;
            if (HoverBorderColor != Color.Empty && BorderSize > 0)
                this.BorderColor = HoverBorderColor;
            if (HoverImage != null)
                this.Image = HoverImage;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (LeaveColor != Color.Empty)
                this.BackColor = LeaveColor;
            if (LeaveBorderColor != Color.Empty && BorderSize > 0)
                this.BorderColor = LeaveBorderColor;
            if (LeaveImage != null)
                this.Image = LeaveImage;
        }
    }
}