using System;
using System.Windows.Forms;

namespace MakePasswords
{
    static class Program
    {
        public static string strVersion = "v1.1";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
