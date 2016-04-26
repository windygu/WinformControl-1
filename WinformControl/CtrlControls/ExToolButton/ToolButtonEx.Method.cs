using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using CtrlControls.Enum;
using CtrlControls.Helper;

namespace CtrlControls.ExToolButton
{
    partial class ToolButtonEx
    {
        /// <summary>
        /// 绘制图标
        /// </summary>
        private void DrawImage(Graphics g)
        {
            Image border = null;
            Rectangle bounds = this.GetDrawIconRegion(this._toolIcon);
            switch (this._mouseState)
            {
                case EMouseState.MouseMove:
                case EMouseState.MouseUp:
                    border = this.ImageHighLight;
                    break;
                case EMouseState.MouseDown:
                    border = this.ImageDown;
                    bounds.X += 1;
                    bounds.Y += 1;
                    break;
            }
            if (border != null)
            {
                g.DrawImage(border, base.ClientRectangle, 0, 0, border.Width, border.Height, GraphicsUnit.Pixel);
            }
            g.DrawImage(this._toolIcon, bounds, 0, 0, this._toolIcon.Width, this._toolIcon.Height, GraphicsUnit.Pixel);
        }
        /// <summary>
        /// 绘制图标和文字
        /// </summary>
        private void DrawImageAndText(Graphics g)
        {
            Rectangle bounds = this.GetDrawIconRegion(this._toolIcon);
            Image borderLeft = null;
            Image borderRight = null;
            switch (this._mouseState)
            {
                case EMouseState.MouseMove:
                case EMouseState.MouseUp:
                    borderLeft = this.ImageHighLightLeft;
                    borderRight = this.ImageHighLightRight;
                    break;
                case EMouseState.MouseDown:
                    borderLeft = this.ImageDownLeft;
                    borderRight = this.ImageDownRight;
                    bounds.X += 1;
                    bounds.Y += 1;
                    break;
            }
            if (borderLeft != null && borderRight != null)
            {
                g.DrawImage(borderLeft, new Rectangle(0, 0, borderLeft.Width, borderLeft.Height), 0, 0, borderLeft.Width, borderRight.Height, GraphicsUnit.Pixel);
                g.DrawImage(borderLeft, new Rectangle(borderLeft.Width, 0, base.Width - borderLeft.Width - borderRight.Width, borderLeft.Height), 2, 0, borderLeft.Width - 4, borderLeft.Height, GraphicsUnit.Pixel);
                g.DrawImage(borderRight, new Rectangle(base.Width - borderLeft.Width, 0, borderRight.Width, borderRight.Height), 1, 0, borderRight.Width - 1, borderRight.Height, GraphicsUnit.Pixel);
            }
            TextRenderer.DrawText(g, this.Text, base.Font, this.ContentRect, base.ForeColor, this._textFlags);
            g.DrawImage(this._toolIcon, bounds, 0, 0, this._toolIcon.Width, this._toolIcon.Height, GraphicsUnit.Pixel);
        }
        /// <summary>
        /// 获取图标的绘制区域
        /// </summary>
        private Rectangle GetDrawIconRegion(Image icon)
        {
            Rectangle rect = new Rectangle(0, 0, icon.Width, icon.Height);
            if (base.Width > icon.Width || base.Height > icon.Height)
            {
                rect.Width = icon.Width;
                rect.Height = icon.Height;
                rect.X = (base.Width - icon.Width) / 2;
                rect.Y = (base.Height - icon.Height) / 2;
            }
            if (!string.IsNullOrEmpty(this.Text))
                rect.X = 0;
            return rect;
        }
    }
}
