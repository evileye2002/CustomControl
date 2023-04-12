using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CustomControl.Properties;
namespace CustomControl
{
    /// <summary>
    /// Use "foreach (CButton button in cMenuButton1.Controls)
    ///         if (button.Name.ToString() == <name>)"
    ///             button.Click += <ClickEvent>;
    /// to add "Click Event" or every other Event
    /// </summary>
    public partial class CMenuButton : UserControl
    {
        #region Fields
        private int subButtonQuantity = 3;
        private int cButtonHeight = 49;
        private Color fillColor = Color.MediumSlateBlue;
        private Color subButtonFillColor = Color.SlateBlue;
        private Color buttonForeColor = Color.White;
        private Color activeButtonColor = Color.Red;
        private Color hoverButtonColor = Color.SlateBlue;
        private string mainButtonText = "cButtonMain";
        public CButton newCButton;
        private CButton currencyButton;
        private Image mainButtonImage = Resources.Cutlery_32;
        private Font font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
        private string fontName = "Arial";
        private float fontSize = 10F;
        private GraphicsUnit graphicsUnit = GraphicsUnit.Point;
        private bool isShow = true;
        #endregion

        #region Event
        public event EventHandler _MainButtonClick;
        #endregion

        #region Properties
        [Category("CMenuButton Setting")]
        public Color FillColor
        {
            get { return fillColor; }
            set
            {
                fillColor = value;
                cButtonMain.BackgroundColor = fillColor;
            }
        }
        [Category("CMenuButton Setting")]
        public Color HoverButtonColor
        {
            get { return hoverButtonColor; }
            set
            {
                hoverButtonColor = value;
                foreach (CButton cButton in Controls)
                    cButton.HoverColor = hoverButtonColor;
            }
        }
        [Category("CMenuButton Setting")]
        public Color SubButtonFillColor
        {
            get { return subButtonFillColor; }
            set
            {
                subButtonFillColor = value;
                foreach (CButton btn in Controls)
                    if(btn != cButtonMain)
                        btn.BackgroundColor = subButtonFillColor;
            }
        }
        [Category("CMenuButton Setting")]
        public Color ButtonForeColor
        {
            get { return buttonForeColor; }
            set
            {
                buttonForeColor = value;
                foreach (CButton btn in Controls)
                    btn.ForeColor = buttonForeColor;
            }
        }
        [Category("CMenuButton Setting")]
        public Color ActiveButtonColor
        {
            get { return activeButtonColor; }
            set
            {
                activeButtonColor = value;
            }
        }
        [Category("CMenuButton Setting")]
        public string MainButtonText
        {
            get { return mainButtonText; }
            set
            {
                mainButtonText = value;
                cButtonMain.CustomTag = mainButtonText;
            }
        }
        [Category("CMenuButton Setting")]
        public Image MainButtonImage
        {
            get { return mainButtonImage; }
            set
            {
                mainButtonImage = value;
                cButtonMain.Image = mainButtonImage;
            }
        }
        [Category("CMenuButton Setting")]
        public bool ShowStatus
        {
            get { return isShow; }
            set
            {
                isShow = value;
                if (isShow)
                    ThisShow();
                else
                    ThisHide();
            }
        }
        [Category("CMenuButton Setting")]
        public int SubButtonQuantity
        {
            get { return subButtonQuantity; }
            set
            {
                if (value > 3 && value != subButtonQuantity)
                {
                    foreach (CButton btn in Controls)
                    {
                        if (btn.Tag.ToString() != "DefaultButton")
                            Controls.Remove(btn);
                    }

                    subButtonQuantity = value;
                    for (int i = 3; i < subButtonQuantity; i++)
                    {
                        AddSubButton(i + 1);
                    }
                }
                else if (value <= 3)
                {
                    foreach (CButton btn in Controls)
                    {
                        if (btn.Tag.ToString() != "DefaultButton")
                            Controls.Remove(btn);
                    }
                    subButtonQuantity = value;
                }
                Invalidate();
            }
        }
        #endregion

        public CMenuButton()
        {
            InitializeComponent();
            Size = new Size(250, cButtonHeight);
            foreach (CButton btn in Controls)
            {
                btn.Size = new Size(Width, 40);
                
            }
        }

        #region Event
        private void cButtonMain_Click(object sender, EventArgs e)
        {
            if (_MainButtonClick != null)
            {
                _MainButtonClick.Invoke(sender, e);
                if (Height != GetHeight(subButtonQuantity) && subButtonQuantity > 0 && isShow)
                {
                    ActivateButton(sender);
                    Height = GetHeight(subButtonQuantity);
                }
                else if(Height == GetHeight(subButtonQuantity) && subButtonQuantity > 0)
                {
                    DisableButton();
                    Height = cButtonHeight;
                }
                else if(!isShow)
                    ActivateButton(sender);
                else
                    DisableButton();
            }
        }
        #endregion

        #region Methods
        private int GetHeight(int n)
        {
            return (n + 1) * cButtonHeight;
        }
        private void AddSubButton(int n)
        {
            CButton btn = new CButton
            {
                Dock = DockStyle.Top,
                Text = "cButton" + n,
                Name = "cButton" + n,
                Height = 40,
                BackgroundColor = subButtonFillColor,
                BorderColor = Color.PaleVioletRed,
                BorderRadius = 0,
                BorderSize = 0,
                Cursor = Cursors.Hand,
                CustomTag = "",
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0))),
                ForeColor = buttonForeColor,
                HoverBorderColor = Color.Empty,
                HoverColor = hoverButtonColor,
                HoverImage = null,
                ImageAlign = ContentAlignment.MiddleLeft,
                LeaveBorderColor = Color.PaleVioletRed,
                LeaveColor = Color.SlateBlue,
                LeaveImage = null,
                Margin = new Padding(0),
                Padding = new Padding(32, 0, 0, 0),
                TextAlign = ContentAlignment.MiddleLeft,
                TextColor = buttonForeColor,
                TextImageRelation = TextImageRelation.ImageBeforeText,
            };
            this.Controls.Add(btn);
            btn.BringToFront();
        }
        public void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                currencyButton = (CButton)btnSender;
                currencyButton.BackgroundColor = activeButtonColor;
                currencyButton.Font = new Font(fontName, fontSize, FontStyle.Bold, graphicsUnit);
            }
        }
        public void DisableButton()
        {
            cButtonMain.BackgroundColor = fillColor;
            cButtonMain.Font = font;
        }
        public void ThisShow()
        {
            cButtonMain.Text = cButtonMain.CustomTag;
            cButtonMain.Padding = new Padding(5, 0, 0, 0);
            cButtonMain.TextImageRelation = TextImageRelation.ImageBeforeText;
            cButtonMain.ImageAlign = ContentAlignment.MiddleLeft;
            Width = 250;

            foreach (CButton btn in Controls)
                if (btn.Name != "cButtonMain")
                {
                    btn.Text = btn.CustomTag;
                    btn.Padding = new Padding(36, 0, 0, 0);
                }
        }
        public void ThisHide()
        {
            foreach (CButton btn in Controls)
            {
                btn.CustomTag = btn.Text;
                btn.Text = "";
                btn.Padding = new Padding(0);
                btn.TextImageRelation = TextImageRelation.Overlay;
                btn.ImageAlign = ContentAlignment.MiddleCenter;
            }
            Width = 60;
        }
        public void SetSubButtonClick(string buttonName, EventHandler clickEvent)
        {
            foreach (CButton btn in Controls)
                if(btn.Name == buttonName)
                    btn.Click += clickEvent;
        }
        public void SetSubButtonText(string buttonName, string text)
        {
            foreach (CButton btn in Controls)
                if (btn.Name == buttonName && !isShow)
                    btn.CustomTag = text;
        }
        #endregion
    }
}
