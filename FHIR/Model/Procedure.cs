using System;
using System.Collections.Generic;
using Hl7.Fhir.Support;
using System.Xml.Linq;

/*
  Copyright (c) 2011-2012, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Mon, Apr 15, 2013 13:14+1000 for FHIR v0.08
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// An action that is performed on a patient
    /// </summary>
    [FhirResource("Procedure")]
    public partial class Procedure : Resource
    {
        /// <summary>
        /// the nature of the relationship
        /// </summary>
        public enum ProcedureRelationshipType
        {
            CausedBy,
            Caused,
        }
        
        /// <summary>
        /// Conversion of ProcedureRelationshipTypefrom and into string
        /// <summary>
        public static class ProcedureRelationshipTypeHandling
        {
            public static bool TryParse(string value, out ProcedureRelationshipType result)
            {
                result = default(ProcedureRelationshipType);
                
                if( value=="caused-by")
                    result = ProcedureRelationshipType.CausedBy;
                else if( value=="caused")
                    result = ProcedureRelationshipType.Caused;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ProcedureRelationshipType value)
            {
                if( value==ProcedureRelationshipType.CausedBy )
                    return "caused-by";
                else if( value==ProcedureRelationshipType.Caused )
                    return "caused";
                else
                    throw new ArgumentException("Unrecognized ProcedureRelationshipType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProcedureRelatedItemComponent")]
        public partial class ProcedureRelatedItemComponent : Element
        {
            /// <summary>
            /// caused-by | caused
            /// </summary>
            public Code<Procedure.ProcedureRelationshipType> Type { get; set; }
            
            /// <summary>
            /// The related item - eg a procedure
            /// </summary>
            public ResourceReference Target { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProcedureDescriptionComponent")]
        public partial class ProcedureDescriptionComponent : Element
        {
            /// <summary>
            /// Identification of the procedure
            /// </summary>
            public CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Procedure notes
            /// </summary>
            public FhirString Notes { get; set; }
            
            /// <summary>
            /// Precise location details
            /// </summary>
            public List<CodeableConcept> BodySite { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProcedurePerformerComponent")]
        public partial class ProcedurePerformerComponent : Element
        {
            /// <summary>
            /// The reference to the practitioner
            /// </summary>
            public ResourceReference Person { get; set; }
            
            /// <summary>
            /// The role the person was in
            /// </summary>
            public CodeableConcept Role { get; set; }
            
        }
        
        
        /// <summary>
        /// Subject of this procedure
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Description of the procedure
        /// </summary>
        public ProcedureDescriptionComponent Description { get; set; }
        
        /// <summary>
        /// Indications for the procedure
        /// </summary>
        public FhirString Indication { get; set; }
        
        /// <summary>
        /// The people who performed the procedure
        /// </summary>
        public List<ProcedurePerformerComponent> Performer { get; set; }
        
        /// <summary>
        /// The date the procedure was perfomed
        /// </summary>
        public Period Date { get; set; }
        
        /// <summary>
        /// The visit during which the procedure was performed
        /// </summary>
        public ResourceReference Visit { get; set; }
        
        /// <summary>
        /// Outcome of the procuedure
        /// </summary>
        public FhirString Outcome { get; set; }
        
        /// <summary>
        /// Any report that results from the procedure
        /// </summary>
        public List<ResourceReference> Report { get; set; }
        
        /// <summary>
        /// Complications
        /// </summary>
        public FhirString Complication { get; set; }
        
        /// <summary>
        /// Instructions for follow up
        /// </summary>
        public FhirString FollowUp { get; set; }
        
        /// <summary>
        /// A procedure that is related to this one
        /// </summary>
        public List<ProcedureRelatedItemComponent> RelatedItem { get; set; }
        
    }
    
}
