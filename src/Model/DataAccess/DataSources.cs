using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentManager.Model.DataAccess
{
    class DataSources
    {
        private static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(SQLiteConfiguration.Standard.UsingFile("firstProject.db"))
                .Mappings(x => x.FluentMappings.AddFromAssemblyOf<DataSources>())
                .BuildSessionFactory();
        }
    }
}
