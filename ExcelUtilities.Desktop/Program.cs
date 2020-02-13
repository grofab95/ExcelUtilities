using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelUtilities.Desktop
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
            AppDomain.CurrentDomain.UnhandledException += HandleUnanticipatedErrors;
            Application.Run(new MainWindow());
        }

        private static void HandleUnanticipatedErrors(object sender,
            UnhandledExceptionEventArgs exceptionEventArgs) =>
            MessageBox.Show(((Exception)exceptionEventArgs.ExceptionObject).Message,
                "Bład",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop);
    }
}
