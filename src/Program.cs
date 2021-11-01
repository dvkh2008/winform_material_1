using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKCT
{
    static class Program
    {

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        //private static Mutex mutex = null;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string appName = "SKCT";
            //bool createdNew;

            using var mutex = new Mutex(true, appName, out bool createdNew);

            if (!createdNew)
            {
                Process current = Process.GetCurrentProcess();
                foreach (Process process in Process.GetProcessesByName(current.ProcessName))
                {
                    if (process.Id != current.Id)
                    {
                        SetForegroundWindow(process.MainWindowHandle);
                        break;
                    }
                }
                //app is already running! Exiting the application  
                return;
            }


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmParent());
        }
    }
}
