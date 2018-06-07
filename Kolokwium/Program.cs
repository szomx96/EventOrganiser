using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kolokwium.Models;
using Kolokwium.Views;
using Kolokwium.Presenters;

namespace Kolokwium
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model model = new Model();
            MainApp view = new MainApp();
            Presenter presenter = new Presenter(model, view);

            Application.Run(view);
        }
    }
}
