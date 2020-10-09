using CtrlControls.Struct;
using System;
using System.Runtime.InteropServices;

namespace CtrlControls.Helper
{
    class WinAPIDllImport
    {
        [DllImport("user32.dll")]
        public static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hwnd, int msg, int wParam, int lParam);

        /// <summary>
        /// 创建一个圆角矩形区域
        /// </summary>
        /// <param name="nLeftRect">x坐标左上角</param>
        /// <param name="nTopRect">y坐标左上角</param>
        /// <param name="nRightRect">x坐标右上角</param>
        /// <param name="nBottomRect">y坐标右上角</param>
        /// <param name="nWidthEllipse">椭圆的宽度</param>
        /// <param name="nHeightEllipse">椭圆的高度</param>
        /// <returns></returns>
        [DllImport("gdi32.dll")]
        public static extern int CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        /// <summary>
        /// 设置窗口的区域的窗口。窗口区域决定在窗户上的地区——该系统允许绘画。该系统不显示任何部分是一个窗口,窗户外面地区
        /// </summary>
        /// <param name="hwnd">窗口句柄</param>
        /// <param name="hRgn">处理区域</param>
        /// <param name="bRedraw">重绘窗体选项</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        public static extern int SetWindowRgn(IntPtr hwnd, int hRgn, Boolean bRedraw);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr handle);
        [DllImport("user32.dll")]
        public static extern int ReleaseDC(IntPtr handle, IntPtr hdc);
        [DllImport("user32.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]
        public static extern IntPtr GetWindowDC(IntPtr hwnd);

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool AdjustWindowRectEx(ref RECT lpRect, int dwStyle, bool bMenu, int dwExStyle);
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool GetClientRect(IntPtr hWnd, ref RECT rect);
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);
        [DllImport("user32.dll")]
        public static extern bool OffsetRect(ref RECT lpRect, int x, int y);
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, int msg, int wParam, ref HDITEM lParam);
        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, int msg, int wParam, ref RECT lParam);
        [DllImport("comctl32.dll", SetLastError = true)]
        public static extern IntPtr ImageList_GetIcon(IntPtr himl, int i, int flags);
        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool DestroyIcon(IntPtr hIcon);
    }
}
