using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CtrlControls.Struct;
using System.Drawing;
using CtrlControls.Helper;
using System.Windows.Forms;
using System.ComponentModel;
using CtrlControls.Enum;

namespace CtrlControls.ExListView
{
    partial class ListViewEx
    {
        private int ColumnAtIndex(int column)
        {
            HDITEM hd = new HDITEM();
            hd.mask = HDI_ORDER;
            for (int i = 0; i < this.ColumnCount; i++)
            {
                if (WinAPIDllImport.SendMessage(this.HeaderWnd, HDM_GETITEMA, column, ref hd) != IntPtr.Zero)
                    return hd.iOrder;
            }
            return 0;
        }
        private Rectangle HeaderEndRect()
        {
            RECT rect = new RECT();
            IntPtr headerWnd = this.HeaderWnd;
            WinAPIDllImport.SendMessage(headerWnd, HDM_GETITEMRECT, this.ColumnAtIndex(this.ColumnCount - 1), ref rect);
            int left = rect.Right;
            WinAPIDllImport.GetWindowRect(headerWnd, ref rect);
            WinAPIDllImport.OffsetRect(ref rect, -rect.Left, -rect.Top);
            rect.Left = left;
            return new Rectangle(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }
        private void WmNcPaint(ref Message m)
        {
            base.WndProc(ref m);
            if (base.BorderStyle == BorderStyle.None)
                return;
            IntPtr hDC = WinAPIDllImport.GetWindowDC(m.HWnd);
            if (hDC == IntPtr.Zero)
                throw new Win32Exception();
            try
            {
                Color backColor = this.BackColor;
                Color borderColor = this._borderColor;

                Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
                using (Graphics g = Graphics.FromHdc(hDC))
                {
                    using (Region region = new Region(bounds))
                    {
                        region.Exclude(this.AbsoluteClientRectangle);
                        using (Brush brush = new SolidBrush(backColor))
                        {
                            g.FillRegion(brush, region);
                        }
                    }
                    ControlPaint.DrawBorder(g, bounds, borderColor, ButtonBorderStyle.Solid);
                }
            }
            finally
            {
                WinAPIDllImport.ReleaseDC(m.HWnd, hDC);
            }
            m.Result = IntPtr.Zero;
        }
        /// <summary>
        /// 得到文本的对齐方式
        /// </summary>
        /// <param name="align"></param>
        /// <returns></returns>
        protected TextFormatFlags GetFormatFlags(HorizontalAlignment align)
        {
            TextFormatFlags flags = TextFormatFlags.EndEllipsis | TextFormatFlags.VerticalCenter;
            switch (align)
            {
                case HorizontalAlignment.Center:
                    flags |= TextFormatFlags.HorizontalCenter;
                    break;
                case HorizontalAlignment.Left:
                    flags |= TextFormatFlags.Left;
                    break;
                case HorizontalAlignment.Right:
                    flags |= TextFormatFlags.Right;
                    break;
            }
            return flags;
        }

        private void DrawImage(Graphics g, ListViewItem item, bool selected)
        {
            ImageList imageList = item.ImageList;
            Size imageSize = imageList.ImageSize;
            Rectangle imageRect = item.GetBounds(ItemBoundsPortion.Icon);

            if (imageRect.Width > imageSize.Width)
            {
                imageRect.X += (imageRect.Width - imageSize.Width) / 2;
                imageRect.Width = imageSize.Width;
            }
            if (imageRect.Height > imageSize.Height)
            {
                imageRect.Y += (imageRect.Height - imageSize.Height) / 2;
                imageRect.Height = imageSize.Height;
            }
            int imageIndex = item.ImageIndex != -1 ? item.ImageIndex : imageList.Images.IndexOfKey(item.ImageKey);
            if (imageIndex != -1)
            {
                if (selected)
                {
                    IntPtr hIcon = WinAPIDllImport.ImageList_GetIcon(imageList.Handle, imageIndex, (int)ImageListDrawFlags.ILD_SELECTED);
                    g.DrawIcon(Icon.FromHandle(hIcon), imageRect);
                    WinAPIDllImport.DestroyIcon(hIcon);
                }
                else
                {
                    Image image = imageList.Images[imageIndex];
                    g.DrawImage(image, imageRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel);
                }
            }
        }
        private void DrawBackground(Graphics g, int itemIndex, Rectangle rect, bool selected)
        {
            switch (base.View)
            {
                case View.SmallIcon:
                case View.List:
                    rect.Inflate(-1, 0);
                    break;
            }
            if (selected)
            {
                using (SolidBrush brush = new SolidBrush(this._itemHighLightBackgroundColor))
                {
                    g.FillRectangle(brush, rect);
                }
            }
            else
            {
                if (base.View == View.List)
                {
                    using (SolidBrush brush = new SolidBrush(this._itemBackgroundColor))
                    {
                        g.FillRectangle(brush, rect);
                    }
                }
            }
        }
        private void DrawText(Graphics g, ListViewItem item, Rectangle rect, bool selected)
        {
            StringFormat sf = StringFormat.GenericTypographic;
            switch (base.View)
            {
                case View.LargeIcon:
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Near;
                    sf.Trimming = StringTrimming.EllipsisCharacter;
                    sf.FormatFlags &= ~(StringFormatFlags.LineLimit);
                    if (selected)
                        sf.FormatFlags &= ~(StringFormatFlags.NoWrap);
                    break;
                case View.List:
                case View.SmallIcon:
                    rect.Inflate(-1, 0);
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Trimming = StringTrimming.EllipsisCharacter;
                    sf.FormatFlags &= ~(StringFormatFlags.LineLimit);
                    break;
                case View.Tile:
                    rect.Inflate(-2, 0);
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Trimming = StringTrimming.EllipsisCharacter;
                    sf.FormatFlags &= ~(StringFormatFlags.NoWrap);
                    break;
            }
            if (base.View != View.Tile || item.SubItems.Count == 1)
            {
                using (Brush brush = new SolidBrush(item.ForeColor))
                {
                    g.DrawString(item.Text, item.Font, brush, rect, sf);
                }
            }
            else
            {
                string subItemText = string.Empty;
                int height;
                bool bBreak = false;
                Rectangle subItemTextRect = rect;
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    if (!string.IsNullOrEmpty(subItem.Text))
                        subItemText = subItem.Text;
                    height = TextRenderer.MeasureText(g, subItem.Text, subItem.Font).Height;
                    subItemTextRect.Height = height;
                    if (subItemTextRect.Bottom > subItemTextRect.Bottom)
                    {
                        subItemTextRect.Height = subItemTextRect.Bottom - subItemTextRect.Y;
                        bBreak = true;
                    }
                    using (Brush brush = new SolidBrush(subItem.ForeColor))
                    {
                        g.DrawString(subItemText, subItem.Font, brush, subItemTextRect, sf);
                    }
                    subItemTextRect.Y += height;
                    if (bBreak)
                        break;
                }
            }
        }
    }
}
