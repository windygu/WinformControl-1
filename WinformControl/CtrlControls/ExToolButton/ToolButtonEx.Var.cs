using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CtrlControls.Enum;
using System.Windows.Forms;

namespace CtrlControls.ExToolButton
{
    partial class ToolButtonEx
    {
        /// <summary>
        /// 工具按钮的图标
        /// </summary>
        private Image _toolIcon = null;
        /// <summary>
        /// 鼠标经过时的状态
        /// </summary>
        private EMouseState _mouseState = EMouseState.Normal;
        /// <summary>
        /// 控件里面文本的对齐方式
        /// </summary>
        private TextFormatFlags _textFlags = TextFormatFlags.Left |
                                        TextFormatFlags.SingleLine |
                                        TextFormatFlags.VerticalCenter;
        /// <summary>
        /// 绘制鼠标划过时的背景图片
        /// </summary>
        private Image _imageHighLight = null;
        /// <summary>
        /// 绘制鼠标划过时的背景图片（左）
        /// </summary>
        private Image _imageHighLightLeft = null;
        /// <summary>
        /// 绘制鼠标划过时的背景图片（右）
        /// </summary>
        private Image _imageHighLightRight = null;

        /// <summary>
        /// 绘制鼠标按下或者选中时的背景图片
        /// </summary>
        private Image _imageDown = null;
        /// <summary>
        /// 绘制鼠标按下或者选中时的背景图片（左）
        /// </summary>
        private Image _imageDownLeft = null;
        /// <summary>
        /// 绘制鼠标按下或者选中时的背景图片（右）
        /// </summary>
        private Image _imageDownRight = null;
    }
}
