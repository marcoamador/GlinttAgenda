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

        public ActionResult Search( string id)
        {

       
            return Content(new PatientModel().byId(id)) ;
        }
    }
}
