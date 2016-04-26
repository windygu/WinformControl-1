using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using CtrlControls.Helper;
using System.Drawing.Drawing2D;
using CtrlControls.Enum;

namespace CtrlControls.ExProgressBar
{
    [ToolboxBitmap(typeof(ProgressBar))]
    public partial class ProgressBarEx : ProgressBar
    {
        public ProgressBarEx()
        {
            base.SetStyle(
                   ControlStyles.UserPaint |
                   ControlStyles.AllPaintingInWmPaint |
                   ControlStyles.OptimizedDoubleBuffer |
                   ControlStyles.ResizeRedraw |
                   ControlStyles.DoubleBuffer |
                   ControlStyles.SupportsTransparentBackColor, true);
            base.UpdateStyles();
        }
        /// <summary>
        /// 画滚动条的值
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            //进度条
            if (base.Value >= base.Minimum && base.Value <= base.Maximum)
            {
                float percent = (float)base.Value / base.Maximum;
                int width = (int)(base.ClientRectangle.Width * percent);
                width = Math.Min(width, this.ClientRectangle.Width - 2);
                if (width > 5)
                {
                    Rectangle rect = base.ClientRectangle;
                    rect.Inflate(-1, -1);
                    Rectangle barRect = new Rectangle(rect.X + 2, rect.Y + 2, width - 5, rect.Height - 5);
                    DrawHelper.RenderProgressBarBackground(
                        g,
                        barRect,
                        this._progressBarColor,
                        this._progressBarColor,
                        ERoundStyle.All,
                        4,
                        0.45f,
                        false,
                        false,
                        LinearGradientMode.Vertical);
                }
            }
        }
        /// <summary>
        /// 画滚动条的背景
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Graphics g = e.Graphics;
            this.CustomPaint(g);
        }

        //protected override void WndProc(ref Message m)
        //{
        //    base.WndProc(ref m);//必须放到if的前面
        //    if (m.Msg == (int)WindowsMessage.WM_PAINT
        //        || m.Msg == (int)WindowsMessage.WM_NCPAINT)
        //    {
        //        using (Graphics g = Graphics.FromHwnd(base.Handle))
        //        {
        //            this.CustomPaint(g);
        //        }
        //    }
        //}

        private void CustomPaint(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = base.ClientRectangle;

            //rect.Inflate(-1, -1);

            DrawHelper.RenderProgressBarBackground(
                g,
                rect,
                this._baseColor,
                this._borderColor,
                this._roundStyle,
                this._radius,
                0.45f,
                true,
                false,
                LinearGradientMode.Vertical);

            if (!string.IsNullOrEmpty(this._progressBarText))
            {
                TextRenderer.DrawText(g, this._progressBarText, new Font("微软雅黑", 8.2f), base.ClientRectangle, this._progressBarTextColor, this._textFlags);
            }
        }
    }
}
