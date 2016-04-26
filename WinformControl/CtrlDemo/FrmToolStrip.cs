using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CtrlControls.ExToolStrip;

namespace CtrlDemo
{
    public partial class FrmToolStrip : Form
    {
        public FrmToolStrip()
        {
            InitializeComponent();
            this.toolStrip2.Renderer = new ToolStripExRenderer(100, Color.White);
        }
    }
}
