using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace MvcApplication1.Models
{
    public class Visit
    {
        glinttEntities ge;
        glinttLocalEntities gle;


        private static Dictionary<string, List<string>> ParamToDic = new Dictionary<string, List<string>>() {
            { "_id", new List<string>(){"n_cons"} }, 
            { "contact", null }, 
            { "fulfills", null },
            { "identifier", new List<string>() {"n_cons"} },
            { "indication", new List<string>() {"observ_cons"} },
            { "length", new List<string>() {"n-mecan"} },
            { "period", new List<string>() {"duracao_cons"} },
            { "period-before", new List<string>() {"dt_cons"} },
            { "period-after", new List<string>() {"dt_cons"} },
            { "responsible", new List<string>() {"medico"} },
            { "setting", null },
            { "state", new List<string>() {"flag_estado"} },
            { "subject", new List<string>() {"doente"} }
        };

        public Visit()
        {
            ge = new glinttEntities();
            gle = new glinttLocalEntities();
        }

        //RESOURCE REFERENCES->SUBJECT, RESPONSIBLE, FULFILLS, CONTACT, INDICATION 

        public string visitParser(g_cons_marc c, MvcApplication1.Visit remain)
        {

            Hl7.Fhir.Model.Visit v = new Hl7.Fhir.Model.Visit();


            Hl7.Fhir.Model.Identifier idt = new Hl7.Fhir.Model.Identifier();
            idt.Id = c.n_cons;

            Hl7.Fhir.Model.CodeableConcept state = new Hl7.Fhir.Model.CodeableConcept();
            state.Text = c.flag_estado; //TODO errado

            Hl7.Fhir.Model.CodeableConcept set = new Hl7.Fhir.Model.CodeableConcept();
            set.Text = null;


            //TODO faltam todos os resource references
            Hl7.Fhir.Model.ResourceReference rr = new Hl7.Fhir.Model.ResourceReference();

            Hl7.Fhir.Model.Period periodo = new Hl7.Fhir.Model.Period();
            //periodo.Start = c.dt_cons;
            //periodo.End = 

            Hl7.Fhir.Model.Duration duracao = new Hl7.Fhir.Model.Duration();
            //DURACAO = PERIODO


            v.Identifier = new List<Hl7.Fhir.Model.Identifier>() { idt };
            v.State = state;
            v.Setting = new Hl7.Fhir.Model.CodeableConcept();
            v.Subject = new Hl7.Fhir.Model.ResourceReference();
            v.Responsible = new Hl7.Fhir.Model.ResourceReference();
            v.Fulfills = new Hl7.Fhir.Model.ResourceReference();
            v.Period = periodo;
            v.Length = duracao;
            v.Contact = new Hl7.Fhir.Model.ResourceReference();
            v.Indication = new Hl7.Fhir.Model.ResourceReference();

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

        public string search(HttpRequestBase v)
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


            string query1 = "Select * from g_cons_marc where ";
            foreach (string querykeys in v.QueryString.Keys)
            {
                if (Visit.ParamToDic.ContainsKey(querykeys))
                {

                    if (i != 0)
                    {
                        query1 += " and ";
                    }
                    int j = 0;
                    foreach (string conver in Visit.ParamToDic[querykeys])
                    {

                        if (conver != null)
                        {
                            if (j != 0)
                            {
                                query1 += " or ";
                            }

                            query1 += conver + "=" + "?";

                            l.Add(v.QueryString[querykeys]);
                            j++;
                        }
                    }
                    i++;
                }

            }

            query1 += ";";
            System.Data.Entity.Infrastructure.DbSqlQuery<g_cons_marc> res = ge.g_cons_marc.SqlQuery(query1, l.ToArray());
            if (res.Count() > 1)
            {
                return generateFeed(res, res.Count(), pageNum, itemNum);
            }
            else if (res.Count() == 1)
            {
                return visitParser(res.First(), localDataById(res.First().n_cons));
            }
            else
            {
                return null;
            }
        }

        public string generateFeed(System.Data.Entity.Infrastructure.DbSqlQuery<g_cons_marc> res, int count, int pageNum, int itemNum)
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
            if (res.Count() > 0 && res.Count() > itemNum * (pageNum - 1))
            {
                int min = 0;
                if (res.Count() > (itemNum * pageNum))
                    min = (itemNum * pageNum);
                else
                    min = res.Count();
                for (int j = (itemNum * (pageNum - 1)); j < min; j++)
                {
                    feed.AppendFormat(@"<link href=""{0}"" />", HttpUtility.HtmlEncode(basicURL + "/" + res.ElementAt(j).n_cons));
                    feed.Append(visitParser(res.ElementAt(j), localDataById(res.ElementAt(j).n_cons)).Replace(@"<?xml version=""1.0"" encoding=""utf-16""?>", ""));
                }
            }
            feed.AppendLine(@"</content>");
            feed.AppendLine(@"</entry>");

            feed.Append(@"</feed>");
            return feed.ToString();
        }

        public String update(HttpRequestBase p, String id)
        {
            Object[] key = { id };
            List<Object> l = new List<Object>();
            System.Data.Entity.Infrastructure.DbSqlQuery<g_cons_marc> sqlresult = ge.g_cons_marc.SqlQuery("Select * from g_cons_marc where n_cons=?", key);
            if (sqlresult.Count() != 0)
            {

                String query1 = "update g_cons_marc set ";
                foreach (string querykeys in p.QueryString.Keys)
                {
                    if (Visit.ParamToDic.ContainsKey(querykeys) || !querykeys.Equals("_id"))
                    {

                        int j = 0;

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

                query1 += " where n_cons = " + id + " ;";

                ge.Database.ExecuteSqlCommand(query1, l.ToArray());
                ge.SaveChanges();
                return visitParser(byId(id), localDataById(id));

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

        public MvcApplication1.Visit localDataById(String id)
        {
            System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.Visit> sqlresult = gle.Visit.SqlQuery("Select * from Visit where id=" + id + ";");
            if (sqlresult.Count() == 0)
            {
                return null;
            }

            return sqlresult.First();
        }
    }

}