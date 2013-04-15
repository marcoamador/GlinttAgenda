using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class PatientModel
    {
        glinttEntities gE;
        public PatientModel() {
            gE = new glinttEntities();

        }
    }
}