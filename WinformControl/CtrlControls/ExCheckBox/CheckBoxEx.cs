using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using CtrlControls.Enum;

namespace CtrlControls.ExCheckBox
{
    [ToolboxBitmap(typeof(CheckBox))]
    public partial class CheckBoxEx : CheckBox
    {
        public CheckBoxEx()
        {
            base.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.Selectable, true);
            base.SetStyle(ControlStyles.Opaque, false);
            base.BackColor = Color.Transparent;
            base.UpdateStyles();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //base.OnPaint(pevent);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.AntiAlias;

            //写字
            TextRenderer.DrawText(g, this.Text, base.Font, this.ContentRect, base.ForeColor, this._textFlags);

            //画图
            Image image = this.NormalImage;

            if (base.Enabled)
            {
                if (!this.DesignMode && base.CheckState == CheckState.Indeterminate)
                {
                    if (this.MouseState == EMouseState.MouseDown ||
                        this.MouseState == EMouseState.MouseMove)
                        image = this.IndeterminateHighLightImage;
                    else
                        image = this.IndeterminateImage;
                }
                else
                {
                    switch (this._mouseState)
                    {
                        case EMouseState.Normal:
                        case EMouseState.MouseLeave:
                            if (base.Checked)
                                image = this.NormalImageChecked;
                            else
                                image = this.NormalImage;
                            break;
                        case EMouseState.MouseDown:
                        case EMouseState.MouseUp:
                        case EMouseState.MouseMove:
                            if (base.Checked)
                                image = this.HighLightImageChecked;
                            else
                                image = this.HighLightImage;
                            break;
                    }
                }
            }
            g.DrawImage(image, this.ImageRect);
        }

        protected override void OnMouseEnter(EventArgs eventargs)
        {
            if (!this.DesignMode)
                this.MouseState = EMouseState.MouseMove;
            base.OnMouseEnter(eventargs);
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            if (!this.DesignMode)
                this.MouseState = EMouseState.MouseDown;
            base.OnMouseDown(mevent);
        }
        protected override void OnMouseLeave(EventArgs eventargs)
        {
            if (!this.DesignMode)
                this.MouseState = EMouseState.MouseLeave;
            base.OnMouseLeave(eventargs);
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            if (!this.DesignMode)
                this.MouseState = EMouseState.MouseUp;
            base.OnMouseUp(mevent);
        }
    }
}
