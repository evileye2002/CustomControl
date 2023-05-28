using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControl
{
    public partial class CLabel : Label
    {
        public CLabel()
        {
            onLeaveColor = ForeColor;
        }

        //Fields
        Color onHoverColor;
        Color onLeaveColor;

        [Category("Custom Control")]
        public Color OnHover_Color
        {
            get { return onHoverColor; }
            set { onHoverColor = value; }
        }

        [Category("Custom Control")]
        public Color OnLeave_Color
        {
            get { return onLeaveColor; }
            set
            {
                if (value != Color.Empty)
                    onLeaveColor = value;
                else
                    onLeaveColor = ForeColor;
            }
        }

        //Overrides
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.ForeColor = onHoverColor;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.ForeColor = onLeaveColor;
        }
    }
}
