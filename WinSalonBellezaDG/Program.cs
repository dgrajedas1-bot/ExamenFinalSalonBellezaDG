using System;
using System.Windows.Forms;

namespace WinSalonBellezaDG
{
    /// <summary>
    /// Punto de entrada de la aplicación Windows Forms.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Inicia el formulario principal.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSalonBellezaDG());
        }
    }
}
