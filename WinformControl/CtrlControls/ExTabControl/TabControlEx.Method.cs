using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CtrlControls.ExTabControl
{
    partial class TabControlEx
    {
        /// <summary>
        /// 绘制背景
        /// </summary>
        /// <param name="g"></param>
        private void DrawBackground(Graphics g)
        {
            int width = base.ClientRectangle.Width;
            int height = base.ClientRectangle.Height - base.DisplayRectangle.Height;
            Color backColor = this.Enabled ? this._tabControlBackColor : SystemColors.Control;
            using (SolidBrush brush = new SolidBrush(backColor))
            {
                g.FillRectangle(brush, base.ClientRectangle);
            }
            Rectangle bgRect = new Rectangle(2, 2, base.Width - 2, base.ItemSize.Height);
            this.DrawImage(g, this._tab_Head_Background_Normal, bgRect);//绘制背景图
        }
        /// <summary>
        /// 绘图
        /// </summary>
        /// <param name="g"></param>
        /// <param name="image"></param>
        /// <param name="rect"></param>
        private void DrawImage(Graphics g, Image image, Rectangle rect)
        {
            g.DrawImage(image, new Rectangle(rect.X, rect.Y, 5, rect.Height), 0, 0, 5, image.Height, GraphicsUnit.Pixel);
            g.DrawImage(image, new Rectangle(rect.X + 5, rect.Y, rect.Width - 10, rect.Height), 5, 0, image.Width - 10, image.Height, GraphicsUnit.Pixel);
            g.DrawImage(image, new Rectangle(rect.X + rect.Width - 5, rect.Y, 5, rect.Height), image.Width - 5, 0, 5, image.Height, GraphicsUnit.Pixel);
        }

        /// <summary>
        /// 绘制选项卡
        /// </summary>
        /// <param name="g"></param>
        private void DrawTabPages(Graphics g)
        {
            using (SolidBrush brush = new SolidBrush(this._tabPageBackColor))
            {
                int x = 2;
                int y = base.ItemSize.Height;
                int width = base.Width - 2;
                int height = base.Height - base.ItemSize.Height;
                g.FillRectangle(brush, x, y, width, height);
                g.DrawRectangle(new Pen(this._tabControlBorderColor), x, y, width - 1, height - 1);
            }
            Rectangle tabRect;
            Point cursorPoint = base.PointToClient(MousePosition);
            for (int i = 0; i < base.TabCount; i++)
            {
                TabPage page = base.TabPages[i];
                tabRect = base.GetTabRect(i);
                Color baseColor = Color.Yellow;
                Image tabHeaderImage = null;
                Image btnArrowImage = null;

                if (base.SelectedIndex == i)//是否选中
                {
                    tabHeaderImage = this.TabHeadBackgroundSelected;
                    Point contextMenuLocation = base.PointToScreen(new Point(this._tabHeadArrowRect.Left, this._tabHeadArrowRect.Top + this._tabHeadArrowRect.Height + 5));
                    ContextMenuStrip contextMenuStrip = base.TabPages[i].ContextMenuStrip;
                    if (contextMenuStrip != null)
                    {
                        contextMenuStrip.Closed -= new ToolStripDropDownClosedEventHandler(contextMenuStrip_Closed);
                        contextMenuStrip.Closed += new ToolStripDropDownClosedEventHandler(contextMenuStrip_Closed);
                        if (contextMenuLocation.X + contextMenuStrip.Width > Screen.PrimaryScreen.WorkingArea.Width - 20)
                        {
                            contextMenuLocation.X = Screen.PrimaryScreen.WorkingArea.Width - contextMenuStrip.Width - 50;
                        }
                        if (tabRect.Contains(cursorPoint))
                        {
                            if (this._isMouseDownArrow)
                            {
                                btnArrowImage = this.TabHeadArrowDown;
                                contextMenuStrip.Show(contextMenuLocation);
                            }
                            else
                            {
                                btnArrowImage = this.TabHeadArrowMove;
                            }
                            this._tabHeadArrowRect = new Rectangle(tabRect.X + tabRect.Width - btnArrowImage.Width, tabRect.Y, btnArrowImage.Width, btnArrowImage.Height);
                        }
                        else if (this._isMouseDownArrow)
                        {
                            btnArrowImage = this.TabHeadArrowDown;
                            contextMenuStrip.Show(contextMenuLocation);
                        }
                    }
                }
                else if (tabRect.Contains(cursorPoint))//鼠标滑过
                {
                    tabHeaderImage = this.TabHeadBackgroundMove;
                }
                if (tabHeaderImage != null)
                {
                    if (this.SelectedIndex == i)
                    {
                        if (this.SelectedIndex == this.TabCount - 1)
                            tabRect.Inflate(2, 0);
                        else
                            tabRect.Inflate(1, 0);
                    }
                    this.DrawImage(g, tabHeaderImage, tabRect);
                    if (btnArrowImage != null)
                    {
                        //当鼠标进入当前选中的选项卡时，显示下拉按钮
                        g.DrawImage(btnArrowImage, this._tabHeadArrowRect);
                    }
                }
                TextRenderer.DrawText(g, page.Text, page.Font, tabRect, page.ForeColor);
            }
        }

        private void contextMenuStrip_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            this._isMouseDownArrow = false;
            base.Invalidate(this._tabHeadArrowRect);
        }
    }
}
