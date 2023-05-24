using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class CRoundAControl : Component
    {
        private Control control;
        private int radius = 8;
        private Color borderColor = Color.Black;
        private int borderSize = 2;

        /*[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
               int nLeftRect,
               int nTopRect,
               int nRightRect,
               int nBottomRect,
               int nWidthEllipse,
               int nHeightEllipse
            );*/

        [Category("Custom Control")]
        public Control TargetControl
        {
            get { return control; }
            set
            {
                if (control != null && value != control)
                {
                    control = value;
                    control.Paint -= Control_Paint;
                }
                else if (value != null)
                {
                    control = value;
                    control.Paint += Control_Paint;
                }
                //control.SizeChanged += (sender, eventArgs) => control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius));
            }
        }

        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                if (control != null)
                {
                    //control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, radius, radius));
                    control.Paint += Control_Paint;
                }
            }
        }

        /*public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                if (control != null && borderSize > 0)
                {
                    control.Paint += Control_Paint;
                }
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                if (control != null)
                {
                    control.Paint += Control_Paint;
                }
            }
        }*/

        private void Control_Paint(object sender, PaintEventArgs e)
        {
            SharedClass.RoundedControl(control, radius, e.Graphics, Color.Empty, 0);
        }
    }
}