using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CustomControl
{
    public class SharedClass
    {
        #region NotFix

        #region Biến toàn cục
        public static CultureInfo cultureVN =  CultureInfo.GetCultureInfo("vn-VN");

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
        //Vẽ đường bo tròn cho Control (không có border)
        public static void RoundedControl(Control c, int radius, Graphics graph, Color borderColor, int borderSize)
        {
            using (GraphicsPath roundPath = GetRoundedPath(c.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            using (Matrix transform = new Matrix())
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                c.Region = new Region(roundPath);
                if (borderSize >= 1)
                {
                    Rectangle rect = c.ClientRectangle;
                    float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                    float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                    transform.Scale(scaleX, scaleY);
                    transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                    graph.Transform = transform;
                    graph.DrawPath(penBorder, roundPath);
                }
            }
        }

        //Sử dụng Form Alert
        public static void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        public static void OpenChildForm(Form childForm, object btnSender, Form activateForm, Panel pnMain)
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
        }


        #endregion

        #endregion
        //====================================================================================================
    }
}
