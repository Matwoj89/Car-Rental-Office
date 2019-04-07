using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wypozyczalnia.Klasy;
using NHibernate;

namespace Wypozyczalnia.Widok.Formatki.Administracja
{
    public partial class NoweAuto : Form
    {
        private static NoweAuto okienko;
        public Auta Rodzic { private get; set; }

        public NoweAuto()
        {
            InitializeComponent();
            //this.Parent.Enabled = false;
        }

        public static NoweAuto pobierzInstancjeOkna()
        {
            if (okienko == null || okienko.IsDisposed) okienko = new NoweAuto();

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
                Auto to = null;

                using (ISession sesja = Program.baza.SessionFactory.OpenSession())
                {
                    to = new Auto();
                    to.Kod = this.TKod.Text;
                    to.Nazwa = this.TNazwa.Text;
                    to.Cena = this.TCena.Text;
                   

                    sesja.Save(to);
                    sesja.Flush();
                }

                if (this.Rodzic != null) this.Rodzic.dodajNowyWiersz(to);

                this.Dispose();
            }
        }

        private bool walidacjaDanych()
        {
            bool stan = true;
            this.error.Clear();

            if (this.TNazwa.Text.Equals(""))
            {
                stan = false;
                this.error.SetError(this.TNazwa, "Podaj nazwę!");
            }

            if (this.TKod.Text.Equals(""))
            {
                stan = false;
                this.error.SetError(this.TKod, "Podaj kod!");
            }

            return stan;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
