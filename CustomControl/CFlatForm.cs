using CustomControl.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CustomControl
{
    public partial class CFlatForm : Form
    {
        public CFlatForm()
        {
            InitializeComponent();
        }

        private void cDragAblePanel1__MaximizeClick(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void CFlatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
