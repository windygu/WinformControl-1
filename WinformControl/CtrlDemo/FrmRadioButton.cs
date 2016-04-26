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
    public partial class FrmRadioButton : Form
    {
        public FrmRadioButton()
        {
            InitializeComponent();
        }

        private void radioButtonEx2_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("radioButtonEx2");
        }
    }
}
