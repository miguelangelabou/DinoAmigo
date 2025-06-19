using System;
using System.Windows.Forms;

namespace MiniGameHub
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Application.EnableVisualStyles(); // Obsolete for .NET 6+
            // Application.SetCompatibleTextRenderingDefault(false); // Obsolete for .NET 6+
            ApplicationConfiguration.Initialize(); // For .NET 6 and later
            Application.Run(new LoginForm()); // Changed Form1 to LoginForm
        }
    }
}
