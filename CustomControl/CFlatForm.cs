using System;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControl
{
    public partial class CFlatForm : Form
    {
        public CFlatForm()
        {
            InitializeComponent();
        }

        private void CFlatForm_Load(object sender, EventArgs e)
        {

        }

        private void CFlatForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //SharedClass.RoundedControl(panel1,16,e.Graphics, Color.BlueViolet, 3);
        }
    }
}
