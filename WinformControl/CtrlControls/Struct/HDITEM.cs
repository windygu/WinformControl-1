using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace CtrlControls.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    public struct HDITEM
    {
        public int mask;
        public int cxy;
        public string pszText;
        public IntPtr hbm;
        public int cchTextMax;
        public int fmt;
        public IntPtr lParam;
        public int iImage;
        public int iOrder;
        public uint type;
        public IntPtr pvFilter;
    }
}
