using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CtrlControls.Enum;
using System.Drawing;

namespace CtrlControls.ExTextBoxIcon
{
    partial class TextBoxIconEx
    {
        private EMouseState _mouseState = EMouseState.Normal;
        private EMouseState _iconMouseState = EMouseState.Normal;

        /// <summary>
        /// 自定义文本框控件的高度与自定义文本框里字体高度的差值
        /// </summary>
        private int HeightSpace = 0;
        /// <summary>
        /// 控件边框的宽度
        /// </summary>
        private const int BORDER_WIDTH = 2;
        /// <summary>
        /// 控件默认的边框图片
        /// </summary>
        private Image _borderNormalImage = null;

        /// <summary>
        /// 鼠标移入时控件的边框图片
        /// </summary>
        private Image _borderOverImage = null;
        /// <summary>
        /// 文本框控件的图标
        /// </summary>
        private Image _icon;
    }
}
