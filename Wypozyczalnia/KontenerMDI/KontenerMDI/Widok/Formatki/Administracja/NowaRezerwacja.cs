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
    public partial class NowaRezerwacja : Form
    {
        private static NowaRezerwacja okienko;
        public Rezerwacje Rodzic { private get; set; }

        public NowaRezerwacja()
        {
            InitializeComponent();
            //this.Parent.Enabled = false;
            foreach(Klient k in Program.baza.pobierzListeObiektowKlient()){
                this.comboBox1.Items.Add(k);
            }

            foreach (Auto a in Program.baza.pobierzListeObiektowAuto())
            {
                this.comboBox2.Items.Add(a);
            }
        }

        public static NowaRezerwacja pobierzInstancjeOkna()
        {
            if (okienko == null || okienko.IsDisposed) okienko = new NowaRezerwacja();

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
                Rezerwacja op = null;

                using (ISession sesja = Program.baza.SessionFactory.OpenSession())
                {
                    op = new Rezerwacja();
                    op.klient = (Klient)this.comboBox1.SelectedItem;
                    op.auto = (Auto)this.comboBox2.SelectedItem;
                    op.start_rezervation = this.DataWypozyczenia.Value.Date;
                    op.end_rezervation = this.DataZwrotu.Value.Date;
                    op.needChildSeat = this.childSeat.Checked;
                    op.needRoofBagage = this.roofBagade.Checked;
                    op.needGPS = this.gps.Checked;

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

            

            return stan;
        }


       
    }
}
