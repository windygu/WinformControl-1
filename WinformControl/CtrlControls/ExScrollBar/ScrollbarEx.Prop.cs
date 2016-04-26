using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using CtrlResource;

namespace CtrlControls.ExScrollBar
{
    partial class ScrollbarEx
    {

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("自定义属性"), Description("LargeChange")]
        public int LargeChange
        {
            get { return this._LargeChange; }
            set
            {
                this._LargeChange = value;
                base.Invalidate();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("自定义属性"), Description("SmallChange")]
        public int SmallChange
        {
            get { return this._SmallChange; }
            set
            {
                this._SmallChange = value;
                base.Invalidate();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("自定义属性"), Description("Minimum")]
        public int Minimum
        {
            get { return this._Minimum; }
            set
            {
                this._Minimum = value;
                base.Invalidate();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("自定义属性"), Description("Maximum")]
        public int Maximum
        {
            get { return this._Maximum; }
            set
            {
                this._Maximum = value;
                base.Invalidate();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("自定义属性"), Description("Value")]
        public int Value
        {
            get { return this._Value; }
            set
            {
                this._Value = value;

                int trackHeight = (base.Height - (this.UpArrowImage.Height + this.DownArrowImage.Height));
                float fThumbHeight = ((float)this.LargeChange / (float)this.Maximum) * trackHeight;
                int thumbHeight = (int)fThumbHeight;

                if (thumbHeight > trackHeight)
                {
                    thumbHeight = trackHeight;
                    fThumbHeight = trackHeight;
                }
                if (thumbHeight < 56)
                {
                    thumbHeight = 56;
                    fThumbHeight = 56;
                }

                //figure out value
                int pixelRange = trackHeight - thumbHeight;
                int realRange = (this.Maximum - this.Minimum) - this.LargeChange;
                float perc = 0.0f;
                if (realRange != 0)
                {
                    perc = (float)_Value / (float)realRange;

                }

                float top = perc * pixelRange;
                this._ThumbTop = (int)top;


                base.Invalidate();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("自定义属性"), Description("Channel Color")]
        public Color ChannelColor
        {
            get { return this._ChannelColor; }
            set { this._ChannelColor = value; }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("自定义属性"), Description("Up Arrow Graphic")]
        public Image UpArrowImage
        {
            get
            {
                if (this._UpArrowImage == null)
                {
                    this._UpArrowImage = AssemblyHelper.GetImage("ScrollBar.uparrow.png", this.DesignMode);
                }
                return this._UpArrowImage;
            }
            set
            {
                if (this._UpArrowImage == value)
                    return;
                this._UpArrowImage = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("自定义属性"), Description("Up Arrow Graphic")]
        public Image DownArrowImage
        {
            get
            {
                if (this._DownArrowImage == null)
                {
                    this._DownArrowImage = AssemblyHelper.GetImage("ScrollBar.downarrow.png", this.DesignMode);
                }
                return this._DownArrowImage;
            }
            set
            {
                if (this._DownArrowImage == value)
                    return;
                this._DownArrowImage = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("自定义属性"), Description("Up Arrow Graphic")]
        public Image ThumbTopImage
        {
            get
            {
                if (this._ThumbTopImage == null)
                {
                    this._ThumbTopImage = AssemblyHelper.GetImage("ScrollBar.ThumbTop.png", this.DesignMode);
                }
                return this._ThumbTopImage;
            }
            set
            {
                if (this._ThumbTopImage == value)
                    return;
                this._ThumbTopImage = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("自定义属性"), Description("Up Arrow Graphic")]
        public Image ThumbTopSpanImage
        {
            get
            {
                if (this._ThumbTopSpanImage == null)
                {
                    this._ThumbTopSpanImage = AssemblyHelper.GetImage("ScrollBar.ThumbSpanTop.png", this.DesignMode);
                }
                return this._ThumbTopSpanImage;
            }
            set
            {
                if (this._ThumbTopSpanImage == value)
                    return;
                this._ThumbTopSpanImage = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("自定义属性"), Description("Up Arrow Graphic")]
        public Image ThumbBottomImage
        {
            get
            {
                if (this._ThumbBottomImage == null)
                {
                    this._ThumbBottomImage = AssemblyHelper.GetImage("ScrollBar.ThumbBottom.png", this.DesignMode);
                }
                return this._ThumbBottomImage;
            }
            set
            {
                if (this._ThumbBottomImage == value)
                    return;
                this._ThumbBottomImage = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("自定义属性"), Description("Up Arrow Graphic")]
        public Image ThumbBottomSpanImage
        {
            get
            {
                if (this._ThumbBottomSpanImage == null)
                {
                    this._ThumbBottomSpanImage = AssemblyHelper.GetImage("ScrollBar.ThumbSpanBottom.png", this.DesignMode);
                }
                return this._ThumbBottomSpanImage;
            }
            set
            {
                if (this._ThumbBottomSpanImage == value)
                    return;
                this._ThumbBottomSpanImage = value;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), DefaultValue(false), Category("自定义属性"), Description("Up Arrow Graphic")]
        public Image ThumbMiddleImage
        {
            get
            {
                if (this._ThumbMiddleImage == null)
                {
                    this._ThumbMiddleImage = AssemblyHelper.GetImage("ScrollBar.ThumbMiddle.png", this.DesignMode);
                }
                return this._ThumbMiddleImage;
            }
            set
            {
                if (this._ThumbMiddleImage == value)
                    return;
                this._ThumbMiddleImage = value;
            }
        }
        public override bool AutoSize
        {
            get
            {
                return base.AutoSize;
            }
            set
            {
                base.AutoSize = value;
                if (base.AutoSize)
                {
                    base.Width = this._UpArrowImage.Width;
                }
            }
        }
    }
}
