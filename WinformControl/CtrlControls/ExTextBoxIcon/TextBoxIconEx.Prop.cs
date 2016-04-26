using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using CtrlControls.Enum;
using CtrlResource;

namespace CtrlControls.ExTextBoxIcon
{
    partial class TextBoxIconEx
    {
        /// <summary>
        /// 控件默认的边框图片
        /// </summary>
        [Description("控件默认的边框图片"), Category("自定义属性")]
        public Image BorderNormalImage
        {
            get
            {
                if (this._borderNormalImage == null)
                    this._borderNormalImage = AssemblyHelper.GetImage("TextBox.textbox_border_normal.png", this.DesignMode);
                return this._borderNormalImage;
            }
            set
            {
                if (this._borderNormalImage == value)
                    return;
                this._borderNormalImage = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 鼠标移入时控件的边框图片
        /// </summary>
        [Description("鼠标移入时控件的边框图片"), Category("自定义属性")]
        public Image BorderOverImage
        {
            get
            {
                if (this._borderOverImage == null)
                    this._borderOverImage = AssemblyHelper.GetImage("TextBox.textbox_border_over.png", this.DesignMode);
                return this._borderOverImage;
            }
            set
            {
                if (this._borderOverImage == value)
                    return;
                this._borderOverImage = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 图标的绘制区域
        /// </summary>
        private Rectangle IconRect
        {
            get { return new Rectangle(2, 2, 20, 20); }
        }
        [Description("文本框的图标"), Category("自定义属性")]
        public Image Icon
        {
            get { return this._icon; }
            set
            {
                if (this._icon == value)
                    return;
                this._icon = value;
                base.Invalidate(this.IconRect);
                this.ChangeBaseTextLocation();
            }
        }
        private EMouseState MouseState
        {
            get { return this._mouseState; }
            set
            {
                if (this._mouseState == value)
                    return;
                this._mouseState = value;
                base.Invalidate();
            }
        }
        private EMouseState IconMouseState
        {
            get { return this._iconMouseState; }
            set
            {
                if (this._iconMouseState == value)
                    return;
                this._iconMouseState = value;
                base.Invalidate(this.IconRect);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        [Description("文本框控件的字体"), Category("自定义属性")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                if (base.Font == value)
                    return;
                base.Font = value;
                this.BaseText.Height = value.Height;
                base.Height = value.Height + this.HeightSpace;
                this.ChangeBaseTextLocation();
            }
        }
        [Description("控制编辑控件的文本是否能够跨越多行。"), Category("自定义属性"), DefaultValue(false)]
        public bool Multiline
        {
            get { return this.BaseText.Multiline; }
            set
            {
                if (this.BaseText.Multiline == value)
                    return;
                base.SetStyle(ControlStyles.FixedHeight, !value);
                base.SetStyle(ControlStyles.FixedWidth, !value);
                base.UpdateStyles();
                this.BaseText.WordWrap = value;
                this.BaseText.Multiline = value;
                base.Height = this.Font.Height + this.HeightSpace;
            }
        }
        [Description("与控件关联的文本"), Category("自定义属性"), Browsable(true), DefaultValue("")]
        public new string Text
        {
            get
            {
                return this.BaseText.Text;
            }
            set
            {
                if (this.BaseText.Text == value)
                    return;
                this.BaseText.Text = value;
            }
        }
        [Description("指定可以在编辑控件中输入的最大字符数。"), Category("自定义属性")]
        public int MaxLength
        {
            get { return this.BaseText.MaxLength; }
            set { this.BaseText.MaxLength = value; }
        }
        [Description("指示将为单行编辑控件的密码输入显示的字符。"), Category("自定义属性")]
        public char PasswordChar
        {
            get { return this.BaseText.PasswordChar; }
            set { this.BaseText.PasswordChar = value; }
        }
        [Description("控制能否更改编辑控件中的文本。"), Category("自定义属性"), DefaultValue(false)]
        public bool ReadOnly
        {
            get { return this.BaseText.ReadOnly; }
            set { this.BaseText.ReadOnly = value; }
        }
        [Description("指示编辑控件中的文本是否以默认的密码字符显示。"), Category("自定义属性")]
        public bool UseSystemPasswordChar
        {
            get { return this.BaseText.UseSystemPasswordChar; }
            set { this.BaseText.UseSystemPasswordChar = value; }
        }
        [Description("指示多行编辑控件是否自动换行。"), Category("自定义属性"), DefaultValue(false)]
        public bool WordWrap
        {
            get { return this.BaseText.WordWrap; }
            set
            {
                if (this.BaseText.WordWrap == value)
                    return;
                this.BaseText.WordWrap = value;
                if (!value)
                {
                    this.MaximumSize = new Size(base.MaximumSize.Width, this.Font.Height + this.HeightSpace);
                    base.Height = this.Font.Height + this.HeightSpace;
                }
            }
        }
        [Description("此组件的前景色，用于显示文本。"), Category("自定义属性")]
        public new Color ForeColor
        {
            get { return this.BaseText.ForeColor; }
            set { this.BaseText.ForeColor = value; }
        }
        [Description("多行编辑中的文本行，作为字符串值的数组。"), Category("自定义属性")]
        public string[] Lines
        {
            get { return this.BaseText.Lines; }
            set { this.BaseText.Lines = value; }
        }
        [Description("指示对于多行编辑控件，将为此控件显示哪些滚动条。"), Category("自定义属性")]
        public ScrollBars ScrollBars
        {
            get { return this.BaseText.ScrollBars; }
            set { this.BaseText.ScrollBars = value; }
        }
        [Description("指示应该如何对齐编辑控件的文本"), Category("自定义属性")]
        public HorizontalAlignment TextAlign
        {
            get { return this.BaseText.TextAlign; }
            set { this.BaseText.TextAlign = value; }
        }
        public override Size MaximumSize
        {
            get
            {
                if (this.BaseText.WordWrap)
                {
                    return base.MaximumSize;
                }
                else
                {
                    return new Size(base.MaximumSize.Width, 26);
                }
            }
            set
            {
                base.MaximumSize = value;
            }
        }
    }
}
