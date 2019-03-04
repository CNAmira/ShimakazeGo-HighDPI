using System;
using System.Reflection;
using System.Windows.Forms;

namespace ShimakazeGo_HighDPI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Version version = new Version(10, 0, 15063, 0);

            if (Environment.OSVersion.Version.CompareTo(version) < 0)
            {
                MessageBox.Show("当前系统不支持 WinForms 的高 DPI 缩放，请直接启动程序。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Assembly assembly = Assembly.LoadFrom("ShimakazeGo.exe");
            MethodInfo entryPoint = assembly.EntryPoint;
            entryPoint.Invoke(null, new object[] { new string[0] { } });
        }
    }
}
