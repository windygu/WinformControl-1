using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CtrlControls.ExDataGridView
{
    partial class DataGridViewEx
    {
        /// <summary>
        /// 标题行和标题列的渐变颜色A
        /// </summary>
        private Color _titleColorA = Color.FromArgb(211, 230, 245);
        /// <summary>
        /// 标题行和标题列的渐变颜色B
        /// </summary>
        private Color _titleColorB = Color.White;
        /// <summary>
        /// 当鼠标划过时单元格变化的颜色
        /// </summary>
        private Color _mouseMoveColor = Color.Yellow;//Color.FromArgb(200, 0, 0, 0);
        private Color _defaultColor;
        //private Color _selectedColor = Color.FromArgb(200, 95, 107, 39);
        //private Color _selectedBorderColor = Color.FromArgb(200, 165, 186, 129);
    }
}
