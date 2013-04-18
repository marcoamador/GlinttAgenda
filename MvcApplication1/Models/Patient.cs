using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{

   
    public class Patient
    {
        Hl7.Fhir.Model.Patient p;
        glinttEntities gE;
        public Patient() {
            gE = new glinttEntities();
            p = new Hl7.Fhir.Model.Patient();

        }

        public String patientParser(g_doente patient){
         
            Hl7.Fhir.Model.Identifier i=new Hl7.Fhir.Model.Identifier();
            i.Id=patient.doente;
            i.InternalId=patient.t_doente;
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
            g_doente patient= gE.g_doente.SqlQuery("Select * from g_doente where t_doente=?",key).First();
            return patientParser(patient);
        }

        public String search(HttpRequestBase req)
        {
            String s = "temp";
            return s;
        }
    
    }
  

}