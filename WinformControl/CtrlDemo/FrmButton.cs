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
    public partial class FrmButton : Form
    {
        public FrmButton()
        {
            InitializeComponent();
        }

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("王云鹏是帅哥");
        }
    }
}
