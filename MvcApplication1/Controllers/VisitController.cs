using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Web.Routing;
using MvcApplication1.Models;
using System.Xml;
using System.IO;

namespace MvcApplication1.Controllers
{
	public class VisitController : Controller
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

				MvcApplication1.Models.Visit v = new MvcApplication1.Models.Visit();
				g_cons_marc r = v.byId(id);
				MvcApplication1.visit rV = v.localDataById(id);
				string access = Common.getPrivileges(Request.QueryString["accessToken"]);

				if (access == "-1")
				{
					Response.StatusCode = 404;
					return null;
				}

				string result = v.visitParser(r, rV, access);
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
				Response.StatusCode = 404;
				return null;
			}

		}


		public ActionResult Search()
		{
			
			string access = Common.getPrivileges(Request.QueryString["accessToken"]);
			MvcApplication1.Models.Visit v = new MvcApplication1.Models.Visit();

			string s = v.search(Request,access);

			if (s == null)
			{
				Response.StatusCode = 404;
				return null;
			}
			return Content(s);
		}

		public ActionResult Update(String id)
		{
			
			MvcApplication1.Models.Visit v = new MvcApplication1.Models.Visit();

			string access = Common.getPrivileges(Request.QueryString["accessToken"]);
			if (access == "0")
			{
				String s = v.update(Request, id,access);
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

        public ActionResult Create()
        {
            MvcApplication1.Models.Visit v = new Visit();
            string access = Common.getPrivileges(Request.QueryString["accessToken"]);
            if (access == "0")
            {
                String s = v.create(Request);
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

        public ActionResult getServices()
        {
            System.Data.Entity.Infrastructure.DbSqlQuery<g_serv> g = gE.g_serv.SqlQuery("Select * from g_serv", new List<object>() { });
            int n = g.Count();
            if (n != 0)
            {
                Dictionary<string, string> d = new Dictionary<string, string>();
                for (int i = 0; i < n; i++)
                {
                    g_serv srv = g.ElementAt(i);
                    d.Add(srv.cod_serv, srv.descr_serv);
                }
                return Content(d.ToJSON());
            }

            return null;
        }

        public ActionResult getSettings()
        {
            MvcApplication1.Models.Visit v = new Visit();
            return Content(v.getSettings().ToJSON());
        }

	}

    
}
