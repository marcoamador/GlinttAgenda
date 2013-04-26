using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class VisitController : Controller
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

                Visit v = new Visit();
                String result = v.byId(id);
                if (result == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }

                try
                {
                    Common.validateXML(result, "~/xsd/visit.xsd");
                }
                catch (Common.InvalidXmlException ie)
                {
                    return Content(ie.error + result);
                }
                return Content(result);
            }
            else
            {
                Response.StatusCode = 400;
                return null;

            }
        }

        public ActionResult Hello(string resource,string res_action, string id)
        {
            return Json(new { resource = resource , resource_action = res_action,id = Int32.Parse(id),count=gE.g_doente.Count() }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Search()
        {
            Visit v = new Visit();
            String s = v.search(Request);
            if (s == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return Content(s);
        }
    }
}
