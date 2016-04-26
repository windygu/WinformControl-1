using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CtrlControls.ExPopup
{
    public struct GripBounds
    {
        private const int GRIPSIZE = 6;
        private const int CORNERGRIPSIZE = GRIPSIZE << 1;

        public GripBounds(Rectangle clientRectangle)
        {
            this.clientRectangle = clientRectangle;
        }

        private Rectangle clientRectangle;
        public Rectangle ClientRectangle
        {
            get { return clientRectangle; }
            //set { clientRectangle = value; }
        }

        public Rectangle Bottom
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Y = rect.Bottom - GRIPSIZE + 1;
                rect.Height = GRIPSIZE;
                return rect;
            }
        }

        public Rectangle BottomRight
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Y = rect.Bottom - CORNERGRIPSIZE + 1;
                rect.Height = CORNERGRIPSIZE;
                rect.X = rect.Width - CORNERGRIPSIZE + 1;
                rect.Width = CORNERGRIPSIZE;
                return rect;
            }
        }

        public Rectangle Top
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Height = GRIPSIZE;
                return rect;
            }
        }

        public Rectangle TopRight
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Height = CORNERGRIPSIZE;
                rect.X = rect.Width - CORNERGRIPSIZE + 1;
                rect.Width = CORNERGRIPSIZE;
                return rect;
            }
        }

        public Rectangle Left
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Width = GRIPSIZE;
                return rect;
            }
        }

        public Rectangle BottomLeft
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Width = CORNERGRIPSIZE;
                rect.Y = rect.Height - CORNERGRIPSIZE + 1;
                rect.Height = CORNERGRIPSIZE;
                return rect;
            }
        }

        public Rectangle Right
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.X = rect.Right - GRIPSIZE + 1;
                rect.Width = GRIPSIZE;
                return rect;
            }
        }

        public Rectangle TopLeft
        {
            get
            {
                Rectangle rect = ClientRectangle;
                rect.Width = CORNERGRIPSIZE;
                rect.Height = CORNERGRIPSIZE;
                return rect;
            }
        }
    }
}
