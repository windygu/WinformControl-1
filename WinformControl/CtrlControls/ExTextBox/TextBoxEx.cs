using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtrlControls.Enum;
using System.Drawing;
using CtrlControls.Helper;

namespace CtrlControls.ExTextBox
{
    /// <summary>
    /// 在TextBox控件内边画上一个边。
    /// </summary>
    [ToolboxBitmap(typeof(TextBox))]
    public partial class TextBoxEx : TextBox
    {
        public TextBoxEx()
        {
            base.Font = new Font("宋体", 11.0f);
            base.Height = base.Font.Height;
            if (this._Border)
            {
                base.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            this.MouseState = EMouseState.MouseMove;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.MouseState = EMouseState.MouseLeave;
            this.Cursor = Cursors.Default;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(e);
            //重绘边框的代码写在这里不管用,？？？
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);//必须放到if的前面
            if (m.Msg == (int)WindowsMessage.WM_PAINT
                || m.Msg == (int)WindowsMessage.WM_NCPAINT)
            {
                this.CustomPaint();
            }
        }

        private void CustomPaint()
        {
            if (this._Border)
            {//绘制水印
                using (Graphics g = Graphics.FromHwnd(base.Handle))
                {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    Color borderColor = this.BorderNormalColor;
                    if (this.MouseState == EMouseState.MouseMove)
                    {
                        borderColor = this.BorderOverColor;
                    }
                    using (Pen pen = new Pen(borderColor, this.BorderWeight))
                    {
                        g.DrawRectangle(pen, 0, 0, base.ClientRectangle.Width - 1, base.ClientRectangle.Height - 1);
                    }

                    if (base.Text.Length == 0
                        && !string.IsNullOrEmpty(this._waterText)
                        && !base.Focused)
                    {
                        TextFormatFlags flags = TextFormatFlags.EndEllipsis | TextFormatFlags.VerticalCenter;
                        if (base.RightToLeft == RightToLeft.Yes)
                        {
                            flags |= TextFormatFlags.RightToLeft | TextFormatFlags.Right;
                        }
                        g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                        TextRenderer.DrawText(g, this._waterText, base.Font, base.ClientRectangle, this._waterColor, flags);
                    }
                }
            }
        }
    }
}
