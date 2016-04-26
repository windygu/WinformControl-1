using System;
using System.Drawing;
using CtrlResource;
using System.ComponentModel;
using CtrlControls.Enum;
using System.Windows.Forms;

namespace CtrlControls.ExButton
{
    partial class ButtonEx
    {
        #region 按钮的图片外观
        /// <summary>
        /// 普通状态下按钮的背景图片
        /// </summary>
        [Description("普通状态下按钮的背景图片"), Category("自定义属性")]
        public Image NormalImage
        {
            get
            {
                if (this._normalImage == null)
                    this._normalImage = AssemblyHelper.GetImage("Button.btn_normal.png", this.DesignMode);
                return this._normalImage;
            }
            set
            {
                if (this._normalImage == value)
                    return;
                this._normalImage = value;
                base.Invalidate();
            }
        }
        [Description("鼠标按下左键时的背景图片"), Category("自定义属性")]
        public Image DownImage
        {
            get
            {
                if (this._downImage == null)
                    this._downImage = AssemblyHelper.GetImage("Button.btn_down.png", this.DesignMode);
                return this._downImage;
            }
            set
            {
                if (this._downImage == value)
                    return;
                this._downImage = value;
                base.Invalidate();
            }
        }
        [Description("鼠标滑过时的图片"), Category("自定义属性")]
        public Image MoveImage
        {
            get
            {
                if (this._moveImage == null)
                    this._moveImage = AssemblyHelper.GetImage("Button.btn_highlight.png", this.DesignMode);
                return this._moveImage;
            }
            set
            {
                if (this._moveImage == value)
                    return;
                this._moveImage = value;
                base.Invalidate();
            }
        }
        [Description("是否显示高亮边框"), Category("自定义属性")]
        public Image BorderImage
        {
            get
            {
                if (this._borderImage == null)
                    this._borderImage = AssemblyHelper.GetImage("Button.btn_border.png");
                return this._borderImage;
            }
            set
            {
                if (this._borderImage == value)
                    return;
                this._borderImage = value;
                base.Invalidate();
            }
        }
        [Description("按钮在获得焦点时，所显示的状态图片"), Category("自定义属性")]
        public Image FocusImage
        {
            get
            {
                if (this._focusImage == null)
                    this._focusImage = AssemblyHelper.GetImage("Button.btn_focus.png");
                return this._focusImage;
            }
            set
            {
                if (this._focusImage == value)
                    return;
                this._focusImage = value;
                base.Invalidate();
            }
        }
        #endregion
        /// <summary>
        /// 是否显示按钮的边
        /// </summary>
        [Description("是否显示按钮的边"), Category("自定义属性"), Browsable(false)]
        public bool IsShowBorder
        {
            get { return this._isShowBorder; }
            set { this._isShowBorder = value; }
        }

        #region 按钮上的文字和图片
        [Description("显示在按钮上的文字"), Category("自定义属性")]
        public override string Text
        {
            get { return base.Text; }
            set
            {
                if (base.Text == value)
                    return;
                base.Text = value;
                base.Invalidate(this.ContentRect);
            }
        }
        [Description("按钮上显示的图片"), CategoryAttribute("自定义属性")]
        public new Image Image
        {
            get { return base.Image; }
            set
            {
                if (base.Image == value)
                    return;
                base.Image = value;
                base.Invalidate();
            }
        }
        #endregion
        /// <summary>
        /// Button控件的内容区域
        /// </summary>
        private Rectangle ContentRect
        {
            get { return new Rectangle(2, 2, this.ClientRectangle.Width - 4, this.ClientRectangle.Height - 4); }
        }
        /// <summary>
        /// 鼠标经过按钮时的状态
        /// </summary>
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
        /// <summary>
        /// 按钮上文字的对齐方式
        /// </summary>
        [Description("按钮上文字的对齐方式"), CategoryAttribute("自定义属性")]
        public override ContentAlignment TextAlign
        {
            get { return base.TextAlign; }
            set
            {
                if (base.TextAlign == value)
                    return;
                base.TextAlign = value;
                switch (base.TextAlign)
                {
                    case ContentAlignment.BottomCenter:
                        this._textAlign = TextFormatFlags.Bottom | TextFormatFlags.HorizontalCenter | TextFormatFlags.SingleLine;
                        break;
                    case ContentAlignment.BottomLeft:
                        this._textAlign = TextFormatFlags.Bottom | TextFormatFlags.Left | TextFormatFlags.SingleLine;
                        break;
                    case ContentAlignment.BottomRight:
                        this._textAlign = TextFormatFlags.Bottom | TextFormatFlags.Right | TextFormatFlags.SingleLine;
                        break;
                    case ContentAlignment.MiddleCenter:
                        this._textAlign = TextFormatFlags.SingleLine | TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
                        break;
                    case ContentAlignment.MiddleLeft:
                        this._textAlign = TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;
                        break;
                    case ContentAlignment.MiddleRight:
                        this._textAlign = TextFormatFlags.Right | TextFormatFlags.VerticalCenter | TextFormatFlags.SingleLine;
                        break;
                    case ContentAlignment.TopCenter:
                        this._textAlign = TextFormatFlags.Top | TextFormatFlags.HorizontalCenter | TextFormatFlags.SingleLine;
                        break;
                    case ContentAlignment.TopLeft:
                        this._textAlign = TextFormatFlags.Top | TextFormatFlags.Left | TextFormatFlags.SingleLine;
                        break;
                    case ContentAlignment.TopRight:
                        this._textAlign = TextFormatFlags.Top | TextFormatFlags.Right | TextFormatFlags.SingleLine;
                        break;
                    default:
                        this._textAlign = TextFormatFlags.SingleLine | TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
                        break;
                }
                base.Invalidate(this.ContentRect);
            }
        }
    }
}
