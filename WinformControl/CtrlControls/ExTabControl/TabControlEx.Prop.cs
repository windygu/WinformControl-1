using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using CtrlResource;

namespace CtrlControls.ExTabControl
{
    partial class TabControlEx
    {
        /// <summary>
        /// 标题栏正常状态下显示的背景图片
        /// </summary>
        [Description("标题栏正常状态下显示的背景图片"), Category("自定义属性")]
        public Image TabHeadBackgroundNormal
        {
            get
            {
                if (this._tab_Head_Background_Normal == null)
                {
                    this._tab_Head_Background_Normal = AssemblyHelper.GetImage("TabControl.tab_head_bkg_normal.png", this.DesignMode);
                }
                return this._tab_Head_Background_Normal;
            }
            set
            {
                if (this._tab_Head_Background_Normal == value)
                    return;
                this._tab_Head_Background_Normal = value;
                base.Invalidate(true);
            }
        }
        /// <summary>
        /// 标题栏选中状态时的背景图片
        /// </summary>
        [Description("标题栏选中状态时的背景图片"), Category("自定义属性")]
        public Image TabHeadBackgroundSelected
        {
            get
            {
                if (this._tab_Head_Background_Selected == null)
                {
                    this._tab_Head_Background_Selected = AssemblyHelper.GetImage("TabControl.tab_head_bkg_selected.png", this.DesignMode);
                }
                return this._tab_Head_Background_Selected;
            }
            set
            {
                if (this._tab_Head_Background_Selected == value)
                    return;
                this._tab_Head_Background_Selected = value;
                base.Invalidate(true);
            }
        }
        /// <summary>
        /// 标题栏鼠标经过时的背景图片
        /// </summary>
        [Description("标题栏鼠标经过时的背景图片"), Category("自定义属性")]
        public Image TabHeadBackgroundMove
        {
            get
            {
                if (this._tab_Head_Background_Move == null)
                {
                    this._tab_Head_Background_Move = AssemblyHelper.GetImage("TabControl.tab_head_bkg_move.png", this.DesignMode);
                }
                return this._tab_Head_Background_Move;
            }
            set
            {
                if (this._tab_Head_Background_Move == value)
                    return;
                this._tab_Head_Background_Move = value;
                base.Invalidate(true);
            }
        }
        /// <summary>
        /// 当有菜单时，鼠标按下箭头时的背景图片
        /// </summary>
        [Description("当有菜单时，鼠标按下箭头时的背景图片"), Category("自定义属性")]
        public Image TabHeadArrowDown
        {
            get
            {
                if (this._tab_Head_Arrow_Down == null)
                {
                    this._tab_Head_Arrow_Down = AssemblyHelper.GetImage("TabControl.tab_arrow_down.png", this.DesignMode);
                }
                return this._tab_Head_Arrow_Down;
            }
            set
            {
                if (this._tab_Head_Arrow_Down == value)
                    return;
                this._tab_Head_Arrow_Down = value;
                base.Invalidate(true);
            }
        }
        /// <summary>
        /// 当有菜单时，鼠标经过箭头时的背景图片
        /// </summary>
        [Description("当有菜单时，鼠标经过箭头时的背景图片"), Category("自定义属性")]
        public Image TabHeadArrowMove
        {
            get
            {
                if (this._tab_Head_Arrow_Move == null)
                {
                    this._tab_Head_Arrow_Move = AssemblyHelper.GetImage("TabControl.tab_arrow_move.png", this.DesignMode);
                }
                return this._tab_Head_Arrow_Move;
            }
            set
            {
                if (this._tab_Head_Arrow_Move == value)
                    return;
                this._tab_Head_Arrow_Move = value;
                base.Invalidate(true);
            }
        }
        /// <summary>
        /// TabControl背景颜色
        /// </summary>
        [DefaultValue(typeof(Color), "234, 247, 254"), Browsable(true), EditorBrowsable(EditorBrowsableState.Always), Description("TabControl背景颜色"), Category("自定义属性")]
        public override Color BackColor
        {
            get { return this._tabControlBackColor; }
            set
            {
                if (this._tabControlBackColor == value)
                    return;
                this._tabControlBackColor = value;
                base.Invalidate(true);
            }
        }
        /// <summary>
        /// TabControl里面TabPage的外边框颜色
        /// </summary>
        [DefaultValue(typeof(Color), "102, 180, 228"), Description("TabControl里面TabPage的外边框颜色"), Category("自定义属性")]
        public Color TabControlBorderColor
        {
            get { return this._tabControlBorderColor; }
            set
            {
                this._tabControlBorderColor = value;
                base.Invalidate(true);
            }
        }
        /// <summary>
        /// 所有TabPage的背景颜色
        /// </summary>
        [Description("所有TabPage的背景颜色"), Category("自定义属性")]
        public Color TabPageBackColor
        {
            get { return this._tabPageBackColor; }
            set
            {
                if (this._tabPageBackColor == value)
                    return;
                this._tabPageBackColor = value;
                if (this.TabPages.Count > 0)
                {
                    for (int i = 0; i < this.TabPages.Count; i++)
                    {
                        this.TabPages[i].BackColor = this._tabPageBackColor;
                    }
                }
                base.Invalidate(true);
            }
        }
    }
}
