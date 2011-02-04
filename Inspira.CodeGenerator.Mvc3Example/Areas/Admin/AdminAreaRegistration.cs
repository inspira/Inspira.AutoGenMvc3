using System.Web.Mvc;

namespace Inspira.CodeGenerator.Mvc3Example.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Admin_home_default",
                "Admin/",
                new { action = "Index", controller = "Home" },
                null,
                new[] { "Inspira.CodeGenerator.Mvc3Example.Areas.Admin.Controllers" }
            );

            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "List", id = UrlParameter.Optional },
                null,
                new[] { "Inspira.CodeGenerator.Mvc3Example.Areas.Admin.Controllers" }
            );
        }
    }
}
