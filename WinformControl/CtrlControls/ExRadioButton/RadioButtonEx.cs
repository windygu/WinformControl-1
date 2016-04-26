using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using CtrlControls.Enum;

namespace CtrlControls.ExRadioButton
{
    public partial class RadioButtonEx : RadioButton
    {
        public RadioButtonEx()
        {
            base.SetStyle(
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.Selectable |
                    ControlStyles.UserPaint, true);
            base.SetStyle(ControlStyles.Opaque, false);
            base.BackColor = Color.Transparent;
            base.UpdateStyles();
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            //base.OnPaint(pevent);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            //写字
            TextRenderer.DrawText(g, base.Text, base.Font, this.ContentRect, base.ForeColor, this._textFlags);
            //画图
            Image image = this.NormalImage;
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
