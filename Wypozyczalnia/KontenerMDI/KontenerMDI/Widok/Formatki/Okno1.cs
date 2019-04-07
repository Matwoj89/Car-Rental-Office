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
using Wypozyczalnia.Widok.Formatki.Administracja;

namespace Wypozyczalnia.Widok.Formatki
{
    public partial class Okno1 : Form
    {
        public Okno1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MojeOkno ok2 = new MojeOkno();

            using (ISession sesja = Program.baza.SessionFactory.OpenSession())
            {
                Klient op1 = sesja.Get<Klient>(1);
                ok2.ustawDane(op1);
            }

            ok2.MdiParent = this;
            ok2.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void okno3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Okno3 ok3 = Okno3.pobierzInstancjeOkna();
            ok3.MdiParent = this;
            ok3.Show();
            ok3.BringToFront();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zamknijBiezaceOknoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild.Name.Equals("MojeOkno"))
            {
                MojeOkno ok = (MojeOkno)this.ActiveMdiChild;
                ok.Dispose();
            }
            else if (this.ActiveMdiChild.Name.Equals("Okno3"))
            {
                Okno3 ok3 = (Okno3)this.ActiveMdiChild;
                ok3.Dispose();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Okno3 ok3 = Okno3.pobierzInstancjeOkna();
            ok3.MdiParent = this;
            ok3.Show();
        }

        private void operatorzyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Klienci ope = new Klienci();
            ope.MdiParent = this;
            ope.Show();
        }

        private void towaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auta ope = new Auta();
            ope.MdiParent = this;
            ope.Show();
        }

        private void administracjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rezerwacjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rezerwacje rezerwacjeForm = new Rezerwacje();
            rezerwacjeForm.MdiParent = this;
            rezerwacjeForm.Show();
        }
    }
}
