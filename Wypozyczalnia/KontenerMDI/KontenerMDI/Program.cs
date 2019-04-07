using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Wypozyczalnia.Widok.Formatki;
using Wypozyczalnia.Klasy.Db;
using NHibernate;
using Wypozyczalnia.Klasy;
using Wypozyczalnia.Widok.Formatki;

namespace Wypozyczalnia
{
    static class Program
    {
        public static BazaDanych baza = new BazaDanych();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogowanieForm());
        }
    }
}
