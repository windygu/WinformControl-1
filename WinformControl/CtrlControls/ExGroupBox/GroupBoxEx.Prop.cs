using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace CtrlControls.ExGroupBox
{
    partial class GroupBoxEx
    {
        /// <summary>
        ///  GroupBox控件的边框颜色
        /// </summary>
        [Description("GroupBox控件的边框颜色"), Category("自定义属性")]
        public Color LineColor
        {
            get { return this._lineColor; }
            set
            {
                if (this._lineColor == value)
                    return;
                this._lineColor = value;
                base.Invalidate();
            }
        }
    }
}
