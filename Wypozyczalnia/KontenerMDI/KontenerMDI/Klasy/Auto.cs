using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Wypozyczalnia.Klasy
{
    public class Auto
    {
        public virtual int Id { get; set; }
        public virtual string Kod { get; set; }
        public virtual string Nazwa { get; set; }
        public virtual string Cena { get; set; }

        public Auto() { }

        public static IList<Auto> pobierzListe()
        {
            return Program.baza.pobierzListeObiektowAuto();
        }

        public override String ToString()
        {
            return this.Nazwa;
        }
    }
}