using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CtrlResource;

namespace CtrlControls.ExToolStrip
{
    partial class ToolStripExRenderer
    {
        /// <summary>
        /// 绘制鼠标划过时的背景图片
        /// </summary>
        public Image ImageHighLight
        {
            get
            {
                if (this._imageHighLight == null)
                {
                    this._imageHighLight = AssemblyHelper.GetImage("ToolStrip.toolstripbtn_highlight.png");
                }
                return this._imageHighLight;
            }
            set
            {
                if (this._imageHighLight == value)
                    return;
                this._imageHighLight = value;
            }
        }
        /// <summary>
        /// 绘制鼠标按下或者选中时的背景图片
        /// </summary>
        public Image ImageDown
        {
            get
            {
                if (this._imageDown == null)
                {
                    this._imageDown = AssemblyHelper.GetImage("ToolStrip.toolstripbtn_down.png");
                }
                return this._imageDown;
            }
            set
            {
                if (this._imageDown == value)
                    return;
                this._imageDown = value;
            }
        }
        /// <summary>
        /// 绘制Separator(竖分离)线
        /// </summary>
        public Image ImageVerticalSeparator
        {
            get
            {
                if (this._imageVerticalSeparator == null)
                {
                    this._imageVerticalSeparator = AssemblyHelper.GetImage("ToolStrip.toolstripbtn_vertical_separator.png");
                }
                return this._imageVerticalSeparator;
            }
            set
            {
                if (this._imageVerticalSeparator == value)
                    return;
                this._imageVerticalSeparator = value;
            }
        }
        /// <summary>
        /// 绘制溢出按钮的背景
        /// </summary>
        public Image ImageOverflow
        {
            get
            {
                if (this._imageOverflow == null)
                {
                    this._imageOverflow = AssemblyHelper.GetImage("ToolStrip.toolstripbtn_overflow.png");
                }
                return this._imageOverflow;
            }
            set
            {
                if (this._imageOverflow == value)
                    return;
                this._imageOverflow = value;
            }
        }
    }
}
