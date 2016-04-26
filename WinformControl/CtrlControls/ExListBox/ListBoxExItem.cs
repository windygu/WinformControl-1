using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CtrlControls.ExListBox
{
    /// <summary>
    /// 每一项的属性
    /// </summary>
    public class ListBoxExItem : IDisposable
    {
        private string _id;
        private Image _icon;
        private Image _image;
        private string _text;
        private Color _foreColor = Color.Black;

        public ListBoxExItem()
        { }
        public ListBoxExItem(string id)
            : this()
        {
            this._id = this._text = id;
        }
        public ListBoxExItem(string id, Image icon)
            : this(id)
        {
            this._icon = icon;
        }
        public ListBoxExItem(string id, Image icon, Image image)
            : this(id, icon)
        {
            this._image = image;
        }
        public ListBoxExItem(string id, Image icon, Image image, string text)
            : this(id, icon, image)
        {
            this._text = text;
        }
        public ListBoxExItem(string id, Image icon, Image image, string text, Color forecolor)
            : this(id, icon, image, text)
        {
            this._foreColor = forecolor;
        }

        /// <summary>
        /// Item的唯一编号
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        /// <summary>
        /// 图标
        /// </summary>
        public Image Icon
        {
            get { return this._icon; }
            set { this._icon = value; }
        }
        /// <summary>
        /// 对应的图片
        /// </summary>
        public Image Image
        {
            get { return this._image; }
            set { this._image = value; }
        }
        /// <summary>
        /// 文本
        /// </summary>
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }
        /// <summary>
        /// 字体颜色
        /// </summary>
        public Color ForeColor
        {
            get { return this._foreColor; }
            set { this._foreColor = value; }
        }

        public object Tag
        {
            get;
            set;
        }

        public void Dispose()
        {
            if (this._image != null)
            {
                this._image.Dispose();
                this._image = null;
            }
            if (this._icon != null)
            {
                this._icon.Dispose();
                this._icon = null;
            }
        }
    }
}
