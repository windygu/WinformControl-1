using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CtrlResource;
using CtrlControls.Enum;

namespace CtrlControls.ExForm
{
    partial class FormEx
    {
        /// <summary>
        /// 标题栏的高度
        /// </summary>
        private const int TITLE_REGION_HEIGHT = 25;
        /// <summary>
        /// 窗体的边框
        /// </summary>
        private Image _borderImage = AssemblyHelper.GetImage("Form.form_border.png");
        /// <summary>
        /// 关闭按钮的鼠标状态
        /// </summary>
        private EMouseState _closeMouseState = EMouseState.Normal;
        /// <summary>
        /// 最大化按钮的鼠标状态
        /// </summary>
        private EMouseState _maxMouseState = EMouseState.Normal;
        /// <summary>
        /// 最小化按钮的鼠标状态
        /// </summary>
        private EMouseState _minMouseState = EMouseState.Normal;
        /// <summary>
        /// 窗体控件标题栏上默认显示的最小化、最大化、关闭按钮
        /// </summary>
        private ESystemButton _systemButton = ESystemButton.CloseMinMax;
    }
}
