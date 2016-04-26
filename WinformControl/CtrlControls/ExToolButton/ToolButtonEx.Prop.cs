using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CtrlResource;
using System.ComponentModel;
using CtrlControls.Enum;

namespace CtrlControls.ExToolButton
{
    partial class ToolButtonEx
    {
        /// <summary>
        /// 鼠标经过时的状态
        /// </summary>
        public EMouseState MouseState
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
        /// 工具按钮的图标
        /// </summary>
        [Description("工具按钮的图标"), Category("自定义属性")]
        public Image ToolIcon
        {
            get
            {
                if (this._toolIcon == null)
                {
                    this._toolIcon = AssemblyHelper.GetImage("ToolButton.toolbutton_weibo.png", base.DesignMode);
                }
                return this._toolIcon;
            }
            set
            {
                if (this._toolIcon == value)
                    return;
                this._toolIcon = value;
                base.Invalidate();
            }
        }
        [Description("工具按钮的文本"), Category("自定义属性"), DefaultValue("")]
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                if (base.Text == value)
                {
                    return;
                }
                if (value == null)
                    value = string.Empty;
                using (Graphics g = base.CreateGraphics())
                {
                    SizeF size = g.MeasureString(value, base.Font);
                    int length = Convert.ToInt32(Math.Ceiling(size.Width));
                    base.Size = new Size(length + this.ToolIcon.Width + 3, base.Height);
                    base.Text = value;
                }
                base.Invalidate(true);
            }
        }
        /// <summary>
        /// 绘制鼠标划过时的背景图片
        /// </summary>
        public Image ImageHighLight
        {
            get
            {
                if (this._imageHighLight == null)
                {
                    this._imageHighLight = AssemblyHelper.GetImage("ToolButton.toolbutton_highlight.png");
                }
                return this._imageHighLight;
            }
            set
            {
                if (this._imageHighLight == value)
                    return;
                this._imageHighLight = value;
            }
        }
        /// <summary>
        /// 绘制鼠标划过时的背景图片（左）
        /// </summary>
        public Image ImageHighLightLeft
        {
            get
            {
                if (this._imageHighLightLeft == null)
                {
                    this._imageHighLightLeft = AssemblyHelper.GetImage("ToolButton.toolbutton_highlight_left.png");
                }
                return this._imageHighLightLeft;
            }
            set
            {
                if (this._imageHighLightLeft == value)
                    return;
                this._imageHighLightLeft = value;
            }
        }
        /// <summary>
        /// 绘制鼠标划过时的背景图片（右）
        /// </summary>
        public Image ImageHighLightRight
        {
            get
            {
                if (this._imageHighLightRight == null)
                {
                    this._imageHighLightRight = AssemblyHelper.GetImage("ToolButton.toolbutton_highlight_right.png");
                }
                return this._imageHighLightRight;
            }
            set
            {
                if (this._imageHighLightRight == value)
                    return;
                this._imageHighLightRight = value;
            }
        }
        /// <summary>
        /// 绘制鼠标按下或者选中时的背景图片
        /// </summary>
        public Image ImageDown
        {
            get
            {
                if (this._imageDown == null)
                {
                    this._imageDown = AssemblyHelper.GetImage("ToolButton.toolbutton_down.png");
                }
                return this._imageDown;
            }
            set
            {
                if (this._imageDown == value)
                    return;
                this._imageDown = value;
            }
        }
        /// <summary>
        /// 绘制鼠标按下或者选中时的背景图片（左）
        /// </summary>
        public Image ImageDownLeft
        {
            get
            {
                if (this._imageDownLeft == null)
                {
                    this._imageDownLeft = AssemblyHelper.GetImage("ToolButton.toolbutton_down_left.png");
                }
                return this._imageDownLeft;
            }
            set
            {
                if (this._imageDownLeft == value)
                    return;
                this._imageDownLeft = value;
            }
        }
        /// <summary>
        /// 绘制鼠标按下或者选中时的背景图片（右）
        /// </summary>
        public Image ImageDownRight
        {
            get
            {
                if (this._imageDownRight == null)
                {
                    this._imageDownRight = AssemblyHelper.GetImage("ToolButton.toolbutton_down_right.png");
                }
                return this._imageDownRight;
            }
            set
            {
                if (this._imageDownRight == value)
                    return;
                this._imageDownRight = value;
            }
        }
        /// <summary>
        /// 图标的绘制区域
        /// </summary>
        private Rectangle ImageRect
        {
            get
            {
                Rectangle rect = Rectangle.Empty;
                if (this._toolIcon != null)
                {
                    rect.Width = this._toolIcon.Width;
                    rect.Height = this._toolIcon.Height;
                    rect.Y = (base.ClientRectangle.Height - rect.Height) / 2;
                }
                return rect;
            }
        }
        /// <summary>
        /// 文字的绘制区域
        /// </summary>
        private Rectangle ContentRect
        {
            get
            {
                if (this._toolIcon == null)
                {
                    return base.ClientRectangle;
                }
                else
                {
                    return new Rectangle(this.ImageRect.Right + 3, 0, base.ClientRectangle.Width, base.ClientRectangle.Height);
                }
            }
        }
        protected override Size DefaultSize
        {
            get
            {
                return new Size(base.DefaultSize.Width, 22);
            }
        }
        public override Size MinimumSize
        {
            get { return new Size(base.MaximumSize.Width, 22); }
        }
        public override Size MaximumSize
        {
            get
            {
                return new Size(base.MaximumSize.Width, 22);
            }
            set
            {
                base.MaximumSize = value;
            }
        }
    }
}
