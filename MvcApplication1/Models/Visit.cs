using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Reflection;

namespace MvcApplication1.Models
{
    public class Visit
    {
        glinttEntities ge;
        glinttlocalEntities gle;


        private static Dictionary<string, List<string>> ParamToDic = new Dictionary<string, List<string>>() {
            { "_id", new List<string>(){"n_cons"} }, 
            { "identifier", new List<string>(){"n_cons"} },
            { "state", new List<string>() {"flag_estado"} },
            { "subject", new List<string>() {"doente"} },
            { "responsible", new List<string>() {"medico"} },
            { "length", new List<string>() {"duracao_cons"} },
            { "period", new List<string>() {"dt_cons"} },
            { "period-before", new List<string>() {"dt_cons"} },
            { "period-after", new List<string>() {"dt_cons"} },
            { "indication", new List<string>() {"observ_cons"} },
            { "location", new List<string>() {"cod_gab"} },
            { "fulfills", null },
            { "contact" , null }
        };

        public Visit()
        {
            ge = new glinttEntities();
            gle = new glinttlocalEntities();
        }

        //RESOURCE REFERENCES->SUBJECT, RESPONSIBLE, FULFILLS, CONTACT, INDICATION 

        public string visitParser(g_cons_marc c, MvcApplication1.visit remain, string access)
        {

            if (access != "0")
            {
                string [] s = access.Split('_');
                string tdoente = s[0];
                string iddoente = s[1];

                if (c.t_doente != tdoente || c.doente != iddoente)
                {
                    return null;
                }
            }

            Hl7.Fhir.Model.Visit v = new Hl7.Fhir.Model.Visit();

            //Id
            Hl7.Fhir.Model.Identifier idt = new Hl7.Fhir.Model.Identifier();
            idt.Id = c.n_cons;
            v.Identifier = new List<Hl7.Fhir.Model.Identifier>() { idt };
            
            //State
            Hl7.Fhir.Model.CodeableConcept state = new Hl7.Fhir.Model.CodeableConcept();
            state.Coding = new List<Hl7.Fhir.Model.Coding>();
            Hl7.Fhir.Model.Coding st = new Hl7.Fhir.Model.Coding();
            st.Code = c.flag_estado; //TODO errado
            state.Coding.Add(st);
            v.State = state;
            
            //Subject
            v.Subject = new Hl7.Fhir.Model.ResourceReference();
            String url = HttpContext.Current.Request.Url.AbsoluteUri;
            String basicURL = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath + "patient";
            v.Subject.Url = new Hl7.Fhir.Model.FhirUri(new Uri(HttpUtility.HtmlEncode(basicURL + "/" + c.t_doente + "_" + c.doente)));
            v.Subject.Type = new Hl7.Fhir.Model.Code("Patient");

            //Responsible
            v.Responsible = new Hl7.Fhir.Model.ResourceReference();
            String responsibleURL = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath + "practitioner";
            v.Responsible.Url = new Hl7.Fhir.Model.FhirUri(new Uri(HttpUtility.HtmlEncode(responsibleURL + "/" + c.medico)));
            v.Responsible.Type = new Hl7.Fhir.Model.Code("Practitioner");

            //Period
            Hl7.Fhir.Model.Period periodo = new Hl7.Fhir.Model.Period();
            periodo.Start = new Hl7.Fhir.Model.FhirDateTime(DateTime.Parse(c.dt_cons.ToString()));
        
            
 
            //Indication
            v.Indication = new Hl7.Fhir.Model.ResourceReference();
            v.Indication.Display = new Hl7.Fhir.Model.FhirString(c.observ_cons);

            //Length
            DateTime result;
            if (DateTime.TryParse(c.duracao_cons.ToString(), out result))
            {
                Hl7.Fhir.Model.Duration duracao = new Hl7.Fhir.Model.Duration();
                duracao.Value = new Hl7.Fhir.Model.FhirDecimal(result.Hour*60 + result.Minute);
                v.Length = duracao;
            }

            //REVER - Não contempla remain.bed
            v.Location = new List<Hl7.Fhir.Model.Visit.VisitLocationComponent>();
            Hl7.Fhir.Model.Visit.VisitLocationComponent location = new Hl7.Fhir.Model.Visit.VisitLocationComponent();
            location.Location = new Hl7.Fhir.Model.ResourceReference();
            location.Location.Display = new Hl7.Fhir.Model.FhirString(c.cod_gab);
            location.Period = new Hl7.Fhir.Model.FhirDateTime(DateTime.Parse(c.dt_cons.ToString()));
            v.Location.Add(location);
           
            if (remain != null)
            {
                //Setting
                v.Setting = new Hl7.Fhir.Model.CodeableConcept();
                Hl7.Fhir.Model.CodeableConcept setting = new Hl7.Fhir.Model.CodeableConcept();
                Hl7.Fhir.Model.Coding sett = new Hl7.Fhir.Model.Coding();
                sett.Code = remain.setting;
                if (remain.setting == "amb")
                    sett.Display = "Ambulatório";
                else if (remain.setting == "cons")
                    sett.Display = "Consulta";
                else if (remain.setting == "home")
                    sett.Display = "Ao Domicílio";
                setting.Coding = new List<Hl7.Fhir.Model.Coding>(){sett};

                v.Setting = setting;

                //period-end
                if(remain.periodEnd != null)
                    periodo.End = new Hl7.Fhir.Model.FhirDateTime(DateTime.Parse(remain.periodEnd.ToString()));

                //Admitter
                v.Admission = new Hl7.Fhir.Model.Visit.VisitAdmissionComponent();
                v.Admission.Admitter = new Hl7.Fhir.Model.ResourceReference();
                v.Admission.Admitter.Url = new Hl7.Fhir.Model.FhirUri(new Uri(HttpUtility.HtmlEncode(responsibleURL + "/" + remain.admitter)));
                v.Admission.Admitter.Type = new Hl7.Fhir.Model.Code("Practitioner");

                //Discharger
                v.Discharge = new Hl7.Fhir.Model.Visit.VisitDischargeComponent();
                v.Discharge.Discharger = new Hl7.Fhir.Model.ResourceReference();
                v.Discharge.Discharger.Url = new Hl7.Fhir.Model.FhirUri(new Uri(HttpUtility.HtmlEncode(responsibleURL + "/" + remain.discharger)));
                v.Discharge.Discharger.Type = new Hl7.Fhir.Model.Code("Practitioner");

                //Contact
                String contactURL = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath + "contact";
                v.Contact = new Hl7.Fhir.Model.ResourceReference();
                v.Contact.Display = "Related Person";
                v.Contact.Url = new Hl7.Fhir.Model.FhirUri(new Uri(HttpUtility.HtmlEncode(contactURL + "/" + remain.id_contact)));

            }
            v.Period = periodo;

            return Hl7.Fhir.Serializers.FhirSerializer.SerializeResourceAsXml(v);
        }

        public g_cons_marc byId(string id)
        {
            Object[] key = { id };
            System.Data.Entity.Infrastructure.DbSqlQuery<g_cons_marc> sqlresult = ge.g_cons_marc.SqlQuery("Select * from g_cons_marc where n_cons=?", key);
            if (sqlresult.Count() == 0)
            {
                return null;
            }
            return sqlresult.First();
        }

        public string search(HttpRequestBase v, string tokenaccess)
        {
            List<Object> l = new List<Object>();
            int i = 0;

            int pageNum, itemNum;

            if (String.IsNullOrEmpty(v.QueryString["page"]))
                pageNum = 1;
            else
                pageNum = int.Parse(v.QueryString["page"]);


            if (String.IsNullOrEmpty(v.QueryString["_count"]))
                itemNum = 10;
            else
                itemNum = int.Parse(v.QueryString["_count"]);

            int glinttkeys = 0;
            
            string query1 = "Select * from g_cons_marc where ";
            foreach (string querykeys in v.QueryString.Keys)
            {
                int j = 0;
                if (Visit.ParamToDic.ContainsKey(querykeys))
                {
                    glinttkeys++;
                    if (i != 0)
                    {
                        query1 += " and ";
                    }
                   
                    foreach (string conver in Visit.ParamToDic[querykeys])
                    {

                        if (conver != null)
                        {
                            if (j != 0)
                            {
                                query1 += " or ";
                            }

                            if (querykeys == "period-before")
                                query1 += conver + "<" + "?";
                            else if (querykeys == "period-after")
                                query1 += conver + ">" + "?";
                            else
                                query1 += conver + "=" + "?";

                            l.Add(v.QueryString[querykeys]);
                            j++;
                        }
                    }
                    i++;
                }

            }
            query1 += ";";
            System.Data.Entity.Infrastructure.DbSqlQuery<g_cons_marc> res = null;
            System.Data.Entity.Infrastructure.DbSqlQuery<g_cons_marc> res2 = null;

            if (glinttkeys > 0)
                res = ge.g_cons_marc.SqlQuery(query1, l.ToArray());
            else
                res = null;

            String query2 = "Select * from Visit where ";
            bool hitit = false;
            List<object> l2 = new List<object>();

            foreach (string querykeys in v.QueryString.Keys)
            {
                if (querykeys == "setting")
                {
                    if (hitit)
                        query2 += " or ";
                    query2 += "setting = ?";
                    l2.Add(v.QueryString["setting"]);
                    hitit = true;
                }
           }
            query2 += ";";

           if (hitit){
               System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.visit> secondResult = gle.visit.SqlQuery(query2, l2.ToArray());
               int n = secondResult.Count();
               string query3 = "Select * from g_cons_marc where n_cons = ?";
               List<object> l3 = new List<object>();
               for(int j = 0; j< n ; ++j)
               {
                   MvcApplication1.visit vis = secondResult.ElementAt(j);
                   if (j > 0)
                       query3 += " or n_cons = ?";
                   l3.Add(vis.id);
               }
               query3 += ";";
               res2 = ge.g_cons_marc.SqlQuery(query3, l3.ToArray());
               n = res2.Count();
           }

           IEnumerable<g_cons_marc> res3;

           if (res == null)
               res3 = res2;
           else if (res2 == null)
               res3 = res;
           else
               res3 = res.Concat(res2).Distinct();

           int c = res3.Count();
            
           if (c > 1)
           {
               return generateFeed(res3, c, pageNum, itemNum, tokenaccess);
           }
           else if (c == 1)
           {
               g_cons_marc elem = res3.First();
               System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.visit> toParse = gle.visit.SqlQuery("Select * from Visit where id=" + elem.n_cons + ";");
               MvcApplication1.visit remaining;
               if (toParse.Count() != 0)
                   remaining = toParse.First();
               else
                   remaining = null;

               return visitParser(elem, remaining, tokenaccess);
           }
           else
           {
               return null;
           }


        }

        public string generateFeed(System.Data.Entity.Infrastructure.DbSqlQuery<g_cons_marc> res, int count, int pageNum, int itemNum, string access)
        {
            StringBuilder feed = new StringBuilder();
            feed.AppendLine(@"<feed xmlns=""http://www.w3.org/2005/Atom"" xmlns:gd=""http://schemas.google.com/g/2005"">");
            feed.AppendFormat(@"<title>g-patient search page {0}</title>", pageNum.ToString());
            DateTime now = DateTime.Now;
            feed.AppendFormat(@"<updated>{0}</updated>", (Common.GetDate(now)).ToString());
            Guid feedId;
            feedId = Guid.NewGuid();
            feed.AppendFormat(@"<id>urn:uuid:{0}</id>", feedId.ToString());
            int next = 0, prev = 0, last = 0;

            if (Math.Ceiling((decimal)(count - ((pageNum - 1) * itemNum)) / itemNum) <= pageNum)
                next = pageNum;
            else
                next = pageNum + 1;

            if (Math.Ceiling((decimal)count / itemNum) <= 1)
                last = 1;
            else
                last = (int)Math.Ceiling((decimal)count / itemNum);

            if (Math.Ceiling((decimal)count - (pageNum * itemNum) / itemNum) >= pageNum)
                prev = pageNum;
            else
                prev = pageNum - 1;

            String url = HttpContext.Current.Request.Url.AbsoluteUri;
            String basicURL = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath + "visit";
            feed.AppendFormat(@"<link rel=""self"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url));
            feed.AppendFormat(@"<link rel=""first"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + "1"));
            if (!(url.Remove(url.Length - 1) + prev.ToString()).Equals(url))
                feed.AppendFormat(@"<link rel=""previous"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + prev.ToString()));
            if (!(url.Remove(url.Length - 1) + next.ToString()).Equals(url))
                feed.AppendFormat(@"<link rel=""next"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + next.ToString()));
            feed.AppendFormat(@"<link rel=""last"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + last.ToString()));

            feed.AppendLine(@"<entry>");
            feed.AppendLine(@"<title>Search Results</title>");
            feed.AppendFormat(@"<link rel=""self"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url));
            Guid entryId = Guid.NewGuid();
            feed.AppendFormat(@"<id>urn:uuid:{0}</id>", entryId.ToString());
            DateTime entryTime = DateTime.Now;
            feed.AppendFormat(@"<updated>{0}</updated>", (Common.GetDate(entryTime)).ToString());
            feed.AppendFormat(@"<published>{0}</published>", (Common.GetDate(entryTime)).ToString());
            feed.AppendLine(@"<author>");
            feed.AppendLine(@"<name>g-patient</name>");
            feed.AppendLine(@"</author>");
            feed.AppendLine(@"<category term=""Visit"" scheme=""http://hl7.org/fhir/sid/fhir/resource-types""/>");
            feed.AppendLine(@"<content type=""text/xml"">");
            if (count > 0 && count > itemNum * (pageNum - 1))
            {
                int min = 0;
                if (count > (itemNum * pageNum))
                    min = (itemNum * pageNum);
                else
                    min = count;
                for (int j = (itemNum * (pageNum - 1)); j < min; j++)
                {
                    g_cons_marc elem = res.ElementAt(j);
                    feed.AppendFormat(@"<link href=""{0}"" />", HttpUtility.HtmlEncode(basicURL + "/" + elem.n_cons));
                    feed.Append(visitParser(elem, localDataById(elem.n_cons), access).Replace(@"<?xml version=""1.0"" encoding=""utf-16""?>", ""));
                }
            }
            feed.AppendLine(@"</content>");
            feed.AppendLine(@"</entry>");

            feed.Append(@"</feed>");
            return feed.ToString();
        }


        public string generateFeed(IEnumerable<g_cons_marc> res, int count, int pageNum, int itemNum, string access)
        {
            StringBuilder feed = new StringBuilder();
            feed.AppendLine(@"<feed xmlns=""http://www.w3.org/2005/Atom"" xmlns:gd=""http://schemas.google.com/g/2005"">");
            feed.AppendFormat(@"<title>g-patient search page {0}</title>", pageNum.ToString());
            DateTime now = DateTime.Now;
            feed.AppendFormat(@"<updated>{0}</updated>", (Common.GetDate(now)).ToString());
            Guid feedId;
            feedId = Guid.NewGuid();
            feed.AppendFormat(@"<id>urn:uuid:{0}</id>", feedId.ToString());
            int next = 0, prev = 0, last = 0;

            if (Math.Ceiling((decimal)(count - ((pageNum - 1) * itemNum)) / itemNum) <= pageNum)
                next = pageNum;
            else
                next = pageNum + 1;

            if (Math.Ceiling((decimal)count / itemNum) <= 1)
                last = 1;
            else
                last = (int)Math.Ceiling((decimal)count / itemNum);

            if (Math.Ceiling((decimal)count - (pageNum * itemNum) / itemNum) >= pageNum)
                prev = pageNum;
            else
                prev = pageNum - 1;

            String url = HttpContext.Current.Request.Url.AbsoluteUri;
            String basicURL = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath + "visit";
            feed.AppendFormat(@"<link rel=""self"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url));
            feed.AppendFormat(@"<link rel=""first"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + "1"));
            if (!(url.Remove(url.Length - 1) + prev.ToString()).Equals(url))
                feed.AppendFormat(@"<link rel=""previous"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + prev.ToString()));
            if (!(url.Remove(url.Length - 1) + next.ToString()).Equals(url))
                feed.AppendFormat(@"<link rel=""next"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + next.ToString()));
            feed.AppendFormat(@"<link rel=""last"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + last.ToString()));

            feed.AppendLine(@"<entry>");
            feed.AppendLine(@"<title>Search Results</title>");
            feed.AppendFormat(@"<link rel=""self"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url));
            Guid entryId = Guid.NewGuid();
            feed.AppendFormat(@"<id>urn:uuid:{0}</id>", entryId.ToString());
            DateTime entryTime = DateTime.Now;
            feed.AppendFormat(@"<updated>{0}</updated>", (Common.GetDate(entryTime)).ToString());
            feed.AppendFormat(@"<published>{0}</published>", (Common.GetDate(entryTime)).ToString());
            feed.AppendLine(@"<author>");
            feed.AppendLine(@"<name>g-patient</name>");
            feed.AppendLine(@"</author>");
            feed.AppendLine(@"<category term=""Visit"" scheme=""http://hl7.org/fhir/sid/fhir/resource-types""/>");
            feed.AppendLine(@"<content type=""text/xml"">");
            if (count > 0 && count > itemNum * (pageNum - 1))
            {
                int min = 0;
                if (count > (itemNum * pageNum))
                    min = (itemNum * pageNum);
                else
                    min = count;
                for (int j = (itemNum * (pageNum - 1)); j < min; j++)
                {
                    g_cons_marc elem = res.ElementAt(j);
                    feed.AppendFormat(@"<link href=""{0}"" />", HttpUtility.HtmlEncode(basicURL + "/" + elem.n_cons));
                    feed.Append(visitParser(elem, localDataById(elem.n_cons), access).Replace(@"<?xml version=""1.0"" encoding=""utf-16""?>", ""));
                }
            }
            feed.AppendLine(@"</content>");
            feed.AppendLine(@"</entry>");

            feed.Append(@"</feed>");
            return feed.ToString();
        }





        public String update(HttpRequestBase p, String id,string access)
        {
            Object[] key = { id };
            List<Object> l = new List<Object>();
            System.Data.Entity.Infrastructure.DbSqlQuery<g_cons_marc> sqlresult = ge.g_cons_marc.SqlQuery("Select * from g_cons_marc where n_cons=?", key);
            if (sqlresult.Count() != 0)
            {

                String query1 = "update g_cons_marc set ";
                int j = 0;
                foreach (string querykeys in p.QueryString.Keys)
                {
                    if (Visit.ParamToDic.ContainsKey(querykeys) && (!querykeys.Equals("_id") && !querykeys.Equals("identifier") && !querykeys.Equals("period-before") && !querykeys.Equals("period-after")))
                    {                    

                        foreach (string conver in Visit.ParamToDic[querykeys])
                        {

                            if (conver != null)
                            {
                                if (j != 0)
                                {
                                    query1 += " , ";
                                }
                                query1 += conver + "=" + "?";
                                l.Add(p.QueryString[querykeys]);
                                j++;
                            }
                        }
                    }

                }

                if (j != 0)
                {
                    query1 += " where n_cons = " + id + " ;";
                    ge.Database.ExecuteSqlCommand(query1, l.ToArray());
                    ge.SaveChanges();
                }

                MvcApplication1.visit visit = new MvcApplication1.visit();
                PropertyInfo[] proptinfo = visit.GetType().GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance);
                List<string> collumns = new List<string>();

                foreach (PropertyInfo pi in proptinfo)
                {
                    collumns.Add(pi.Name);
                }

                string query2 = "update Visit set ";
                List<object> l2 = new List<object>();
                bool bbb = false;

                foreach (string querykeys in p.QueryString.Keys)
                {
                    if (collumns.Contains(querykeys))
                    {
                        if (bbb)
                            query2 += ",";
                        query2 += querykeys + " = ? ";
                        l2.Add(p.QueryString[querykeys]);
                        bbb = true;
                    }

                }

                if (bbb)
                {
                    query2 += " where id = ?";
                    l2.Add(id);
                    gle.Database.ExecuteSqlCommand(query2, l2.ToArray());
                    gle.SaveChanges();
                }

                return "ok";

            }

            return null;
        }




        /*
     public List<VisitModel> byPatient (string id) 
     {

         List<VisitModel> result = new List<VisitModel>();
         Object[] key = { id };
         System.Data.Entity.Infrastructure.DbSqlQuery<g_cons_marc> sqlresult = ge.g_cons_marc.SqlQuery("Select * from g_cons_marc where doente=?", key);
         if (sqlresult.Count() == 0)
         {
             return null;
         }
    
         for(int i=0; sqlresult.Count()<i; i++)
         {
             g_cons_marc temp = sqlresult.ElementAt(i);


             VisitModel final = visitParser(temp);
             result.Add(temp);
         }
         return ;
  

    }
        
 */

        public MvcApplication1.visit localDataById(String id)
        {
            System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.visit> sqlresult = gle.visit.SqlQuery("Select * from Visit where id=" + id + ";");
            if (sqlresult.Count() == 0)
            {
                return null;
            }

            return sqlresult.First();
        }
    }

}