using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class Notifications
    {
        public string add(HttpRequestBase p){
            notifications n = new notifications();
            string[] s = p.QueryString["userid"].Split('_');
            n.t_doente = s[0];
            n.idDoente = s[1];
            n.seen = 0;
            n.timestamp = DateTime.Now;
            n.text = p.QueryString["text"];
            glinttlocalEntities gle = new glinttlocalEntities();
            gle.notifications.Add(n);
            gle.SaveChanges();
            return "ok";
        }

        public string generateNotification(String userID, String text)
        {
            notifications n = new notifications();
            string[] s = userID.Split('_');
            n.t_doente = s[0];
            n.idDoente = s[1];
            n.seen = 0;
            n.timestamp = DateTime.Now;
            n.text = text;
            glinttlocalEntities gle = new glinttlocalEntities();
            gle.notifications.Add(n);
            gle.SaveChanges();
            return "ok";
        }
    }
}
