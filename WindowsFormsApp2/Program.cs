using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
//using System.Keys
namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            foreach (var process in Process.GetProcessesByName("samp-server"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("samp-npc"))
            {
                process.Kill();
            }
            Process.Start("samp-server.exe");
            Process.Start("samp-npc.exe");

            Application.Exit();
        }
    }
}
