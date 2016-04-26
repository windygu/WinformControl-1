using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtrlControls.Enum
{
    /// <summary>
    /// 建立圆角路径的样式
    /// </summary>
    [Flags]
    public enum ERoundStyle
    {
        All = 15,
        Bottom = 12,
        BottomLeft = 4,
        BottomRight = 8,
        Left = 5,
        None = 0,
        Right = 10,
        Top = 3,
        TopLeft = 1,
        TopRight = 2
    }
}
