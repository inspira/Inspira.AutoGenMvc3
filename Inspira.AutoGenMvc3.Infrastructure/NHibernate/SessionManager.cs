using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate;
using System.Reflection;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Automapping;
using NHibernate.Context;
using FluentNHibernate.Cfg;

namespace Inspira.AutoGenMvc3.Infrastructure.DataAccess.NHibernate
{
    public class SessionManager
    {
        public static Assembly DomainAssembly { get; set; }
        public static String ConfigurationPath { get; set; }

        private static ISessionFactory sessionFactory;
        internal static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    sessionFactory = CreateSessionFactory();
                }
                return sessionFactory;
            }
        }

        internal static ISessionFactory CreateSessionFactory()
        {
            var nhConfiguration = new Configuration();
            if (String.IsNullOrWhiteSpace(ConfigurationPath))
            {
                nhConfiguration.Configure();
            }
            else
            {
                nhConfiguration.Configure(ConfigurationPath);
            }
            //return nhConfiguration.BuildSessionFactory();            

            //var assembly = Assembly.Load("Inspira.AutoGenMvc3.TestModel.dll");
            var autoMap = AutoMap.Assembly(DomainAssembly, new DefaultAutomappingConfiguration());
            autoMap.UseOverridesFromAssembly(Assembly.GetExecutingAssembly());

            autoMap.Conventions.Add(
                DefaultCascade.SaveUpdate(),
                DefaultLazy.Always(),
                /*new ColumnNullabilityConvention(),
                new ForeignKeyConstraintNameConvention(),
                new StringColumnLengthConvention(),
                new EnumConvention(),*/
                ForeignKey.EndsWith("_ID"),
                ConventionBuilder.Reference.Always(x => x.Not.Nullable()),
                ConventionBuilder.Reference.Always(x => x.Cascade.None()),
                ConventionBuilder.HasMany.Always(x => x.Inverse())
            );

            var sessionFactory = Fluently.Configure(nhConfiguration)
                .Mappings(m => m.AutoMappings.Add(autoMap))
                .BuildSessionFactory();

            return sessionFactory;
        }

        public static ISession GetNewSession()
        {
            if (SessionFactory == null) throw new ApplicationException("Session factory not configured. Did you call ApplicationManager.Initialize()?");
            return SessionFactory.OpenSession();
        }

        public static void FinishRequest(ISession session)
        {
            if (session != null)
            {
                if (session.Transaction != null && session.Transaction.IsActive)
                {
                    session.Transaction.Rollback();
                }
                else
                {
                    session.Flush();
                }
                session.Close();
            }
        }
    }
}