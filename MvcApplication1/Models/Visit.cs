using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class VisitModel
    {

        private static Dictionary<String, String> ParamToDic = new Dictionary<string, string>() {
            { "_id", "n_cons" }, 
            { "contact", null }, 
            { "fulfills", null },
            { "identifier", "n_cons" },
            { "indication", "observ_cons" },
            { "length", "n-mecan" },
            { "period", "duracao_cons" },
            { "period-before", "dt_cons" },
            { "period-after", "dt_cons" },
            { "responsible", "medico" },
            { "setting", null },
            { "state", "flag_estado" },
            { "subject", "doente" }
        };

        public VisitModel()
        { 
              ge = new glinttEntities();
        }

     glinttEntities ge;

    //RESOURCE REFERENCES->SUBJECT, RESPONSIBLE, FULFILLS, CONTACT, INDICATION 

     public string visitParser(g_cons_marc c) {

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


         v.Identifier = new List<Hl7.Fhir.Model.Identifier>() {idt};
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

     public String byId(string id)
     {
         Object[] key = { id };
         System.Data.Entity.Infrastructure.DbSqlQuery<g_cons_marc> sqlresult = ge.g_cons_marc.SqlQuery("Select * from g_cons_marc where n_cons=?", key);
         if (sqlresult.Count() == 0)
         {
             return null;
         }
         g_cons_marc visit = sqlresult.First();
         return visitParser(visit);
     }
     

  
 
    }


}