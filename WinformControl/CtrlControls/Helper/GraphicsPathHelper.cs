using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;
using CtrlControls.Enum;

namespace CtrlControls.Helper
{
    public static class GraphicsPathHelper
    {
        public static GraphicsPath CreatePath(Rectangle rect, int radius, ERoundStyle style, bool correction)
        {
            GraphicsPath path = new GraphicsPath();
            int num = correction ? 1 : 0;
            switch (style)
            {
                case ERoundStyle.None:
                    path.AddRectangle(rect);
                    break;
                case ERoundStyle.TopLeft:
                    path.AddArc(rect.X, rect.Y, radius, radius, 180f, 90f);
                    path.AddLine(rect.Right - num, rect.Y, rect.Right - num, rect.Bottom - num);
                    path.AddLine(rect.Right - num, rect.Bottom - num, rect.X, rect.Bottom - num);
                    break;
                case ERoundStyle.TopRight:
                    path.AddArc((rect.Right - radius) - num, rect.Y, radius, radius, 270f, 90f);
                    path.AddLine(rect.Right - num, rect.Bottom - num, rect.X, rect.Bottom - num);
                    path.AddLine(rect.X, rect.Bottom - num, rect.X, rect.Y);
                    break;
                case ERoundStyle.Top:
                    path.AddArc(rect.X, rect.Y, radius, radius, 180f, 90f);
                    path.AddArc((rect.Right - radius) - num, rect.Y, radius, radius, 270f, 90f);
                    path.AddLine(rect.Right - num, rect.Bottom - num, rect.X, rect.Bottom - num);
                    break;
                case ERoundStyle.BottomLeft:
                    path.AddArc(rect.X, (rect.Bottom - radius) - num, radius, radius, 90f, 90f);
                    path.AddLine(rect.X, rect.Y, rect.Right - num, rect.Y);
                    path.AddLine(rect.Right - num, rect.Y, rect.Right - num, rect.Bottom - num);
                    break;
                case ERoundStyle.Left:
                    path.AddArc(rect.X, rect.Y, radius, radius, 180f, 90f);
                    path.AddLine(rect.Right - num, rect.Y, rect.Right - num, rect.Bottom - num);
                    path.AddArc(rect.X, (rect.Bottom - radius) - num, radius, radius, 90f, 90f);
                    break;
                case ERoundStyle.BottomRight:
                    path.AddArc((rect.Right - radius) - num, (rect.Bottom - radius) - num, radius, radius, 0f, 90f);
                    path.AddLine(rect.X, rect.Bottom - num, rect.X, rect.Y);
                    path.AddLine(rect.X, rect.Y, rect.Right - num, rect.Y);
                    break;
                case ERoundStyle.Right:
                    path.AddArc((rect.Right - radius) - num, rect.Y, radius, radius, 270f, 90f);
                    path.AddArc((rect.Right - radius) - num, (rect.Bottom - radius) - num, radius, radius, 0f, 90f);
                    path.AddLine(rect.X, rect.Bottom - num, rect.X, rect.Y);
                    break;
                case ERoundStyle.Bottom:
                    path.AddArc((rect.Right - radius) - num, (rect.Bottom - radius) - num, radius, radius, 0f, 90f);
                    path.AddArc(rect.X, (rect.Bottom - radius) - num, radius, radius, 90f, 90f);
                    path.AddLine(rect.X, rect.Y, rect.Right - num, rect.Y);
                    break;
                case ERoundStyle.All:
                    path.AddArc(rect.X, rect.Y, radius, radius, 180f, 90f);
                    path.AddArc((rect.Right - radius) - num, rect.Y, radius, radius, 270f, 90f);
                    path.AddArc((rect.Right - radius) - num, (rect.Bottom - radius) - num, radius, radius, 0f, 90f);
                    path.AddArc(rect.X, (rect.Bottom - radius) - num, radius, radius, 90f, 90f);
                    break;
            }
            path.CloseFigure();
            return path;
        }


        /// <summary>
        /// 构建圆角矩型路径
        /// </summary>
        public static GraphicsPath CreateRoundRect(RectangleF r, float r1, float r2, float r3, float r4)
        {
            float x = r.X;
            float y = r.Y;
            float width = r.Width - 1;
            float height = r.Height - 1;
            GraphicsPath path = new GraphicsPath();
            path.AddBezier(x, y + r1, x, y, x + r1, y, x + r1, y);
            path.AddLine(x + r1, y, (x + width) - r2, y);
            path.AddBezier((x + width) - r2, y, x + width, y, x + width, y + r2, x + width, y + r2);
            path.AddLine((float)(x + width), (float)(y + r2), (float)(x + width), (float)((y + height) - r3));
            path.AddBezier((float)(x + width), (float)((y + height) - r3), (float)(x + width), (float)(y + height), (float)((x + width) - r3), (float)(y + height), (float)((x + width) - r3), (float)(y + height));
            path.AddLine((float)((x + width) - r3), (float)(y + height), (float)(x + r4), (float)(y + height));
            path.AddBezier(x + r4, y + height, x, y + height, x, (y + height) - r4, x, (y + height) - r4);
            path.AddLine(x, (y + height) - r4, x, y + r1);
            return path;
        }

        public static bool ConvertToPixels(Graphics graphics, float srcWidth, float srcHeight, ref float destWidth, ref float destHeight)
        {
            GraphicsUnit pageUnit = graphics.PageUnit;
            float dpiX = graphics.DpiX;
            float dpiY = graphics.DpiY;
            switch (pageUnit)
            {
                case GraphicsUnit.World:
                    return false;

                case GraphicsUnit.Display:
                case GraphicsUnit.Pixel:
                    destWidth = srcWidth;
                    destHeight = srcHeight;
                    return true;

                case GraphicsUnit.Point:
                    destWidth = (0.01388889f * dpiX) * srcWidth;
                    destHeight = (0.01388889f * dpiY) * srcHeight;
                    return true;

                case GraphicsUnit.Inch:
                    destWidth = dpiX * srcWidth;
                    destHeight = dpiY * srcHeight;
                    return true;

                case GraphicsUnit.Document:
                    destWidth = (0.003333333f * dpiX) * srcWidth;
                    destHeight = (0.003333333f * dpiY) * srcHeight;
                    return true;

                case GraphicsUnit.Millimeter:
                    destWidth = (0.03937008f * dpiX) * srcWidth;
                    destHeight = (0.03937008f * dpiY) * srcHeight;
                    return true;
            }
            return false;
        }

        public static bool MeasureGraphicsPath(Graphics graphics, GraphicsPath path, ref float pixelsWidth, ref float pixelsHeight)
        {
            if (path.PathData.Points.Length <= 0)
            {
                return false;
            }
            float x = path.PathData.Points[0].X;
            float y = path.PathData.Points[0].Y;
            float num3 = path.PathData.Points[0].X;
            float num4 = path.PathData.Points[0].Y;
            int length = path.PathData.Points.Length;
            PointF[] points = path.PathData.Points;
            for (int i = 1; i < length; i++)
            {
                if (points[i].X < num3)
                {
                    num3 = points[i].X;
                }
                if (points[i].Y < num4)
                {
                    num4 = points[i].Y;
                }
                if (points[i].X > x)
                {
                    x = points[i].X;
                }
                if (points[i].Y > y)
                {
                    y = points[i].Y;
                }
            }
            if (num3 < 0f)
            {
                num3 = -num3;
            }
            else
            {
                num3 = 0f;
            }
            if (num4 < 0f)
            {
                num4 = -num4;
            }
            else
            {
                num4 = 0f;
            }
            return ConvertToPixels(graphics, (num3 + x) - pixelsWidth, (num4 + y) - pixelsHeight, ref pixelsWidth, ref pixelsHeight);
        }

        public static bool MeasureGraphicsPathRealHeight(Graphics graphics, GraphicsPath path, ref float pixelsWidth, ref float pixelsHeight)
        {
            if (path.PathData.Points.Length <= 0)
            {
                return false;
            }
            float x = path.PathData.Points[0].X;
            float y = path.PathData.Points[0].Y;
            float num3 = path.PathData.Points[0].X;
            float num4 = path.PathData.Points[0].Y;
            int length = path.PathData.Points.Length;
            PointF[] points = path.PathData.Points;
            for (int i = 1; i < length; i++)
            {
                if (points[i].X < num3)
                {
                    num3 = points[i].X;
                }
                if (points[i].Y < num4)
                {
                    num4 = points[i].Y;
                }
                if (points[i].X > x)
                {
                    x = points[i].X;
                }
                if (points[i].Y > y)
                {
                    y = points[i].Y;
                }
            }
            return ConvertToPixels(graphics, (num3 + x) - pixelsWidth, (num4 + y) - pixelsHeight, ref pixelsWidth, ref pixelsHeight);
        }
    }
}
