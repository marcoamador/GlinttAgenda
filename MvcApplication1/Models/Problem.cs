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
// Generated on Tue, Apr 9, 2013 08:39+1000 for FHIR v0.08
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Detailed information about problems or diagnoses
    /// </summary>
    [FhirResource("Problem")]
    public partial class Problem : Resource
    {
        /// <summary>
        /// The type of relationship between a problem/diagnosis and it's related item
        /// </summary>
        public enum ProblemRelationshipType
        {
            DueTo,
            Follows,
        }
        
        /// <summary>
        /// Conversion of ProblemRelationshipTypefrom and into string
        /// <summary>
        public static class ProblemRelationshipTypeHandling
        {
            public static bool TryParse(string value, out ProblemRelationshipType result)
            {
                result = default(ProblemRelationshipType);
                
                if( value=="due-to")
                    result = ProblemRelationshipType.DueTo;
                else if( value=="follows")
                    result = ProblemRelationshipType.Follows;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(ProblemRelationshipType value)
            {
                if( value==ProblemRelationshipType.DueTo )
                    return "due-to";
                else if( value==ProblemRelationshipType.Follows )
                    return "follows";
                else
                    throw new ArgumentException("Unrecognized ProblemRelationshipType value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProblemStageComponent")]
        public partial class ProblemStageComponent : Element
        {
            /// <summary>
            /// Simple summary (disease specific)
            /// </summary>
            public CodeableConcept Summary { get; set; }
            
            /// <summary>
            /// Formal record of assessment
            /// </summary>
            public List<ResourceReference> Assessment { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProblemLocationComponent")]
        public partial class ProblemLocationComponent : Element
        {
            /// <summary>
            /// Location - may include laterality
            /// </summary>
            public CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Precise location details
            /// </summary>
            public ResourceReference Details { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProblemEvidenceComponent")]
        public partial class ProblemEvidenceComponent : Element
        {
            /// <summary>
            /// Manifestation/symptom
            /// </summary>
            public CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Supporting information found elsewhere
            /// </summary>
            public List<ResourceReference> Details { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ProblemRelatedItemComponent")]
        public partial class ProblemRelatedItemComponent : Element
        {
            /// <summary>
            /// due-to | follows
            /// </summary>
            public Code<Problem.ProblemRelationshipType> Type { get; set; }
            
            /// <summary>
            /// Relationship target
            /// </summary>
            public ResourceReference Target { get; set; }
            
        }
        
        
        /// <summary>
        /// Subject of this problem
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Encounter during which the problem was first asserted
        /// </summary>
        public ResourceReference Encounter { get; set; }
        
        /// <summary>
        /// Person who asserts this problem
        /// </summary>
        public ResourceReference Asserter { get; set; }
        
        /// <summary>
        /// When the first detected/suspected/entered
        /// </summary>
        public Date DateAsserted { get; set; }
        
        /// <summary>
        /// Identification of the problem or diagnosis
        /// </summary>
        public CodeableConcept Code { get; set; }
        
        /// <summary>
        /// E.g. finding | problem | diagnosis | concern
        /// </summary>
        public CodeableConcept Category { get; set; }
        
        /// <summary>
        /// provisional | working | confirmed | refuted
        /// </summary>
        public Code Status { get; set; }
        
        /// <summary>
        /// Degree of confidence
        /// </summary>
        public CodeableConcept Certainty { get; set; }
        
        /// <summary>
        /// Subjective severity of problem/diagnosis
        /// </summary>
        public CodeableConcept Severity { get; set; }
        
        /// <summary>
        /// Estimated or actual date, or age
        /// </summary>
        public Element Onset { get; set; }
        
        /// <summary>
        /// If/when in resolution/remission
        /// </summary>
        public Element Abatement { get; set; }
        
        /// <summary>
        /// Stage/grade, usually assessed formally
        /// </summary>
        public ProblemStageComponent Stage { get; set; }
        
        /// <summary>
        /// Supporting evidence
        /// </summary>
        public List<ProblemEvidenceComponent> Evidence { get; set; }
        
        /// <summary>
        /// Snatomical location, if relevant
        /// </summary>
        public List<ProblemLocationComponent> Location { get; set; }
        
        /// <summary>
        /// Causes or precedents for this problem
        /// </summary>
        public List<ProblemRelatedItemComponent> RelatedItem { get; set; }
        
    }
    
}
