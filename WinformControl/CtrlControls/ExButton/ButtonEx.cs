using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using CtrlControls.Helper;
using CtrlResource;
using CtrlControls.Enum;

namespace CtrlControls.ExButton
{
    [ToolboxBitmap(typeof(Button))]
    public partial class ButtonEx : Button
    {
        public ButtonEx()
            : base()
        {
            base.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.Selectable, true);
            base.SetStyle(ControlStyles.Opaque, false);
            base.Size = new System.Drawing.Size(75, 28);
            base.BackColor = Color.Transparent;
            base.UpdateStyles();
        }

        #region 重新画一个按钮
        /// <summary>
        /// 重新画一个按钮
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(pevent);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            if (this._isShowBorder && base.Focused)
            {
                //画边
                DrawHelper.RenderButtonBorderBackground(g, this.ClientRectangle, this.BorderImage, true);
            }
            Image image = this.NormalImage;
            switch (this._mouseState)//跟据鼠标的状态，选择要绘制按钮图片
            {
                case EMouseState.MouseDown:
                    image = this.DownImage;
                    break;
                case EMouseState.MouseMove:
                case EMouseState.MouseUp:
                    image = this.MoveImage;
                    break;
                default:
                    if (base.Focused
                        && this._isShowBorder)
                    {
                        image = this.FocusImage;
                    }
                    break;
            }
            //画背景
            DrawHelper.RenderButtonBorderBackground(g, this.ContentRect, image, true);
            Rectangle textRect = this.ContentRect;
            if (this.Image != null)
            {
                int y = (this.Height - this.Image.Height) / 2;
                int x = 10;
                if (!string.IsNullOrWhiteSpace(this.Text))
                    x = (this.ClientRectangle.Width -  TextHelper.GetStringLen(this.Text)) / 2 - this.Image.Width;
                else
                    x = (this.Width - this.Image.Width) / 2;
                Rectangle rect = new Rectangle(x, y, this.Image.Width, this.Image.Height);
                Rectangle imgRect = new Rectangle(0, 0, this.Image.Width, this.Image.Height);
                g.DrawImage(this.Image, rect, imgRect, GraphicsUnit.Pixel);//画图片
                textRect = new Rectangle(
                    this.ContentRect.X + this.Image.Width,
                    this.ContentRect.Y,
                    this.ContentRect.Width,
                    this.ContentRect.Height);//图片和文字在一起时的位置
            }
            //写字
            TextRenderer.DrawText(g, this.Text, base.Font, textRect, base.ForeColor, this._textAlign);
        }
        #endregion

        #region 增加鼠标的操作状态
        protected override void OnMouseEnter(EventArgs e)
        {
            if (!this.DesignMode)
                this.MouseState = EMouseState.MouseMove;
            base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            if (!this.DesignMode)
                this.MouseState = EMouseState.Normal;
            base.OnMouseLeave(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (!this.DesignMode)
            {
                if (e.Button == MouseButtons.Left)
                    this.MouseState = EMouseState.MouseDown;
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (!this.DesignMode)
                this.MouseState = EMouseState.MouseUp;
            base.OnMouseUp(e);
        }
        #endregion

    }
}
