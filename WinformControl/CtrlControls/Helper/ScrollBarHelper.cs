#region << 版 本 注 释 >>
/*
     * ========================================================================
     * Copyright Notice  2010-2020 TideBuy.com All rights reserved .
     * ========================================================================
     * 机器名称：USER-JLFFS1KMVG 
     * 文件名：  ControlHelper 
     * 版本号：  V1.0.0.0 
     * 创建人：  wangyunpeng
     * 创建时间： 2020/10/9 11:35:21 
     * 描述    :
     * =====================================================================
     * 修改时间：2020/10/9 11:35:21 
     * 修改人  ： wangyunpeng
     * 版本号  ： V1.0.0.0 
     * 描述    ：
*/
#endregion

using CtrlControls.Enum;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace CtrlControls.Helper
{
    public static class ScrollBarHelper
    {

        #region 滚动条    English:scroll bar
        static uint SB_HORZ = 0x0;
        static uint SB_VERT = 0x1;
        static uint SB_CTL = 0x2;
        static uint SB_BOTH = 0x3;
        [DllImport("user32.dll", SetLastError = true, EntryPoint = "GetScrollInfo")]
        private static extern int GetScrollInfo(IntPtr hWnd, uint fnBar, ref SCROLLINFO psbi);
        [DllImport("user32.dll")]//[return: MarshalAs(UnmanagedType.Bool)]
        private static extern int SetScrollInfo(IntPtr handle, uint fnBar, ref SCROLLINFO si, bool fRedraw);

        [DllImport("user32.dll", EntryPoint = "PostMessage")]
        private static extern bool PostMessage(IntPtr handle, int msg, uint wParam, uint lParam);
        [DllImport("User32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        /// <summary>
        /// ShowScrollBar
        /// </summary>
        /// <param name="hWnd">hWnd</param>
        /// <param name="wBar">0:horizontal,1:vertical,3:both</param>
        /// <param name="bShow">bShow</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ShowScrollBar(IntPtr hWnd, int wBar, bool bShow);
        /// <summary>
        ///获取水平滚动条信息
        /// </summary>
        /// <param name="hWnd">The h WND.</param>
        /// <returns>Scrollbarinfo.</returns>
        public static SCROLLINFO GetHScrollBarInfo(IntPtr hWnd)
        {
            SCROLLINFO info = new SCROLLINFO();
            info.cbSize = (int)Marshal.SizeOf(info);
            info.fMask = (int)ScrollInfoMask.SIF_DISABLENOSCROLL | (int)ScrollInfoMask.SIF_ALL;
            int intRef = GetScrollInfo(hWnd, SB_HORZ, ref info);
            return info;
        }
        /// <summary>
        /// 获取垂直滚动条信息
        /// </summary>
        /// <param name="hWnd">The h WND.</param>
        /// <returns>Scrollbarinfo.</returns>
        public static SCROLLINFO GetVScrollBarInfo(IntPtr hWnd)
        {
            SCROLLINFO info = new SCROLLINFO();
            info.cbSize = (int)Marshal.SizeOf(info);
            info.fMask = (int)ScrollInfoMask.SIF_DISABLENOSCROLL | (int)ScrollInfoMask.SIF_ALL;
            int intRef = GetScrollInfo(hWnd, SB_VERT, ref info);
            return info;
        }
        public struct SCROLLINFO
        {
            public int cbSize;
            public int fMask;
            public int nMin;
            public int nMax;
            public int nPage;
            public int nPos;
            public int nTrackPos;
            public int ScrollMax { get { return nMax + 1 - nPage; } }
        }
        public enum ScrollInfoMask : uint
        {
            SIF_RANGE = 0x1,
            SIF_PAGE = 0x2,
            SIF_POS = 0x4,
            SIF_DISABLENOSCROLL = 0x8,
            SIF_TRACKPOS = 0x10,
            SIF_ALL = (SIF_RANGE | SIF_PAGE | SIF_POS | SIF_TRACKPOS),
            SB_THUMBTRACK = 5,
            WM_HSCROLL = 0x0114,
            WM_VSCROLL = 0x0115,
            SB_LINEUP = 0,
            SB_LINEDOWN = 1,
            SB_LINELEFT = 0,
            SB_LINERIGHT = 1,
        }

        public static void SetVScrollValue(IntPtr handle, int value)
        {
            var info = GetVScrollBarInfo(handle);
            info.nPos = value;
            SetScrollInfo(handle, SB_VERT, ref info, true);
            PostMessage(handle, (int)ScrollInfoMask.WM_VSCROLL, MakeLong((short)ScrollInfoMask.SB_THUMBTRACK, highPart: (short)info.nPos), 0);
        }
        public static void SetHScrollValue(IntPtr handle, int value)
        {
            var info = GetHScrollBarInfo(handle);
            info.nPos = value;
            SetScrollInfo(handle, SB_HORZ, ref info, true);
            PostMessage(handle, (int)ScrollInfoMask.WM_HSCROLL, MakeLong((short)ScrollInfoMask.SB_THUMBTRACK, highPart: (short)info.nPos), 0);
        }
        private static uint MakeLong(short lowPart, short highPart)
        {
            return (ushort)lowPart | (uint)(highPart << 16);
        }
        /// <summary>
        /// 控件向上滚动一个单位
        /// </summary>
        /// <param name="handle">控件句柄</param>
        public static void ScrollUp(IntPtr handle)
        {
            SendMessage(handle, (int)ScrollInfoMask.WM_VSCROLL, (int)ScrollInfoMask.SB_LINEUP, 0);
        }

        /// <summary>
        /// 控件向下滚动一个单位
        /// </summary>
        /// <param name="handle">控件句柄</param>
        public static void ScrollDown(IntPtr handle)
        {
            SendMessage(handle, (int)ScrollInfoMask.WM_VSCROLL, (int)ScrollInfoMask.SB_LINEDOWN, 0);
        }
        /// <summary>
        /// 控件向左滚动一个单位
        /// </summary>
        /// <param name="handle">控件句柄</param>
        public static void ScrollLeft(IntPtr handle)
        {
            SendMessage(handle, (int)ScrollInfoMask.WM_HSCROLL, (int)ScrollInfoMask.SB_LINELEFT, 0);
        }

        /// <summary>
        /// 控件向右滚动一个单位
        /// </summary>
        /// <param name="handle">控件句柄</param>
        public static void ScrollRight(IntPtr handle)
        {
            SendMessage(handle, (int)ScrollInfoMask.WM_VSCROLL, (int)ScrollInfoMask.SB_LINERIGHT, 0);
        }
        #endregion
        /// <summary>
        /// Sets the window long.
        /// </summary>
        /// <param name="hWnd">The h WND.</param>
        /// <param name="nIndex">Index of the n.</param>
        /// <param name="wndproc">The wndproc.</param>
        /// <returns>System.Int32.</returns>
        [DllImport("user32.dll ")]
        public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int wndproc);

        /// <summary>
        /// Gets the window long.
        /// </summary>
        /// <param name="hWnd">The h WND.</param>
        /// <param name="nIndex">Index of the n.</param>
        /// <returns>System.Int32.</returns>
        [DllImport("user32.dll ")]
        public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        /// <summary>
        /// 设置GDI高质量模式抗锯齿
        /// </summary>
        /// <param name="g">The g.</param>
        public static void SetGDIHigh(this Graphics g)
        {
            g.SmoothingMode = SmoothingMode.AntiAlias;  //使绘图质量最高，即消除锯齿
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.CompositingQuality = CompositingQuality.HighQuality;
        }

        /// <summary>
        /// 根据矩形和圆得到一个圆角矩形Path
        /// </summary>
        /// <param name="rect">The rect.</param>
        /// <param name="cornerRadius">The corner radius.</param>
        /// <returns>GraphicsPath.</returns>
        public static GraphicsPath CreateRoundedRectanglePath(this Rectangle rect, int cornerRadius)
        {
            GraphicsPath roundedRect = new GraphicsPath();
            roundedRect.AddArc(rect.X, rect.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            roundedRect.AddLine(rect.X + cornerRadius, rect.Y, rect.Right - cornerRadius * 2, rect.Y);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
            roundedRect.AddLine(rect.Right, rect.Y + cornerRadius * 2, rect.Right, rect.Y + rect.Height - cornerRadius * 2);
            roundedRect.AddArc(rect.X + rect.Width - cornerRadius * 2, rect.Y + rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            roundedRect.AddLine(rect.Right - cornerRadius * 2, rect.Bottom, rect.X + cornerRadius * 2, rect.Bottom);
            roundedRect.AddArc(rect.X, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            roundedRect.AddLine(rect.X, rect.Bottom - cornerRadius * 2, rect.X, rect.Y + cornerRadius * 2);
            roundedRect.CloseFigure();
            return roundedRect;
        }

        /// <summary>
        /// Paints the triangle.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="brush">The brush.</param>
        /// <param name="point">The point.</param>
        /// <param name="size">The size.</param>
        /// <param name="direction">The direction.</param>
        public static void PaintTriangle(Graphics g, System.Drawing.Brush brush, Point point, int size, EGraphDirection direction)
        {
            Point[] array = new Point[4];
            switch (direction)
            {
                case EGraphDirection.Leftward:
                    array[0] = new Point(point.X, point.Y - size);
                    array[1] = new Point(point.X, point.Y + size);
                    array[2] = new Point(point.X - 2 * size, point.Y);
                    break;
                case EGraphDirection.Rightward:
                    array[0] = new Point(point.X, point.Y - size);
                    array[1] = new Point(point.X, point.Y + size);
                    array[2] = new Point(point.X + 2 * size, point.Y);
                    break;
                case EGraphDirection.Upward:
                    array[0] = new Point(point.X - size, point.Y);
                    array[1] = new Point(point.X + size, point.Y);
                    array[2] = new Point(point.X, point.Y - 2 * size);
                    break;
                default:
                    array[0] = new Point(point.X - size, point.Y);
                    array[1] = new Point(point.X + size, point.Y);
                    array[2] = new Point(point.X, point.Y + 2 * size);
                    break;
            }
            array[3] = array[0];
            g.FillPolygon(brush, array);
        }
    }
}
