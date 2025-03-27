using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace CadastroImobiliaria
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new FormPrincipal());
        }
    }
}