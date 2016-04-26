using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace CtrlControls.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct NCCALCSIZE_PARAMS
    {
        internal RECT rgrc0;
        internal RECT rgrc1;
        internal RECT rgrc2;
        internal IntPtr lppos;
    }
}
