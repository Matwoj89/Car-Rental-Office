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

namespace Wypozyczalnia.Widok.Formatki
{
    public partial class MojeOkno : Form
    {
        static int numerOkna = 0;

        public MojeOkno()
        {
            InitializeComponent();
            numerOkna++;
            this.Text = String.Format("Okno2 ({0})", numerOkna);
        }

        public void ustawDane(Klient op)
        {
            this.textBox1.Text = op.Nazwisko;
            this.textBox1.Tag = op;
            this.textBox2.Text = op.Imie;
            this.dateTimePicker1.Value = op.DataUrodzenia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ISession sesja = Program.baza.SessionFactory.OpenSession())
            {
                using (ITransaction tx = sesja.BeginTransaction())
                {
                    Klient op = this.textBox1.Tag as Klient;
                    //MessageBox.Show(op.Id.ToString());
                    op.Imie = this.textBox1.Text;
                    op.Nazwisko = this.textBox2.Text;
                    op.DataUrodzenia = this.dateTimePicker1.Value.Date;

                    sesja.SaveOrUpdate(op);
                    tx.Commit();
                }

                this.Dispose();
            }
        }
    }
}
