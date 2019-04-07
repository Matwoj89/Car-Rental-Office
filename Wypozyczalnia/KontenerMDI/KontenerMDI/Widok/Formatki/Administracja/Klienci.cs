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
    public partial class Klienci : Form
    {
        public Klienci()
        {
            InitializeComponent();

            IList<Klient> operatorzyLista = Klient.pobierzListe();

            foreach (Klient op in operatorzyLista)
            {
                this.dodajNowyWiersz(op);
            }
        }

        public void dodajNowyWiersz(Klient op)
        {
            DataGridViewRow wiersz = this.GListaOperatorow.RowTemplate.Clone() as DataGridViewRow;
            wiersz.CreateCells(this.GListaOperatorow);

            wiersz.Cells[0].Value = op.Nazwisko;
            wiersz.Cells[1].Value = op.Imie;
            wiersz.Cells[2].Value = op.DataUrodzenia;
            wiersz.Cells[3].Value = op.Miasto;

            this.GListaOperatorow.Rows.Add(wiersz);
        }

        private void BDodajOperatora_Click(object sender, EventArgs e)
        {
            NowyKlient nope = NowyKlient.pobierzInstancjeOkna();
            nope.MdiParent = this.MdiParent;
            nope.Rodzic = this;
            nope.Show();
            nope.BringToFront();
        }

      

      
    }
}
