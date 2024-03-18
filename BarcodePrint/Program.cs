using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodePrint.Models;
using BarcodePrint.Views;
using BarcodePrint._Repositories;
using BarcodePrint.Presenters;
using System.Configuration;

namespace BarcodePrint
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["LSBUDBConnection"].ConnectionString;
            IMainView View = new MainView();
            new MainPresenter(View, sqlConnectionString);
            Application.Run((Form)View);
        }
    }
}
