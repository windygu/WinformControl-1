using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using CtrlControls.Helper;

namespace CtrlControls.ExMenu
{
    public partial class MenuRenderer : ToolStripRenderer
    {
        /// <summary>
        /// 绘制菜单背景
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle rect = e.AffectedBounds;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            int rgn = WinAPIDllImport.CreateRoundRectRgn(1, 1, rect.Width, rect.Height, 3, 3);
            WinAPIDllImport.SetWindowRgn(e.ToolStrip.Handle, rgn, true);
            #region 画菜单的背景图片
            //左侧
            g.DrawImage(this._background, new Rectangle(0, 0, 28, 5), new Rectangle(4, 4, 28, 5), GraphicsUnit.Pixel);//左上角
            g.DrawImage(this._background, new Rectangle(0, 5, 28, rect.Height - 10), new Rectangle(4, 8, this._background.Height - 2, 14), GraphicsUnit.Pixel);//左边
            g.DrawImage(this._background, new Rectangle(0, rect.Height - 5, 28, 5), new Rectangle(4, this._background.Height - 9, 28, 5), GraphicsUnit.Pixel);//左下角
            //右侧
            g.DrawImage(this._backgroundBorder, new Rectangle(28, 0, rect.Width - 32, 5), new Rectangle(10, 4, this._backgroundBorder.Width - 35, 5), GraphicsUnit.Pixel);//上边
            g.DrawImage(this._backgroundBorder, new Rectangle(rect.Width - 4, 0, 8, 5), new Rectangle(this._backgroundBorder.Width - 8, 4, 8, 5), GraphicsUnit.Pixel);//右上角
            g.DrawImage(this._backgroundBorder, new Rectangle(rect.Width - 4, 5, 8, rect.Height - 10), new Rectangle(this._backgroundBorder.Width - 8, 10, 8, 12), GraphicsUnit.Pixel);//右边
            g.DrawImage(this._backgroundBorder, new Rectangle(rect.Width - 4, rect.Height - 5, 8, 5), new Rectangle(this._backgroundBorder.Width - 8, this._backgroundBorder.Height - 9, 8, 5), GraphicsUnit.Pixel);//右下角
            g.DrawImage(this._backgroundBorder, new Rectangle(28, rect.Height - 4, rect.Width - 32, 5), new Rectangle(10, this._backgroundBorder.Height - 8, this._backgroundBorder.Width - 35, 5), GraphicsUnit.Pixel);//下边
            g.DrawImage(this._backgroundBorder, new Rectangle(28, 5, rect.Width - 32, rect.Height - 9), new Rectangle(10, 10, 32, 12), GraphicsUnit.Pixel);//填充
            #endregion
        }

        /// <summary>
        /// 绘制 ToolStripItem 上的箭头。
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
            Rectangle rectDesc = new Rectangle(e.ArrowRectangle.X + 4, (e.ArrowRectangle.Height - this._arrow.Height) / 2, this._arrow.Width, this._arrow.Height);//图片的位置和显示的大小
            Rectangle rectSrc = new Rectangle(0, 0, this._arrow.Width, this._arrow.Height);
            e.Graphics.DrawImage(this._arrow, rectDesc, rectSrc, GraphicsUnit.Pixel);
        }
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //把父类里面的Border擦出了（去掉默认的Border）
            //base.OnRenderToolStripBorder(e);
        }
        /// <summary>
        /// 鼠标划过时背景颜色和文字颜色
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.ToolStrip is ToolStripDropDown)
            {
                ToolStripItem item = e.Item;
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //绘制选中项
                if (item.Selected)
                {
                    item.ForeColor = Color.White;//文字颜色
                    if (this._highlight != null)
                    {
                        Rectangle rectDesc = new Rectangle(item.ContentRectangle.X + 1, item.ContentRectangle.Y, item.ContentRectangle.Width - 1, item.ContentRectangle.Height);
                        Rectangle imgSrc = new Rectangle(0, 0, this._highlight.Width - 1, this._highlight.Height);
                        e.Graphics.DrawImage(this._highlight, rectDesc, imgSrc, GraphicsUnit.Pixel);//背景
                    }
                }
                else
                {
                    item.ForeColor = Color.Black;
                }
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
        /// <summary>
        /// 水平线
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            if (!e.Vertical)
            {
                Rectangle rect = new Rectangle(e.Item.ContentRectangle.X + 25, e.Item.ContentRectangle.Y, e.Item.ContentRectangle.Width - 25, this._cutling.Height);
                e.Graphics.DrawImage(this._cutling, rect);
            }
            else
            {
                base.OnRenderSeparator(e);
            }
        }
        /// <summary>
        /// 选中项
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e)
        {
            e.Graphics.DrawImage(this._check, e.ImageRectangle);
        }
        /// <summary>
        /// 将图标居中绘制
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRenderItemImage(ToolStripItemImageRenderEventArgs e)
        {
            //base.OnRenderItemImage(e);//去掉默认绘制菜单项图片的方式
            if (e.ToolStrip is ContextMenuStrip)
            {
                ContextMenuStrip contextMenuStrip = e.ToolStrip as ContextMenuStrip;
                Image imgIcon = e.Image;
                int x = (30 - imgIcon.Width) / 2;
                int y = (e.Item.Height - imgIcon.Height) / 2;
                e.Graphics.DrawImage(imgIcon, x, y, imgIcon.Width, imgIcon.Height);
            }
        }
    }
}
