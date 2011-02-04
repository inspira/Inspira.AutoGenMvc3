using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Inspira.CodeGenerator.Mvc3Example.InversionOfControl
{
    public class CustomControllerActivator : IControllerActivator
    {
        IController IControllerActivator.Create(RequestContext requestContext, Type controllerType)
        {
            var controller = DependencyResolver.Current.GetService(controllerType) as IController;
            if (controller == null)
            {
                throw new HttpException(404, "Not found");
            }
            return controller;
        }
    }

}