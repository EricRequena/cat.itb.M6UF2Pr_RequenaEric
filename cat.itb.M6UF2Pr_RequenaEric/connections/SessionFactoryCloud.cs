using cat.itb.M6UF2Pr_RequenaEric.model;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Criterion;

namespace cat.itb.M6UF2Pr_RequenaEric
{
    public class SessionFactoryCloud
    {
        private static string ConnectionString = "Server=salt.db.elephantsql.com;Port=5432;Database=phdzlzpl;User Id=phdzlzpl;Password=7xi_qER1xx5nR7XoU6Bqi-lgAS2lLgU5;";
        private static ISessionFactory session;

        public static ISessionFactory CreateSession()
        {
            if (session != null)
                return session;

            IPersistenceConfigurer configDB = PostgreSQLConfiguration.PostgreSQL82.ConnectionString(ConnectionString);
            var configMap =
                Fluently.Configure().Database(configDB)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Emloyee>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Order>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Product>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Supplier>());

            session = configMap.BuildSessionFactory();

            return session;
        }

        public static ISession Open()
        {
            return CreateSession().OpenSession();
        }
    }
}
