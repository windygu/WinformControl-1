using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CtrlControls.ExListView
{
    partial class ListViewEx
    {
        private Color _headBackgroundColor = Color.FromArgb(209, 231, 243);
        private Color _borderColor = Color.FromArgb(55, 126, 168);
        private Color _itemHighLightBackgroundColor = Color.FromArgb(62, 150, 215);
        private Color _itemBackgroundColor = Color.FromArgb(232, 245, 251);
        /// <summary>
        /// 鼠标按下时行的背景图片
        /// </summary>
        private Image _itemBackgroundImage = null;
        private HeaderNativeWindow _headerNativeWindow;
    }
}
