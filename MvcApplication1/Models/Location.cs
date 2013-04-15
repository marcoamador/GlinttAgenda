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
    /// A place at which services may be provided by, or on behalf of, an Organization
    /// </summary>
    [FhirResource("Location")]
    public partial class Location : Resource
    {
        /// <summary>
        /// Name of the location
        /// </summary>
        public FhirString Name { get; set; }
        
        /// <summary>
        /// Classification of the location
        /// </summary>
        public List<CodeableConcept> Type { get; set; }
        
        /// <summary>
        /// Physical location
        /// </summary>
        public Address Address { get; set; }
        
        /// <summary>
        /// Contact details of the location
        /// </summary>
        public Contact Telecom { get; set; }
        
        /// <summary>
        /// The organization that provides services at the location
        /// </summary>
        public ResourceReference Provider { get; set; }
        
        /// <summary>
        /// Whether the location is still used to provide services
        /// </summary>
        public FhirBoolean Active { get; set; }
        
        /// <summary>
        /// Description of the location
        /// </summary>
        public FhirString Description { get; set; }
        
    }
    
}
