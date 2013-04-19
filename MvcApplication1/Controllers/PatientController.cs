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

        public ActionResult Index(String id)
        {
            if (Request.HttpMethod.Equals("GET"))
            {
                if (id == null || id.Equals(""))
                {
                    Response.StatusCode = 404;
                    return null;
                }
                Patient p = new Patient();
                String result = p.byId(id);
                if (result == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                return Content(result);
            }
            else {
                Response.StatusCode = 400;
                return null;
            
            }
        }

        public ActionResult SearchById(String id)
        {

            return Content(new Patient().byId(id)) ;
        }

        public ActionResult Search()
        {
            Patient p = new Patient();
            String s = p.search(Request);
            if (s == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return Content(s);
        }
    }
}
