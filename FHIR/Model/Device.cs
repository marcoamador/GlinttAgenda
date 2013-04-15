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
    /// Identifies a manufactured Device involved in healthcare
    /// </summary>
    [FhirResource("Device")]
    public partial class Device : Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DeviceIdentityComponent")]
        public partial class DeviceIdentityComponent : Element
        {
            /// <summary>
            /// GTIN assigned to this device
            /// </summary>
            public FhirString Gtin { get; set; }
            
            /// <summary>
            /// Lot number of manufacture
            /// </summary>
            public FhirString Lot { get; set; }
            
            /// <summary>
            /// Serial number assigned by the manufacturer
            /// </summary>
            public FhirString SerialNumber { get; set; }
            
            /// <summary>
            /// Date of expiry of this device (if applicable)
            /// </summary>
            public Date Expiry { get; set; }
            
        }
        
        
        /// <summary>
        /// What kind of device this is
        /// </summary>
        public CodeableConcept Type { get; set; }
        
        /// <summary>
        /// Name of device manufacturer
        /// </summary>
        public FhirString Manufacturer { get; set; }
        
        /// <summary>
        /// Model id assigned by the manufacturer
        /// </summary>
        public FhirString Model { get; set; }
        
        /// <summary>
        /// Version number (i.e. software)
        /// </summary>
        public FhirString Version { get; set; }
        
        /// <summary>
        /// Universal Device Id fields
        /// </summary>
        public DeviceIdentityComponent Identity { get; set; }
        
        /// <summary>
        /// Organization responsible for device
        /// </summary>
        public ResourceReference Owner { get; set; }
        
        /// <summary>
        /// Identifier assigned by various organizations
        /// </summary>
        public List<Identifier> AssignedId { get; set; }
        
        /// <summary>
        /// Where the resource is found
        /// </summary>
        public ResourceReference Location { get; set; }
        
        /// <summary>
        /// If the resource is affixed to a person
        /// </summary>
        public ResourceReference Patient { get; set; }
        
        /// <summary>
        /// Details for human/organization for support
        /// </summary>
        public List<Contact> Contact { get; set; }
        
        /// <summary>
        /// Network address to contact device
        /// </summary>
        public FhirUri Url { get; set; }
        
    }
    
}
