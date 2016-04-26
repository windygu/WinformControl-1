using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using CtrlControls.Enum;

namespace CtrlControls.ExImageLink
{
    partial class ImageLinkEx
    {
        /// <summary>
        /// 鼠标状态
        /// </summary>
        private EMouseState _mouseState = EMouseState.Normal;
        /// <summary>
        /// 控件里面文本的对齐方式
        /// </summary>
        private TextFormatFlags _textFlags = TextFormatFlags.Left |
                                        TextFormatFlags.SingleLine |
                                        TextFormatFlags.VerticalCenter;

        /// <summary>
        /// 图标
        /// </summary>
        private Image _icon = null;
        /// <summary>
        /// 控件本身的颜色
        /// </summary>
        private Color _natureColor = Color.Empty;
        /// <summary>
        /// 鼠标经过控件的颜色
        /// </summary>
        private Color _hoverColor = Color.FromArgb(22, 112, 235);
    }
}
