using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using CtrlResource;

namespace CtrlControls.ExListBox
{
    [ToolboxBitmap(typeof(ListBox))]
    public class ListBoxEx : ListBox
    {
        private ListBoxExCollection _items = null;
        private Image _selectImage = AssemblyHelper.GetImage("ListBox.listitem_check.png");
        //MouseEventArgs _mouseEvent = null;

        public ListBoxEx()
        {
            this._items = new ListBoxExCollection(this);
            base.Font = new Font("宋体", 11.0f);
            base.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            base.ItemHeight = 35;
            this.SetStyle(
                        ControlStyles.DoubleBuffer |
                        ControlStyles.ResizeRedraw |
                        ControlStyles.AllPaintingInWmPaint |
                        ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }

        internal ListBox.ObjectCollection OldItems
        {
            get { return base.Items; }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]//这两个特性没有的话运行的时候就会删除Items的内容
        [EditorBrowsable(EditorBrowsableState.Always)]
        new public ListBoxExCollection Items
        {
            get
            {
                if (this._items == null)
                    this._items = new ListBoxExCollection(this);
                return this._items;
            }
        }


        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (this.Items.Count > 0)
            {
                Rectangle bounds = e.Bounds;
                Graphics g = e.Graphics;
                ListBoxExItem item = this.Items[e.Index] as ListBoxExItem;
                Color selectColor = item.ForeColor;
                Rectangle textRect = Rectangle.Empty;
                if (e.State == (DrawItemState.Selected | DrawItemState.Focus))
                {
                    g.DrawImage(this._selectImage, bounds);
                    selectColor = Color.White;
                }
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                if (item.Icon != null)
                {
                    Rectangle rec = new Rectangle(bounds.X + 2, bounds.Y + 2, 22, 22);
                    g.DrawImage(item.Icon, rec, new Rectangle(0, 0, item.Icon.Width, item.Icon.Height), GraphicsUnit.Pixel);
                    textRect = new Rectangle(40, bounds.Y, bounds.Width - 40, bounds.Height);
                }
                else
                {
                    textRect = new Rectangle(4, bounds.Y, bounds.Width - 4, bounds.Height);
                }
                if (item.Image != null)
                {
                    g.DrawImage(item.Image, new Rectangle(bounds.X + 22, bounds.Y + 1, bounds.Width - 24, bounds.Height - 2), new Rectangle(0, 0, item.Image.Width, item.Image.Height), GraphicsUnit.Pixel);
                }
                if (!string.IsNullOrEmpty(item.Text))
                {
                    g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                    TextFormatFlags fs = TextFormatFlags.Left | TextFormatFlags.VerticalCenter;
                    TextRenderer.DrawText(g, item.Text, this.Font, textRect, selectColor, fs);
                }
            }
            base.OnDrawItem(e);
        }
        //protected override void OnMouseMove(MouseEventArgs e)
        //{
        //    base.OnMouseMove(e);
        //    this._mouseEvent = e;
        //}
    }
}
