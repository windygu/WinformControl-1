using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;

namespace CtrlControls.ExDataGridView
{
    partial class DataGridViewEx
    {
        /// <summary>
        /// 标题行和标题列的渐变颜色A
        /// </summary>
        [Description("标题行和标题列的渐变颜色A"), Category("自定义属性")]
        public Color TitleColorA
        {
            get { return this._titleColorA; }
            set
            {
                if (this._titleColorA == value)
                    return;
                this._titleColorA = value;
                base.Invalidate(true);
            }
        }
        /// <summary>
        /// 标题行和标题列的渐变颜色B
        /// </summary>
        [Description("标题行和标题列的渐变颜色B"), Category("自定义属性")]
        public Color TitleColorB
        {
            get { return this._titleColorB; }
            set
            {
                if (this._titleColorB == value)
                    return;
                this._titleColorB = value;
                base.Invalidate(true);
            }
        }
        /// <summary>
        /// 当鼠标划过时单元格变化的颜色
        /// </summary>
        [Description("当鼠标划过时单元格变化的颜色"), Category("自定义属性")]
        public Color MouseMoveColor
        {
            get { return this._mouseMoveColor; }
            set
            {
                if (this._mouseMoveColor == value)
                    return;
                this._mouseMoveColor = value;
                base.Invalidate(true);
            }
        }
    }
}
