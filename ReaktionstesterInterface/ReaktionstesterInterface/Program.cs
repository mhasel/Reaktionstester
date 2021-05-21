using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReaktionstesterInterface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // DPI Awareness für Vista oder höher
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }

            /* Teil der WinAPI "user32.dll" importieren
             * "Many C# functions are behind the scenes actually wrapper implementations for operating system functions.
             * Some of the more specific methods do not have C# equivalents
             * - use the [DllImport] attribute to access them anyway"
             */
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
