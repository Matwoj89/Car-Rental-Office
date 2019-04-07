using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wypozyczalnia.Klasy;

namespace Wypozyczalnia.Interfejsy
{
    public interface ILogowanie
    {
        Boolean zaloguj(Uzytkownik user);
    }
}
