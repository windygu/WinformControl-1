using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;

namespace CtrlControls.ExProgressBar
{
    partial class ProgressBarEx
    {
        [Description("圆角弧度"),Category("自定义属性")]
        public int Radius
        {
            get { return this._radius; }
            set
            {
                this._radius = value;
                base.Invalidate();
            }
        }
        [Description("控件背景颜色"),Category("自定义属性")]
        public Color BaseColor
        {
            get { return this._baseColor; }
            set
            {
                this._baseColor = value;
                base.Invalidate();
            }
        }
        [Description("控件边框颜色"),Category("自定义属性")]
        public Color BorderColor
        {
            get { return this._borderColor; }
            set
            {
                this._borderColor = value;
                base.Invalidate();
            }
        }
        [Description("进度条边框颜色"),Category("自定义属性")]
        public Color ProgressBarBorderColor
        {
            get { return this._progressBarBorderColor; }
            set
            {
                this._progressBarBorderColor = value;
                base.Invalidate();
            }
        }
        [Description("进度条上的文本颜色"),Category("自定义属性")]
        public Color ProgressBarTextColor
        {
            get { return this._progressBarTextColor; }
            set
            {
                this._progressBarTextColor = value;
                base.Invalidate();
            }
        }
        [Description("进度条的颜色"),Category("自定义属性")]
        public Color ProgressBarColor
        {
            get { return this._progressBarColor; }
            set
            {
                this._progressBarColor = value;
                base.Invalidate();
            }
        }
        [Description("进度条上的文字信息"),Category("自定义属性")]
        public string ProgressBarText
        {
            get { return this._progressBarText; }
            set
            {
                this._progressBarText = value;
                base.Invalidate();
            }
        }
    }
}
