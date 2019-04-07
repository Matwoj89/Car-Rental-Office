using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace Wypozyczalnia.Klasy.Db
{
    class BazaDanych
    {
        private ISessionFactory _factory;
        public ISessionFactory SessionFactory
        {
            get
            {
                return this._factory;
            }
        }

        public BazaDanych()
        {
            this._factory = BazaDanych.CreateSessionFactory();
        }

        private static void CreateDataBase(Configuration cfg)
        {
            var schema = new SchemaExport(cfg);
            //schema.Drop(true, true);
            schema.Create(true,true);
                
        }

        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile("baza_danych.db").ShowSql)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Klient>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Auto>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Rezerwacja>())

                .ExposeConfiguration(CreateDataBase)
                .BuildSessionFactory();
        }

        public IList<Klient> pobierzListeObiektowKlient()
        {
            using (ISession sesja = _factory.OpenSession())
            {
                ICriteria criteria = sesja.CreateCriteria<Klient>();
                return criteria.List<Klient>();
            }
        }

        public IList<Auto> pobierzListeObiektowAuto()
        {
            using (ISession sesja = _factory.OpenSession())
            {
                ICriteria criteria = sesja.CreateCriteria<Auto>();
                return criteria.List<Auto>();
            }
        }

        public IList<Rezerwacja> pobierzListeRezerwacji()
        {
            using (ISession sesja = _factory.OpenSession())
            {
                ICriteria criteria = sesja.CreateCriteria<Rezerwacja>();
                return criteria.List<Rezerwacja>();
            }
        }

        public void zapiszKlient(Klient klient)
        {
            using (ISession sesja = _factory.OpenSession())
            {
                sesja.Save(klient);
            }
        }

        public void zapiszAuto(Auto auto)
        {
            using (ISession sesja = _factory.OpenSession())
            {
                sesja.Save(auto);
            }
        }

    }
}
