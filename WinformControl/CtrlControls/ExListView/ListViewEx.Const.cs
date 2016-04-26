using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtrlControls.ExListView
{
    partial class ListViewEx
    {
        private const int LVM_FIRST = 0x1000;
        private const int LVM_GETHEADER = (LVM_FIRST + 31);
        private const int HDI_ORDER = 0x0080;
        private const int HDM_FIRST = 0x1200;
        private const int HDM_GETITEMCOUNT = (HDM_FIRST + 0);
        private const int HDM_GETITEMA = (HDM_FIRST + 3);
        private const int HDM_GETITEMRECT = (HDM_FIRST + 7);
    }
}
