using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using Wypozyczalnia.Klasy;

namespace Wypozyczalnia.Widok.Formatki.Administracja
{
    public partial class NowyKlient : Form
    {
        private static NowyKlient okienko;
        public Klienci Rodzic { private get; set; }

        public NowyKlient()
        {
            InitializeComponent();
            //this.Parent.Enabled = false;
        }

        public static NowyKlient pobierzInstancjeOkna()
        {
            if (okienko == null || okienko.IsDisposed) okienko = new NowyKlient();

            return okienko;
        }

        private void BAnuluj_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BZapisz_Click(object sender, EventArgs e)
        {
            if (this.walidacjaDanych())
            {
                Klient op = null;

                using (ISession sesja = Program.baza.SessionFactory.OpenSession())
                {
                    op = new Klient();
                    op.Imie = this.TImie.Text;
                    op.Nazwisko = this.TNazwisko.Text;
                    op.DataUrodzenia = this.DDataUrodzenia.Value.Date;
                    op.Ulica = this.TUlica.Text;
                    op.KodPocztowy = this.TKodPocztowy.Text;
                    op.Miasto = this.TMiasto.Text;

                    sesja.Save(op);
                    sesja.Flush();
                }

                if (this.Rodzic != null) this.Rodzic.dodajNowyWiersz(op);

                this.Dispose();
            }
        }

        private bool walidacjaDanych()
        {
            bool stan = true;
            this.error.Clear();

            if (this.TNazwisko.Text.Equals(""))
            {
                stan = false;
                this.error.SetError(this.TNazwisko, "Podaj nazwisko!");
            }

            if (this.TImie.Text.Equals(""))
            {
                stan = false;
                this.error.SetError(this.TImie, "Podaj imie!");
            }

            return stan;
        }
    }
}
