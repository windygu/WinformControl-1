using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CtrlControls.ExDataGridView
{
    partial class DataGridViewExLinkCellEx
    {
        /// <summary>
        /// 黑名单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool BlackClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return false;
            if (sender is DataGridView)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.Columns[e.ColumnIndex] is DataGridViewExLinkColumnEx)
                {
                    Rectangle cellBounds = dgv[e.ColumnIndex, e.RowIndex].ContentBounds;
                    Rectangle blackRect = new Rectangle(
                        cellBounds.Location.X + 2,
                        cellBounds.Location.Y + (cellBounds.Height - HeightList[0]) / 2,
                        WidthList[0],
                        HeightList[0]);
                    if (blackRect.Contains(e.Location))
                        return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 邀请
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool InviteClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return false;
            if (sender is DataGridView)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.Columns[e.ColumnIndex] is DataGridViewExLinkColumnEx)
                {
                    Rectangle cellBounds = dgv[e.ColumnIndex, e.RowIndex].ContentBounds;
                    Rectangle inviteRect = new Rectangle(
                        cellBounds.Location.X + 2 + WidthList[0],
                        cellBounds.Location.Y + (cellBounds.Height - HeightList[1]) / 2,
                        WidthList[1],
                        HeightList[1]);
                    if (inviteRect.Contains(e.Location))
                        return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 强制邀请
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool ForceInviteClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return false;
            if (sender is DataGridView)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.Columns[e.ColumnIndex] is DataGridViewExLinkColumnEx)
                {
                    Rectangle cellBounds = dgv[e.ColumnIndex, e.RowIndex].ContentBounds;
                    Rectangle inviteRect = new Rectangle(
                        cellBounds.Location.X + 2 + WidthList[0] + WidthList[1],
                        cellBounds.Location.Y + (cellBounds.Height - HeightList[1]) / 2,
                        WidthList[1],
                        HeightList[1]);
                    if (inviteRect.Contains(e.Location))
                        return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 对话记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool RecordClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return false;
            if (sender is DataGridView)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.Columns[e.ColumnIndex] is DataGridViewExLinkColumnEx)
                {
                    Rectangle cellBounds = dgv[e.ColumnIndex, e.RowIndex].ContentBounds;
                    Rectangle inviteRect = new Rectangle(
                        cellBounds.Location.X + 2 + WidthList[0] + WidthList[1] + WidthList[2],
                        cellBounds.Location.Y + (cellBounds.Height - HeightList[1]) / 2,
                        WidthList[1],
                        HeightList[1]);
                    if (inviteRect.Contains(e.Location))
                        return true;
                }
            }
            return false;
        }
        /// <summary>
        /// 访客卡片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public static bool CardClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return false;
            if (sender is DataGridView)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.Columns[e.ColumnIndex] is DataGridViewExLinkColumnEx)
                {
                    Rectangle cellBounds = dgv[e.ColumnIndex, e.RowIndex].ContentBounds;
                    Rectangle inviteRect = new Rectangle(
                        cellBounds.Location.X + 2 + WidthList[0] + WidthList[1] + WidthList[2] + WidthList[3],
                        cellBounds.Location.Y + (cellBounds.Height - HeightList[1]) / 2,
                        WidthList[1],
                        HeightList[1]);
                    if (inviteRect.Contains(e.Location))
                        return true;
                }
            }
            return false;
        }
    }
}
