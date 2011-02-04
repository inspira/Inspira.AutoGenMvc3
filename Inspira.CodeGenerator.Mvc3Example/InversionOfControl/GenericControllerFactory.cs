using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using System.Web.Routing;
using Inspira.CodeGenerator.Mvc3Example.Areas.Admin.Controllers;

namespace Inspira.CodeGenerator.Mvc3Example.InversionOfControl
{
    public class GenericControllerFactory : DefaultControllerFactory
    {
        private readonly Assembly domainAssembly;
        public GenericControllerFactory(Assembly domainAssembly)
        {
            this.domainAssembly = domainAssembly;
        }

        protected override Type GetControllerType(RequestContext requestContext, string controllerName)
        {
            Type controllerType = base.GetControllerType(requestContext, controllerName);
            if (controllerType == null)
            {
                // specific controller does not exist... try the generic one
                var entityType = domainAssembly.GetType(domainAssembly.GetTypes()[0].Namespace + "." + controllerName);
                if (entityType == null)
                {
                    return null;
                }

                controllerType = typeof(GenericEntityController<>).MakeGenericType(entityType);
                //var genericViewModelType = typeof(GenericViewModel<>).MakeGenericType(entityType);
                //controllerType = typeof(GenericController<,>).MakeGenericType(entityType, genericViewModelType);
            }
            return controllerType;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            if (controllerType != null) return DependencyResolver.Current.GetService(controllerType) as IController;
            throw new HttpException(404, String.Format("The controller for path '{0}' could not be found or it does not implement IController.", requestContext.HttpContext.Request.Path));
        }
    }
}