using MIF.BL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIF
{
    static class Program
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private const string forceLaunchParam = "-fl"; 

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string [] args)
        {
            bool forceLaunch = false;

            if (args.Length > 0)
               forceLaunch = args[0] == forceLaunchParam; 

            if (forceLaunch)
            {
                StartProgram();
                return;
            }

            bool createdNew = true;

            using (Mutex mutex = new Mutex(true, "MIF_searcher", out createdNew))
            {
                if (createdNew)
                {
                    StartProgram();
                }
                else
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
                }
            }
        }


        private static void StartProgram()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            Model searcher = new Model();
            IWindowManager windowManager = new WindowManager();

            MainPresenter presenter = new MainPresenter(form, searcher, windowManager);

            Application.Run(form);
        }

    }
}
