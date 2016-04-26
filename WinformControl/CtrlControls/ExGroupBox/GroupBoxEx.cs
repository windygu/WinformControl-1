using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CtrlControls.ExGroupBox
{
    public partial class GroupBoxEx : GroupBox
    {
        public GroupBoxEx()
        {
            base.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.Selectable |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.DoubleBuffer, true);
            base.SetStyle(ControlStyles.Opaque, false);
            base.BackColor = Color.Transparent;
            base.UpdateStyles();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.DrawLine(new Pen(this._lineColor), 1, 7, 6, 7);
            g.DrawLine(new Pen(this._lineColor), g.MeasureString(base.Text, base.Font).Width + 4, 7, base.Width - 2, 7);
            g.DrawLine(new Pen(this._lineColor), 1, 7, 1, base.Height - 2);
            g.DrawLine(new Pen(this._lineColor), 1, base.Height - 2, base.Width - 2, base.Height - 2);
            g.DrawLine(new Pen(this._lineColor), base.Width - 2, 7, base.Width - 2, base.Height - 2);
        }

    }
}
