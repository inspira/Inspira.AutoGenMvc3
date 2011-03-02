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
using Inspira.AutoGenMvc3.TestModel;

namespace Inspira.AutoGenMvc3.Infrastructure.DataAccess.NHibernate
{
    public class SessionManager
    {
        internal static ISessionFactory sessionFactory;
        internal static ISessionFactory CreateSessionFactory()
        {
            sessionFactory = Web.Generics.ApplicationManager.CreateSessionFactory();
            return sessionFactory;
        }

        public static ISession GetNewSession()
        {
            return sessionFactory.OpenSession();
        }

        public static void FinishRequest(ISession session)
        {
        }
    }
}