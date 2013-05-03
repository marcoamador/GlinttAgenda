﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace MvcApplication1.Models
{
    public class Practitioner
    {

        private static Dictionary<string, List<string>> ParamToDic = new Dictionary<string, List<string>>() 
        {
            { "_id", new List<string>() {"n_mecan"} }, 
            { "address", new List<string>() {"morada"} }, 
            { "family", null },
            { "gender", null },
            { "given", new List<string>() {"nome"} },
            { "identifier", new List<string>() {"n-mecan"} },
            { "language", null },
            { "name", new List<string>() {"nome"} },
            { "organization", null },
            { "phonetic", null },
            { "telecom", new List<string>() {"telef"} }
        };


        glinttEntities gE;

        public Practitioner()
        {
            gE = new glinttEntities();
        }


       

        public String practitionerParser(g_pess_hosp_def d)
        {
            Hl7.Fhir.Model.Practitioner p = new Hl7.Fhir.Model.Practitioner();
            
            //setup id
            Hl7.Fhir.Model.Identifier idt = new Hl7.Fhir.Model.Identifier();
            idt.Id= d.n_mecan;
            
            //setup role
            Hl7.Fhir.Model.CodeableConcept role = new Hl7.Fhir.Model.CodeableConcept();
            role.Text = d.titulo;

            //setup name
            Hl7.Fhir.Model.HumanName name = new Hl7.Fhir.Model.HumanName();
            name.Text = d.nome;

            //setup telecom
            Hl7.Fhir.Model.Contact tel = new Hl7.Fhir.Model.Contact();
            tel.Value = d.telef;
            Hl7.Fhir.Model.Contact mail = new Hl7.Fhir.Model.Contact();
            mail.Value = d.email;


            p.Identifier = new List<Hl7.Fhir.Model.Identifier>(){idt};
            p.Role = new List<Hl7.Fhir.Model.CodeableConcept>(){role};
            p.Details.Identifier = new List<Hl7.Fhir.Model.Identifier>(){idt};
            p.Details.Name = new List<Hl7.Fhir.Model.HumanName>(){name};
            p.Details.Telecom = new List<Hl7.Fhir.Model.Contact>() { tel, mail };
            

            return Hl7.Fhir.Serializers.FhirSerializer.SerializeResourceAsXml(p);
        }

        public String byId(string id)
        {
            Object[] key = { id };
            System.Data.Entity.Infrastructure.DbSqlQuery<g_pess_hosp_def> sqlresult = gE.g_pess_hosp_def.SqlQuery("Select * from g_pess_hosp_def where n_mecan=?", key);
            if (sqlresult.Count() == 0)
            {
                return null;
            }
            g_pess_hosp_def practitioner = sqlresult.First();
            return practitionerParser(practitioner);
        }

        public string search(HttpRequestBase pr)
        {
            List<Object> l = new List<Object>();
            int i = 0;
            string query1 = "Select * from g_pess_hosp_def where ";
            foreach (string querykeys in pr.QueryString.Keys)
            {
                if (i != 0)
                {
                    query1 += " and ";
                }
                int j = 0;
                foreach (string conver in Practitioner.ParamToDic[querykeys])
                {

                    if (conver != null)
                    {
                        if (j != 0)
                        {
                            query1 += " or ";
                        }
                        query1 += conver + "=" + "?";

                        l.Add(pr.QueryString[querykeys]);
                        j++;
                    }
                }
                i++;

            }

            query1 += ";";
            System.Data.Entity.Infrastructure.DbSqlQuery<g_pess_hosp_def> res = gE.g_pess_hosp_def.SqlQuery(query1, l.ToArray());
            if (res.Count() > 0)
            {
                return generateFeed(res);
            }
            else
            {
                return null;
            }
        }

        public string generateFeed(System.Data.Entity.Infrastructure.DbSqlQuery<g_pess_hosp_def> res)
        {
            StringBuilder feed = new StringBuilder();
            feed.AppendLine(@"<feed xmlns=""http://www.w3.org/2005/Atom"" xmlns:gd=""http://schemas.google.com/g/2005"">");
            feed.AppendLine(@"<title>g-patient feed</title>");
            DateTime now = DateTime.Now;
            feed.AppendFormat(@"<updated>{0}</updated>", now.ToString());
            Guid feedId;
            feedId = Guid.NewGuid();
            feed.AppendFormat(@"<id>{0}</id>", feedId.ToString());
            feed.AppendLine(@"<link rel=""self"" href=""http://site.com"" />");

            feed.AppendLine(@"<entry>");
            feed.AppendLine(@"<title>Search Results</title>");
            feed.AppendLine(@"<link rel=""self"" href=""http://site.com""/>");
            Guid entryId = Guid.NewGuid();
            feed.AppendFormat(@"<id>{0}</id>", entryId.ToString());
            DateTime entryTime = DateTime.Now;
            feed.AppendFormat(@"<updated>{0}</updated>\n", entryTime.ToString());
            feed.AppendFormat(@"<published>{0}</published>\n", entryTime.ToString());
            feed.AppendLine(@"<author>");
            feed.AppendLine(@"<name>g-patient</name>");
            feed.AppendLine(@"</author>");
            feed.AppendLine(@"<category term=""Practitioner"" scheme=""http://hl7.org/fhir/sid/fhir/resource-types""/>");
            feed.AppendLine(@"<content type=""text/xml"">");
            if (res.Count() > 0)
            {
                foreach (g_pess_hosp_def i in res)
                {
                    feed.Append(practitionerParser(i));
                }
            }
            feed.AppendLine(@"</content>");
            feed.AppendLine(@"</entry>");

            feed.Append(@"</feed>");
            return feed.ToString();
        }



    }
}