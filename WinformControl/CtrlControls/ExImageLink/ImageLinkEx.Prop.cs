using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using CtrlControls.Enum;
using CtrlResource;

namespace CtrlControls.ExImageLink
{
    partial class ImageLinkEx
    {
        [Description("链接按钮上的图标"), Category("自定义属性")]
        public Image Icon
        {
            get
            {
                if (this._icon == null)
                {
                    this._icon = AssemblyHelper.GetImage("ImageLink.imagelink_webconnect.png", this.DesignMode);
                }
                return this._icon;
            }
            set
            {
                if (this._icon == value)
                    return;
                this._icon = value;
                base.Invalidate();
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
                if (this._icon != null)
                {
                    rect.Width = this._icon.Width;
                    rect.Height = this._icon.Height;
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
                if (this._icon == null)
                {
                    return base.ClientRectangle;
                }
                else
                {
                    return new Rectangle(this.ImageRect.Right + 3, 0, base.ClientRectangle.Width , base.ClientRectangle.Height);
                }
            }
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
        /// 鼠标经过控件的颜色
        /// </summary>
        [Description("鼠标经过控件的颜色"), Category("自定义属性")]
        public Color HoverColor
        {
            get
            {
                return this._hoverColor;
            }
            set
            {
                if (this._hoverColor == value)
                    return;
                this._hoverColor = value;
                this.Invalidate();
            }
        }
        /// <summary>
        /// 控件本身的颜色
        /// </summary>
        [Description("控件本身的颜色"), Category("自定义属性")]
        public Color NatureColor
        {
            get
            {
                return this._natureColor;
            }
            set
            {
                if (this._natureColor == value)
                    return;
                this._natureColor = value;
                this.Invalidate();
            }
        }
    }
}
