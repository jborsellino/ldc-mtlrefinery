using System;
using System.Windows.Forms;

namespace Suncor_LdtConduitesUI
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

            // Initialize the database connection
            Suncor_LdtConduitesLibrary.GlobalConfig.InitializeConnection(true);

            Application.Run(new ListeDesConduitesMainForm());
        }
    }
}
