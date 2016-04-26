using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace CtrlControls.ExScrollBar
{
    partial class ScrollbarEx
    {
        private int GetThumbHeight()
        {
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

            return thumbHeight;
        }

        private void CustomScrollbar_MouseDown(object sender, MouseEventArgs e)
        {
            Point ptPoint = this.PointToClient(Cursor.Position);
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

            int nTop = _ThumbTop;
            nTop += UpArrowImage.Height;


            Rectangle thumbrect = new Rectangle(new Point(1, nTop), new Size(ThumbMiddleImage.Width, nThumbHeight));
            if (thumbrect.Contains(ptPoint))
            {

                //hit the thumb
                _ClickPoint = (ptPoint.Y - nTop);
                //MessageBox.Show(Convert.ToString((ptPoint.Y - nTop)));
                this._ThumbDown = true;
            }

            Rectangle uparrowrect = new Rectangle(new Point(1, 0), new Size(UpArrowImage.Width, UpArrowImage.Height));
            if (uparrowrect.Contains(ptPoint))
            {

                int nRealRange = (Maximum - Minimum) - LargeChange;
                int nPixelRange = (nTrackHeight - nThumbHeight);
                if (nRealRange > 0)
                {
                    if (nPixelRange > 0)
                    {
                        if ((_ThumbTop - SmallChange) < 0)
                            _ThumbTop = 0;
                        else
                            _ThumbTop -= SmallChange;

                        //figure out value
                        float fPerc = (float)_ThumbTop / (float)nPixelRange;
                        float fValue = fPerc * (Maximum - LargeChange);

                        _Value = (int)fValue;
                        Debug.WriteLine(_Value.ToString());

                        if (ValueChanged != null)
                            ValueChanged(this, new EventArgs());

                        if (Scroll != null)
                            Scroll(this, new EventArgs());

                        Invalidate();
                    }
                }
            }

            Rectangle downarrowrect = new Rectangle(new Point(1, UpArrowImage.Height + nTrackHeight), new Size(UpArrowImage.Width, UpArrowImage.Height));
            if (downarrowrect.Contains(ptPoint))
            {
                int nRealRange = (Maximum - Minimum) - LargeChange;
                int nPixelRange = (nTrackHeight - nThumbHeight);
                if (nRealRange > 0)
                {
                    if (nPixelRange > 0)
                    {
                        if ((_ThumbTop + SmallChange) > nPixelRange)
                            _ThumbTop = nPixelRange;
                        else
                            _ThumbTop += SmallChange;

                        //figure out value
                        float fPerc = (float)_ThumbTop / (float)nPixelRange;
                        float fValue = fPerc * (Maximum - LargeChange);

                        _Value = (int)fValue;
                        Debug.WriteLine(_Value.ToString());

                        if (ValueChanged != null)
                            ValueChanged(this, new EventArgs());

                        if (Scroll != null)
                            Scroll(this, new EventArgs());

                        Invalidate();
                    }
                }
            }
        }

        private void CustomScrollbar_MouseUp(object sender, MouseEventArgs e)
        {
            this._ThumbDown = false;
            this._ThumbDragging = false;
        }

        private void MoveThumb(int y)
        {
            int nRealRange = Maximum - Minimum;
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

            int nSpot = _ClickPoint;

            int nPixelRange = (nTrackHeight - nThumbHeight);
            if (_ThumbDown && nRealRange > 0)
            {
                if (nPixelRange > 0)
                {
                    int nNewThumbTop = y - (UpArrowImage.Height + nSpot);

                    if (nNewThumbTop < 0)
                    {
                        _ThumbTop = nNewThumbTop = 0;
                    }
                    else if (nNewThumbTop > nPixelRange)
                    {
                        _ThumbTop = nNewThumbTop = nPixelRange;
                    }
                    else
                    {
                        _ThumbTop = y - (UpArrowImage.Height + nSpot);
                    }

                    //figure out value
                    float fPerc = (float)_ThumbTop / (float)nPixelRange;
                    float fValue = fPerc * (Maximum - LargeChange);
                    _Value = (int)fValue;
                    Debug.WriteLine(_Value.ToString());

                    Application.DoEvents();

                    Invalidate();
                }
            }
        }

        private void CustomScrollbar_MouseMove(object sender, MouseEventArgs e)
        {
            if (this._ThumbDown == true)
            {
                this._ThumbDragging = true;
            }

            if (this._ThumbDragging)
            {

                this.MoveThumb(e.Y);
            }

            if (this.ValueChanged != null)
                this.ValueChanged(this, new EventArgs());

            if (this.Scroll != null)
                this.Scroll(this, new EventArgs());
        }

    }
}
