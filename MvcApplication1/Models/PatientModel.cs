using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{

   
    public class PatientModel
    {
        Hl7.Fhir.Model.Patient p;
        glinttEntities gE;
        public PatientModel() {
            gE = new glinttEntities();
            p = new Hl7.Fhir.Model.Patient();

        }
    
        public string byId(string id){
            g_doente patient= gE.g_doente.Find(id);
           
            Hl7.Fhir.Model.Identifier i=new Hl7.Fhir.Model.Identifier();
            i.Id=patient.doente;
            i.InternalId=patient.t_doente;
            
            p.Identifier.Add(i); //errado

            Hl7.Fhir.Model.Demographics dem = new Hl7.Fhir.Model.Demographics();
            dem.Identifier.Add(i); //errado
            dem.InternalId = patient.t_doente;
            Hl7.Fhir.Model.HumanName human=new Hl7.Fhir.Model.HumanName();
            human.Text=patient.nome;
            dem.Name.Add(human)


            return Hl7.Fhir.Serializers.FhirSerializer.SerializeResourceAsXml(p);
        }
    
    }
  

}