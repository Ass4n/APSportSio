using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APProjetSport
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (FormConnexion connexion = new FormConnexion())
            {
                if (connexion.ShowDialog() == DialogResult.OK)
                {
                    Application.Run(new AGestion(connexion.Login));
                }
            }

        }
    }
}
