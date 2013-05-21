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
                MvcApplication1.Models.Patient p = new MvcApplication1.Models.Patient();
                String result = p.byId(id);
                if (result == null)
                {
                    Response.StatusCode = 404;
                    return null;
                }

                try
                {
                    Common.validateXML(result, "~/Content/xsd/patient.xsd");
                }
                catch (Common.InvalidXmlException ie)
                {
                   
                    return Content(Common.addtoxml(result,ie.error));
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
            return Content(new MvcApplication1.Models.Patient().byId(id));
        }

        public ActionResult Search()
        {
            MvcApplication1.Models.Patient p = new MvcApplication1.Models.Patient();
            String s = p.search(Request);
            if (s == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return Content(s);
        }

        public ActionResult Update(String id)
        {
            MvcApplication1.Models.Patient p = new MvcApplication1.Models.Patient();
            String s = p.update(Request, id);
            if (s == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return Content(s);
        }
    }
}
