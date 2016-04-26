using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CtrlControls.ExTabControl
{
    partial class TabControlEx
    {
        private Image _tab_Head_Background_Normal = null;
        private Image _tab_Head_Background_Selected = null;
        private Image _tab_Head_Background_Move = null;
        private Image _tab_Head_Arrow_Down = null;
        private Image _tab_Head_Arrow_Move = null;

        private Color _tabControlBackColor = Color.FromArgb(234, 247, 254);
        private Color _tabControlBorderColor = SystemColors.Control;
        private Color _tabPageBackColor = SystemColors.Control;
        /// <summary>
        /// 鼠标是否按下菜单的箭头区域
        /// </summary>
        private bool _isMouseDownArrow = false;
        /// <summary>
        /// 选项卡箭头区域
        /// </summary>
        private Rectangle _tabHeadArrowRect = Rectangle.Empty;
    }
}
