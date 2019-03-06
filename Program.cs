using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsForms
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DateTime exeStart = DateTime.Now;

            // Les 3 lignes suivantes sont déjà dans votre code.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            TimeSpan exeDuration = DateTime.Now.Subtract(exeStart);

            string exeTime = string.Format(
                "Temps d'exécution : {0}h, {1}m, {2}s et {3}ms.",
                exeDuration.Hours,
                exeDuration.Minutes,
                exeDuration.Seconds,
                exeDuration.Milliseconds);

            Console.WriteLine(exeTime);
        }
    }
}
