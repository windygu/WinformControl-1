using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using CtrlControls.Enum;

namespace CtrlControls.ExTabControl
{
    [ToolboxBitmap(typeof(TabControl))]
    public partial class TabControlEx : TabControl
    {
        public TabControlEx()
            : base()
        {
            base.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);
            base.SizeMode = TabSizeMode.Fixed;
            base.ItemSize = new Size(120, 34);
            base.UpdateStyles();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            this.DrawBackground(g);
            this.DrawTabPages(g);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            base.Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            base.Invalidate();
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left && this._tabHeadArrowRect.Contains(e.Location))
            {
                this._isMouseDownArrow = true;
                base.Invalidate(this._tabHeadArrowRect);
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg != (int)WindowsMessage.WM_CONTEXTMENU)//0x007B鼠标右键
            {
                base.WndProc(ref m);
            }
        }
    }
}
