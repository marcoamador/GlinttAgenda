using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hello(string resource,string res_action, string id)
        {
            
            return Json(new { foo = resource , baz = res_action,baz2 = Int32.Parse(id) }, JsonRequestBehavior.AllowGet);
        }
    }
}
