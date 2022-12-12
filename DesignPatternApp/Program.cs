using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // A legjobb megközelítés a SystemAware lenne (alapértelmezett), de azzal nem jól skálázza
            // a rajzokat nagy DPI-n.
            Application.SetHighDpiMode(HighDpiMode.DpiUnawareGdiScaled);

            var mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}
