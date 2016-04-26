using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CtrlResource;
using System.ComponentModel;
using CtrlControls.Enum;

namespace CtrlControls.ExRadioButton
{
    partial class RadioButtonEx
    {
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
        /// 普通状态下控件未选中时的背景图片
        /// </summary>
        [Description("普通状态下按钮的背景图片"), Category("自定义属性")]
        public Image NormalImage
        {
            get
            {
                if (this._normalImage == null)
                    this._normalImage = AssemblyHelper.GetImage("RadioButton.radiobtn_normal.png", this.DesignMode);
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
                    this._normalImageChecked = AssemblyHelper.GetImage("RadioButton.radiobtn_normal_checked.png", this.DesignMode);
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
                    this._highLightImage = AssemblyHelper.GetImage("RadioButton.radiobtn_highlight.png", this.DesignMode);
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
                    this._highLightImageChecked = AssemblyHelper.GetImage("RadioButton.radiobtn_highlight_checked.png", this.DesignMode);
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
        /// 图片区域
        /// </summary>
        internal Rectangle ImageRect
        {
            get { return new Rectangle(0, (base.Height - RADIOBUTTON_IMAGE_SIZE) / 2, RADIOBUTTON_IMAGE_SIZE, RADIOBUTTON_IMAGE_SIZE); }
        }

        /// <summary>
        /// 文本区域
        /// </summary>
        internal Rectangle ContentRect
        {
            get { return new Rectangle(RADIOBUTTON_IMAGE_SIZE, 0, base.Width - 17, base.Height); }
        }
    }
}
