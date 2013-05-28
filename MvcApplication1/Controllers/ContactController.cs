using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication1.Controllers
{
    public class ContactController : Controller
    {
        glinttEntities gE;
        glinttLocalEntities glE;
        protected override void Initialize(RequestContext rc)
        {
            base.Initialize(rc);
            gE = new glinttEntities();
            glE = new glinttLocalEntities();
        }

        public ActionResult Index(string id)
        {
            return View();
        }

    }
}
