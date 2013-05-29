using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Xml;
using System.Text.RegularExpressions;


namespace MvcApplication1.Models
{
    public class Patient
    {

        private static Dictionary<string, List<string>> ParamToDic = new Dictionary<string, List<string>>() {
            {"_id", new List<string>(){"doente", "t_doente"}},
            {"deceased",new List<string>() {"flag_falec"}},
            {"address",new List<string>() {"morada"}},
            {"birthdate",new List<string>() {"dt_nasc"}},
            {"birthdate-before",new List<string>(){"dt_nasc"}},
            {"birthdate-after",new List<string>(){"dt_nasc"}},
            {"gender",new List<string>(){"sexo"}},
            {"name",new List<string>(){"nome"}},
            {"identifier",new List<string>(){"n_bi", "n_contrib", "cartao_europeu_saude"}},
            {"language",null},
            {"telecom",new List<string>(){"telef1","telef2"}}
        };

        private static Dictionary<string, List<string>> LocalDic = new Dictionary<string, List<string>>() {
            {"deceased_date", new List<string>(){"deceasedDate"}},
            {"active", new List<string>(){"active"}}
        };

        glinttEntities gE;
        glinttLocalEntities glE;

        public Patient()
        {
            gE = new glinttEntities();
            glE = new glinttLocalEntities();
        }


        //Faltam dados da base de dados local
        public String patientParser(g_doente patient, MvcApplication1.Patient remain)
        {
            Hl7.Fhir.Model.Patient p = new Hl7.Fhir.Model.Patient();

            //Patient Identifier
            Hl7.Fhir.Model.Identifier i = new Hl7.Fhir.Model.Identifier();
            i.Label = new Hl7.Fhir.Model.FhirString("doente");
            i.Id = patient.doente;
            //i.InternalId = patient.doente;
            Hl7.Fhir.Model.Identifier id2 = new Hl7.Fhir.Model.Identifier();
            id2.Label = new Hl7.Fhir.Model.FhirString("t_doente");
            id2.Id = patient.t_doente;
            p.Identifier = new List<Hl7.Fhir.Model.Identifier>();
            p.Identifier.Add(i); //errado
            p.Identifier.Add(id2);
            
            //Patient Details
            Hl7.Fhir.Model.Demographics dem = new Hl7.Fhir.Model.Demographics();
            
            //BI
            Hl7.Fhir.Model.Identifier i1 = new Hl7.Fhir.Model.Identifier();
            i1.Id = patient.n_bi;
            i1.Label = "BI";
            dem.Identifier = new List<Hl7.Fhir.Model.Identifier>();
            dem.Identifier.Add(i1); //errado

            //N_Contrib
            Hl7.Fhir.Model.Identifier cc = new Hl7.Fhir.Model.Identifier();
            cc.Id = patient.n_contrib;
            cc.Label = "NIF";
            dem.Identifier.Add(cc);

            //CES
            Hl7.Fhir.Model.Identifier i2 = new Hl7.Fhir.Model.Identifier();
            i2.Id = patient.cartao_europeu_saude;
            i2.Label = "CES";
            dem.Identifier.Add(i2);
            
            //Name
            Hl7.Fhir.Model.HumanName human = new Hl7.Fhir.Model.HumanName();
            human.Given = new List<Hl7.Fhir.Model.FhirString>();

            if (patient.nome.Contains(' '))
            {
                String[] names = patient.nome.Split(' ');
                if (names.Length > 1)
                {
                    for (int k = 0; k < names.Length - 1; k++)
                    {
                        human.Given.Add(names.ElementAt(k));
                    }
                    human.Family = new List<Hl7.Fhir.Model.FhirString>() { names.ElementAt(names.Length - 1) };
                }
                else
                {
                    human.Given.Add(names.ElementAt(0));
                }
            }
            else
                human.Given.Add(patient.nome);

            //Use
            human.Use = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.HumanName.NameUse>(Hl7.Fhir.Model.HumanName.NameUse.Official);
            dem.Name = new List<Hl7.Fhir.Model.HumanName>() { human };
                        
            //Gender
            Hl7.Fhir.Model.Coding gender = new Hl7.Fhir.Model.Coding();
            gender.Code = patient.sexo;
            if (patient.sexo == "M")
                gender.Display = "Masculino";
            else if (patient.sexo == "F")
                gender.Display = "Feminino";

            dem.Gender = gender;
            
            //Birthdate
            DateTime date = DateTime.Parse(patient.dt_nasc.ToString());
            Hl7.Fhir.Model.FhirDateTime dt_nasc = new Hl7.Fhir.Model.FhirDateTime(date.Date);
            dem.BirthDate = dt_nasc;

            //isDead
            Hl7.Fhir.Model.FhirBoolean dead = new Hl7.Fhir.Model.FhirBoolean();
            if (patient.flag_falec != "1!")
                dem.Deceased = false;
            else
                dem.Deceased = true;
            
            //Address
            Hl7.Fhir.Model.Address address = new Hl7.Fhir.Model.Address();
            address.Use = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Address.AddressUse>(Hl7.Fhir.Model.Address.AddressUse.Home);
            address.City = patient.localidade;
            address.Country = getCountry(patient.cod_pais); 
            address.Zip = patient.cod_postal;
            address.Line = new List<Hl7.Fhir.Model.FhirString>(){patient.morada};
            dem.Address = new List<Hl7.Fhir.Model.Address>(){address};

            //Telecom
            dem.Telecom = new List<Hl7.Fhir.Model.Contact>();
            Hl7.Fhir.Model.Contact contact1 = new Hl7.Fhir.Model.Contact();
            contact1.Value = patient.telef1;
            contact1.Use = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contact.ContactUse>(Hl7.Fhir.Model.Contact.ContactUse.Mobile);
            contact1.System = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contact.ContactSystem>(Hl7.Fhir.Model.Contact.ContactSystem.Phone);
            Hl7.Fhir.Model.Contact contact2 = new Hl7.Fhir.Model.Contact();
            contact2.Value = patient.telef2;
            contact2.Use = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contact.ContactUse>(Hl7.Fhir.Model.Contact.ContactUse.Home);
            contact2.System = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contact.ContactSystem>(Hl7.Fhir.Model.Contact.ContactSystem.Phone);

            Hl7.Fhir.Model.Contact contact3 = new Hl7.Fhir.Model.Contact();
            contact3.Value = patient.e_mail;
            contact3.System = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contact.ContactSystem>(Hl7.Fhir.Model.Contact.ContactSystem.Email);
            dem.Telecom.Add(contact1);
            dem.Telecom.Add(contact2);
            dem.Telecom.Add(contact3);
            

            //Marital Status
            dem.MaritalStatus = new Hl7.Fhir.Model.CodeableConcept();
            dem.MaritalStatus.Coding = new List<Hl7.Fhir.Model.Coding>();
            Hl7.Fhir.Model.Coding marCoding = new Hl7.Fhir.Model.Coding();
            marCoding.Code = patient.estado_civil;

            if (patient.estado_civil == "ca")
                marCoding.Display = "Casado";
            else if (patient.estado_civil == "so")
                marCoding.Display = "Solteiro";
            else if (patient.estado_civil == "div")
                marCoding.Display = "Divorciado";
            else if (patient.estado_civil == "vi")
                marCoding.Display = "Viúvo";
            else if (patient.estado_civil == "oth")
                marCoding.Display = "Outro";

            dem.MaritalStatus.Coding.Add(marCoding);

            p.Details = dem;



            if (remain != null){
                
                //Active
                Hl7.Fhir.Model.FhirBoolean active = new Hl7.Fhir.Model.FhirBoolean();
                active = remain.active;
                p.Active = active;

                //DeceasedDate
                if (remain.deceasedDate != null)
                {
                    DateTime dDate = DateTime.Parse(remain.deceasedDate.ToString());
                    Hl7.Fhir.Model.FhirDateTime deceasedDate = new Hl7.Fhir.Model.FhirDateTime(dDate);
                    p.DeceasedDate = deceasedDate;
                }

            }

            List<Hl7.Fhir.Model.Patient.ContactComponent> contacts = getContacts(patient.doente, patient.t_doente);

            if (contacts != null)
            {
                p.Contact = new List<Hl7.Fhir.Model.Patient.ContactComponent>();
                p.Contact = contacts;
            }

            return Hl7.Fhir.Serializers.FhirSerializer.SerializeResourceAsXml(p);
        }

        public string getCountry(string cod_pais) {

            string country = null;

            System.Data.Entity.Infrastructure.DbSqlQuery<Country> sqlresult = glE.Country.SqlQuery("Select * from Country where cod_pais=" + cod_pais + ";");
            
            if (sqlresult.Count() == 0)
            {
                return null;
            }

            else
                country = sqlresult.First().ToString();

            return country;

        }

        public List<Hl7.Fhir.Model.Patient.ContactComponent> getContacts(string doente, string t_doente)
        {
            List<Hl7.Fhir.Model.Patient.ContactComponent> list = new List<Hl7.Fhir.Model.Patient.ContactComponent>();
            System.Data.Entity.Infrastructure.DbSqlQuery<ContactPatient> sqlresult = glE.ContactPatient.SqlQuery("Select * from ContactPatient where t_doente=" + t_doente + " and doente= " + t_doente + ";");
            if (sqlresult.Count() == 0)
            {
                return null;
            }

            for (int i = 0; i < sqlresult.Count(); i++)
            {
                System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.Contact> secondResult = glE.Contact.SqlQuery("Select * from Contact where id=" + sqlresult.ElementAt(i).id + ";");
                if (secondResult.Count() == 0)
                {
                    return null;
                }
                for (int j = 0; j < secondResult.Count(); j++)
                {
                    Hl7.Fhir.Model.Patient.ContactComponent contact = new Hl7.Fhir.Model.Patient.ContactComponent();
                    contact.Details = new Hl7.Fhir.Model.Demographics();
                    
                    //Address
                    contact.Details.Address = new List<Hl7.Fhir.Model.Address>();
                    Hl7.Fhir.Model.Address addr = new Hl7.Fhir.Model.Address();
                    addr.Line = new List<Hl7.Fhir.Model.FhirString>() { secondResult.ElementAt(j).address };
                    
                    //BirthDate
                    DateTime cBirth = DateTime.Parse(secondResult.ElementAt(j).birthDate);
                    contact.Details.BirthDate = new Hl7.Fhir.Model.FhirDateTime(cBirth);
                    
                    //Deceased
                    contact.Details.Deceased = new Hl7.Fhir.Model.FhirBoolean(secondResult.ElementAt(j).deceased.Value);
                    
                    //Gender
                    contact.Details.Gender = new Hl7.Fhir.Model.Coding();
                    contact.Details.Gender.Code = secondResult.ElementAt(j).gender;

                    if (secondResult.ElementAt(j).gender == "M")
                        contact.Details.Gender.Display = "Masculino";
                    else if (secondResult.ElementAt(j).gender == "F")
                        contact.Details.Gender.Display = "Feminino";

                    //Name
                    contact.Details.Name = new List<Hl7.Fhir.Model.HumanName>();
                    Hl7.Fhir.Model.HumanName cName = new Hl7.Fhir.Model.HumanName();
                    cName.Given = new List<Hl7.Fhir.Model.FhirString>() { secondResult.ElementAt(j).name };
                    contact.Details.Name.Add(cName);

                    //MaritalStatus
                    contact.Details.MaritalStatus = new Hl7.Fhir.Model.CodeableConcept();
                    contact.Details.MaritalStatus.Coding = new List<Hl7.Fhir.Model.Coding>();
                    Hl7.Fhir.Model.Coding marStatus = new Hl7.Fhir.Model.Coding();
                    marStatus.Code = secondResult.ElementAt(j).maritalStatus;

                    if (secondResult.ElementAt(j).maritalStatus == "ca")
                        marStatus.Display = "Casado";
                    else if (secondResult.ElementAt(j).maritalStatus == "so")
                        marStatus.Display = "Solteiro";
                    else if (secondResult.ElementAt(j).maritalStatus == "div")
                        marStatus.Display = "Divorciado";
                    else if (secondResult.ElementAt(j).maritalStatus == "vi")
                        marStatus.Display = "Viúvo";
                    else if (secondResult.ElementAt(j).maritalStatus == "oth")
                        marStatus.Display = "Outro";

                    contact.Details.MaritalStatus.Coding.Add(marStatus);

                    //Telecom
                    contact.Details.Telecom = new List<Hl7.Fhir.Model.Contact>();
                    Hl7.Fhir.Model.Contact telecom = new Hl7.Fhir.Model.Contact();
                    telecom.Value = secondResult.ElementAt(j).telecom.ToString();
                    telecom.System = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contact.ContactSystem>(Hl7.Fhir.Model.Contact.ContactSystem.Phone);
                    contact.Details.Telecom.Add(telecom);

                    //Relationship
                    contact.Relationship = new List<Hl7.Fhir.Model.CodeableConcept>();
                    Hl7.Fhir.Model.CodeableConcept relationship = new Hl7.Fhir.Model.CodeableConcept();
                    relationship.Coding = new List<Hl7.Fhir.Model.Coding>();
                    Hl7.Fhir.Model.Coding relText = new Hl7.Fhir.Model.Coding();
                    relText.Code = sqlresult.ElementAt(i).relationship;
                    relationship.Coding.Add(relText);
                    contact.Relationship.Add(relationship);

                    list.Add(contact);
                }

                
            }
            return list;
        }

        public String byId(string id)
        {
            System.Data.Entity.Infrastructure.DbSqlQuery<g_doente> sqlresult = gE.g_doente.SqlQuery("Select * from g_doente where t_doente=" + id.Split('_').ElementAt(0) + " and doente= " + id.Split('_').ElementAt(1) + ";");

            if (sqlresult.Count() == 0)
            {
                return null;
            }
            g_doente patient = sqlresult.First();

            System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.Patient> secondResult = glE.Patient.SqlQuery("Select * from Patient where t_doente="+ id.Split('_').ElementAt(0) + " and doente= " + id.Split('_').ElementAt(1) + ";");
            MvcApplication1.Patient remaining;
            if (secondResult.Count() != 0)
                remaining = secondResult.First();
            else
                remaining = null;
            

            return patientParser(patient, remaining);
        }

        public string search(HttpRequestBase p)
        {
            List<Object> l = new List<Object>();
            int i = 0;
            int pageNum, itemNum;

            if (String.IsNullOrEmpty(p.QueryString["page"]))
                pageNum = 1;
            else
                pageNum = int.Parse(p.QueryString["page"]);


            if (String.IsNullOrEmpty(p.QueryString["_count"]))
                itemNum = 10;
            else
                itemNum = int.Parse(p.QueryString["_count"]);

            string query1 = "Select * from g_doente where ";
            foreach (string querykeys in p.QueryString.Keys)
            {
                if (Patient.ParamToDic.ContainsKey(querykeys))
                {
                
                    if (i != 0)
                    {
                        query1 += " and ";
                    }

                    int j = 0;
                    foreach (string conver in Patient.ParamToDic[querykeys])
                    {
                        
                        if (conver != null)
                        {
                            if (j != 0 && querykeys != "_id")
                            {
                                query1 += " or ";
                            }
                            if (j != 0 && querykeys == "_id")
                            {
                                query1 += " and ";
                            }

                            if (querykeys == "birthdate-before")
                                query1 += conver + "<" + "?";
                            else if (querykeys == "birthdate-after")
                                query1 += conver + ">" + "?";
                            else if (querykeys == "name")
                                query1 += conver + " like " + "%?%";
                            else
                                query1 += conver + "=" + "?";


                            if (j == 0 && (querykeys == "_id" || querykeys == "telecom"))
                            {
                                l.Add(p.QueryString[querykeys].Split('_').ElementAt(0));
                            }
                            else if (j != 0 && ( querykeys == "_id" || querykeys == "telecom"))
                            {
                                l.Add(p.QueryString[querykeys].Split('_').ElementAt(1));
                            }
                            else if (j == 1 && querykeys == "identifier")
                            {
                                l.Add(p.QueryString[querykeys].Split('_').ElementAt(1));
                            }
                            else if (j == 2 && querykeys == "identifier")
                            {
                                l.Add(p.QueryString[querykeys].Split('_').ElementAt(2));
                            }
                            else
                                l.Add(p.QueryString[querykeys]);

                            j++;
                        }
                    }
                    i++;
                }
                
            }

            query1 += ";";
            
            System.Data.Entity.Infrastructure.DbSqlQuery<g_doente> res = gE.g_doente.SqlQuery(query1, l.ToArray());

            if (res.Count() > 1)
            {
                return generateFeed(res, res.Count(), pageNum, itemNum);
            }
            else if (res.Count() == 1)
            {
                System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.Patient> rem = glE.Patient.SqlQuery("Select * from Patient where t_doente=" + res.First().t_doente + " and doente=" + res.First().doente + ";");
                MvcApplication1.Patient remaining;
                if (rem.Count() != 0)
                    remaining = rem.First();
                else
                    remaining = null;

                return patientParser(res.First(), remaining);
            }
            else
            {
                return null;
            }
        }

        public string generateFeed(System.Data.Entity.Infrastructure.DbSqlQuery<g_doente> res, int count, int pageNum, int itemNum)
        {
            StringBuilder feed = new StringBuilder();
            feed.AppendLine(@"<feed xmlns=""http://www.w3.org/2005/Atom"">");
            feed.AppendFormat(@"<title>g-patient search page {0}</title>", pageNum.ToString());
            DateTime now = DateTime.Now;
           
            int next = 0, prev = 0, last = 0;

            if ( Math.Ceiling((decimal)(count- ((pageNum-1)*itemNum)) / itemNum) <= pageNum)
                next = pageNum;
            else
                next = pageNum + 1;

            if (Math.Ceiling((decimal)count / itemNum) <= 1)
                last = 1;
            else
                last = (int) Math.Ceiling((decimal) count / itemNum );

            if ( Math.Ceiling( (decimal)count - (pageNum * itemNum) / itemNum) >= pageNum)
                prev = pageNum;
            else
                prev = pageNum - 1;

            String url = HttpContext.Current.Request.Url.AbsoluteUri;
            String basicURL = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath + "patient";
            feed.AppendFormat(@"<link rel=""self"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(url));
            feed.AppendFormat(@"<link rel=""first"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + "1"));
            if(!(url.Remove(url.Length - 1) + prev.ToString()).Equals(url))
                feed.AppendFormat(@"<link rel=""previous"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + prev.ToString()));
            if(!(url.Remove(url.Length - 1) + next.ToString()).Equals(url))
                feed.AppendFormat(@"<link rel=""next"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + next.ToString()));
            feed.AppendFormat(@"<link rel=""last"" href=""{0}"" />", HttpUtility.HtmlEncode(url.Remove(url.Length - 1) + last.ToString()));
            feed.AppendFormat(@"<updated>{0}</updated>", (Common.GetDate(now)).ToString());
            Guid feedId;
            feedId = Guid.NewGuid();
            feed.AppendFormat(@"<id>urn:uuid:{0}</id>", feedId.ToString());

            feed.AppendLine(@"<author>");
            feed.AppendLine(@"<name>g-patient</name>");
            feed.AppendLine(@"</author>");

            feed.AppendLine(@"<entry>");
            feed.AppendLine(@"<title>Search Results</title>");
            Guid entryId = Guid.NewGuid();
            feed.AppendFormat(@"<id>urn:uuid:{0}</id>", HttpUtility.HtmlEncode(entryId.ToString()));

            feed.AppendFormat(@"<link rel=""self"" href=""{0}"" />", HttpUtility.HtmlEncode(url.ToString()));

            DateTime entryTime = DateTime.Now;
            feed.AppendFormat(@"<updated>{0}</updated>", HttpUtility.HtmlEncode((Common.GetDate(entryTime)).ToString()));
            feed.AppendFormat(@"<published>{0}</published>", HttpUtility.HtmlEncode((Common.GetDate(entryTime)).ToString()));
            feed.AppendLine(@"<author>");
            feed.AppendLine(@"<name>g-patient</name>");
            feed.AppendLine(@"</author>");
            feed.AppendLine(@"<category term=""Patient"" scheme=""http://hl7.org/fhir/sid/fhir/resource-types""/>");
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
                    System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.Patient> rem = glE.Patient.SqlQuery("Select * from Patient where t_doente=" + res.ElementAt(j).t_doente + " and doente=" + res.ElementAt(j).doente + ";");
                    MvcApplication1.Patient remaining;
                    if (rem.Count() != 0)
                        remaining = rem.First();
                    else
                        remaining = null;

                    feed.AppendFormat(@"<link href=""{0}"" />", HttpUtility.HtmlEncode(basicURL + "/" + res.ElementAt(j).t_doente));
                    feed.Append(patientParser(res.ElementAt(j), remaining).Replace(@"<?xml version=""1.0"" encoding=""utf-16""?>", ""));
                }
            }
            feed.AppendLine(@"</content>");
            feed.AppendLine(@"</entry>");

            feed.Append(@"</feed>");
            return feed.ToString();
        }

        public String update(HttpRequestBase p, String id)
        {
            int idIndex = 0;
            int telecomIndex = 0;
            List<Object> l = new List<Object>();
            System.Data.Entity.Infrastructure.DbSqlQuery<g_doente> sqlresult = gE.g_doente.SqlQuery("Select * from g_doente where t_doente=" + id.Split('_').ElementAt(0) + " and doente=" + id.Split('_').ElementAt(1) + ";");
            if (sqlresult.Count() != 0)
            {
                int countKeysGlintt = 0;
                int countKeysLocal = 0;
                String query1 = "update g_doente set ";
                foreach (string querykeys in p.QueryString.Keys)
                {
                    if (Patient.ParamToDic.ContainsKey(querykeys) && (!querykeys.Equals("_id") && !querykeys.Equals("birthdate-before") && !querykeys.Equals("birthdate-after")))
                    {
                        if (!Patient.LocalDic.ContainsKey(querykeys))
                        {
                            int j = 0;
                            countKeysGlintt++;
                            foreach (string conver in Patient.ParamToDic[querykeys])
                            {

                                if (conver != null)
                                {
                                    if (j != 0)
                                    {
                                        query1 += " , ";
                                    }

                                    query1 += conver + "=" + "?";
                                    
                                    if (querykeys.Equals("identifier"))
                                    {
                                        l.Add(p.QueryString[querykeys].Split('_').ElementAt(idIndex));
                                        idIndex+=1;
                                    }
                                    else if (querykeys.Equals("telecom"))
                                    {
                                        l.Add(p.QueryString[querykeys].Split('_').ElementAt(telecomIndex));
                                        telecomIndex+=1;
                                    }else
                                        l.Add(p.QueryString[querykeys]);
              
                                    j++;

                                    


                                }
                            }
                        }
                    }

                }

                query1 += " where t_doente = " + id.Split('_').ElementAt(0) + " and doente=" + id.Split('_').ElementAt(1) + ";";
                if (countKeysGlintt > 0)
                {
                    
                    gE.Database.ExecuteSqlCommand(query1, l.ToArray());
                    gE.SaveChanges();
                }
                
                List<Object> newList = new List<Object>();
                System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.Patient> secondResult = glE.Patient.SqlQuery("Select * from Patient where t_doente=" + id.Split('_').ElementAt(0) + " and doente=" + id.Split('_').ElementAt(1) + ";");
                if (secondResult.Count() != 0)
                {
                    String query2 = "update Patient set ";
                    foreach (string querykeys in p.QueryString.Keys)
                    {
                        if (Patient.LocalDic.ContainsKey(querykeys))
                        {

                            int j = 0;
                            countKeysLocal++;
                            foreach (string conver in Patient.LocalDic[querykeys])
                            {

                                if (conver != null)
                                {
                                    if (j != 0)
                                    {
                                        query2 += " , ";
                                    }
                                    query2 += conver + "=" + "?";
                                    newList.Add(p.QueryString[querykeys]);
                                    j++;
                                }
                            }
                        }

                    }
                    query2 += " where t_doente = " + id.Split('_').ElementAt(0) + " and doente=" + id.Split('_').ElementAt(1) + ";";
                    if (countKeysLocal > 0)
                    {
                        
                        glE.Database.ExecuteSqlCommand(query2, newList.ToArray());
                        glE.SaveChanges();
                    }
                }

                return byId(id);

            }

            return null;
        }

    }
}