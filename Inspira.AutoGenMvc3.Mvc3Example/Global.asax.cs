using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using Inspira.AutoGenMvc3.Mvc3Example.InversionOfControl;
using System.Reflection;
using Inspira.AutoGenMvc3.Infrastructure.DataAccess.NHibernate;
using NHibernate;
using Inspira.AutoGenMvc3.Core.CustomTypes;
using Inspira.AutoGenMvc3.TestModel;

namespace Inspira.AutoGenMvc3.Mvc3Example
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new SessionStateAttribute(SessionStateBehavior.Disabled));
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{name}.ico");
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                null,
                new [] { "Inspira.AutoGenMvc3.Mvc3Example.Controllers" }
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            
            ControllerBuilder.Current.SetControllerFactory(new GenericControllerFactory(Assembly.Load("Inspira.AutoGenMvc3.TestModel")));
            SessionManager.DomainAssembly = typeof(MyRealEntity).Assembly;
        }

        protected void Application_EndRequest()
        {
            SessionManager.FinishRequest(DependencyResolver.Current.GetService<ISession>());
        }
    }
}