using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFirstVisualizer;

namespace MyTestConsole
{
    internal static class TestConsole
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            String myString = "Hello, World";
            DebuggerSide.TestShowVisualizer(myString);

            Application.Run(new Form1());
        }
    }
}
