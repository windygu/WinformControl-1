using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using CtrlControls.Helper;
using CtrlControls.Enum;

namespace CtrlControls.ExForm
{
    public partial class FormEx : Form
    {
        public FormEx()
        {
            base.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.FixedHeight |
                ControlStyles.FixedWidth |
                ControlStyles.Selectable |
                ControlStyles.ContainerControl |
                ControlStyles.DoubleBuffer, true);
            base.SetStyle(ControlStyles.Opaque, false);
            base.BackColor = Color.FromArgb(102, 180, 228);
            base.FormBorderStyle = FormBorderStyle.None;
            base.UpdateStyles();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            //画系统按钮
            if (this._systemButton != ESystemButton.None)
            {
                if (this._systemButton == ESystemButton.CloseMinMax)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                        this.DrawSystemButton(g, this.MaxMouseState, this.MaxButtonRect, "restore");//向下还原按钮
                    else
                        this.DrawSystemButton(g, this.MaxMouseState, this.MaxButtonRect, "max");//最大化按钮
                }
                if (this._systemButton == ESystemButton.CloseMin || this._systemButton == ESystemButton.CloseMinMax)
                {
                    this.DrawSystemButton(g, this.MinMouseState, this.MinButtonRect, "mini");//最小化按钮
                }
                if (this._systemButton != ESystemButton.None)
                {
                    this.DrawSystemButton(g, this.CloseMouseState, this.CloseButtonRect, "close");//关闭按钮
                }
            }

            if (base.ShowIcon)
            {
                g.DrawImage(base.Icon.ToBitmap(), this.TitleBarIconRect);
            }
            if (!string.IsNullOrEmpty(this.Text))
            {
                TextRenderer.DrawText(g, this.Text, base.Font, this.TitleBarTextRect, base.ForeColor, TextFormatFlags.VerticalCenter);
            }

            //画窗体的边框
            DrawHelper.RenderFormBorder(g, this.ClientRectangle, this._borderImage);

        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case (int)WindowsMessage.WM_NCHITTEST:
                    this.WM_NCHITTEST(ref m);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            #region 无边窗口实现拖拽
            Point point = e.Location;
            if (e.Button == MouseButtons.Left
                 && this.WindowState != FormWindowState.Maximized)
            {
                WinAPIDllImport.ReleaseCapture();
                if (this.CloseButtonRect.Contains(point)
                    || this.MinButtonRect.Contains(point)
                    || this.MaxButtonRect.Contains(point))
                    return;
                WinAPIDllImport.SendMessage(this.Handle, (int)WindowsMessage.WM_SYSCOMMAND, (int)EWM_SYSCOMMAND_WPARAM.SC_MOVE + (int)EWM_NCHITTEST.HTCAPTION, 0);//移动窗体
            }
            #endregion
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            Point point = e.Location;
            if (this.CloseButtonRect.Contains(point))
                this.CloseMouseState = EMouseState.MouseMove;
            else
                this.CloseMouseState = EMouseState.Normal;
            if (this.MinButtonRect.Contains(point))
                this.MinMouseState = EMouseState.MouseMove;
            else
                this.MinMouseState = EMouseState.Normal;
            if (this.MaxButtonRect.Contains(point))
                this.MaxMouseState = EMouseState.MouseMove;
            else
                this.MaxMouseState = EMouseState.Normal;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (e.Button != MouseButtons.Left)
                return;
            Point point = e.Location;
            if (this.CloseButtonRect.Contains(point))
            {
                this.CloseMouseState = EMouseState.MouseMove;
                this.Close();//关闭窗体
            }
            else
            {
                this.CloseMouseState = EMouseState.Normal;
            }
            if (this.MinButtonRect.Contains(point))
            {
                this.MinMouseState = EMouseState.MouseMove;
                this.WindowState = FormWindowState.Minimized;//最小化窗体
            }
            else
            {
                this.MinMouseState = EMouseState.Normal;
            }
            if (this.MaxButtonRect.Contains(point))
            {
                this.MaxMouseState = EMouseState.MouseMove;
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;//向下还原窗体
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;//最大化窗体
                }
            }
            else
            {
                this.MaxMouseState = EMouseState.Normal;
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            //画一个圆角矩形的窗体控件
            int Rgn = WinAPIDllImport.CreateRoundRectRgn(0, 0, this.Width + 1, this.Height + 1, 5, 5);
            WinAPIDllImport.SetWindowRgn(this.Handle, Rgn, true);
        }
    }
}
