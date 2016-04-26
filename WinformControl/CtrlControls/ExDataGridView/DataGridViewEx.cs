using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace CtrlControls.ExDataGridView
{
    public partial class DataGridViewEx : DataGridView
    {
        public DataGridViewEx()
        {
            base.DoubleBuffered = base.ReadOnly = true;
            base.MultiSelect = base.RowHeadersVisible = base.AllowUserToAddRows = base.AllowUserToDeleteRows = false;
            base.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            base.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            base.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
        }
        /// <summary>
        /// 重绘DataGridView的标题栏
        /// </summary>
        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            //base.OnCellPainting(e);
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(e.CellBounds, this._titleColorA, this._titleColorB, 90f))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }
                //绘制标题栏边框
                Rectangle border = e.CellBounds;
                border.Offset(-1, -1);
                using (Pen pen = new Pen(Color.Gray))
                {
                    e.Graphics.DrawRectangle(pen, border);
                }
                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
        }

        protected override void OnCellMouseEnter(DataGridViewCellEventArgs e)
        {
            base.OnCellMouseEnter(e);
            if (e.RowIndex >= 0)
                this._defaultColor = this.Rows[e.RowIndex].DefaultCellStyle.BackColor;
        }
        protected override void OnCellMouseMove(DataGridViewCellMouseEventArgs e)
        {
            base.OnCellMouseMove(e);
            if (e.RowIndex >= 0)
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = this._mouseMoveColor;
        }
        protected override void OnCellMouseLeave(DataGridViewCellEventArgs e)
        {
            base.OnCellMouseLeave(e);
            if (e.RowIndex >= 0)
                this.Rows[e.RowIndex].DefaultCellStyle.BackColor = this._defaultColor;
        }
    }
}
