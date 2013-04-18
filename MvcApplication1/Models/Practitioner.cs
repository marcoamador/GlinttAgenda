using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Practitioner
    {
        public Practitioner()
        {
            ge = new glinttEntities();
        }


        glinttEntities ge;

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

        public String byID(int id)
        {
            g_pess_hosp_def d = ge.g_pess_hosp_def.Find(id);
            return practitionerParser(d);

        }

    }
}