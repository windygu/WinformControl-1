using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtrlControls.Enum
{
    /// <summary>
    /// 窗体控件标题栏上的最小化、最大化、关闭按钮的枚举类型
    /// </summary>
    public enum ESystemButton
    {
        /// <summary>
        /// 无
        /// </summary>
        None = 0,
        /// <summary>
        /// 关闭
        /// </summary>
        Close = 1,
        /// <summary>
        /// 关闭,最小化
        /// </summary>
        CloseMin = 2,
        /// <summary>
        /// 关闭,最小化,最大化
        /// </summary>
        CloseMinMax = 3
    }
}
