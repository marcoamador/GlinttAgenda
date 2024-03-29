﻿using System;
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
        glinttlocalEntities glE;
        protected override void Initialize(RequestContext rc)
        {
            base.Initialize(rc); 
            gE = new glinttEntities();
            glE = new glinttlocalEntities();
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
                string access = Common.getPrivileges(Request.QueryString["accessToken"]);
                if (access == "0" || access == id)
                {
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
            else if (Request.HttpMethod.Equals("PUT"))
            {
                string access = Common.getPrivileges(Request.QueryString["accessToken"]);
                if (access == "0" || access == id)
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
                else
                {
                    Response.StatusCode = 403;
                    return null;
                }
            }
            else
            {
                Response.StatusCode = 403;
                return null;
            } 

        }

        public ActionResult SearchById(String id)
        {

            string access = Common.getPrivileges(Request.QueryString["accessToken"]);
            if (access == "0" || access == id)
            {
                return Content(new MvcApplication1.Models.Patient().byId(id));
            }
            else
            {
                Response.StatusCode = 403;
                return null;
            }
        }

        public ActionResult Search()
        {
            string access = Common.getPrivileges(Request.QueryString["accessToken"]);
            if (access == "0")
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
            else
            {
                Response.StatusCode = 403;
                return null;
            }
        }

        public ActionResult Update(String id)
        {
            string access = Common.getPrivileges(Request.QueryString["accessToken"]);
            if (access == "0" || access == id)
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
            else
            {
                Response.StatusCode = 403;
                return null;
            }
        }


        public ActionResult setPassword(String id)
        {
            string access = Common.getPrivileges(Request.QueryString["accessToken"]);
            if (access == "0" || access == id)
            {
                MvcApplication1.Models.Patient p = new Patient();
                if(p.setPassword(id,Request.QueryString["oldpassword"],Request.QueryString["newpassword"]))
                {
                    return Content("ok");
                }
                return Content("wrong password");
            }
            else
            {
                Response.StatusCode = 403;
                return null;
            }
        }

        public ActionResult removePassword(String id)
        {
            string access = Common.getPrivileges(Request.QueryString["accessToken"]);
            if (access == "0" || access == id)
            {
                MvcApplication1.Models.Patient p = new Patient();
                if (p.removePassword(id,Request.QueryString["password"]))
                {
                    return Content("ok");
                }
                return Content("wrong password");
            }
            else
            {
                Response.StatusCode = 403;
                return null;
            }
        }

    }
}
