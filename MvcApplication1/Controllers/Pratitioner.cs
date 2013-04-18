﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcApplication1.Controllers
{
    public class PratitionerController : Controller
    {

        private static Dictionary<string, string> ParamToDic = new Dictionary<string, string>() {
                                                                                    { "_id", "n_mecan" }, 
                                                                                    { "address", "morada" }, 
                                                                                    { "family", null },
                                                                                    { "gender", null },
                                                                                    { "given", "nome" },
                                                                                    { "identifier", "n-mecan" },
                                                                                    { "language", null },
                                                                                    { "name", "nome" },
                                                                                    { "organization", null },
                                                                                    { "phonetic", null },
                                                                                    { "telecom", "telef" }
                                                                                };
        glinttEntities gE;
        protected override void Initialize(RequestContext rc)
        {
            base.Initialize(rc);
            gE = new glinttEntities();
        }
 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hello(string resource,string res_action, string id)
        {
            
            
            return Json(new { resource = resource , resource_action = res_action,id = Int32.Parse(id),count=gE.g_doente.Count() }, JsonRequestBehavior.AllowGet);
        }
    }
}
