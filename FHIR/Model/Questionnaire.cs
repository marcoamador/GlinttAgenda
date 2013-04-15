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
    /// A set of answers to predefined lists of questions
    /// </summary>
    [FhirResource("Questionnaire")]
    public partial class Questionnaire : Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SectionComponent")]
        public partial class SectionComponent : Element
        {
            /// <summary>
            /// Code or name of the section on a questionnaire
            /// </summary>
            public CodeableConcept Name { get; set; }
            
            /// <summary>
            /// Specimen details for this group
            /// </summary>
            public List<AnswerComponent> Answer { get; set; }
            
            /// <summary>
            /// Nested questionnaire section
            /// </summary>
            public List<SectionComponent> Section { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("AnswerComponent")]
        public partial class AnswerComponent : Element
        {
            /// <summary>
            /// Code or text of the question answered
            /// </summary>
            public CodeableConcept Name { get; set; }
            
            /// <summary>
            /// The answer
            /// </summary>
            public Element Value { get; set; }
            
            /// <summary>
            /// Support for the given answer
            /// </summary>
            public ResourceReference Evidence { get; set; }
            
            /// <summary>
            /// Remarks about the answer given
            /// </summary>
            public FhirString Remarks { get; set; }
            
        }
        
        
        /// <summary>
        /// registered|interim|final|amended|cancelled|withdrawn
        /// </summary>
        public Code<ObservationStatus> Status { get; set; }
        
        /// <summary>
        /// Date this version was authored
        /// </summary>
        public Instant Authored { get; set; }
        
        /// <summary>
        /// The subject of the questionnaires
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Person that collected the answers
        /// </summary>
        public ResourceReference Author { get; set; }
        
        /// <summary>
        /// The person that answered the questions
        /// </summary>
        public ResourceReference Source { get; set; }
        
        /// <summary>
        /// Name/code for a predefined list of questions
        /// </summary>
        public CodeableConcept Name { get; set; }
        
        /// <summary>
        /// Identification of this questionnaire
        /// </summary>
        public Identifier Identifier { get; set; }
        
        /// <summary>
        /// Primary visit during which the answers were collected
        /// </summary>
        public ResourceReference Visit { get; set; }
        
        /// <summary>
        /// Answers to questions
        /// </summary>
        public List<AnswerComponent> Answer { get; set; }
        
        /// <summary>
        /// Grouped answers
        /// </summary>
        public List<SectionComponent> Section { get; set; }
        
    }
    
}
