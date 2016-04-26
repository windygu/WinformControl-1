using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CtrlControls.ExDataGridView
{
    public class DataGridViewExLinkEx
    {
        public DataGridViewExLinkEx(Image image)
        {
            this.Image = image;
        }

        public Color Color { get; set; }
        public bool MouseMove { get; set; }
        public Rectangle Bounds { get; set; }
        public Size Size { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        private Image _Image;
        public Image Image
        {
            get { return this._Image; }
            set
            {
                if (this._Image == value)
                    return;
                this._Image = value;
                if (this._Image != null)
                {
                    this.Size = new Size(this._Image.Width, this._Image.Height);
                    this.Width = this._Image.Width;
                    this.Height = this._Image.Height;
                }
            }
        }
    }
}
