using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using CtrlControls.Helper;

namespace CtrlControls.ExListView
{
    partial class ListViewEx
    {
        private class HeaderNativeWindow : NativeWindow, IDisposable
        {
            private ListViewEx _owner;

            public HeaderNativeWindow(ListViewEx owner)
            {
                this._owner = owner;
                base.AssignHandle(owner.HeaderWnd);
            }

            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);

                if (m.Msg == 0xF || m.Msg == 0x47)
                {
                    IntPtr hdc = WinAPIDllImport.GetDC(m.HWnd);
                    try
                    {
                        using (Graphics g = Graphics.FromHdc(hdc))
                        {
                            Rectangle bounds = this._owner.HeaderEndRect();
                            Color baseColor = this._owner._headBackgroundColor;
                            Color borderColor = this._owner._headBackgroundColor;
                            Color innerBorderColor = Color.FromArgb(150, 255, 255, 255);
                            if (this._owner.ColumnCount > 0)
                            {
                                bounds.X--;
                                bounds.Width++;
                            }
                            DrawHelper.RenderListViewBackground(g, bounds, this._owner._headBackgroundColor, this._owner._headBackgroundColor, innerBorderColor, false, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
                        }
                    }
                    finally
                    {
                        WinAPIDllImport.ReleaseDC(m.HWnd, hdc);
                    }
                }
            }

            public void Dispose()
            {
                base.ReleaseHandle();
                this._owner = null;
            }
        }
    }
}
