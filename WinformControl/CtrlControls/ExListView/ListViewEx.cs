using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using CtrlControls.Enum;
using CtrlControls.Helper;

namespace CtrlControls.ExListView
{
    [ToolboxBitmap(typeof(ListView))]
    public partial class ListViewEx : ListView
    {
        public ListViewEx()
            : base()
        {
            base.GridLines = base.FullRowSelect = base.OwnerDraw = true;
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (this._headerNativeWindow == null)
            {
                if (this.HeaderWnd != IntPtr.Zero)
                {
                    this._headerNativeWindow = new HeaderNativeWindow(this);
                }
            }
        }
        protected override void OnHandleDestroyed(EventArgs e)
        {
            base.OnHandleDestroyed(e);
            if (this._headerNativeWindow != null)
            {
                this._headerNativeWindow.Dispose();
                this._headerNativeWindow = null;
            }
        }
        protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
        {
            //base.OnDrawSubItem(e);
            if (e.ItemIndex == -1)
                return;
            if (base.View == View.Details)
            {
                Rectangle bounds = e.Bounds;
                ListViewItemStates itemState = e.ItemState;
                Graphics g = e.Graphics;
                ListViewItem item = e.Item;
                bool selected = (itemState & ListViewItemStates.Selected) != 0;
                bool drawImage = false;
                bool fistItem = false;
                int imageIndex = -1;

                if (e.ColumnIndex == 0)
                {
                    fistItem = true;
                    if (item.ImageList != null)
                    {
                        if (item.ImageIndex != -1)
                            imageIndex = item.ImageIndex;
                        else if (!string.IsNullOrEmpty(item.ImageKey))
                            imageIndex = item.ImageList.Images.IndexOfKey(item.ImageKey);

                        if (imageIndex != -1)
                            drawImage = true;
                    }
                }

                Rectangle backRect = bounds;
                Rectangle imageRect = Rectangle.Empty;
                if (drawImage)
                {
                    imageRect = item.GetBounds(ItemBoundsPortion.Icon);
                    backRect = item.GetBounds(ItemBoundsPortion.Label);
                    backRect.X += 2;
                    backRect.Width -= 2;
                }
                Color textColor = Color.Black;
                if (selected && (base.FullRowSelect || (!base.FullRowSelect && fistItem)))
                {
                    backRect.Height--;
                    Color innerBorderColor = Color.FromArgb(150, 255, 255, 255);
                    //绘制选中区域
                    Image image = this.ItemBackgroundImage;
                    g.DrawImage(image, backRect, 0, 0, 5, image.Height, GraphicsUnit.Pixel);
                    g.DrawImage(image, backRect, 5, 0, image.Width - 10, image.Height, GraphicsUnit.Pixel);
                    g.DrawImage(image, backRect, image.Width - 5, 0, 5, image.Height, GraphicsUnit.Pixel);
                    textColor = Color.White;
                }
                else
                {
                    using (SolidBrush brush = new SolidBrush(this._itemBackgroundColor))
                    {
                        g.FillRectangle(brush, backRect);
                    }
                }
                TextFormatFlags flags = this.GetFormatFlags(e.Header.TextAlign);
                if (drawImage)//如果绘制图像
                {
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;

                    if (selected)
                    {
                        IntPtr hIcon = WinAPIDllImport.ImageList_GetIcon(item.ImageList.Handle, imageIndex, (int)ImageListDrawFlags.ILD_SELECTED);
                        g.DrawIcon(Icon.FromHandle(hIcon), imageRect.X, imageRect.Y + 2);
                        WinAPIDllImport.DestroyIcon(hIcon);
                    }
                    else
                    {
                        Image image = item.ImageList.Images[imageIndex];
                        g.DrawImage(image, imageRect.X, imageRect.Y + 2);
                    }
                    Rectangle textRect = new Rectangle(imageRect.Right + 3, bounds.Y, bounds.Width - imageRect.Right - 3, bounds.Height);
                    TextRenderer.DrawText(g, item.Text, item.Font, textRect, textColor, flags);
                }
                else
                {
                    bounds.X += 3;
                    TextRenderer.DrawText(g, e.SubItem.Text, e.SubItem.Font, bounds, textColor, flags);
                }
                if (base.CheckBoxes)
                {
                    if (e.Item.SubItems[0] == e.SubItem)
                    {
                        Size sizeCheckBox = CheckBoxRenderer.GetGlyphSize(e.Graphics, e.Item.Checked ? System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal : System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
                        Point checkBoxPoint = new Point(e.Bounds.X, e.Bounds.Top + 10);
                        CheckBoxRenderer.DrawCheckBox(e.Graphics, checkBoxPoint, e.Item.Checked ? System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal : System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal);
                    }
                }
            }
        }
        protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
        {
            //base.OnDrawColumnHeader(e);
            Graphics g = e.Graphics;
            Rectangle bounds = e.Bounds;

            Color innerBorderColor = Color.FromArgb(150, 255, 255, 255);
            if (e.ColumnIndex != 0)
            {
                bounds.X--;
                bounds.Width++;
            }
            DrawHelper.RenderListViewBackground(g, bounds, this._headBackgroundColor, this._headBackgroundColor, innerBorderColor, false, System.Drawing.Drawing2D.LinearGradientMode.Vertical);

            if (e.ColumnIndex != 0)
            {
                bounds.X++;
                bounds.Width--;
            }
            TextFormatFlags flags = this.GetFormatFlags(e.Header.TextAlign);
            Rectangle textRect = new Rectangle(bounds.X + 3, bounds.Y, bounds.Width - 6, bounds.Height);

            if (e.Header.ImageList != null)
            {
                Image image = e.Header.ImageIndex == -1 ? null : e.Header.ImageList.Images[e.Header.ImageIndex];
                if (image != null)
                {
                    Rectangle imageRect = new Rectangle(bounds.X + 3, bounds.Y + 2, bounds.Height - 4, bounds.Height - 4);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
                    g.DrawImage(image, imageRect);

                    textRect.X = imageRect.Right + 3;
                    textRect.Width -= imageRect.Width;
                }
            }
            TextRenderer.DrawText(g, e.Header.Text, e.Font, textRect, e.ForeColor, flags);
        }
        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            //base.OnDrawItem(e);
            if (base.View == View.Details)
                return;
            Graphics g = e.Graphics;
            ListViewItem item = e.Item;
            ListViewItemStates itemState = e.State;
            ImageList imageList = item.ImageList;
            e.DrawBackground();

            bool drawImage = (imageList != null) && (item.ImageIndex != -1 || string.IsNullOrEmpty(item.ImageKey));
            bool selected = (itemState & ListViewItemStates.Selected) != 0;
            if (drawImage)
                this.DrawImage(g, item, selected);
            if (!string.IsNullOrEmpty(item.Text))
            {
                Rectangle textRect = item.GetBounds(ItemBoundsPortion.Label);
                this.DrawBackground(g, item.Index, textRect, selected);
                this.DrawText(g, item, textRect, selected);

            }
        }
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case (int)WindowsMessage.WM_NCPAINT:
                    this.WmNcPaint(ref m);
                    break;
                case (int)WindowsMessage.WM_WINDOWPOSCHANGED:
                    base.WndProc(ref m);
                    IntPtr result = m.Result;
                    this.WmNcPaint(ref m);
                    m.Result = result;
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
    }
}
