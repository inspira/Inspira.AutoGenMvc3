using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;
using Inspira.CodeGenerator.Mvc3Example.InversionOfControl;
using System.Reflection;
using Inspira.CodeGenerator.Infrastructure.DataAccess.NHibernate;
using NHibernate;
using Inspira.CodeGenerator.Core.CustomTypes;
using Inspira.CodeGenerator.TestModel;

namespace Inspira.CodeGenerator.Mvc3Example
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
                new [] { "Inspira.CodeGenerator.Mvc3Example.Controllers" }
            );
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
            
            ControllerBuilder.Current.SetControllerFactory(new GenericControllerFactory(Assembly.Load("Inspira.CodeGenerator.TestModel")));
            SessionManager.DomainAssembly = typeof(MyRealEntity).Assembly;
        }

        protected void Application_EndRequest()
        {
            SessionManager.FinishRequest(DependencyResolver.Current.GetService<ISession>());
        }
    }
}