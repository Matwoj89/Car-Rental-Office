using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wypozyczalnia.Klasy
{
    public class Uzytkownik
    {
         public String login;
         public String haslo;

        public Uzytkownik(String login,String haslo)
        {
            this.login = login;
            this.haslo = haslo;
        }
    }
}
