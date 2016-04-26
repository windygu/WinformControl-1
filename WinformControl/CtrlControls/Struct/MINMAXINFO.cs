using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;

namespace CtrlControls.Struct
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct MINMAXINFO
    {
        public Point reserved;
        public Size maxSize;
        public Point maxPosition;
        public Size minTrackSize;
        public Size maxTrackSize;
    }
}
