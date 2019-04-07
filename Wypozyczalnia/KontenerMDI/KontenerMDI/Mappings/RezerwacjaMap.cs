using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wypozyczalnia.Klasy;
using FluentNHibernate.Mapping;

namespace Wypozyczalnia.Mappings
{
    public class RezerwacjaMap : ClassMap<Rezerwacja>
    {
        public RezerwacjaMap()
        {
            Table("Rezerwacje");
            Id(x => x.Id).GeneratedBy.Identity();
            References(x => x.klient);
            References(x => x.auto);
            Map(x=>x.start_rezervation);
            Map(x=>x.end_rezervation);
            Map(x => x.needChildSeat);
            Map(x=>x.needRoofBagage);
            Map(x=>x.needGPS);
            
        }
    }
}
