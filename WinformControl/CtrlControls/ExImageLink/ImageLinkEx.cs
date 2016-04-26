using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using CtrlControls.Enum;

namespace CtrlControls.ExImageLink
{
    [ToolboxBitmap(typeof(Control))]
    public partial class ImageLinkEx : Control
    {
        public ImageLinkEx()
        {
            base.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.Selectable, true);
            base.SetStyle(ControlStyles.Opaque, false);
            base.BackColor = Color.Transparent;
            base.UpdateStyles();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics g = e.Graphics;
            Rectangle imageRect = this.ImageRect;
            Rectangle contentRect = this.ContentRect;
            if (this._mouseState == EMouseState.MouseDown)
            {
                imageRect.X += 1;
                imageRect.Y += 1;
                contentRect.X += 1;
                contentRect.Y += 1;
            }
            if (this._icon != null)
            {
                //画图
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawImage(this._icon, imageRect, new Rectangle(0, 0, this._icon.Width, this._icon.Height), GraphicsUnit.Pixel);
            }

            if (!string.IsNullOrEmpty(base.Text))
            {
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                TextRenderer.DrawText(g, this.Text, base.Font, contentRect, base.ForeColor, this._textFlags);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            this._natureColor = base.ForeColor;
            base.OnMouseEnter(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (this.ClientRectangle.Contains(e.Location))
            {
                this.Cursor = Cursors.Hand;
                this.MouseState = EMouseState.MouseMove;
                base.ForeColor = this._hoverColor;
            }
            base.OnMouseMove(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (this.ClientRectangle.Contains(e.Location)
                && e.Button == MouseButtons.Left)
            {
                this.MouseState = EMouseState.MouseDown;
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.MouseState = EMouseState.MouseUp;
            base.OnMouseUp(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            this.MouseState = EMouseState.Normal;
            base.ForeColor = this._natureColor;
            base.OnMouseLeave(e);
        }
    }
}
