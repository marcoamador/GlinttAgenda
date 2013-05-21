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

            Response.AppendHeader("Access-Control-Allow-Origin", "*");

            Response.Redirect(response_uri);
            Response.End();

            return Content("");
        }

        public ActionResult AuthorizeLogin()
        {
            string clientid =  Request.Headers["clientid"];
            string clientsecret = Request.Headers["clientsecret"];
            //string accessToken = Request.Headers["accesstoken"]; 
            string email = Request.Headers["email"];
            string password = Request.Headers["password"];
            
            glinttLocalEntities gle = new glinttLocalEntities();
            glinttEntities ge = new glinttEntities();

            OauthClients c =  gle.OauthClients.Find(clientid);
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
                                string s = generateRandomSequence(32);
                                c.accessToken = s;
                                c.timestamp = DateTime.Now;
                                c.isAdmin = 0;
                                c.userid = patientquery.doente;
                                c.t_doente = patientquery.t_doente;
                                gle.SaveChanges();
                                Response.AppendHeader("Access-Control-Allow-Origin", "*");
                                Response.Headers["user"] = email;
                                Response.Headers["acessToken"] = s;

                                Response.Redirect(c.responseUri);
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
                                string s = generateRandomSequence(32);
                                c.accessToken = s;
                                c.timestamp = DateTime.Now;
                                c.isAdmin = 1;
                                c.userid = practitionerquery.n_mecan;
                                gle.SaveChanges();
                                Response.AppendHeader("Access-Control-Allow-Origin", "*");
                                Response.Headers["user"] = email;
                                Response.Headers["acessToken"] = s;
                                Response.Redirect(c.responseUri);
                                Response.End();
                                return Content("");
                            }
                        }
                    }
                }
            }
            
            return null;
        }
    }
}
