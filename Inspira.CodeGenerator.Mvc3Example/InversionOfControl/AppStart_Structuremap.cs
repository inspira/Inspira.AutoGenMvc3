using System.Web.Mvc;
using StructureMap;

[assembly: WebActivator.PreApplicationStartMethod(typeof(Inspira.CodeGenerator.Mvc3Example.InversionOfControl.AppStart_Structuremap), "Start")]

namespace Inspira.CodeGenerator.Mvc3Example.InversionOfControl
{
    public static class AppStart_Structuremap {
        public static void Start() {
            var container = (IContainer) IoC.Initialize();
            DependencyResolver.SetResolver(new SmDependencyResolver(container));
        }
    }
}