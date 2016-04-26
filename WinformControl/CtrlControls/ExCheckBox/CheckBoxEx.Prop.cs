using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using CtrlResource;
using CtrlControls.Enum;

namespace CtrlControls.ExCheckBox
{
    partial class CheckBoxEx
    {
        /// <summary>
        /// 普通状态下控件未选中时的背景图片
        /// </summary>
        [Description("普通状态下按钮的背景图片"), Category("自定义属性")]
        public Image NormalImage
        {
            get
            {
                if (this._normalImage == null)
                    this._normalImage = AssemblyHelper.GetImage("CheckBox.checkbox_normal.png", this.DesignMode);
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
        /// <summary>
        /// 普通状态下控件选中时的背景图片
        /// </summary>
        [Description("普通状态下控件选中时的背景图片"), Category("自定义属性")]
        public Image NormalImageChecked
        {
            get
            {
                if (this._normalImageChecked == null)
                    this._normalImageChecked = AssemblyHelper.GetImage("CheckBox.checkbox_normal_checked.png", this.DesignMode);
                return this._normalImageChecked;
            }
            set
            {
                if (this._normalImageChecked == value)
                    return;
                this._normalImageChecked = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 鼠标经过状态（或控件具有焦点）时控件未选中时的背景图片
        /// </summary>
        [Description("鼠标经过状态（或控件具有焦点）时控件未选中时的背景图片"), Category("自定义属性")]
        public Image HighLightImage
        {
            get
            {
                if (this._highLightImage == null)
                    this._highLightImage = AssemblyHelper.GetImage("CheckBox.checkbox_highlight.png", this.DesignMode);
                return this._highLightImage;
            }
            set
            {
                if (this._highLightImage == value)
                    return;
                this._highLightImage = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 鼠标经过状态（或控件具有焦点）时控件选中时的背景图片
        /// </summary>
        [Description("鼠标经过状态（或控件具有焦点）时控件选中时的背景图片"), Category("自定义属性")]
        public Image HighLightImageChecked
        {
            get
            {
                if (this._highLightImageChecked == null)
                    this._highLightImageChecked = AssemblyHelper.GetImage("CheckBox.checkbox_highlight_checked.png", this.DesignMode);
                return this._highLightImageChecked;
            }
            set
            {
                if (this._highLightImageChecked == value)
                    return;
                this._highLightImageChecked = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 不确定状态下控件鼠标离开控件时的背景图片
        /// </summary>
        [Description("不确定状态下控件鼠标离开控件时的背景图片"), Category("自定义属性")]
        public Image IndeterminateImage
        {
            get
            {
                if (base.CheckState == System.Windows.Forms.CheckState.Indeterminate
                    && this._indeterminateImage == null)
                    this._indeterminateImage = AssemblyHelper.GetImage("CheckBox.checkbox_indeterminate_normal.png", this.DesignMode);
                return this._indeterminateImage;
            }
            set
            {
                if (this._indeterminateImage == value)
                    return;
                this._indeterminateImage = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 不确定状态下控件鼠标进入控件时的背景图片
        /// </summary>
        [Description("不确定状态下控件鼠标进入控件时的背景图片"), Category("自定义属性")]
        public Image IndeterminateHighLightImage
        {
            get
            {
                if (base.CheckState == System.Windows.Forms.CheckState.Indeterminate
                    && this._indeterminateHighLightImage == null)
                    this._indeterminateHighLightImage = AssemblyHelper.GetImage("CheckBox.checkbox_indeterminate_highlight.png", this.DesignMode);
                return this._indeterminateHighLightImage;
            }
            set
            {
                if (this._indeterminateHighLightImage == value)
                    return;
                this._indeterminateHighLightImage = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// CheckBox控件的内容区域
        /// </summary>
        private Rectangle ContentRect
        {
            get { return new Rectangle(this.CheckBoxImageSize, 0, this.ClientRectangle.Width - this.CheckBoxImageSize, this.ClientRectangle.Height); }
        }

        /// <summary>
        /// 图片显示区域
        /// </summary>
        private Rectangle ImageRect
        {
            get { return new Rectangle(0, (this.Height - this.CheckBoxImageSize) / 2, this.CheckBoxImageSize, this.CheckBoxImageSize); }
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
        /// CheckBox控件图片的大小
        /// </summary>
        private int CheckBoxImageSize
        {
            get
            {
                if (base.CheckState == System.Windows.Forms.CheckState.Indeterminate)
                    return CHECKBOX_IMAGE_INDETERMINATE_SIZE;
                else
                    return CHECKBOX_IMAGE_SIZE;
            }
        }
    }
}
