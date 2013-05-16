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
            oc.clientID = (gle.OauthClients.Count() + 1).ToString();
            oc.clientSecret = generateRandomSequence(16);
            oc.responseUri = response_uri;
            gle.OauthClients.Add(oc);
            gle.SaveChanges();
            

            List<string> l = new List<string>{
                oc.clientID,
                oc.clientSecret,
            };


            Response.AppendHeader("Access-Control-Allow-Origin", "*");

            return Content(l.ToJSON());
        }

            
        /*
        public ActionResult getAccessToken()
        {
            //check if clientid and clientsecret match, generate accessToken accordingly
            string clientid =  Request.Headers["clientid"];
            string clientsecret = Request.Headers["clientsecret"];
            string response_uri = Request.Headers["response_uri"];
            glinttLocalEntities gle = new glinttLocalEntities();

            OauthClients c =  gle.OauthClients.Find(clientid);
            if (c != null)
            {
                if (c.clientSecret == clientsecret)
                {
                    Response.AppendHeader("Access-Control-Allow-Origin", "*");
                    string s = generateRandomSequence(32);
                    c.accessToken = s;
                    c.timestamp = DateTime.Now;
                    gle.SaveChanges();
                    return Content(generateRandomSequence(32));
                }
            }

            return null;
        }
        */

        public ActionResult AuthorizeLogin()
        {
            string clientid =  Request.Headers["clientid"];
            string clientsecret = Request.Headers["clientsecret"];
            string response_uri = Request.Headers["response_uri"];
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
                    //string qry = "select * from g_doente where e_mail = \"" + email + "\"";
                      
                    string qry = "select * from g_doente where e_mail = ?";
                    List<Object> l = new List<Object>() { email };
                    g_doente doentequery = ge.g_doente.SqlQuery(qry, l.ToArray()).FirstOrDefault();
                    
                    //IEnumerator<g_doente> doentequery = ge.Database.SqlQuery<g_doente>(qry, new List<Object>() {email}).GetEnumerator();
                    //IEnumerator<g_doente> doentequery =  ge.g_doente.SqlQuery(qry).GetEnumerator();
                    if (doentequery!= null)
                    {
                        List<Object> l2 = new List<object>() { doentequery.doente, doentequery.t_doente };
                        Patient patientquery = gle.Patient.SqlQuery("select * from Patient where doente = ? and t_doente = ?", l2.ToArray() ).FirstOrDefault();
                        if (patientquery != null)
                        {
                            if (patientquery.password == password)
                            {
                                //authentication successful
                                //TODO tokens must expire
                                string s = generateRandomSequence(32);
                                c.accessToken = s;
                                c.timestamp = DateTime.Now;
                                gle.SaveChanges();
                                Response.AppendHeader("Access-Control-Allow-Origin", "*");
                                Response.Headers["user"] = email;
                                Response.Headers["acessToken"] = s;
                                return Content(generateRandomSequence(32)); 
                            }
                        }
                
                    }
                }
            }
            
            /*
            //check if the acesstoken matches, then validate login credentials

            if (Membership.ValidateUser(username, password))
            {
                bool isPersistent = true;

                
                // Usado para manter user's role na sessão
                //string userData = string.Join("|",GetCustomUserRoles());
                

                //Token com respetivas regras
                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                    1,                                     // ticket version
                    username,                              // authenticated username
                    DateTime.Now,                          // issueDate
                    DateTime.Now.AddMinutes(30),           // expiryDate
                    isPersistent,                          // true to persist across browser sessions
                    //userData,
                    FormsAuthentication.FormsCookiePath);  // the path for the cookie

                // Encriptar o ticket
                string encryptedTicket = FormsAuthentication.Encrypt(ticket);

                // Coloca o ticket encriptado numa cookie e a cookie no request
                HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                cookie.HttpOnly = true;
                Response.Cookies.Add(cookie);

                // Redireciona o request
                Response.Redirect(FormsAuthentication.GetRedirectUrl(username, isPersistent));
            }

            return null;
        */







            return null;
        }
    }
}
