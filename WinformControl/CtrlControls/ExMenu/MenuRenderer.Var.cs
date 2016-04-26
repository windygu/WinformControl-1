using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CtrlResource;

namespace CtrlControls.ExMenu
{
    partial class MenuRenderer
    {
        /// <summary>
        /// 箭头
        /// </summary>
        private Image _arrow = AssemblyHelper.GetImage("Menu.menu_arrow.png");
        /// <summary>
        /// 背景图片
        /// </summary>
        private Image _background = AssemblyHelper.GetImage("Menu.menu_bkg.png");
        /// <summary>
        /// 背景的边
        /// </summary>
        private Image _backgroundBorder = AssemblyHelper.GetImage("Menu.menu_bkg_border.png");
        /// <summary>
        /// Checked状态的图片
        /// </summary>
        private Image _check = AssemblyHelper.GetImage("Menu.menu_check.png");
        /// <summary>
        /// 水平线
        /// </summary>
        private Image _cutling = AssemblyHelper.GetImage("Menu.menu_cutling.png");
        /// <summary>
        /// 高亮背景颜色
        /// </summary>
        private Image _highlight = AssemblyHelper.GetImage("Menu.menu_highlight.png");
    }
}
