using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wypozyczalnia.Klasy;
using FluentNHibernate.Mapping;

namespace Wypozyczalnia.Mappings
{
    public class AutoMap : ClassMap<Auto>
    {
        public AutoMap()
        {
            Table("Auta");
            SchemaAction.All();
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Kod).Not.Nullable().Length(20);
            Map(x => x.Nazwa).Not.Nullable().Length(30);
            Map(x => x.Cena).Nullable().Length(20);
        }
    }
}
