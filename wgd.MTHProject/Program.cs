using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wgd.MTHProject
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
            FormLogin frmLogin = new FormLogin();
            frmLogin.TopMost = true;
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FormMain());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
