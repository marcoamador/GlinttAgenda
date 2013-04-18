using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class Visit
    {
        Hl7.Fhir.Model.Visit v;
        glinttEntities gE;

        public Visit()
        {
            gE = new glinttEntities();
            v = new Hl7.Fhir.Model.Visit();
        }

        /*public String byId(string id)
        {
            Object[] key = { id };
            g_cons_marc visit = gE.g_cons_marc.SqlQuery("Select * from g_cons_marc where n_cons=?", key).First();

            Hl7.Fhir.Model.Identifier i = new Hl7.Fhir.Model.Identifier();
            i.Id = visit.n_cons;
        }*/
    }
}
