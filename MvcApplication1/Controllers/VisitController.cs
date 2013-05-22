using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
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

                MvcApplication1.Models.Visit v = new MvcApplication1.Models.Visit();
                g_cons_marc r = v.byId(id);
                int access = Common.getPrivileges(Request.Headers["accessToken"]);
                if (access == 0 || access.ToString() == r.doente)
                {
                    string result = v.visitParser(r);
                    if (result == null)
                    {
                        Response.StatusCode = 404;
                        return null;
                    }

                    try
                    {
                        Common.validateXML(result, "~/Content/xsd/visit.xsd");
                    }
                    catch (Common.InvalidXmlException ie)
                    {
                        return Content(Common.addtoxml(result, ie.error));
                    }
                    return Content(result);
                }
                else
                {
                    Response.StatusCode = 403;
                    return null;
                }
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
            int access = Common.getPrivileges(Request.Headers["accessToken"]);
            if (access == 0 || Request["doente"] == access.ToString() )
            {
                MvcApplication1.Models.Visit v = new MvcApplication1.Models.Visit();
                string s = v.search(Request);
                if (s == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                return Content(s);
            }
            else
            {
                Response.StatusCode = 403;
                return null;
            }
        }

        public ActionResult Update(String id)
        {
            MvcApplication1.Models.Visit v = new MvcApplication1.Models.Visit();
            g_cons_marc r = v.update(Request, id);
            int access = Common.getPrivileges(Request.Headers["accessToken"]);
            if (access == 0 || access.ToString() == r.doente)
            {
                string s = v.visitParser(r);
                if (s == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                return Content(s);
            }
            else
            {
                Response.StatusCode = 403;
                return null;
            }
        }
    }
}
