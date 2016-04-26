using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using CtrlControls.Helper;
using CtrlControls.Struct;
using CtrlControls.Enum;
using System.Windows.Forms;
using CtrlResource;

namespace CtrlControls.ExListView
{
    partial class ListViewEx
    {
        /// <summary>
        /// ListView控件头部背景颜色
        /// </summary>
        [DefaultValue(typeof(Color), "209, 231, 243"), Description("ListView控件头部背景颜色"), Category("自定义属性")]
        public Color HeadBackgroundColor
        {
            get { return this._headBackgroundColor; }
            set
            {
                if (this._headBackgroundColor == value)
                    return;
                this._headBackgroundColor = value;
                base.Invalidate(true);
            }
        }
        /// <summary>
        /// ListView控件四周边框的颜色
        /// </summary>
        [DefaultValue(typeof(Color), "55, 126, 168"), Description("ListView控件四周边框的颜色"), Category("自定义属性")]
        public Color BorderColor
        {
            get { return this._borderColor; }
            set
            {
                if (this._borderColor == value)
                    return;
                this._borderColor = value;
                base.Invalidate(true);
            }
        }
        /// <summary>
        /// ListView控件选择某一项的背景颜色
        /// </summary>
        [DefaultValue(typeof(Color), "52, 139, 203"), Description("ListView控件选择某一项的背景颜色"), Category("自定义属性")]
        public Color ItemHighLightBackgroundColor
        {
            get { return this._itemHighLightBackgroundColor; }
            set
            {
                if (this._itemHighLightBackgroundColor == value)
                    return;
                this._itemHighLightBackgroundColor = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// ListView控件某一项的默认背景颜色
        /// </summary>
        [DefaultValue(typeof(Color), "232, 245, 251"), Description("ListView控件某一项的默认背景颜色"), Category("自定义属性")]
        public Color ItemBackgroundColor
        {
            get { return this._itemBackgroundColor; }
            set
            {
                if (this._itemBackgroundColor == value)
                    return;
                this._itemBackgroundColor = value;
                base.Invalidate();
            }
        }
        /// <summary>
        /// "ListView控件某一项的鼠标按下时背景图片
        /// </summary>
        [Description("ListView控件某一项的鼠标按下时背景图片"), Category("自定义属性")]
        public Image ItemBackgroundImage
        {
            get
            {
                if (this._itemBackgroundImage == null)
                {
                    this._itemBackgroundImage = AssemblyHelper.GetImage("ListView.listview_item_highlight.png", this.DesignMode);
                }
                return this._itemBackgroundImage;
            }
            set
            {
                if (this._itemBackgroundImage == value)
                    return;
                this._itemBackgroundImage = value;
                base.Invalidate();
            }
        }
        private IntPtr HeaderWnd
        {
            get
            {
                return new IntPtr(WinAPIDllImport.SendMessage(base.Handle, LVM_GETHEADER, 0, 0));
            }
        }
        private int ColumnCount
        {
            get
            {
                return WinAPIDllImport.SendMessage(this.HeaderWnd, HDM_GETITEMCOUNT, 0, 0);
            }
        }
        private RECT AbsoluteClientRECT
        {
            get
            {
                RECT lpRect = new RECT();
                CreateParams createParams = this.CreateParams;
                WinAPIDllImport.AdjustWindowRectEx(ref lpRect, createParams.Style, false, createParams.ExStyle);
                int left = -lpRect.Left;
                int right = -lpRect.Top;
                WinAPIDllImport.GetClientRect(base.Handle, ref lpRect);

                lpRect.Left += left;
                lpRect.Right += left;
                lpRect.Top += right;
                lpRect.Bottom += right;
                return lpRect;
            }
        }
        private Rectangle AbsoluteClientRectangle
        {
            get
            {
                RECT absoluteClientRect = this.AbsoluteClientRECT;
                Rectangle rect = Rectangle.FromLTRB(
                    absoluteClientRect.Left,
                    absoluteClientRect.Top,
                    absoluteClientRect.Right,
                    absoluteClientRect.Bottom);
                CreateParams cp = base.CreateParams;
                bool bHscroll = (cp.Style & (int)WindowStyle.WS_HSCROLL) != 0;
                bool bVscroll = (cp.Style & (int)WindowStyle.WS_VSCROLL) != 0;
                if (bHscroll)
                    rect.Height += SystemInformation.HorizontalScrollBarHeight;
                if (bVscroll)
                    rect.Width += SystemInformation.VerticalScrollBarWidth;
                return rect;
            }
        }
    }
}
