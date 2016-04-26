using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtrlControls.Enum;
using CtrlControls.Helper;
using System.Diagnostics;

namespace CtrlControls.ExTextBoxIcon
{
    /// <summary>
    /// 在TextBox控件外边画上一个边。
    /// </summary>
    [ToolboxBitmap(typeof(TextBox))]
    public partial class TextBoxIconEx : UserControl
    {
        //继承用户控件的目的是为了能够使用设计器完成对水印控件的设置
        public TextBoxIconEx()
        {
            this.SetStyle(ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.FixedHeight |
                ControlStyles.FixedWidth |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.Selectable, true);
            base.BackColor = Color.Transparent;//发布用这个颜色,Designer.cs文件也是同样的
            //base.BackColor = Color.Black;//为了在设计界面能看清楚TextBox控件
            this.UpdateStyles();
            InitializeComponent();

            this.BaseText.WordWrap = false;

            base.Size = new Size(100, 26);//设置默认控件的尺寸
            this.HeightSpace = base.Size.Height - this.Font.Height;

            this.ChangeBaseTextLocation();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);//组合控件不能注释掉
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (this._mouseState == EMouseState.MouseMove)
            {
                DrawHelper.RendererTextBoxBorderBackground(g, base.ClientRectangle, this.BorderOverImage);
            }
            else
            {
                DrawHelper.RendererTextBoxBorderBackground(g, base.ClientRectangle, this.BorderNormalImage);
            }
            if (this._icon != null)
            {
                Rectangle iconRect = this.IconRect;
                int y = 0;
                if (this._iconMouseState == EMouseState.MouseDown)
                {
                    iconRect.X += 1;
                    y = 1;
                }
                iconRect = new Rectangle(iconRect.X, (base.Height - iconRect.Bottom) / 2 + y, iconRect.Width, iconRect.Height); ;
                g.DrawImage(this._icon, iconRect, 0, 0, this._icon.Width, this._icon.Height, GraphicsUnit.Pixel);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            this.MouseState = EMouseState.MouseMove;
            if (this._icon != null && this.IconRect.Contains(e.Location))
            {
                this.Cursor = Cursors.Hand;
            }
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (this._icon != null
                && e.Button == MouseButtons.Left
                && this.IconRect.Contains(e.Location))
            {
                this.IconMouseState = EMouseState.MouseDown;
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (this._icon != null)
            {
                this.IconMouseState = EMouseState.MouseUp;
                if (e.Button == MouseButtons.Left
                    && this.IconRect.Contains(e.Location))
                {
                    this.OnIconClick();
                }
            }
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            this.MouseState = EMouseState.MouseLeave;
            this.Cursor = Cursors.Default;
        }

        #region 鼠标经过TextBox控件时，也需要重画自定义控件的边框
        private void BaseText_MouseLeave(object sender, EventArgs e)
        {
            this.MouseState = EMouseState.MouseLeave;
        }

        private void BaseText_MouseMove(object sender, MouseEventArgs e)
        {
            this.MouseState = EMouseState.MouseMove;
        }
        #endregion
    }
}
