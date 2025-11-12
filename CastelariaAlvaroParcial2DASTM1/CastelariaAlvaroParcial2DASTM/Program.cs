using Controladora;
using System.Windows.Forms;
using Vista;

namespace Vista
{
    internal static class Program
    {
        /// <summary>
        /// El punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        { 
            ApplicationConfiguration.Initialize();
            Application.Run(new FormLoginAlta());
        }
    }
}