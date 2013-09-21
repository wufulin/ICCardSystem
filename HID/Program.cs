using System;
using System.Windows.Forms;

namespace HID
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
            Form frm1 = new MainFrom();
            Application.Run(frm1);
        }

        
    }
}
