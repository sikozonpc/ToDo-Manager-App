using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TDMLibrary;

namespace TDMForms
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

            // Initialize the database connections 
            TDMLibrary.GlobalConfig.InitializeConnection(DatabaseType.TextFile);

            Application.Run(new MainForm());
        }
    }
}
