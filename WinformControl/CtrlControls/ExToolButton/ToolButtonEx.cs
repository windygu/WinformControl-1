using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using CtrlControls.Enum;

namespace CtrlControls.ExToolButton
{
    public partial class ToolButtonEx : Control
    {
        public ToolButtonEx()
        {
            base.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.Selectable |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.DoubleBuffer, true);
            base.BackColor = Color.Transparent;
            base.UpdateStyles();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (this._toolIcon != null)
            {
                if (string.IsNullOrEmpty(this.Text))
                {
                    this.DrawImage(e.Graphics);
                }
                else
                {
                    this.DrawImageAndText(e.Graphics);
                }
            }
            else
            {
                base.OnPaint(e);
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.MouseState = EMouseState.MouseMove;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
                this.MouseState = EMouseState.MouseDown;
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            this.MouseState = EMouseState.MouseUp;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.MouseState = EMouseState.MouseLeave;
        }

    }
}
