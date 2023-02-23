using System;
using System.Windows.Forms;

namespace INF36207.TP2.Md5PasswordFinder
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PasswordDictionarySelectForm());
        }
    }
}
