using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Inspira.CodeGenerator.TestModel;
using NHibernate;

namespace Inspira.CodeGenerator.Mvc3Example.Areas.Admin.Controllers
{
    //[Authorize]
    public class GenericEntityController<T> : Controller where T : class, new()
    {
        private readonly ISession session;
        public GenericEntityController(ISession session) {
            this.session = session;
        }

        public ActionResult List()
        {
            if (Request["ShowDeleteMessage"] != null) ViewBag.ShowDeleteMessage = Boolean.Parse(Request["ShowDeleteMessage"]);
            if (Request["ShowCreateMessage"] != null) ViewBag.ShowCreateMessage = Boolean.Parse(Request["ShowCreateMessage"]);
            if (Request["ShowEditMessage"] != null) ViewBag.ShowEditMessage = Boolean.Parse(Request["ShowEditMessage"]);

            var items = session.CreateCriteria<T>().List<T>();
            return View(items);
        }

        public ActionResult Create()
        {
            return View(new T());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(T obj)
        {
            if (!ModelState.IsValid) return View(obj);
            session.Save(obj);
            return RedirectToAction("List", new { ShowCreateMessage = true });
        }

        public ActionResult Edit(String id)
        {
            Object typedId = GuessTypedId(id);
            T entity = session.Get<T>(typedId);

            return View(entity);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(T obj, FormCollection formValues)
        {
            if (!ModelState.IsValid) return View(obj);
            session.Merge(obj);
            return RedirectToAction("List", new { ShowEditMessage = true });
        }

        public ActionResult Delete(String id)
        {
            Object typedId = GuessTypedId(id);
            T entity = session.Get<T>(typedId);

            session.Delete(entity);
            return RedirectToAction("List", new { ShowDeleteMessage = true });
        }

        private object GuessTypedId(string id)
        {
            Guid guid;
            Int32 intId;
            if (Guid.TryParse(id, out guid))
            {
                return guid;
            }
            else if (Int32.TryParse(id, out intId))
            {
                return intId;
            }
            else
            {
                return id;
            }
        }
    }
}