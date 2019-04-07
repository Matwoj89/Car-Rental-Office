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
    public partial class Auta : Form
    {
        public Auta()
        {
            InitializeComponent();

            IList<Auto> towaryLista = Auto.pobierzListe();

            foreach (Auto to in towaryLista)
            {
                this.dodajNowyWiersz(to);
            }
        }

        public void dodajNowyWiersz(Auto to)
        {
            DataGridViewRow wiersz = this.GListaTowarow.RowTemplate.Clone() as DataGridViewRow;
            wiersz.CreateCells(this.GListaTowarow);

            wiersz.Cells[0].Value = to.Kod;
            wiersz.Cells[1].Value = to.Nazwa;
            wiersz.Cells[2].Value = to.Cena;
            wiersz.Cells[3].Value = "https://maps.google.com/maps?q=52.23456,20.920";

                

            this.GListaTowarow.Rows.Add(wiersz);
        }

       
        
        private void BDodajTowar_Click(object sender, EventArgs e)
        {
            NoweAuto ntow = NoweAuto.pobierzInstancjeOkna();
            ntow.MdiParent = this.MdiParent;
            ntow.Rodzic = this;
            ntow.Show();
            ntow.BringToFront();
        }

        private void GListaTowarow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
