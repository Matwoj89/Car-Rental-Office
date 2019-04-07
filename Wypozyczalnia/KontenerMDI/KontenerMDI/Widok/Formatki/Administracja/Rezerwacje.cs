using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wypozyczalnia.Klasy;

namespace Wypozyczalnia.Widok.Formatki.Administracja
{
    public partial class Rezerwacje : Form
    {
        public Rezerwacje()
        {
            InitializeComponent();
            foreach (Rezerwacja r in Program.baza.pobierzListeRezerwacji())
            {
                dodajNowyWiersz(r);
            }

        }

        public void dodajNowyWiersz(Rezerwacja rez)
        {
            DataGridViewRow wiersz = this.GListaOperatorow.RowTemplate.Clone() as DataGridViewRow;
            wiersz.CreateCells(this.GListaOperatorow);

            wiersz.Cells[0].Value = rez.klient.Imie+" "+rez.klient.Nazwisko;
            wiersz.Cells[1].Value = rez.auto.Nazwa;
            wiersz.Cells[2].Value = rez.start_rezervation+" do "+rez.end_rezervation ;
            wiersz.Cells[3].Value = rez.needRoofBagage;
            wiersz.Cells[4].Value = rez.needChildSeat;
            wiersz.Cells[5].Value = rez.needGPS;

            this.GListaOperatorow.Rows.Add(wiersz);
        }

        private void GListaOperatorow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void BDodajOperatora_Click(object sender, EventArgs e)
        {
            NowaRezerwacja rez = new NowaRezerwacja();
            rez.Rodzic = this;
            rez.Show();
        }

        
    }
}
