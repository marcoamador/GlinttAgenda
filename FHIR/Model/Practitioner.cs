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
    /// A person who is qualified to provide a service
    /// </summary>
    [FhirResource("Practitioner")]
    public partial class Practitioner : Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("PractitionerQualificationComponent")]
        public partial class PractitionerQualificationComponent : Element
        {
            /// <summary>
            /// Qualification
            /// </summary>
            public CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Period during which the qualification is valid
            /// </summary>
            public Period Period { get; set; }
            
            /// <summary>
            /// Organization that regulates and issues the qualification
            /// </summary>
            public ResourceReference Issuer { get; set; }
            
        }
        
        
        /// <summary>
        /// A identifier for the person as this agent
        /// </summary>
        public List<Identifier> Identifier { get; set; }
        
        /// <summary>
        /// Practitioner's personal demographics
        /// </summary>
        public Demographics Details { get; set; }
        
        /// <summary>
        /// The represented organization
        /// </summary>
        public ResourceReference Organization { get; set; }
        
        /// <summary>
        /// A role the practitioner has
        /// </summary>
        public List<CodeableConcept> Role { get; set; }
        
        /// <summary>
        /// Specific specialty of the practitioner
        /// </summary>
        public List<CodeableConcept> Specialty { get; set; }
        
        /// <summary>
        /// The period during which the person is authorized to perform the service
        /// </summary>
        public Period Period { get; set; }
        
        /// <summary>
        /// Qualifications relevant to the provided service
        /// </summary>
        public List<PractitionerQualificationComponent> Qualification { get; set; }
        
    }
    
}
