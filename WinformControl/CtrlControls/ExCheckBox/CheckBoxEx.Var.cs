using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CtrlControls.Enum;
using System.Drawing;
using System.Windows.Forms;

namespace CtrlControls.ExCheckBox
{
    /// <summary>
    /// CheckBox控件（复选框控件）
    /// </summary>
    partial class CheckBoxEx
    {
        /// <summary>
        /// 控件的尺寸17*17
        /// </summary>
        private const int CHECKBOX_IMAGE_SIZE = 17;
        /// <summary>
        /// 控件不确定状态下的尺寸15*15
        /// </summary>
        private const int CHECKBOX_IMAGE_INDETERMINATE_SIZE = 15;
        /// <summary>
        /// 控件里面文本的对齐方式
        /// </summary>
        private TextFormatFlags _textFlags = TextFormatFlags.Left |
                                        TextFormatFlags.SingleLine |
                                        TextFormatFlags.VerticalCenter;
        /// <summary>
        /// 鼠标状态
        /// </summary>
        private EMouseState _mouseState = EMouseState.Normal;
        /// <summary>
        /// 普通状态下控件未选中时的背景图片
        /// </summary>
        private Image _normalImage = null;
        /// <summary>
        /// 普通状态下控件选中时的背景图片
        /// </summary>
        private Image _normalImageChecked = null;
        /// <summary>
        /// 鼠标经过状态（或控件具有焦点）时控件未选中时的背景图片
        /// </summary>
        private Image _highLightImage = null;
        /// <summary>
        /// 鼠标经过状态（或控件具有焦点）时控件选中时的背景图片
        /// </summary>
        private Image _highLightImageChecked = null;
        /// <summary>
        /// 不确定状态下控件鼠标离开控件时的背景图片
        /// </summary>
        private Image _indeterminateImage = null;
        /// <summary>
        /// 不确定状态下控件鼠标进入控件时的背景图片
        /// </summary>
        private Image _indeterminateHighLightImage = null;
    }
}
