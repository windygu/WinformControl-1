using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace CtrlControls.ExTextBoxIcon
{
    partial class TextBoxIconEx
    {
        /// <summary>
        /// 改变文本框的位置
        /// </summary>
        private void ChangeBaseTextLocation()
        {
            if (this._icon != null)
            {
                int position = this.IconRect.Right;
                this.BaseText.Width = this.Width - position - BORDER_WIDTH * 2;
                this.BaseText.Location = new Point(position + BORDER_WIDTH, (base.Height - this.BaseText.Height) / 2 + 1);
            }
            else
            {
                this.BaseText.Width = this.Width - BORDER_WIDTH * 2;
                this.BaseText.Location = new Point(BORDER_WIDTH, (base.Height - this.BaseText.Height) / 2 + 1);
            }
        }
    }
}
