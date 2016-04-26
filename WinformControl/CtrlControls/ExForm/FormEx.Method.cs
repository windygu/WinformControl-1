using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using CtrlControls.Enum;
using CtrlResource;
using System.Windows.Forms;
using CtrlControls.Helper;
using System.Diagnostics;

namespace CtrlControls.ExForm
{
    partial class FormEx
    {
        #region 渲染系统按钮
        /// <summary>
        /// 渲染系统按钮
        /// </summary>
        /// <param name="g">画板</param>
        /// <param name="mouseState">鼠标状态</param>
        /// <param name="systemButtonRect">系统按钮的区域</param>
        /// <param name="state">窗体最大化、最小化、关闭按钮按钮的图片名称</param>
        private void DrawSystemButton(Graphics g, EMouseState mouseState, Rectangle systemButtonRect, string state)
        {
            switch (mouseState)
            {
                case EMouseState.Normal:
                    g.DrawImage(AssemblyHelper.GetImage("Form.form_" + state + "_normal.png"), systemButtonRect);
                    break;
                case EMouseState.MouseLeave:
                case EMouseState.MouseDown:
                    g.DrawImage(AssemblyHelper.GetImage("Form.form_" + state + "_down.png"), systemButtonRect);
                    break;
                case EMouseState.MouseMove:
                case EMouseState.MouseUp:
                    g.DrawImage(AssemblyHelper.GetImage("Form.form_" + state + "_highlight.png"), systemButtonRect);
                    break;
            }
        }
        #endregion

        #region 无边窗口改变大小
        /// <summary>
        /// 无边窗口改变大小
        /// </summary>
        /// <param name="m"></param>
        private void WM_NCHITTEST(ref Message m)
        {
            int lparam = m.LParam.ToInt32();
            int x = Win32Helper.LOWORD(lparam);
            int y = Win32Helper.HIWORD(lparam);

            Point point = new Point(x, y);
            //Debug.WriteLine("Screen x:{0},y:{1}", x, y);
            point = this.PointToClient(point);
            //Debug.WriteLine("WorkRegion x:{0},y:{1}", point.X, point.Y);

            if (this.WindowState != FormWindowState.Maximized)
            {
                if (point.X <= 5)
                {
                    if (point.Y <= 5)
                        m.Result = (IntPtr)DefWindowProc.HTTOPLEFT;
                    else if (point.Y > this.Height - 5)
                        m.Result = (IntPtr)DefWindowProc.HTBOTTOMLEFT;
                    else
                        m.Result = (IntPtr)DefWindowProc.HTLEFT;
                }
                else if (point.X >= this.Width - 5)
                {
                    if (point.Y <= 5)
                        m.Result = (IntPtr)DefWindowProc.HTTOPRIGHT;
                    else if (point.Y >= this.Height - 5)
                        m.Result = (IntPtr)DefWindowProc.HTBOTTOMRIGHT;
                    else
                        m.Result = (IntPtr)DefWindowProc.HTRIGHT;
                }
                else if (point.Y <= 5)
                {
                    m.Result = (IntPtr)DefWindowProc.HTTOP;
                }
                else if (point.Y >= this.Height - 5)
                {
                    m.Result = (IntPtr)DefWindowProc.HTBOTTOM;
                }
                else
                {
                    //Debug.WriteLine("DefWindowProc.HTCAPTION");
                    //m.Result = (IntPtr)DefWindowProc.HTCAPTION;
                    base.WndProc(ref m);
                }
            }
            else
            {
                base.WndProc(ref m);
            }
        }
        #endregion
    }
}
