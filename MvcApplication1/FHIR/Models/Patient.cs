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
    /// Person or animal receiving care
    /// </summary>
    [FhirResource("Patient")]
    public partial class Patient : Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ContactComponent")]
        public partial class ContactComponent : Element
        {
            /// <summary>
            /// The kind of relationship
            /// </summary>
            public List<CodeableConcept> Relationship { get; set; }
            
            /// <summary>
            /// Details about the contact person
            /// </summary>
            public Demographics Details { get; set; }
            
            /// <summary>
            /// Organization that is associated with the contact
            /// </summary>
            public ResourceReference Organization { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("AnimalComponent")]
        public partial class AnimalComponent : Element
        {
            /// <summary>
            /// E.g. Dog, Cow
            /// </summary>
            public CodeableConcept Species { get; set; }
            
            /// <summary>
            /// E.g. Poodle, Angus
            /// </summary>
            public CodeableConcept Breed { get; set; }
            
            /// <summary>
            /// E.g. Neutered, Intact
            /// </summary>
            public CodeableConcept GenderStatus { get; set; }
            
        }
        
        
        /// <summary>
        /// Other patients linked to this resource
        /// </summary>
        public List<ResourceReference> Link { get; set; }
        
        /// <summary>
        /// Whether this patient record is active (in use)
        /// </summary>
        public FhirBoolean Active { get; set; }
        
        /// <summary>
        /// An identifier for the person as this patient
        /// </summary>
        public List<Identifier> Identifier { get; set; }
        
        /// <summary>
        /// Patient demographics
        /// </summary>
        public Demographics Details { get; set; }
        
        /// <summary>
        /// A contact party for the patient
        /// </summary>
        public List<ContactComponent> Contact { get; set; }
        
        /// <summary>
        /// If this patient is an animal (non-human)
        /// </summary>
        public AnimalComponent Animal { get; set; }
        
        /// <summary>
        /// Organization managing the patient
        /// </summary>
        public ResourceReference Provider { get; set; }
        
        /// <summary>
        /// Indicates whether patient is part of a multiple birth
        /// </summary>
        public Element MultipleBirth { get; set; }
        
        /// <summary>
        /// Date of death of patient
        /// </summary>
        public FhirDateTime DeceasedDate { get; set; }
        
        /// <summary>
        /// Dietary restrictions for the patient
        /// </summary>
        public CodeableConcept Diet { get; set; }
        
    }
    
}
