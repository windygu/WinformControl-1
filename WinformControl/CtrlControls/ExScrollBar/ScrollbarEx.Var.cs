using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CtrlControls.ExScrollBar
{
    partial class ScrollbarEx
    {
        protected Color _ChannelColor = Color.DodgerBlue;
        protected Image _UpArrowImage = null;
        //protected Image moUpArrowImage_Over = null;
        //protected Image moUpArrowImage_Down = null;
        protected Image _DownArrowImage = null;
        //protected Image moDownArrowImage_Over = null;
        //protected Image moDownArrowImage_Down = null;
        protected Image _ThumbArrowImage = null;

        protected Image _ThumbTopImage = null;
        protected Image _ThumbTopSpanImage = null;
        protected Image _ThumbBottomImage = null;
        protected Image _ThumbBottomSpanImage = null;
        protected Image _ThumbMiddleImage = null;

        protected int _LargeChange = 10;
        protected int _SmallChange = 1;
        protected int _Minimum = 0;
        protected int _Maximum = 100;
        protected int _Value = 0;
        private int _ClickPoint;

        protected int _ThumbTop = 0;

        protected bool _AutoSize = false;

        private bool _ThumbDown = false;
        private bool _ThumbDragging = false;
    }
}
