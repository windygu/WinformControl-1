using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtrlControls.ExDataGridView;

namespace CtrlDemo
{
    public partial class FrmDataGridView : Form
    {
        public FrmDataGridView()
        {
            InitializeComponent();
            this.InitDataGridView();
        }
        public class CustomerItem
        {
            /// <summary>
            /// 访客姓名
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// 卡片姓名
            /// </summary>
            public string CardName { get; set; }
            /// <summary>
            /// 状态
            /// </summary>
            public string Status { get; set; }
            /// <summary>
            /// 访问次数
            /// </summary>
            public int Count { get; set; }
            /// <summary>
            /// 关键词
            /// </summary>
            public string KeyWord { get; set; }
            /// <summary>
            /// 访问来源
            /// </summary>
            public string Source { get; set; }
            /// <summary>
            /// 最后时间
            /// </summary>
            public DateTime LastTime { get; set; }
            /// <summary>
            /// 等待时间
            /// </summary>
            public string WaitTime { get; set; }
        }
        private void InitDataGridView()
        {
            this.dataGridViewEx1.ReadOnly = false;
            CustomerItem test1 = new CustomerItem() { Name = "湖南省长沙市", CardName = "湖南省长沙市", Status = "空闲", Count = 1, KeyWord = "在线客服", Source = "www.baidu.com", LastTime = DateTime.Parse("1984-04-04"), WaitTime = "10:10" };
            CustomerItem test2 = new CustomerItem() { Name = "福建省福州市", CardName = "福建省福州市", Status = "空闲", Count = 1, KeyWord = "在线客服", Source = "www.baidu.com", LastTime = DateTime.Parse("1985-05-05"), WaitTime = "11:11" };
            CustomerItem test3 = new CustomerItem() { Name = "北京市", CardName = "帅哥", Status = "空闲", Count = 1, KeyWord = "客服系统", Source = "www.baidu.com", LastTime = DateTime.Parse("1986-06-06"), WaitTime = "12:12" };
            CustomerItem test4 = new CustomerItem() { Name = "河北省", CardName = "王云鹏", Status = "已经来过", Count = 3, KeyWord = "", Source = "jobs.chinahr.com", LastTime = DateTime.Parse("1987-07-07"), WaitTime = "13:13" };
            CustomerItem test5 = new CustomerItem() { Name = "广东省汕尾市", CardName = "北大青鸟", Status = "正在对话", Count = 22, KeyWord = "网站客服", Source = "www.baidu.com", LastTime = DateTime.Parse("1988-08-08"), WaitTime = "14:14" };
            List<CustomerItem> lists = new List<CustomerItem>();
            lists.AddRange(new CustomerItem[] { test1, test2, test3, test4, test5 });
            this.dataGridViewEx1.DataSource = new BindingList<CustomerItem>(lists);
            this.dataGridView1.DataSource = new BindingList<CustomerItem>(lists);
            this.dataGridViewEx1.CellMouseClick += new DataGridViewCellMouseEventHandler(this.dataGridViewEx1_CellMouseClick);
        }

        private void dataGridViewEx1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DataGridViewExLinkCellEx.BlackClick(sender, e))
            {
                MessageBox.Show(string.Format("黑名单-列：{0}，行：{1}", e.ColumnIndex, e.RowIndex));
            }
            else if (DataGridViewExLinkCellEx.InviteClick(sender, e))
            {
                MessageBox.Show(string.Format("邀请-列：{0}，行：{1}", e.ColumnIndex, e.RowIndex));
            }
            else if (DataGridViewExLinkCellEx.ForceInviteClick(sender, e))
            {
                MessageBox.Show(string.Format("强制邀请-列：{0}，行：{1}", e.ColumnIndex, e.RowIndex));
            }
            else if (DataGridViewExLinkCellEx.RecordClick(sender, e))
            {
                MessageBox.Show(string.Format("对话记录-列：{0}，行：{1}", e.ColumnIndex, e.RowIndex));
            }
            else if (DataGridViewExLinkCellEx.CardClick(sender, e))
            {
                MessageBox.Show(string.Format("卡片-列：{0}，行：{1}", e.ColumnIndex, e.RowIndex));
            }
        }
    }
}
