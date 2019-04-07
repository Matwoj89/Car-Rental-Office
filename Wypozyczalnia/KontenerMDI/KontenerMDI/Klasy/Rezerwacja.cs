using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wypozyczalnia.Klasy
{
    public class Rezerwacja
    {
        public virtual int Id { get; set; }
        public virtual Klient klient { get; set; }
        public virtual Auto auto { get; set; }
        public virtual DateTime start_rezervation { get; set; }
        public virtual DateTime end_rezervation { get; set; }
        public virtual bool needChildSeat { get; set; }
        public virtual bool needRoofBagage { get; set; }
        public virtual bool needGPS { get; set; }




    }
}
