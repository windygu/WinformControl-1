using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtrlControls.ExMenu;

namespace CtrlDemo
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            this.button2.Click += new EventHandler(button2_Click);
            this.contextMenuStrip2.Renderer = new MenuRenderer();
        }

        void button2_Click(object sender, EventArgs e)
        {
            this.contextMenuStrip2.Show(this.button2, new Point(0, 0), ToolStripDropDownDirection.AboveRight);
        }
    }
}
