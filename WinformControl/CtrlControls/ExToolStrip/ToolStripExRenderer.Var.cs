using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CtrlControls.ExToolStrip
{
    partial class ToolStripExRenderer
    {
        /// <summary>
        /// 背景颜色
        /// </summary>
        private Color _backColor = Color.White;
        /// <summary>
        /// 透明度
        /// </summary>
        private int _alpha = 255;

        /// <summary>
        /// 绘制鼠标划过时的背景图片
        /// </summary>
        private Image _imageHighLight = null;
        /// <summary>
        /// 绘制鼠标按下或者选中时的背景图片
        /// </summary>
        private Image _imageDown = null;
        /// <summary>
        /// 绘制Separator(竖分离)线
        /// </summary>
        private Image _imageVerticalSeparator = null;
        /// <summary>
        /// 绘制溢出按钮的背景
        /// </summary>
        private Image _imageOverflow = null;
       
    }
}
