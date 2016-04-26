using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CtrlDemo
{
    public partial class FrmListView : Form
    {
        public FrmListView()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmListView_Load);
        }

        void FrmListView_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                ListViewItem item = new ListViewItem();

                item.Text = i.ToString();

                // 文件大小
                item.SubItems.Add("100M");
                // 已完成
                item.SubItems.Add(i + "0%");
                // 下载进度
                item.SubItems.Add((10 - i) + "0%");
                // 剩余时间
                item.SubItems.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                // 下载速度
                item.SubItems.Add("0KB");
                // 创建时间
                item.SubItems.Add(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                // 下载状态
                item.SubItems.Add("正在等待");
                // 下载说明
                item.SubItems.Add("下载说明");
                // 下载地址
                item.SubItems.Add("http://www.mpnco.cn");

                this.listViewEx1.Items.Add(item);
            }
        }
    }
}
