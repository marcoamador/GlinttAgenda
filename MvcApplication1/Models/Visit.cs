using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class VisitModel
    {
        public VisitModel()
        { 
              ge = new glinttEntities();
        }

     glinttEntities ge;

    //STATE, SETTING, 

     public string byID(int id) {

         Hl7.Fhir.Model.Visit v = new Hl7.Fhir.Model.Visit();

         g_cons_marc c = ge.g_cons_marc.Find(id);

         Hl7.Fhir.Model.Identifier idt = new Hl7.Fhir.Model.Identifier();
         idt.Id = c.n_cons;

         Hl7.Fhir.Model.CodeableConcept state = new Hl7.Fhir.Model.CodeableConcept();
         state.Text = c.flag_estado; //TODO errado

         Hl7.Fhir.Model.ResourceReference rr = new Hl7.Fhir.Model.ResourceReference();
         rr.InternalId = c.doente;

         v.Identifier = new List<Hl7.Fhir.Model.Identifier>() {idt};
         v.State = new Hl7.Fhir.Model.CodeableConcept();
         v.Setting = new Hl7.Fhir.Model.CodeableConcept();
         v.Subject = new Hl7.Fhir.Model.ResourceReference();
     }
     

  
 
    }


}