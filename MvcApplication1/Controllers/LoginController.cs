using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcApplication1.Controllers
{

    public class LoginController : Controller
    {

        

        private string generateRandomSequence(int length)
        {
            RandomNumberGenerator cryptoRandomDataGenerator = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[length];
            cryptoRandomDataGenerator.GetBytes(buffer);
            string uniq = Convert.ToBase64String(buffer);
            return uniq;
        }

        public ActionResult registerClient( string response_uri )
        {
            //check if response_uri exists
            //create respective clientID and ClientSecret
            //save responseUri

            Response.AppendHeader("Access-Control-Allow-Origin", "*");

            glinttEntities e = new glinttEntities();

            glinttLocalEntities gle = new glinttLocalEntities();
            OauthClients oc = new OauthClients();
            oc.clientID = (gle.OauthClients.Count() + 1);
            oc.clientSecret = generateRandomSequence(16);
            oc.responseUri = response_uri;
            gle.OauthClients.Add(oc);
            gle.SaveChanges();
            

            List<string> l = new List<string>{
                oc.clientID.ToString(),
                oc.clientSecret,
            };


            Response.Headers["clientid"] = oc.clientID.ToString();
            Response.Headers["clientsecret"] = oc.clientSecret;

            

            Response.Redirect(response_uri);
            Response.End();

            return Content("");
        }

        public ActionResult AuthorizeLogin()
        {
            Response.AppendHeader("Access-Control-Allow-Origin", "*");

            string clientid = Request.QueryString["clientid"];
            string clientsecret = Request.QueryString["clientsecret"];
            //string accessToken = Request.QueryString["accesstoken"]; 
            string email = Request.QueryString["email"];
            string password = Request.QueryString["password"];
            
            glinttLocalEntities gle = new glinttLocalEntities();
            glinttEntities ge = new glinttEntities();

            OauthClients c =  gle.OauthClients.Find(Convert.ToInt32(clientid));
            if (c != null)
            {
                if (c.clientSecret == clientsecret)
                {
                      
                    string qry = "select * from g_doente where e_mail = ?";
                    List<Object> l = new List<Object>() { email };
                    g_doente doentequery = ge.g_doente.SqlQuery(qry, l.ToArray()).FirstOrDefault();

                    if (doentequery != null)
                    {
                        List<Object> l1 = new List<object>() { doentequery.doente, doentequery.t_doente };
                        Patient patientquery = gle.Patient.SqlQuery("select * from Patient where doente = ? and t_doente = ?", l1.ToArray()).FirstOrDefault();
                        if (patientquery != null)
                        {
                            if (patientquery.password == password) //normal user login
                            {
                                //authentication successful
                                //TODO tokens must expire
                                string tokenstring = generateRandomSequence(32);

                                
                                Accesstokens t = new Accesstokens();
                                t.clientid = c.clientID;
                                t.userid = patientquery.doente;
                                t.t_doente = patientquery.t_doente;
                                t.Timestamp = DateTime.Now;
                                t.Token = tokenstring;
                                t.isAdmin = 0;
                                
                                gle.Accesstokens.Add(t);

                                gle.SaveChanges();

                                Response.Redirect(c.responseUri+"?accessToken="+tokenstring + "&userid=" + patientquery.t_doente + "_" + patientquery.doente);
                                Response.End();
                                return Content("");
                            }
                        }

                    }
                    else
                    {
                        List<Object> l2 = new List<object>(){email};
                        g_pess_hosp_def practitionerquery = ge.g_pess_hosp_def.SqlQuery("select *  from g_pess_hosp_def where email =?", l2.ToArray()).FirstOrDefault();
                        
                        if (practitionerquery != null)
                        {
                            List<Object> l3 = new List<object>() { practitionerquery.n_mecan };
                            Practitioner practitionerquery1 = gle.Practitioner.SqlQuery("select * from Practitioner where if = ?").FirstOrDefault();

                            if (practitionerquery1.password == password) //admin login
                            {
                                string tokenstring = generateRandomSequence(32);
                                Accesstokens t = new Accesstokens();
                                t.Token = tokenstring;
                                t.Timestamp = DateTime.Now;
                                t.isAdmin = 1;
                                t.clientid = Convert.ToInt32(practitionerquery.n_mecan);

                                gle.Accesstokens.Add(t);
                                gle.SaveChanges();

                                Response.Redirect(c.responseUri+"?accessToken="+tokenstring + "?userid=" + practitionerquery.n_mecan);
                                Response.End();
                                return Content("");
                            }
                        }
                    }
                }
                Response.Redirect(c.responseUri + "?username=" + email + "&password=" + password + "&error=1");
                return Content("");
            }
            return Content("");
        }

        public ActionResult isTokenValid()
        {
            Response.AppendHeader("Access-Control-Allow-Origin", "*");
            if (Common.getPrivileges(Request.QueryString["accesstoken"]) != "-1")
                return Content("1");
            return Content("0");
        }
    }
}
