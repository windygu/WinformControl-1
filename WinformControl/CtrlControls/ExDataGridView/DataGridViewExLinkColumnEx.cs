using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace CtrlControls.ExDataGridView
{
    public class DataGridViewExLinkColumnEx : DataGridViewColumn
    {
        public DataGridViewExLinkColumnEx()
            : base(new DataGridViewExLinkCellEx())
        {
            base.DefaultCellStyle = new DataGridViewCellStyle(new DataGridViewCellStyle() { BackColor = Color.White });
        }
    }
}
