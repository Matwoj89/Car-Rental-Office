using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wypozyczalnia.Klasy
{
    public class Klient
    {
        public virtual int Id { get; set; }
        public virtual string Nazwisko { get; set; }
        public virtual string Imie { get; set; }
        public virtual DateTime DataUrodzenia { get; set; }
        public virtual string Ulica { get; set; }
        public virtual string KodPocztowy { get; set; }
        public virtual string Miasto { get; set; }

        public Klient() { }

        public static IList<Klient> pobierzListe()
        {
            return Program.baza.pobierzListeObiektowKlient();
        }

        public override String ToString()
        {
            return this.Imie + " " + this.Nazwisko;
        }
    }
}
