using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CtrlControls.Enum;
using System.Windows.Forms;

namespace CtrlControls.ExProgressBar
{
    partial class ProgressBarEx
    {
        /// <summary>
        /// 控件背景颜色
        /// </summary>
        private Color _baseColor = Color.FromArgb(231, 243, 249);
        /// <summary>
        /// 控件边框颜色
        /// </summary>
        private Color _borderColor = Color.FromArgb(180, 180, 180);
        /// <summary>
        /// 进度条边框颜色
        /// </summary>
        private Color _progressBarBorderColor = Color.LightGray;
        /// <summary>
        /// 进度条上的文本颜色
        /// </summary>
        private Color _progressBarTextColor = Color.FromArgb(0, 95, 147);
        /// <summary>
        /// 进度条的颜色
        /// </summary>
        private Color _progressBarColor = Color.CornflowerBlue;//Color.FromArgb(105, 185, 222);
        /// <summary>
        /// 圆角弧度
        /// </summary>
        private int _radius = 8;
        /// <summary>
        /// 圆角样式
        /// </summary>
        private ERoundStyle _roundStyle = ERoundStyle.All;
        /// <summary>
        /// 进度条上的文字信息
        /// </summary>
        private string _progressBarText = string.Empty;
        /// <summary>
        /// 文字对齐方式
        /// </summary>
        private TextFormatFlags _textFlags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
    }
}
