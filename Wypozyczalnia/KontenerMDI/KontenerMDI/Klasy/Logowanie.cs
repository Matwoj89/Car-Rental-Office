using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wypozyczalnia.Interfejsy;

namespace Wypozyczalnia.Klasy
{
    
    class Logowanie: ILogowanie
    {
        private IList<Uzytkownik> uzytkownicy;

        public Logowanie() {
            uzytkownicy = new List<Uzytkownik>();
            uzytkownicy.Add(new Uzytkownik("admin", "12345"));
            uzytkownicy.Add(new Uzytkownik("admin2", "abcde"));
        }

        public bool zaloguj(Uzytkownik user){
               foreach(Uzytkownik u in uzytkownicy){
                    if(user.login==u.login && user.haslo==u.haslo){
                        return true;
                    }
               }
            return false;
        }
    }
}
