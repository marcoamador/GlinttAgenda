using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{

   
    public class Patient
    {
        private static Dictionary<string, List<string>> ParamToDic = new Dictionary<string, List<string>>() { { "_id", new List<string>(){"doente"} }, { "active",new List<string>() {"flag_falec"} }, 
                                            { "address",new List<string>() {"morada"} }, { "birthdate",new List<string>() {"dt_nasc"} },{"birthdate-before",new List<string>(){"dt_nasc"}},
                                            {"birthdate-after",new List<string>(){"dt_nasc"}}, {"family",new List<string>(){"last_name"}}, {"gender",new List<string>(){"sexo"}},
                                            {"given",new List<string>(){"nome"}},{"identifier",new List<string>(){"n_bi","cartao_europeu_saude"}},
                                            {"language",null},{"name",new List<string>(){"nome"}},{"phonetic",null},
                                            {"telecom",new List<string>(){"telef1","telef2"}}};
                                            

        Hl7.Fhir.Model.Patient p;
        glinttEntities gE;
        public Patient() {
            gE = new glinttEntities();
            p = new Hl7.Fhir.Model.Patient();

        }

        public String patientParser(g_doente patient){
         
            Hl7.Fhir.Model.Identifier i=new Hl7.Fhir.Model.Identifier();
            i.Id=patient.doente;
            i.InternalId=patient.doente;
            p.Identifier = new List<Hl7.Fhir.Model.Identifier>();
            p.Identifier.Add(i); //errado

            Hl7.Fhir.Model.Demographics dem = new Hl7.Fhir.Model.Demographics();

            Hl7.Fhir.Model.Identifier i1 = new Hl7.Fhir.Model.Identifier();
            i1.Id = patient.n_bi;
            i1.InternalId = patient.t_doente;
            dem.Identifier = new List<Hl7.Fhir.Model.Identifier>();
            dem.Identifier.Add(i1); //errado

            Hl7.Fhir.Model.Identifier i2 = new Hl7.Fhir.Model.Identifier();
            i2.Id = patient.cartao_europeu_saude;
            i2.InternalId = patient.t_doente;
            dem.Identifier.Add(i2);
            dem.InternalId = patient.t_doente;
            Hl7.Fhir.Model.HumanName human=new Hl7.Fhir.Model.HumanName();
            human.Text=patient.nome;
            dem.Name = new List<Hl7.Fhir.Model.HumanName>();
            dem.Name.Add(human); //falta completar
            Hl7.Fhir.Model.Coding gender = new Hl7.Fhir.Model.Coding();
            gender.Code = patient.sexo;
            dem.Gender = gender;
            Hl7.Fhir.Model.Contact c1=new Hl7.Fhir.Model.Contact();
            Hl7.Fhir.Model.Contact c2=new Hl7.Fhir.Model.Contact();
            c1.Value=patient.telef1;
            c2.Value=patient.telef2;
            dem.Telecom = new List<Hl7.Fhir.Model.Contact>();
            dem.Telecom.Add(c1);
            dem.Telecom.Add(c2);
            Hl7.Fhir.Model.FhirDateTime dt_nasc = new Hl7.Fhir.Model.FhirDateTime();
            dt_nasc.Contents = patient.dt_nasc.ToString();
            dem.BirthDate = dt_nasc;
            Hl7.Fhir.Model.FhirBoolean dead=new Hl7.Fhir.Model.FhirBoolean();
            dead.Contents=patient.flag_falec=="1"; //confirmar
            dem.Deceased = dead;
            Hl7.Fhir.Model.Address address = new Hl7.Fhir.Model.Address();
            address.City = patient.localidade;
            address.Country = patient.cod_pais; //confirmar
            address.Zip = patient.cod_postal;
            address.Text = patient.morada;
            dem.Address = new List<Hl7.Fhir.Model.Address>();
            dem.Address.Add(address);
            dem.MaritalStatus = new Hl7.Fhir.Model.CodeableConcept();
            dem.MaritalStatus.Text = patient.estado_civil;

            p.Details = dem;

            //falta familiares

            return Hl7.Fhir.Serializers.FhirSerializer.SerializeResourceAsXml(p);
        }
    
        public String byId(string id){
            Object[] key = { id };
            System.Data.Entity.Infrastructure.DbSqlQuery<g_doente> sqlresult= gE.g_doente.SqlQuery("Select * from g_doente where t_doente=?", key);
            if (sqlresult.Count() == 0) {
                return null;
            }
            g_doente patient= sqlresult.First();
            return patientParser(patient);
        }

        public string search(HttpRequestBase p)
        {
            //System.Data.SqlClient.SqlCommand query = new System.Data.SqlClient.SqlCommand("Select * from aadasd where");
            List<Object> l = new List<Object>();
            int i = 0;
            string query1 = "Select * from g_doente where ";
            foreach(string querykeys in p.QueryString.Keys){
                if (i != 0)
                {
                    query1 += " and ";
                }
                int j = 0;
                foreach (string conver in Patient.ParamToDic[querykeys]) {
                
                    if (conver != null) {
                       // query.Parameters.Add(conver,System.Data.SqlDbType.VarChar);
                        //query.Parameters[conver].Value = p.QueryString[querykeys];
                        if (j != 0)
                        {
                            query1 += " or ";
                        }
                            query1 += conver + "=" + "?";
                        
                        l.Add(p.QueryString[querykeys]);
                        j++;
                        //query += conver + "=" + System.Security.SecurityElement.Escape() + " and ";
                    }  
                }
                i++;
            
            }

            query1 += ";";
            System.Data.Entity.Infrastructure.DbSqlQuery<g_doente> res=gE.g_doente.SqlQuery(query1,l.ToArray());
            if (res.Count() > 0)
            {
                return patientParser(res.First());
            }
            else {
                return null;
            }
        }
    
    }
  

}