﻿using System;
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

            //Response.AppendHeader("Access-Control-Allow-Origin", "*");

            glinttEntities e = new glinttEntities();

            glinttlocalEntities gle = new glinttlocalEntities();
            oauthclients oc = new oauthclients();
            oc.clientID = (gle.oauthclients.Count() + 1);
            oc.clientSecret = Guid.NewGuid().ToString(); //generateRandomSequence(16);
            oc.responseUri = response_uri;
            gle.oauthclients.Add(oc);
            gle.SaveChanges();
            

            List<string> l = new List<string>{
                oc.clientID.ToString(),
                oc.clientSecret,
            };

            /*
            Response.Headers["clientid"] = oc.clientID.ToString();
            Response.Headers["clientsecret"] = oc.clientSecret;
            Response.Redirect(response_uri);
            Response.End();
            */
            return Content(new Dictionary<string, string>() { {"clientid", oc.clientID.ToString()}, {"clientsecret",oc.clientSecret} }.ToJSON());
        }

        public ActionResult AuthorizeLogin()
        {
            //Response.AppendHeader("Access-Control-Allow-Origin", "*");

            string clientid = Request.QueryString["clientid"];
            string clientsecret = Request.QueryString["clientsecret"];
            //string accessToken = Request.QueryString["accesstoken"]; 
            string email = Request.QueryString["email"];
            string password = Request.QueryString["password"];
            
            glinttlocalEntities gle = new glinttlocalEntities();
            glinttEntities ge = new glinttEntities();

            oauthclients c =  gle.oauthclients.Find(Convert.ToInt32(clientid));
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
                        patient patientquery = gle.patient.SqlQuery("select * from Patient where doente = ? and t_doente = ?", l1.ToArray()).FirstOrDefault();
                        if (patientquery != null)
                        {
                            if (patientquery.password == password) //normal user login
                            {
                                //authentication successful
                                //TODO tokens must expire
                                string tokenstring = Guid.NewGuid().ToString(); //generateRandomSequence(32);

                                List<object> lt = new List<object>(){patientquery.doente,patientquery.t_doente, c.clientID};
                                accesstokens t = gle.accesstokens.SqlQuery("select * from Accesstokens where userid = ? and t_doente = ? and clientid = ?", lt.ToArray()).FirstOrDefault();
                                if (t != null)
                                {
                                    if (!Common.isTokenOutOfDate(t.Timestamp))
                                    {
                                        tokenstring = t.Token;
                                    }
                                    else
                                    {
                                        t.Token = tokenstring;
                                        t.Timestamp = DateTime.Now;
                                    }

                                    t.isAdmin = 0;
                                }
                                else
                                {
                                    accesstokens ac = new accesstokens();
                                    ac.clientid = c.clientID;
                                    ac.userid = patientquery.doente;
                                    ac.t_doente = patientquery.t_doente;
                                    ac.Timestamp = DateTime.Now;
                                    ac.Token = tokenstring;
                                    ac.isAdmin = 0;

                                    gle.accesstokens.Add(ac);
                                    gle.SaveChanges();
                                }
                                
                                

                                

                                Response.Redirect(c.responseUri + "?accessToken=" + tokenstring + "&userid=" + patientquery.t_doente + "_" + patientquery.doente + "&usertype=1");
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
                            practitioner practitionerquery1 = gle.practitioner.SqlQuery("select * from Practitioner where n_mecan = ?",l3.ToArray()).FirstOrDefault();

                            if (practitionerquery1.password == password) //admin login
                            {
                                string tokenstring = Guid.NewGuid().ToString();// generateRandomSequence(32);

                                List<object> lt = new List<object>() { practitionerquery.n_mecan, 1, c.clientID };
                                accesstokens t = gle.accesstokens.SqlQuery("select * from Accesstokens where userid = ? and isAdmin = ? and clientid = ? ", lt.ToArray()).FirstOrDefault();

                                if (t != null)
                                {

                                    if (!Common.isTokenOutOfDate(t.Timestamp))
                                    {
                                        tokenstring = t.Token;
                                    }
                                    else
                                    {
                                        t.Token = tokenstring;
                                        t.Timestamp = DateTime.Now;
                                    }

                                }
                                else
                                {
                                    accesstokens ac = new accesstokens();

                                    ac.Token = tokenstring;
                                    ac.Timestamp = DateTime.Now;
                                    ac.isAdmin = 1;
                                    ac.t_doente = "0";
                                    ac.userid = practitionerquery1.n_mecan.ToString();
                                    ac.clientid = Convert.ToInt32(practitionerquery.n_mecan);
                                    gle.accesstokens.Add(ac);
                                    gle.SaveChanges();
                                }
                                

                                Response.Redirect(c.responseUri+"?accessToken="+tokenstring + "&userid=" + practitionerquery.n_mecan +"&usertype=0");
                                Response.End();
                                return Content("");
                            }
                        }
                    }
                }
                Response.Redirect(c.responseUri + "?username=" + email + "&password=" + password + "&error=1");
                return Content("");
            }
            Response.StatusCode = 403;
            return null;
        }

        public ActionResult isTokenValid()
        {
            //Response.AppendHeader("Access-Control-Allow-Origin", "*");
            if (Common.getPrivileges(Request.QueryString["accesstoken"]) != "-1")
                return Content("1");
            return Content("0");
        }

        public ActionResult passwordForgotten()
        {

            return null;
        }
    }
}
