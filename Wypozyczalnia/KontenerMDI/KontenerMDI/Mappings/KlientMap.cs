using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Wypozyczalnia.Klasy;

namespace Wypozyczalnia.Mappings
{
    public class KlientMap: ClassMap<Klient>
    {
        public KlientMap()
        {
            Table("Klienci");
            SchemaAction.All();
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Imie).Not.Nullable().Length(20);
            Map(x => x.Nazwisko).Not.Nullable().Length(30);
            Map(x => x.DataUrodzenia).Nullable();
            Map(x => x.Ulica).Not.Nullable().Length(50);
            Map(x => x.KodPocztowy).Not.Nullable().Length(6);
            Map(x => x.Miasto).Not.Nullable().Length(30).Precision(11).Scale(2);
        }
    }
}
