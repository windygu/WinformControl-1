using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using CtrlControls.Enum;

namespace CtrlControls.ExForm
{
    partial class FormEx
    {
        /// <summary>
        /// 标题栏系统按钮所占用的区域
        /// </summary>
        private Rectangle TitleBarButtonRect
        {
            get
            {
                return Rectangle.Empty;
            }
        }
        /// <summary>
        /// 标题栏上的区域
        /// </summary>
        private Rectangle TitleBarRect
        {
            get { return new Rectangle(0, 0, this.Width - this.TitleBarButtonRect.Width, TITLE_REGION_HEIGHT); }
        }
        /// <summary>
        /// 标题栏上图标显示的区域
        /// </summary>
        private Rectangle TitleBarIconRect
        {
            get { return new Rectangle(6, 8, 16, 16); }
        }
        /// <summary>
        /// 标题栏上标题文字显示的区域
        /// </summary>
        private Rectangle TitleBarTextRect
        {
            get
            {
                Rectangle textRect = new Rectangle(5, 3, this.TitleBarRect.Width - this.TitleBarIconRect.Width - 15, TITLE_REGION_HEIGHT);
                if (base.ShowIcon)
                {
                    textRect.X = this.TitleBarIconRect.Width + 8;
                }
                return textRect;
            }
        }
        /// <summary>
        /// 窗体标题文字
        /// </summary>
        [Description("窗体标题文字"), Category("自定义属性")]
        public new string Text //??? new not override
        {
            get { return base.Text; }
            set
            {
                base.Text = value;
                base.Invalidate(this.TitleBarTextRect);
            }
        }
        /// <summary>
        /// 系统控制按钮的显示与隐藏
        /// </summary>
        [Description("系统控制按钮的显示与隐藏"), Category("自定义属性"), DefaultValue((int)ESystemButton.CloseMinMax)]
        public ESystemButton SystemButton
        {
            get { return this._systemButton; }
            set
            {
                if (this._systemButton == value)
                    return;
                this._systemButton = value;
                base.Invalidate();
            }
        }

        #region 系统按钮的区域大小
        /// <summary>
        /// 获取关闭按钮区域
        /// </summary>
        private Rectangle CloseButtonRect
        {
            get
            {
                Rectangle rect = Rectangle.Empty;
                if (this._systemButton != ESystemButton.None)
                    rect = new Rectangle(this.Width - 39, 0, 39, 20);//39*20是关闭按钮图片的宽和高
                return rect;
            }
        }
        /// <summary>
        /// 获取最大化按钮区域
        /// </summary>
        private Rectangle MaxButtonRect
        {
            get
            {
                Rectangle rect = Rectangle.Empty;
                if (this._systemButton == ESystemButton.CloseMinMax)
                    rect = new Rectangle(this.Width - this.CloseButtonRect.Width - 28, 0, 28, 20);//28*20是最大化按钮和恢复按钮图片的宽和高
                return rect;
            }
        }
        /// <summary>
        /// 最小化按钮区域
        /// </summary>
        private Rectangle MinButtonRect
        {
            get
            {
                Rectangle rect = Rectangle.Empty;
                if (this._systemButton == ESystemButton.CloseMinMax)
                    rect = new Rectangle(this.Width - this.CloseButtonRect.Width - this.MaxButtonRect.Width - 28, -1, 28, 20);//28*20是最小化按钮图片的宽和高
                else if (this._systemButton == ESystemButton.CloseMin)
                    rect = new Rectangle(this.Width - this.CloseButtonRect.Width - 28, -1, 28, 20);//28*20是最小化按钮图片的宽和高
                return rect;
            }
        }
        #endregion

        #region 系统按钮的鼠标状态
        /// <summary>
        /// 关闭按钮的鼠标状态
        /// </summary>
        private EMouseState CloseMouseState
        {
            get { return this._closeMouseState; }
            set
            {
                if (this._closeMouseState == value)
                    return;
                this._closeMouseState = value;
                base.Invalidate(this.CloseButtonRect);
            }
        }
        /// <summary>
        /// 最大化按钮的鼠标状态
        /// </summary>
        private EMouseState MaxMouseState
        {
            get { return this._maxMouseState; }
            set
            {
                if (this._maxMouseState == value)
                    return;
                this._maxMouseState = value;
                base.Invalidate(this.MaxButtonRect);
            }
        }
        /// <summary>
        /// 最小化按钮的鼠标状态
        /// </summary>
        private EMouseState MinMouseState
        {
            get { return this._minMouseState; }
            set
            {
                if (this._minMouseState == value)
                    return;
                this._minMouseState = value;
                base.Invalidate(this.MinButtonRect);
            }
        }
        #endregion

    }
}
