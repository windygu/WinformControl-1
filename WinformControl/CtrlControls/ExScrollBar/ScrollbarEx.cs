using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace CtrlControls.ExScrollBar
{
    [Designer(typeof(ScrollbarExControlDesigner))]
    public partial class ScrollbarEx : UserControl
    {
        public new event EventHandler Scroll = null;
        public event EventHandler ValueChanged = null;

        public ScrollbarEx()
        {
            InitializeComponent();
            base.SetStyle(ControlStyles.ResizeRedraw, true);
            base.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            base.SetStyle(ControlStyles.DoubleBuffer, true);

            base.Width = this.UpArrowImage.Width;
            base.MinimumSize = new Size(this.UpArrowImage.Width, this.UpArrowImage.Height + this.DownArrowImage.Height + this.GetThumbHeight());
        }

        private void InitializeComponent()
        {
            base.SuspendLayout();
            base.Name = "CustomScrollbar";
            base.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomScrollbar_MouseDown);
            base.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomScrollbar_MouseMove);
            base.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CustomScrollbar_MouseUp);
            base.ResumeLayout(false);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            if (UpArrowImage != null)
            {
                e.Graphics.DrawImage(UpArrowImage, new Rectangle(new Point(0, 0), new Size(this.Width, UpArrowImage.Height)));
            }

            Brush oBrush = new SolidBrush(this._ChannelColor);
            Brush oWhiteBrush = new SolidBrush(Color.FromArgb(255, 255, 255));

            //draw channel left and right border colors
            e.Graphics.FillRectangle(oWhiteBrush, new Rectangle(0, UpArrowImage.Height, 1, (this.Height - DownArrowImage.Height)));
            e.Graphics.FillRectangle(oWhiteBrush, new Rectangle(this.Width - 1, UpArrowImage.Height, 1, (this.Height - DownArrowImage.Height)));

            //draw channel
            e.Graphics.FillRectangle(oBrush, new Rectangle(1, UpArrowImage.Height, this.Width - 2, (this.Height - DownArrowImage.Height)));

            //draw thumb
            int nTrackHeight = (this.Height - (UpArrowImage.Height + DownArrowImage.Height));
            float fThumbHeight = ((float)LargeChange / (float)Maximum) * nTrackHeight;
            int nThumbHeight = (int)fThumbHeight;

            if (nThumbHeight > nTrackHeight)
            {
                nThumbHeight = nTrackHeight;
                fThumbHeight = nTrackHeight;
            }
            if (nThumbHeight < 56)
            {
                nThumbHeight = 56;
                fThumbHeight = 56;
            }

            //Debug.WriteLine(nThumbHeight.ToString());

            float fSpanHeight = (fThumbHeight - (this.ThumbMiddleImage.Height + this.ThumbTopImage.Height + this.ThumbBottomImage.Height)) / 2.0f;
            int nSpanHeight = (int)fSpanHeight;

            int nTop = this._ThumbTop;
            nTop += this.UpArrowImage.Height;

            //draw top
            e.Graphics.DrawImage(this.ThumbTopImage, new Rectangle(1, nTop, this.Width - 2, ThumbTopImage.Height));

            nTop += this.ThumbTopImage.Height;
            //draw top span
            Rectangle rect = new Rectangle(1, nTop, this.Width - 2, nSpanHeight);


            e.Graphics.DrawImage(this.ThumbTopSpanImage, 1.0f, (float)nTop, (float)this.Width - 2.0f, (float)fSpanHeight * 2);

            nTop += nSpanHeight;
            //draw middle
            e.Graphics.DrawImage(this.ThumbMiddleImage, new Rectangle(1, nTop, this.Width - 2, ThumbMiddleImage.Height));


            nTop += this.ThumbMiddleImage.Height;
            //draw top span
            rect = new Rectangle(1, nTop, this.Width - 2, nSpanHeight * 2);
            e.Graphics.DrawImage(this.ThumbBottomSpanImage, rect);

            nTop += nSpanHeight;
            //draw bottom
            e.Graphics.DrawImage(this.ThumbBottomImage, new Rectangle(1, nTop, this.Width - 2, nSpanHeight));

            if (this.DownArrowImage != null)
            {
                e.Graphics.DrawImage(this.DownArrowImage, new Rectangle(new Point(0, (this.Height - this.DownArrowImage.Height)), new Size(this.Width, this.DownArrowImage.Height)));
            }

        }

    }
}
