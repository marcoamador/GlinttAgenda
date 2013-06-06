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
    public class NotificationsController : Controller
    {
        public ActionResult byUserId(string id)
        {

            string access = Common.getPrivileges(Request.QueryString["accessToken"]);
            if (id == access || access == "0")
            {
                glinttlocalEntities gle = new glinttlocalEntities();
                string[] doenteid = id.Split('_');
                List<object> l = new List<object>() { doenteid[0], doenteid[1]  };
                System.Data.Entity.Infrastructure.DbSqlQuery<notifications> notif = gle.notifications.SqlQuery("select * from Notifications where t_doente = ? and idDoente = ?", l.ToArray());

                List<notifications> res = new List<notifications>();

                if (notif != null)
                {

                    foreach (notifications n in notif)
                    {
                        res.Add(n);
                    }
                    
                    if (res.Count() > 0)
                        return Content(res.ToJSON());
                }
                Response.StatusCode = 404;
                return Content("");
            }
            Response.StatusCode = 403;
            return Content("");
        }

        public ActionResult add()
        {

            string access = Common.getPrivileges(Request.QueryString["accessToken"]);
            if (access == "0")
            {
                Notifications n = new Notifications();
                String s = n.add(Request);
                if (s != null)
                {
                    Response.StatusCode = 404;
                    return null;
                }
                else
                {
                    Response.StatusCode = 200;
                    return Content("ok");
                }
            }
            else
            {
                Response.StatusCode = 403;
                return Content("");
            }
        }

        public ActionResult markRead()
        {

            string access = Common.getPrivileges(Request.QueryString["accessToken"]);
            glinttlocalEntities gle = new glinttlocalEntities();
            notifications n = gle.notifications.Find(Request.QueryString["notificationid"]);
            if (n != null)
            {
                if (n.t_doente + "_" + n.idDoente == access || access == "0")
                {
                    n.seen = 1;
                    n.seentimestamp = DateTime.Now;
                    gle.SaveChanges();

                    return Content("ok");
                }
                else
                {
                    Response.StatusCode = 403;
                    return null;
                }
            }
            Response.StatusCode = 403;
            return Content("");
        }
        
    }
}
