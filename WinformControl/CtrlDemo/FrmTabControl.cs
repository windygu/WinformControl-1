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
    public partial class FrmTabControl : Form
    {
        public FrmTabControl()
        {
            InitializeComponent();
            this.contextMenuStrip1.Renderer = new MenuRenderer();
        }
    }
}
