using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtrlControls.ExForm;
using CtrlControls.ExMenu;
using CtrlControls.ExToolStrip;

namespace CtrlDemo
{
    public partial class FrmForm : FormEx
    {
        public FrmForm()
        {
            InitializeComponent();
            this.contextMenuStrip1.Renderer = new MenuRenderer();
            this.toolStrip1.Renderer = new ToolStripExRenderer(100, Color.White);
            this.btnListView.Click += (sender, e) => new FrmListView().Show();
            this.btnDataGridView.Click += (sender, e) => new FrmDataGridView().Show();
            this.btnTabControl.Click += (sender, e) => new FrmTabControl().Show();
            this.btnContextMenu.Click += (sender, e) => this.contextMenuStrip1.Show(this.btnContextMenu, new Point(0, 0), ToolStripDropDownDirection.AboveRight);
            this.btnGroupBox.Click += (sender, e) => new FrmGroupBox().Show();
            this.btnListBox.Click += (sender, e) => new FrmListBox().Show();
            this.btnComboBox.Click += (sender, e) => new FrmComboBox().Show();
            this.btnGrouper.Click += (sender, e) => new FrmGrouper().Show();
        }
    }
}
