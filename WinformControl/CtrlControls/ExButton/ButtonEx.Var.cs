using System;
using System.Windows.Forms;
using System.Drawing;
using CtrlControls.Enum;

namespace CtrlControls.ExButton
{
    partial class ButtonEx
    {
        /// <summary>
        /// 普通状态下按钮的背景图片
        /// </summary>
        private Image _normalImage = null;
        /// <summary>
        /// 鼠标经过的背景图
        /// </summary>
        private Image _moveImage = null;
        /// <summary>
        /// 鼠标按下的背景图
        /// </summary>
        private Image _downImage = null;
        /// <summary>
        /// 是否显示按钮的边
        /// </summary>
        private bool _isShowBorder = true;
        /// <summary>
        /// 按钮的边的图片
        /// </summary>
        private Image _borderImage = null;
        /// <summary>
        /// 按钮具有焦点时的图片
        /// </summary>
        private Image _focusImage = null;
        /// <summary>
        /// 鼠标经过按钮时的状态
        /// </summary>
        private EMouseState _mouseState = EMouseState.Normal;
        /// <summary>
        /// 按钮文字的居中方式
        /// </summary>
        private TextFormatFlags _textAlign = TextFormatFlags.SingleLine | TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
    }
}
