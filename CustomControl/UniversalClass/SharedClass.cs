using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CustomControl
{
    public class SharedClass
    {
        #region NotFix

        #region Biến toàn cục
        public static CultureInfo cultureVN = CultureInfo.GetCultureInfo("vn-VN");
        public static Form form2 { get; set; }

        #endregion

        #region Other
        //Đổ dữ liệu vào DataGridView
        public static void FillDGV(DataGridView dgv, string sql, SqlConnection sqlConnection)
        {
            dgv.DataSource = SqlClass.FillTable(sql, sqlConnection);
        }

        //Đổ dữ liệu vào ComboBox
        public static void FillCBB(string sql, CComboBox cbo/*, string ma*/, string ten, SqlConnection sqlConnection)
        {
            cbo.DataSource = SqlClass.FillTable(sql, sqlConnection);
            //cbo.ValueMember = ma; //Trường giá trị
            cbo.DisplayMember = ten; //Trường hiển thị
        }

        //Lấy GraphicPath dựa trên bán kính nhập vào
        public static GraphicsPath GetRoundedPath(Rectangle rect, float radius)
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
        //Vẽ đường bo tròn cho Form
        public static void RoundedForm(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (form.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
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

        //Vẽ đường bo tròn cho Control
        public static void RoundedControl(Control c, int radius, Graphics graphics, Color borderColor, int borderSize)
        {
            Rectangle rectSurface = c.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (radius > 2) //Rounded Control
            {
                using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, radius))
                using (GraphicsPath pathBorder = GetRoundedPath(rectBorder, radius - borderSize))
                using (Pen penSurface = new Pen(c.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Control surface
                    c.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    graphics.DrawPath(penSurface, pathSurface);
                }
            }
            else //Normal Control
            {
                graphics.SmoothingMode = SmoothingMode.None;
                //Control surface
                c.Region = new Region(rectSurface);
            }
        }

        //Sử dụng Form Alert
        public static void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public static Form OpenChildForm(Form childForm, Form activateForm, Panel pnMain)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(childForm);
            pnMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            return activateForm;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public extern static void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        public static void DragEvent(object sender, MouseEventArgs e)
        {
            if (form2 != null && form2.WindowState != FormWindowState.Maximized)
            {
                ReleaseCapture();
                SendMessage(form2.Handle, 0x112, 0xf012, 0);
            }
        }

        public static void CenterControl(Control control, Control parent)
        {
            control.Left = (parent.Width - control.Width) / 2;
            control.Top = (parent.Height - control.Height) / 2;
        }

        /// <summary>
        /// Get all child controls of a control
        /// </summary>
        /// <param name="root">Control want to get all child</param>
        /// <returns></returns>
        public static IEnumerable<Control> GetAllControls(Control root)
        {
            var queue = new Queue<Control>();

            queue.Enqueue(root);

            do
            {
                var control = queue.Dequeue();

                yield return control;

                foreach (var child in control.Controls.OfType<Control>())
                    queue.Enqueue(child);

            } while (queue.Count > 0);

        }
        #endregion

        #endregion
        //====================================================================================================
    }
}
