using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CtrlResource;
using System.Drawing;

namespace CtrlDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += (sender, e) =>
            {
                foreach (Image image in AssemblyHelper.Dict.Values)
                {
                    image.Dispose();
                }
                AssemblyHelper.Dict.Clear();
            };
            Application.Run(new FrmForm());
        }
    }
}
