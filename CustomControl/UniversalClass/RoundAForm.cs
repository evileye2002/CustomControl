using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public class RoundAForm
    {
        /// <summary>
        /// Round a form and border without smooth rounded
        /// </summary>
        /// <param name="form"></param>
        /// <param name="radius"></param>
        /// <param name="graph"></param>
        /// <param name="borderColor"></param>
        /// <param name="borderSize"></param>
        public static void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (form.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = SharedClass.GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);
                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);
                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        /// <summary>
        /// Round a control and border without smooth rounded
        /// </summary>
        /// <param name="control"></param>
        /// <param name="radius"></param>
        /// <param name="graph"></param>
        /// <param name="borderColor"></param>
        public static void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            if(radius > 0)
            {
                using (GraphicsPath roundPath = SharedClass.GetRoundedPath(control.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, 1))
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    control.Region = new Region(roundPath);
                    graph.DrawPath(penBorder, roundPath);
                }
            }
            else
            {
                control.Region = new Region(control.ClientRectangle);
            }
        }

        public static void DrawPath(Rectangle rect, Graphics graph, Color color, float borderRadius)
        {
            using (GraphicsPath roundPath = SharedClass.GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }

        public struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }

        /// <summary>
        /// Get color from 4 corner of a form
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        public static FormBoundsColors GetFormBoundsColors(Form form)
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);
                //Top Left
                rectBmp.X = form.Bounds.X - 1;
                rectBmp.Y = form.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);
                //Top Right
                rectBmp.X = form.Bounds.Right;
                rectBmp.Y = form.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);
                //Bottom Left
                rectBmp.X = form.Bounds.X;
                rectBmp.Y = form.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);
                //Bottom Right
                rectBmp.X = form.Bounds.Right;
                rectBmp.Y = form.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }

        //Events
        /// <summary>
        /// Round a form and border with smooth rounded
        /// </summary>
        /// <param name="e"></param>
        /// <param name="form"></param>
        /// <param name="borderRadius"></param>
        /// <param name="borderColor"></param>
        /// <param name="borderSize"></param>
        public static void FormPaint(PaintEventArgs e, Form form, int borderRadius, Color borderColor, int borderSize)
        {
            //-> SMOOTH OUTER BORDER
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rectForm = form.ClientRectangle;
            if(borderRadius > 0)
            {
                int mWidht = rectForm.Width / 2;
                int mHeight = rectForm.Height / 2;
                var fbColors = GetFormBoundsColors(form);
                //Top Left
                DrawPath(rectForm, e.Graphics, fbColors.TopLeftColor, borderRadius);
                //Top Right
                Rectangle rectTopRight = new Rectangle(mWidht, rectForm.Y, mWidht, mHeight);
                DrawPath(rectTopRight, e.Graphics, fbColors.TopRightColor, borderRadius);
                //Bottom Left
                Rectangle rectBottomLeft = new Rectangle(rectForm.X, rectForm.X + mHeight, mWidht, mHeight);
                DrawPath(rectBottomLeft, e.Graphics, fbColors.BottomLeftColor, borderRadius);
                //Bottom Right
                Rectangle rectBottomRight = new Rectangle(mWidht, rectForm.Y + mHeight, mWidht, mHeight);
                DrawPath(rectBottomRight, e.Graphics, fbColors.BottomRightColor, borderRadius);
                //-> SET ROUNDED REGION AND BORDER
                FormRegionAndBorder(form, borderRadius, e.Graphics, borderColor, borderSize);
            }
            else
            {
                form.Region = new Region(rectForm);
            }
        }
    }

}
