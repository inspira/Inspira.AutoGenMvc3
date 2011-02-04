using StructureMap;
using NHibernate;
using NHibernate.Context;
using System.Web;
using Inspira.CodeGenerator.Infrastructure.DataAccess.NHibernate;

namespace Inspira.CodeGenerator.Mvc3Example.InversionOfControl {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<ISession>().Use(() => {
                                ISession session = (ISession)HttpContext.Current.Items["NHibernateSession"];
                                if (session == null) {
                                    HttpContext.Current.Items["NHibernateSession"] = session = SessionManager.GetNewSession();
                                }
                                return session;
                            });
                            //x.For<System.Web.Mvc.IControllerActivator>().Use<CustomControllerActivator>(); 
            //                x.For<IExample>().Use<Example>();
                        });

            

            return ObjectFactory.Container;
        }
    }
}