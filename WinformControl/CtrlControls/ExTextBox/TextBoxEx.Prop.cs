using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using CtrlResource;
using CtrlControls.Enum;

namespace CtrlControls.ExTextBox
{
    partial class TextBoxEx
    {
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
        /// 水印文字
        /// </summary>
        [Description("水印文字"), Category("自定义属性")]
        public string WaterText
        {
            get { return this._waterText; }
            set
            {
                if (this._waterText == value)
                    return;
                this._waterText = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// 水印颜色
        /// </summary>
        [Description("水印颜色"), Category("自定义属性")]
        public Color WaterColor
        {
            get { return this._waterColor; }
            set
            {
                if (this._waterColor == value)
                    return;
                this._waterColor = value;
                base.Invalidate();
            }
        }
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
        /// 边框的宽度
        /// </summary>
        [Description("边框的宽度"), Category("自定义属性")]
        public float BorderWeight
        {
            get { return _BorderWeight; }
            set { _BorderWeight = value; }
        }
        /// <summary>
        /// 正常边框的颜色
        /// </summary>
        [Description("正常边框的颜色"), Category("自定义属性")]
        public Color BorderNormalColor
        {
            get { return this._BorderNormalColor; }
            set { this._BorderNormalColor = value; }
        }
        /// <summary>
        /// 鼠标进入边框时的颜色
        /// </summary>
        [Description("鼠标进入边框时的颜色"), Category("自定义属性")]
        public Color BorderOverColor
        {
            get { return this._BorderOverColor; }
            set { this._BorderOverColor = value; }
        }
        /// <summary>
        /// 是否启用自定义边框
        /// </summary>
        [Description("是否启用自定义边框"), Category("自定义属性")]
        public bool Border
        {
            get { return this._Border; }
            set
            {
                if (this._Border == value)
                    return;
                this._Border = value;
            }
        }
    }
}
