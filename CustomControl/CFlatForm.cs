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
            //cTextbox1.PlaceholderText = "123";
            //cTextbox1.Texts = "567";
            //sTextBox1.Texts = "123";
        }

        private void CFlatForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
