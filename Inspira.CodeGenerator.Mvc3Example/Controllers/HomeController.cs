﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inspira.CodeGenerator.Mvc3Example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content("<a href=Admin/>Admin</a>");
        }

    }
}
