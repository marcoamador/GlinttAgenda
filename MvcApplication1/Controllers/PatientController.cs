using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class PatientController : Controller
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

        public ActionResult SearchById(String id)
        {

            return Content(new Patient().byId(id)) ;
        }

        public ActionResult SearchField()
        {
            return Content(new Patient().search(Request.Params));
        }
    }
}
