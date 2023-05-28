using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace CustomControl
{
    public partial class Form_Test : Form
    {
        public Form_Test()
        {
            InitializeComponent();
        }

        private void CFlatForm_Load(object sender, EventArgs e)
        {
            //cTextbox2.Texts = "333";
        }

        private void CFlatForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cComboBox1_Paint(object sender, PaintEventArgs e)
        {
            //SharedClass.RoundedControl(cComboBox1, 16, e.Graphics, Color.Empty, 0);
        }
    }
}
