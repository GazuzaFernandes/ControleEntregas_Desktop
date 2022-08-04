using Logistica.Sistema_Controle_de_Preços;
using LogisticaEntregas;
using System;
using System.Windows.Forms;

namespace Logistica
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
            Application.Run(new FrmEscolherSistema());
        }
    }
}
