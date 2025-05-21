using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace sliding_menue
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string staff;
        [STAThread]
        static void Main()
        {  
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
