using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ocenka_mer_svyzei
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mdi_form());
        }
    }
}