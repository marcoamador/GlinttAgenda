using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MvcApplication1.Models;
using System.Xml;
using System.IO;

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
            Response.AppendHeader("Access-Control-Allow-Origin", "*");

            string access = Common.getPrivileges(Request.QueryString["accessToken"]);

            if (id == null || id.Equals("") || access == "-1")
            {
                Response.StatusCode = 404;
                return null;
            }

            MvcApplication1.Models.Practitioner p = new MvcApplication1.Models.Practitioner();
            String result = p.byId(id);
            if (result == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            if (access != "0")
            {
                result = trimPractitionerResource(result);
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


        private string trimPractitionerResource(string result)
        {
            
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(result);

            XmlDocument trimdxdoc = new XmlDocument();
            trimdxdoc.AppendChild(trimdxdoc.CreateProcessingInstruction("xml", "version=\"1.0\" encoding=\"UTF-16\""));
            XmlNode x = xdoc.DocumentElement.ParentNode.FirstChild.NextSibling;

            if (x != null)
            {
                XmlElement t = trimdxdoc.CreateElement( x.LocalName, x.NamespaceURI);
                trimdxdoc.AppendChild(t);

                XmlNodeList x1 = xdoc.GetElementsByTagName("identifier");
                XmlElement t1 = trimdxdoc.CreateElement(x1.Item(0).Name);
                t1.InnerXml = x1.Item(0).InnerXml;
                

                XmlElement d = trimdxdoc.CreateElement("details");
                
                XmlNodeList x2 = xdoc.GetElementsByTagName("name");
                XmlElement t2 = trimdxdoc.CreateElement(x2.Item(0).Name);
                t2.InnerXml = x2.Item(0).InnerXml;
                d.AppendChild(t2);

                XmlNodeList x3 = xdoc.GetElementsByTagName("telecom");
                XmlElement t3 = trimdxdoc.CreateElement(x3.Item(0).Name);
                t3.InnerXml = x3.Item(0).InnerXml;
                d.AppendChild(t3);

                trimdxdoc.DocumentElement.AppendChild(d);
                trimdxdoc.DocumentElement.AppendChild(t1);

                //trimdxdoc.DocumentElement.RemoveAllAttributes();
            }
            StringWriter sw = new StringWriter();
            XmlWriter xmlw = XmlWriter.Create(sw);
            trimdxdoc.WriteTo(xmlw);
            xmlw.Flush();

            return sw.GetStringBuilder().ToString();
             
        }
        

        public ActionResult Search()
        {
            Response.AppendHeader("Access-Control-Allow-Origin", "*");

            string access = Common.getPrivileges(Request.QueryString["accessToken"]);
            
            if (access == "-1")
            {
                Response.StatusCode = 404;
                return null;
            }

            MvcApplication1.Models.Practitioner pr = new MvcApplication1.Models.Practitioner();
            String s = pr.search(Request);
            if (s == null)
            {
                Response.StatusCode = 404;
                return null;
            }

            if (access != "0")
            {
                s = trimPractitionerResource(s);
            }

            return Content(s);

        }

        public ActionResult Update(String id)
        {
            Response.AppendHeader("Access-Control-Allow-Origin", "*");

            string access = Common.getPrivileges(Request.QueryString["accessToken"]);
            if (access == "0")
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
