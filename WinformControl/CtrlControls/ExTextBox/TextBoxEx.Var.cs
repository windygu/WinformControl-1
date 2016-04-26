using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CtrlControls.Enum;

namespace CtrlControls.ExTextBox
{
    partial class TextBoxEx
    {
        /// <summary>
        /// 鼠标状态
        /// </summary>
        private EMouseState _mouseState = EMouseState.Normal;
        /// <summary>
        /// 水印文字
        /// </summary>
        private string _waterText = string.Empty;
        /// <summary>
        /// 水印文字的颜色
        /// </summary>
        private Color _waterColor = Color.DarkGray;
        /// <summary>
        /// 控件默认的边框图片
        /// </summary>
        private Image _borderNormalImage = null;
        /// <summary>
        /// 鼠标移入时控件的边框图片
        /// </summary>
        private Image _borderOverImage = null;
        /// <summary>
        /// 正常边框的颜色
        /// </summary>
        private Color _BorderNormalColor = Color.RoyalBlue;
        /// <summary>
        /// 鼠标进入边框时的颜色
        /// </summary>
        private Color _BorderOverColor = Color.BlueViolet;
        /// <summary>
        /// 边框的宽度
        /// </summary>
        private float _BorderWeight = 1.0f;
        /// <summary>
        /// 是否启用自定义边框
        /// </summary>
        private bool _Border = true;
        
    }
}
