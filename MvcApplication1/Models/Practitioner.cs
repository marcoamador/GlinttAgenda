using System;
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
            {"_id", new List<string>() {"n_mecan"}}, 
            {"address", new List<string>() {"morada"}}, 
            {"gender", null},
            {"language", null},
            {"name", new List<string>() {"nome"}},
            {"organization", null},
            {"telecom", new List<string>() {"telef", "email"}}
        };

        glinttEntities gE;
        glinttLocalEntities glE;

        public Practitioner()
        {
            gE = new glinttEntities();
            glE = new glinttLocalEntities();

        }   


        public String practitionerParser(g_pess_hosp_def d, MvcApplication1.Practitioner remain)
        {
            Hl7.Fhir.Model.Practitioner p = new Hl7.Fhir.Model.Practitioner();
            p.Details = new Hl7.Fhir.Model.Demographics();


            //Practioner identifier
            Hl7.Fhir.Model.Identifier pID = new Hl7.Fhir.Model.Identifier();
            pID.Use = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Identifier.IdentifierUse>(Hl7.Fhir.Model.Identifier.IdentifierUse.Official);
            pID.Id = d.n_mecan;


            //Practitioner name
            Hl7.Fhir.Model.HumanName name = new Hl7.Fhir.Model.HumanName();
            name.Prefix = new List<Hl7.Fhir.Model.FhirString>() { d.titulo };
            name.Given = new List<Hl7.Fhir.Model.FhirString>();

            if (d.nome.Contains(' '))
            {
                String[] names = d.nome.Split(' ');
                if (names.Length > 1)
                {
                    for (int k = 0; k < names.Length - 1; k++)
                    {
                        name.Given.Add(names.ElementAt(k));
                    }
                    name.Family = new List<Hl7.Fhir.Model.FhirString>() { names.ElementAt(names.Length - 1) };
                }
                else
                {
                    name.Given.Add(names.ElementAt(0));
                }
            }
            else
                name.Given.Add(d.nome);

            //Practitioner telecom
            Hl7.Fhir.Model.Contact tel = new Hl7.Fhir.Model.Contact();
            tel.System = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contact.ContactSystem>(Hl7.Fhir.Model.Contact.ContactSystem.Phone);
            tel.Value = d.telef;
            Hl7.Fhir.Model.Contact mail = new Hl7.Fhir.Model.Contact();
            mail.System = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contact.ContactSystem>(Hl7.Fhir.Model.Contact.ContactSystem.Email);
            mail.Value = d.email;


            p.Identifier = new List<Hl7.Fhir.Model.Identifier>() { pID };
            p.Details.Name = new List<Hl7.Fhir.Model.HumanName>() { name };
            p.Details.Telecom = new List<Hl7.Fhir.Model.Contact>() { tel, mail };

            //Role
            p.Role = new List<Hl7.Fhir.Model.CodeableConcept>();
            Hl7.Fhir.Model.CodeableConcept pRole = new Hl7.Fhir.Model.CodeableConcept();
            pRole.Coding = new List<Hl7.Fhir.Model.Coding>();
            Hl7.Fhir.Model.Coding roleValue = new Hl7.Fhir.Model.Coding();
            if (d.titulo == "Dr.")
                roleValue.Display = "Médico";
            else if (d.titulo == "Enf.º")
                roleValue.Display = "Enfermeiro";
            else if (d.titulo == "Dra.")
                roleValue.Display = "Médica";
            else if (d.titulo == "Enf.ª")
                roleValue.Display = "Enfermeira";

            pRole.Coding.Add(roleValue);
            p.Role.Add(pRole);
            
            if (remain != null)
            {
                //Practitioner Gender
                Hl7.Fhir.Model.Coding gender = new Hl7.Fhir.Model.Coding();
                gender.Code = remain.gender;
                if (remain.gender == "M")
                    gender.Display = "Masculino";
                else if (remain.gender == "F")
                    gender.Display = "Feminino";
                p.Details.Gender = gender;

                //Practitioner BirthDate
                Hl7.Fhir.Model.FhirDateTime birthdate = new Hl7.Fhir.Model.FhirDateTime(DateTime.Parse(remain.birthDate));
                p.Details.BirthDate = birthdate;

                //Practitioner Deceased
                if (remain.deceased != null)
                {
                    Hl7.Fhir.Model.FhirBoolean deceased = new Hl7.Fhir.Model.FhirBoolean();
                    deceased = remain.deceased;
                    p.Details.Deceased = deceased;
                }
                

                //Practitioner Address
                Hl7.Fhir.Model.Address address = new Hl7.Fhir.Model.Address();
                address.Line = new List<Hl7.Fhir.Model.FhirString>(){remain.address};
                p.Details.Address = new List<Hl7.Fhir.Model.Address>();
                p.Details.Address.Add(address);


                //Practitioner MaritalStatus

                if (remain.maritalStatus != null)
                {
                    p.Details.MaritalStatus = new Hl7.Fhir.Model.CodeableConcept();
                    p.Details.MaritalStatus.Coding = new List<Hl7.Fhir.Model.Coding>();
                    Hl7.Fhir.Model.Coding pMarStatus = new Hl7.Fhir.Model.Coding();
                    pMarStatus.Code = remain.maritalStatus;

                    if (remain.maritalStatus == "ca")
                        pMarStatus.Display = "Casado";
                    else if (remain.maritalStatus == "so")
                        pMarStatus.Display = "Solteiro";
                    else if (remain.maritalStatus == "div")
                        pMarStatus.Display = "Divorciado";
                    else if (remain.maritalStatus == "vi")
                        pMarStatus.Display = "Viúvo";
                    else if (remain.maritalStatus == "oth")
                        pMarStatus.Display = "Outro";

                    p.Details.MaritalStatus.Coding.Add(pMarStatus);
                }

                //Practitioner Period
                if (remain.periodStart != null && remain.periodEnd != null)
                {
                    Hl7.Fhir.Model.Period period = new Hl7.Fhir.Model.Period();
                    if (remain.periodStart != null)
                        period.Start = new Hl7.Fhir.Model.FhirDateTime(DateTime.Parse(remain.periodStart.ToString()));
                    if (remain.periodEnd != null)
                        period.End = new Hl7.Fhir.Model.FhirDateTime(DateTime.Parse(remain.periodEnd.ToString()));
                    p.Period = period;
                }
                
                //Practitioner Speciality
                if (remain.specialty != null)
                {
                    Hl7.Fhir.Model.CodeableConcept speciality = new Hl7.Fhir.Model.CodeableConcept();
                    speciality.Coding = new List<Hl7.Fhir.Model.Coding>();
                    Hl7.Fhir.Model.Coding spec = new Hl7.Fhir.Model.Coding();
                    spec.Display = remain.specialty;
                    speciality.Coding.Add(spec);
                    p.Specialty = new List<Hl7.Fhir.Model.CodeableConcept>() { speciality };
                }
                
           

            }

          
            return Hl7.Fhir.Serializers.FhirSerializer.SerializeResourceAsXml(p);
        }

        public String byId(string id)
        {
 
            System.Data.Entity.Infrastructure.DbSqlQuery<g_pess_hosp_def> sqlresult = gE.g_pess_hosp_def.SqlQuery("Select * from g_pess_hosp_def where n_mecan='" + id + "';");
            if (sqlresult.Count() == 0)
            {
                return null;
            }
            g_pess_hosp_def practitioner = sqlresult.First();

            System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.Practitioner> secondResult = glE.Practitioner.SqlQuery("Select * from Practitioner where n_mecan=" + id + ";");
            MvcApplication1.Practitioner remaining;
            if (secondResult.Count() != 0)
                remaining = secondResult.First();
            else
                remaining = null;

            return practitionerParser(practitioner, remaining);
        }

        public string search(HttpRequestBase pr)
        {
            List<Object> l = new List<Object>();
            int i = 0;

            int pageNum, itemNum;

            if (String.IsNullOrEmpty(pr.QueryString["page"]))
                pageNum = 1;
            else
                pageNum = int.Parse(pr.QueryString["page"]);


            if (String.IsNullOrEmpty(pr.QueryString["_count"]))
                itemNum = 10;
            else
                itemNum = int.Parse(pr.QueryString["_count"]);


            string query1 = "Select * from g_pess_hosp_def where ";
            foreach (string querykeys in pr.QueryString.Keys)
            {
                if (Practitioner.ParamToDic.ContainsKey(querykeys))
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

            }

            query1 += ";";
            System.Data.Entity.Infrastructure.DbSqlQuery<g_pess_hosp_def> res = gE.g_pess_hosp_def.SqlQuery(query1, l.ToArray());
            if (res.Count() > 1)
            {
                return generateFeed(res, res.Count(), pageNum, itemNum);
            }
            else if (res.Count() == 1)
            {
                System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.Practitioner> secondResult = glE.Practitioner.SqlQuery("Select * from Practitioner where n_mecan=" + res.First().n_mecan + ";");
                MvcApplication1.Practitioner remaining;
                if (secondResult.Count() != 0)
                    remaining = secondResult.First();
                else
                    remaining = null;

                return practitionerParser(res.First(), remaining);
            }
            else
            {
                return null;
            }
        }

        public string generateFeed(System.Data.Entity.Infrastructure.DbSqlQuery<g_pess_hosp_def> res, int count, int pageNum, int itemNum)
        {
            StringBuilder feed = new StringBuilder();
            feed.AppendLine(@"<feed xmlns=""http://www.w3.org/2005/Atom"">");
            feed.AppendLine(@"<title>g-patient feed</title>");
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
            String basicURL = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath + "practitioner";
            feed.AppendFormat(@"<link rel=""self"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url));
            feed.AppendFormat(@"<link rel=""first"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + "1"));
            if (!(url.Remove(url.Length - 1) + prev.ToString()).Equals(url))
                feed.AppendFormat(@"<link rel=""previous"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + prev.ToString()));
            if (!(url.Remove(url.Length - 1) + next.ToString()).Equals(url))
                feed.AppendFormat(@"<link rel=""next"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + next.ToString()));
            feed.AppendFormat(@"<link rel=""last"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + last.ToString()));

            feed.AppendLine(@"<author>");
            feed.AppendLine(@"<name>g-patient</name>");
            feed.AppendLine(@"</author>");

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
            feed.AppendLine(@"<category term=""Practitioner"" scheme=""http://hl7.org/fhir/sid/fhir/resource-types""/>");
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
                    System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.Practitioner> secondResult = glE.Practitioner.SqlQuery("Select * from Practitioner where n_mecan=" + res.First().n_mecan + ";");
                    MvcApplication1.Practitioner remaining;
                    if (secondResult.Count() != 0)
                        remaining = secondResult.First();
                    else
                        remaining = null;

                    feed.AppendFormat(@"<link href=""{0}"" />", HttpUtility.HtmlEncode(basicURL + "/" + res.ElementAt(j).n_mecan));
                    feed.Append(practitionerParser(res.ElementAt(j), remaining).Replace(@"<?xml version=""1.0"" encoding=""utf-16""?>", ""));
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
            System.Data.Entity.Infrastructure.DbSqlQuery<g_pess_hosp_def> sqlresult = gE.g_pess_hosp_def.SqlQuery("Select * from g_pess_hosp_def where n_mecan=?", key);
            if (sqlresult.Count() != 0)
            {

                String query1 = "update g_pess_hosp_def set ";
                foreach (string querykeys in p.QueryString.Keys)
                {
                    if (Practitioner.ParamToDic.ContainsKey(querykeys) || !querykeys.Equals("_id"))
                    {

                        int j = 0;

                        foreach (string conver in Practitioner.ParamToDic[querykeys])
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

                query1 += " where n_mecan = '" + id  + "' ;";
                gE.Database.ExecuteSqlCommand(query1, l.ToArray());
                gE.SaveChanges();
                return query1;

            }

            return null;
        }



    }
}