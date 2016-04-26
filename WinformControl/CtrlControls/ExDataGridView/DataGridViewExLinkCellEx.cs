using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtrlResource;
using System.Drawing;

namespace CtrlControls.ExDataGridView
{
    public partial class DataGridViewExLinkCellEx : DataGridViewLinkCell
    {
        public DataGridViewExLinkCellEx()
        {
            DataGridViewExLinkEx link1 = new DataGridViewExLinkEx(AssemblyHelper.GetImage("DataGridView.datagridview_linkex_black.png"));
            DataGridViewExLinkEx link2 = new DataGridViewExLinkEx(AssemblyHelper.GetImage("DataGridView.datagridview_linkex_invite.png"));
            DataGridViewExLinkEx link3 = new DataGridViewExLinkEx(AssemblyHelper.GetImage("DataGridView.datagridview_linkex_force_invite.png"));
            DataGridViewExLinkEx link4 = new DataGridViewExLinkEx(AssemblyHelper.GetImage("DataGridView.datagridview_linkex_record.png"));
            DataGridViewExLinkEx link5 = new DataGridViewExLinkEx(AssemblyHelper.GetImage("DataGridView.datagridview_linkex_card.png"));

            this._linkExList.AddRange(new DataGridViewExLinkEx[] { link1, link2, link3, link4, link5 });
            if (!this._isPostBack)
            {
                WidthList.AddRange(new int[] { link1.Size.Width, link2.Size.Width, link3.Size.Width, link4.Size.Width, link5.Size.Width });
                HeightList.AddRange(new int[] { link1.Size.Height, link2.Size.Height, link3.Size.Height, link4.Size.Height, link5.Size.Height });
                this._isPostBack = true;
            }
        }


        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates cellState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);//调用系统的绘制Link单元格的方法，自己搞不定背景高亮显示时的颜色。
            //下面是重新画自定义的LinkButton按钮
            int total = 0;
            for (int i = 0; i < this._linkExList.Count; i++)
            {
                this._linkExList[i].Bounds = new Rectangle(
                    cellBounds.Location.X + total + 2,
                    cellBounds.Location.Y + (cellBounds.Height - this._linkExList[i].Height) / 2,
                    this._linkExList[i].Width,
                    this._linkExList[i].Height);

                total += this._linkExList[i].Size.Width;

                graphics.DrawImage(
                    this._linkExList[i].Image,
                    this._linkExList[i].Bounds,
                    0,
                    0,
                    this._linkExList[i].Width,
                    this._linkExList[i].Height,
                    GraphicsUnit.Pixel);
            }
        }
    }
}
