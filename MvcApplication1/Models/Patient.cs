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
            {"zipcode", new List<string>() {"cod_postal"}},
            {"city", new List<string>() {"localidade"}},
            {"country", new List<string>() {"pais"}},
            {"maritalStatus", new List<string>() {"estado_civil"}},
            {"birthdate-before",new List<string>(){"dt_nasc"}},
            {"birthdate-after",new List<string>(){"dt_nasc"}},
            {"gender",new List<string>(){"sexo"}},
            {"name",new List<string>(){"nome"}},
            {"given", new List<string>() {"nome"}},
            {"family", new List<string>() {"nome"}},
            {"identifier",new List<string>(){"n_bi", "n_contrib", "cartao_europeu_saude"}},
            {"language",null},
            {"phonetic",null},
            {"provider",null},
            {"telecom",new List<string>(){"telef1","telef2","e_mail"}}
        };

        private static Dictionary<string, List<string>> LocalDic = new Dictionary<string, List<string>>() {
            {"deceased_date", new List<string>(){"deceasedDate"}},
            {"active", new List<string>(){"active"}}
        };

        glinttEntities gE;
        glinttlocalEntities glE;

        public Patient()
        {
            gE = new glinttEntities();
            glE = new glinttlocalEntities();
        }


        //Faltam dados da base de dados local
        public String patientParser(g_doente patient, MvcApplication1.patient remain)
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

            if (patient.estado_civil == "C")
                marCoding.Display = "Casado";
            else if (patient.estado_civil == "S")
                marCoding.Display = "Solteiro";
            else if (patient.estado_civil == "D")
                marCoding.Display = "Divorciado";
            else if (patient.estado_civil == "V")
                marCoding.Display = "Viúvo";

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

            System.Data.Entity.Infrastructure.DbSqlQuery<country> sqlresult = glE.country.SqlQuery("Select * from Country where cod_pais=" + cod_pais + ";");
            
            if (sqlresult.Count() == 0)
            {
                return null;
            }
            return sqlresult.First().pais.ToString();
        }

        public List<Hl7.Fhir.Model.Patient.ContactComponent> getContacts(string doente, string t_doente)
        {
            List<Hl7.Fhir.Model.Patient.ContactComponent> list = new List<Hl7.Fhir.Model.Patient.ContactComponent>();
            System.Data.Entity.Infrastructure.DbSqlQuery<contact> sqlresult = glE.contact.SqlQuery("Select Contact.* from ContactPatient, Contact where ContactPatient.t_doente=" + t_doente + " and ContactPatient.doente= " + doente + " and ContactPatient.id = Contact.id ;");

            if (sqlresult.Count() == 0)
            {
                return null;
            }

           int n = sqlresult.Count();

            for (int i = 0; i < n; i++)
            {
                MvcApplication1.contact element = sqlresult.ElementAt(i);
                Hl7.Fhir.Model.Patient.ContactComponent contact = new Hl7.Fhir.Model.Patient.ContactComponent();
                contact.Details = new Hl7.Fhir.Model.Demographics();              
                    
                //Address
                contact.Details.Address = new List<Hl7.Fhir.Model.Address>();
                Hl7.Fhir.Model.Address addr = new Hl7.Fhir.Model.Address();
                addr.Line = new List<Hl7.Fhir.Model.FhirString>() { element.address };

                if (element.birthDate != null)
                {
                    //BirthDate
                    DateTime cBirth = element.birthDate.Value;
                    contact.Details.BirthDate = new Hl7.Fhir.Model.FhirDateTime(cBirth);
                }
                    
                //Deceased
                contact.Details.Deceased = new Hl7.Fhir.Model.FhirBoolean(element.deceased.Value);
                    
                //Gender
                contact.Details.Gender = new Hl7.Fhir.Model.Coding();
                contact.Details.Gender.Code = element.gender;

                if (element.gender == "M")
                    contact.Details.Gender.Display = "Masculino";
                else if (element.gender == "F")
                    contact.Details.Gender.Display = "Feminino";

                //Name
                contact.Details.Name = new List<Hl7.Fhir.Model.HumanName>();
                Hl7.Fhir.Model.HumanName cName = new Hl7.Fhir.Model.HumanName();
                cName.Given = new List<Hl7.Fhir.Model.FhirString>() { element.name };
                contact.Details.Name.Add(cName);

                //MaritalStatus
                contact.Details.MaritalStatus = new Hl7.Fhir.Model.CodeableConcept();
                contact.Details.MaritalStatus.Coding = new List<Hl7.Fhir.Model.Coding>();
                Hl7.Fhir.Model.Coding marStatus = new Hl7.Fhir.Model.Coding();
                marStatus.Code = element.maritalStatus;

                if (element.maritalStatus == "C")
                    marStatus.Display = "Casado";
                else if (element.maritalStatus == "S")
                    marStatus.Display = "Solteiro";
                else if (element.maritalStatus == "D")
                    marStatus.Display = "Divorciado";
                else if (element.maritalStatus == "V")
                    marStatus.Display = "Viúvo";
                

                contact.Details.MaritalStatus.Coding.Add(marStatus);

                //Telecom
                contact.Details.Telecom = new List<Hl7.Fhir.Model.Contact>();
                Hl7.Fhir.Model.Contact telecom = new Hl7.Fhir.Model.Contact();
                telecom.Value = element.telecom.ToString();
                telecom.System = new Hl7.Fhir.Model.Code<Hl7.Fhir.Model.Contact.ContactSystem>(Hl7.Fhir.Model.Contact.ContactSystem.Phone);
                contact.Details.Telecom.Add(telecom);

                //Relationship
                contact.Relationship = new List<Hl7.Fhir.Model.CodeableConcept>();
                Hl7.Fhir.Model.CodeableConcept relationship = new Hl7.Fhir.Model.CodeableConcept();
                relationship.Coding = new List<Hl7.Fhir.Model.Coding>();
                Hl7.Fhir.Model.Coding relText = new Hl7.Fhir.Model.Coding();
                relText.Code = element.relationship;
                relationship.Coding.Add(relText);
                contact.Relationship.Add(relationship);

                list.Add(contact);
                   
            }

            return list;
        }

        public String byId(string id)
        {
            String[] idSplit = id.Split('_');
            if (idSplit.Length != 2)
                return null;
            if (idSplit.ElementAt(1).Equals(""))
                return null;

            List<object> l = new List<object>();
            l.Add(idSplit.ElementAt(0));
            l.Add(idSplit.ElementAt(1));
            System.Data.Entity.Infrastructure.DbSqlQuery<g_doente> sqlresult = gE.g_doente.SqlQuery("Select * from g_doente where t_doente= ? and doente= ? ;", l.ToArray());

            if (sqlresult.Count() == 0)
            {
                return null;
            }
            g_doente patient = sqlresult.First();

            System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.patient> secondResult = glE.patient.SqlQuery("Select * from Patient where t_doente=? and doente=? ;", l.ToArray());
            MvcApplication1.patient remaining;
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

            if (String.IsNullOrEmpty(p.QueryString["_page"]))
                pageNum = 1;
            else
                pageNum = int.Parse(p.QueryString["_page"]);


            if (String.IsNullOrEmpty(p.QueryString["_count"]))
                itemNum = 10;
            else
                itemNum = int.Parse(p.QueryString["_count"]);

            string query1 = "Select * from g_doente where ";
            foreach (string querykeys in p.QueryString.Keys)
            {
                if (Patient.ParamToDic.ContainsKey(querykeys))
                {
                    if (querykeys == "_id")
                    {
                        String[] idSplit = p.QueryString[querykeys].Split('_');
                        if (idSplit.Length != 2)
                            return null;
                        if (idSplit.ElementAt(0).Equals("") || idSplit.ElementAt(1).Equals(""))
                            return null;
                    }

                    if (querykeys == "identifier")
                    {
                        String[] stringSplit = p.QueryString[querykeys].Split('_');
                        if (stringSplit.Length != 3)
                            return null;
                        if (stringSplit.ElementAt(0).Equals("") || stringSplit.ElementAt(1).Equals("") || stringSplit.ElementAt(2).Equals(""))
                            return null;
                    }
                    if (querykeys == "telecom")
                    {
                        String[] stringSplit = p.QueryString[querykeys].Split('#');
                        if (stringSplit.Length != 3)
                            return null;
                        if (stringSplit.ElementAt(0).Equals("") || stringSplit.ElementAt(1).Equals("") || stringSplit.ElementAt(2).Equals(""))
                            return null;
                    }
                    

                    if (i != 0)
                    {
                        query1 += " and ";
                    }

                    int j = 0;
                    foreach (string conver in Patient.ParamToDic[querykeys])
                    {
                        
                        if (conver != null)
                        {
                            if (Patient.ParamToDic[querykeys].Count > 1 && j==0)
                                query1 += "(";
                            
                            
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
                            else if (querykeys == "name" || querykeys == "given" || querykeys == "family" || querykeys == "address"){
                                query1 += conver + " like " + "?";
                            }                                
                            else
                                query1 += conver + "=" + "?";

                            

                            if (j == 0 && (querykeys == "_id" || querykeys == "identifier"))
                            {
                                l.Add(p.QueryString[querykeys].Split('_').ElementAt(0));
                            }
                            else if (j == 0 && querykeys == "telecom")
                            {
                                l.Add(p.QueryString[querykeys].Split('#').ElementAt(0));
                            }
                            else if (j != 0 && querykeys == "_id")
                            {
                                l.Add(p.QueryString[querykeys].Split('_').ElementAt(1));
                                query1 += " )";
                            }
                            else if (j == 1 && querykeys == "identifier")
                            {
                                l.Add(p.QueryString[querykeys].Split('_').ElementAt(1));
                            }
                            else if (j == 1 && querykeys == "telecom")
                            {
                                l.Add(p.QueryString[querykeys].Split('#').ElementAt(1));
                            }
                            else if (j == 2 && querykeys == "identifier")
                            {
                                l.Add(p.QueryString[querykeys].Split('_').ElementAt(2));
                                query1 += " )";
                            }
                            else if (j == 2 && querykeys == "telecom")
                            {
                                l.Add(p.QueryString[querykeys].Split('#').ElementAt(2));
                                query1 += " )";
                            }
                            else if (querykeys == "name" || querykeys == "given" || querykeys == "family" || querykeys == "address")
                                l.Add("%" + p.QueryString[querykeys].ToLowerInvariant() + "%");
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
            int n = res.Count();

            if (n > 1)
            {
                return generateFeed(res, n, pageNum, itemNum);
            }
            else if (n == 1)
            {

                g_doente elem = res.First();
                
                System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.patient> rem = glE.patient.SqlQuery("Select * from Patient where t_doente=" + elem.t_doente + " and doente=" + elem.doente + ";");
                MvcApplication1.patient remaining;
                if (rem.Count() != 0)
                    remaining = rem.First();
                else
                    remaining = null;

                return patientParser(elem, remaining);
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

            if ( Math.Ceiling((decimal)(count- ((pageNum-1)*itemNum)) / itemNum) < pageNum)
                next = pageNum;
            else
                next = pageNum + 1;

            if (Math.Ceiling((decimal)count / itemNum) <= 1)
                last = 1;
            else
                last = (int) Math.Ceiling((decimal) count / itemNum );

            if (pageNum - 1 < 1)
                prev = pageNum;
            else
                prev = pageNum - 1;

            String url = HttpContext.Current.Request.Url.AbsoluteUri;
            String toAppend = "";
            if (!url.Contains("&_page="))
                toAppend = "&_page=x";

            String basicURL = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + HttpContext.Current.Request.ApplicationPath;
            if (!basicURL.ElementAt(basicURL.Length - 1).Equals('/'))
                basicURL += "/";
            basicURL += "patient";

            string self = (url + toAppend).Remove((url + toAppend).Length - 1) + pageNum;
            string first = (url + toAppend).Remove((url + toAppend).Length - 1) + "1";
            string nextS = (url + toAppend).Remove((url + toAppend).Length - 1) + next.ToString();
            string previous = (url + toAppend).Remove((url + toAppend).Length - 1) + prev.ToString();

            feed.AppendFormat(@"<link rel=""self"" type=""application/atom+xml"" href=""{0}"" />", HttpUtility.HtmlEncode(self));
            feed.AppendFormat(@"<link rel=""first"" href=""{0}"" />", HttpUtility.HtmlEncode(first));
            if (!previous.Equals(self))
                feed.AppendFormat(@"<link rel=""previous"" href=""{0}"" />", HttpUtility.HtmlEncode(previous));
            if (!nextS.Equals(self))
                feed.AppendFormat(@"<link rel=""next"" href=""{0}"" />", HttpUtility.HtmlEncode(nextS));
            feed.AppendFormat(@"<link rel=""last"" href=""{0}"" />", HttpUtility.HtmlEncode((url + toAppend).Remove((url + toAppend).Length - 1) + last.ToString()));

            feed.AppendFormat(@"<updated>{0}</updated>", (Common.GetDate(now)).ToString());
            Guid feedId;
            feedId = Guid.NewGuid();
            feed.AppendFormat(@"<id>urn:uuid:{0}</id>", feedId.ToString());         


            if (count > 0 && count > itemNum * (pageNum - 1))
            {
                int min = 0;
                if (count > (itemNum * pageNum))
                    min = (itemNum * pageNum);
                else
                    min = count;
                for (int j = (itemNum * (pageNum - 1)); j < min; j++)
                {
                    g_doente elem = res.ElementAt(j);
                    
                    System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.patient> rem = glE.patient.SqlQuery("Select * from Patient where t_doente=" + elem.t_doente + " and doente=" + elem.doente + ";");
                    MvcApplication1.patient remaining;
                    if (rem.Count() != 0)
                        remaining = rem.First();
                    else
                        remaining = null;
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
                    feed.AppendFormat(@"<link href=""{0}"" />", HttpUtility.HtmlEncode(basicURL + "/" + elem.t_doente));
                    feed.Append(patientParser(elem, remaining).Replace(@"<?xml version=""1.0"" encoding=""utf-16""?>", ""));
                    feed.AppendLine(@"</content>");
                    feed.AppendLine(@"</entry>");
                }
            }
            

            feed.Append(@"</feed>");
            return feed.ToString();
        }

        public String update(HttpRequestBase p, String id)
        {
            String[] idSplit = id.Split('_');
            if (idSplit.Length != 2)
                return null;
            if (idSplit.ElementAt(1).Equals(""))
                return null;
            
            int idIndex = 0;
            int telecomIndex = 0;
            List<Object> l = new List<Object>();
            List<Object> firstList = new List<Object>();
            firstList.Add(id.Split('_').ElementAt(0));
            firstList.Add(id.Split('_').ElementAt(1));
            System.Data.Entity.Infrastructure.DbSqlQuery<g_doente> sqlresult = gE.g_doente.SqlQuery("Select * from g_doente where t_doente=? and doente=? ;", firstList.ToArray());
            if (sqlresult.Count() != 0)
            {
                int countKeysGlintt = 0;
                int countKeysLocal = 0;
                int z = 0;
                String query1 = "update g_doente set ";
                foreach (string querykeys in p.Form.Keys)
                {
                    if (Patient.ParamToDic.ContainsKey(querykeys) && (!querykeys.Equals("_id") && !querykeys.Equals("birthdate-before") && !querykeys.Equals("birthdate-after")))
                    {
                        if (!Patient.LocalDic.ContainsKey(querykeys))
                        {

                            if (querykeys == "identifier")
                            {
                                String[] stringSplit = p.Form[querykeys].Split('_');
                                if (stringSplit.Length != 3)
                                    return null;
                                if (stringSplit.ElementAt(0).Equals("") || stringSplit.ElementAt(1).Equals("") || stringSplit.ElementAt(2).Equals(""))
                                    return null;
                            }
                            if (querykeys == "telecom")
                            {
                                String[] stringSplit = p.Form[querykeys].Split('#');
                                if (stringSplit.Length != 3)
                                    return null;
                                if (stringSplit.ElementAt(0).Equals("") || stringSplit.ElementAt(1).Equals("") || stringSplit.ElementAt(2).Equals(""))
                                    return null;
                            }

                            
                            countKeysGlintt++;
                            foreach (string conver in Patient.ParamToDic[querykeys])
                            {

                                if (conver != null)
                                {
                                    if (z != 0)
                                    {
                                        query1 += " , ";
                                    }

                                    query1 += conver + "=" + "?";
                                    
                                    if (querykeys.Equals("identifier"))
                                    {
                                        l.Add(p.Form[querykeys].Split('_').ElementAt(idIndex));
                                        idIndex+=1;
                                    }
                                    else if (querykeys.Equals("telecom"))
                                    {
                                        l.Add(p.Form[querykeys].Split('#').ElementAt(telecomIndex));
                                        telecomIndex+=1;
                                    }
                                    else if (querykeys.Equals("maritalStatus"))
                                    {
                                        l.Add(p.Form[querykeys].ElementAt(0).ToString());
                                    }
                                    else
                                        l.Add(p.Form[querykeys]);
              
                                    z++;

                                    


                                }
                            }
                        }
                    }

                }
                query1 += " where t_doente = ? and doente= ? ;";
                if (countKeysGlintt > 0)
                {
                    l.Add(id.Split('_').ElementAt(0));
                    l.Add(id.Split('_').ElementAt(1));
                    gE.Database.ExecuteSqlCommand(query1, l.ToArray());
                    gE.SaveChanges();
                }
                
                List<Object> newList = new List<Object>();
                System.Data.Entity.Infrastructure.DbSqlQuery<MvcApplication1.patient> secondResult = glE.patient.SqlQuery("Select * from Patient where t_doente= ? and doente= ? ;", firstList.ToArray());
                if (secondResult.Count() != 0)
                {
                    String query2 = "update Patient set ";
                    foreach (string querykeys in p.Form.Keys)
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
                                    newList.Add(p.Form[querykeys]);
                                    j++;
                                }
                            }
                        }

                    }
                    query2 += " where t_doente = ? and doente= ? ;";
                    if (countKeysLocal > 0)
                    {
                        newList.Add(id.Split('_').ElementAt(0));
                        newList.Add(id.Split('_').ElementAt(1));

                        glE.Database.ExecuteSqlCommand(query2, newList.ToArray());
                        glE.SaveChanges();
                    }
                }

                return byId(id);

            }

            return null;
        }


        public bool setPassword(string id, string oldp, string newp)
        {
            List<Object> l = new List<Object>() { };
            l.Add(id.Split('_').ElementAt(0));
            l.Add(id.Split('_').ElementAt(1));

            patient p = glE.patient.SqlQuery("select * from patient where doente = ? and t_doente = ?", l.ToArray()).FirstOrDefault();
            
            if (p != null)
            {
                if (p.password == oldp)
                {
                    p.password = newp;
                    glE.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool removePassword(string id, string pw)
        {
            patient p = glE.patient.SqlQuery("select * from patient where doente = ? and t_doente = ?", new List<Object>() { id.Split('_').ElementAt(0), id.Split('_').ElementAt(1) }.ToArray()).FirstOrDefault();
            if (p != null && p.password == pw)
            {
                p.password = null;
                glE.SaveChanges();
                return true;
            }
            return false;
        }
    }
}