using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CtrlControls.ExTextBoxIcon
{
    partial class TextBoxIconEx
    {
        #region 自定义事件 && 激发事件的方法
        public event EventHandler IconClick;
        protected void OnIconClick()
        {
            if (this.IconClick != null)
                this.IconClick(this, EventArgs.Empty);
        }
        #endregion
    }
}
