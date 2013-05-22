using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class PractitionerController : Controller
    {
        glinttEntities gE;
        glinttLocalEntities glE;
        protected override void Initialize(RequestContext rc)
        {
            base.Initialize(rc);
            gE = new glinttEntities();
            glE = new glinttLocalEntities();
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
                int access = Common.getPrivileges(Request.Headers["accessToken"]);
                if (access == 0)
                {
                    MvcApplication1.Models.Practitioner p = new MvcApplication1.Models.Practitioner();
                    String result = p.byId(id);
                    if (result == null)
                    {
                        Response.StatusCode = 404;
                        return null;
                    }

                    try
                    {
                        Common.validateXML(result, "~/Content/xsd/practitioner.xsd");
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

        public ActionResult Search()
        {
            int access = Common.getPrivileges(Request.Headers["accessToken"]);
            if (access == 0)
            {
                MvcApplication1.Models.Practitioner pr = new MvcApplication1.Models.Practitioner();
                String s = pr.search(Request);
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
            int access = Common.getPrivileges(Request.Headers["accessToken"]);
            if (access == 0)
            {
                MvcApplication1.Models.Practitioner pr = new MvcApplication1.Models.Practitioner();
                String s = pr.update(Request, id);
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
