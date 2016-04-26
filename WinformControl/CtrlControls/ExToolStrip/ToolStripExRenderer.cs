using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using CtrlResource;
using CtrlControls.Helper;

namespace CtrlControls.ExToolStrip
{
    public partial class ToolStripExRenderer : ToolStripRenderer
    {
        #region 构造函数
        public ToolStripExRenderer()
        { }
        public ToolStripExRenderer(int alpha)
        {
            this._alpha = alpha;
        }
        public ToolStripExRenderer(Color backColor)
        {
            this._backColor = backColor;
        }
        public ToolStripExRenderer(int alpha, Color backColor)
            : this(alpha)
        {
            this._backColor = backColor;
        }
        #endregion

        /// <summary>
        /// 绘制背景颜色
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            //base.OnRenderToolStripBackground(e);
            Graphics g = e.Graphics;
            Rectangle bounds = e.AffectedBounds;

            Color backColor = Color.FromArgb(this._alpha, this._backColor);
            using (SolidBrush brush = new SolidBrush(backColor))
            {
                g.FillRectangle(brush, bounds);
            }
        }

        /// <summary>
        /// 绘制鼠标划过时的背景
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            //base.OnRenderButtonBackground(e);
            ToolStripItem item = e.Item;
            Graphics g = e.Graphics;
            Rectangle bounds = item.ContentRectangle;
            if (item.Selected && !item.Pressed)
            {
                DrawHelper.RenderButtonBorderBackground(g, bounds, this.ImageHighLight, true);
            }

            if (item is ToolStripButton)
            {
                ToolStripButton toolStripButton = item as ToolStripButton;
                if (toolStripButton.Checked)
                {
                    DrawHelper.RenderButtonBorderBackground(g, bounds, this.ImageDown, true);
                    return;
                }
            }
            if (item.Pressed)
            {
                DrawHelper.RenderButtonBorderBackground(g, bounds, this.ImageDown, true);
            }
        }

        /// <summary>
        /// 绘制Separator(分离)线
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            //base.OnRenderSeparator(e);
            if (e.Vertical)
            {
                Graphics g = e.Graphics;
                Rectangle bounds = e.Item.ContentRectangle;
                Image image = this.ImageVerticalSeparator;
                int y = (bounds.Height - image.Height) / 2 + bounds.Y;
                Rectangle imageRect = new Rectangle(0, y, image.Width, image.Height);
                g.DrawImage(image, imageRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
            }
        }
        /// <summary>
        /// 绘制溢出按钮的背景
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderOverflowButtonBackground(ToolStripItemRenderEventArgs e)
        {
            //base.OnRenderOverflowButtonBackground(e);
            Image image = this.ImageOverflow;
            Rectangle bounds = e.ToolStrip.Bounds;
            Rectangle rect = new Rectangle(bounds.X, (bounds.Height - image.Height) / 2, image.Width, image.Height);
            e.Graphics.DrawImage(image, rect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
        }
    }
}
