using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;

namespace EMS
{
    [DefaultEvent("_TextChanged")]
    public partial class RountTextBoxPassword: UserControl
    {
        #region -> Fields
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderColorFocus = Color.HotPink;
        private bool isFocused = false;

        private int borderRadius = 0;
        private Color placeholderColor = Color.DarkGray;
        private string placeholdertext = "";
        private bool isPlaceHolder = false;
        private bool isPasswordChar = false;
        #endregion
        //Events
        public event EventHandler _TextChanged;

        //Constructor
        public RountTextBoxPassword()
        {
            InitializeComponent();
        }

        #region -> Properties
        //Properties
        [Category("Advance Style")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("Advance Style")]
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        [Category("Advance Style")]
        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }
        [Category("Advance Style")]
        public bool PasswordChar
        {
            get
            {
                return isPasswordChar;
            }
            set
            {
                isPasswordChar = value;
                textBox1.UseSystemPasswordChar = value;
            }
        }
        [Category("Advance Style")]
        public bool MultiLine
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
            }
        }
        [Category("Advance Style")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        [Category("Advance Style")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("Advance Style")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }
        [Category("Advance Style")]
        public string Texts
        {
            get
            {
                if (isPlaceHolder) return "";
                else return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                SetPlaceHolder();

            }
        }

        private void SetPlaceHolder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholdertext != "")
            {
                isPlaceHolder = true;
                textBox1.Text = placeholdertext;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = false;
            }
        }
        private void RemovePlaceholder()
        {
            if (isPlaceHolder && placeholdertext != "")
            {
                isPlaceHolder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
        }

        [Category("Advance Style")]
        public Color BorderColorFocus
        {
            get
            {
                return borderColorFocus;
            }
            set
            {
                borderColorFocus = value;
            }
        }
        [Category("Advance Style")]
        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();//redraw control
                }

            }
        }
        [Category("Advance Style")]
        public Color PlaceholderColor
        {
            get
            {
                return placeholderColor;
            }
            set
            {
                placeholderColor = value;
                if (isPlaceHolder)
                    textBox1.ForeColor = value;
            }
        }
        [Category("Advance Style")]
        public string Placeholdertext
        {
            get
            {
                return placeholdertext;
            }
            set
            {
                placeholdertext = value;
                textBox1.Text = "";
                SetPlaceHolder();
            }
        }
        #endregion

        #region -> Override methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1) // Rounded textbox
            {
                // Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                // Ensure these variables are properly declared
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    // Drawing
                    this.Region = new Region(pathBorderSmooth); // Set the border to round
                    if (borderRadius > 15) setTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

                    if (!isFocused)
                    {
                        if (underlinedStyle) // Underline style
                        {
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else // Normal border
                        {
                            graph.DrawPath(penBorder, pathBorder); // FIXED: Use DrawPath instead of DrawRectangle
                        }
                    }
                    else
                    {
                        penBorder.Color = borderColorFocus;

                        if (underlinedStyle) // Underline style
                        {
                            graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else // Normal border
                        {
                            graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                            graph.DrawPath(penBorder, pathBorder);
                        }
                    }
                }
            }
            else // Normal textbox
            {
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    if (!isFocused)
                    {
                        if (underlinedStyle)
                        {
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                        }
                    }
                    else
                    {
                        penBorder.Color = borderColorFocus;

                        if (underlinedStyle)
                        {
                            graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else
                        {
                            graph.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                        }
                    }
                }
            }
        }


        private void setTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (MultiLine)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region();
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region();
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        #endregion

        #region -> private method
        //private method
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        #endregion


        #region -> TextBox Events
        #endregion
        
     

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceHolder();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            this.OnKeyDown(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\p{Cs}";
            textBox1.Text = Regex.Replace(textBox1.Text, pattern, "");
            textBox1.SelectionStart = textBox1.Text.Length;

            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);

            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_MouseHover_1(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
    }
}
