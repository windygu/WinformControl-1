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
    public partial class FrmListBox : Form
    {
        public FrmListBox()
        {
            InitializeComponent();
            this.listBoxEx1.Items.Add(new CtrlControls.ExListBox.ListBoxExItem("帅哥"));
            this.listBoxEx1.Items.Add(new CtrlControls.ExListBox.ListBoxExItem("美女"));
            this.listBoxEx1.Items.Add(new CtrlControls.ExListBox.ListBoxExItem("野兽"));
            this.listBoxEx1.Items.Add(new CtrlControls.ExListBox.ListBoxExItem("恐龙"));
            this.listBoxEx1.Items.Add(new CtrlControls.ExListBox.ListBoxExItem("人妖"));
            this.listBoxEx1.Items.Add(new CtrlControls.ExListBox.ListBoxExItem("山炮"));
            this.listBoxEx1.Items.Add(new CtrlControls.ExListBox.ListBoxExItem("吊死"));
        }
    }
}
