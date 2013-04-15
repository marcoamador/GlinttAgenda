using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        glinttEntities gE;
        protected override void Initialize(RequestContext rc)
        {
            base.Initialize(rc);
            gE = new glinttEntities();
        }
 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hello(string resource,string res_action, string id)
        {
            
            
            return Json(new { foo = resource , baz = res_action,baz2 = Int32.Parse(id),count=gE.g_doente.Count() }, JsonRequestBehavior.AllowGet);
        }
    }
}
