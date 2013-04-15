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
    /// A grouping of people or organizations with a common purpose
    /// </summary>
    [FhirResource("Organization")]
    public partial class Organization : Resource
    {
        /// <summary>
        /// The status of the record of this organization
        /// </summary>
        public enum RecordStatus
        {
            Active, // The state representing the fact that the Entity record is currently active.
            Inactive, // The state representing the fact that the Entity record is currently inactive.
        }
        
        /// <summary>
        /// Conversion of RecordStatusfrom and into string
        /// <summary>
        public static class RecordStatusHandling
        {
            public static bool TryParse(string value, out RecordStatus result)
            {
                result = default(RecordStatus);
                
                if( value=="active")
                    result = RecordStatus.Active;
                else if( value=="inactive")
                    result = RecordStatus.Inactive;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(RecordStatus value)
            {
                if( value==RecordStatus.Active )
                    return "active";
                else if( value==RecordStatus.Inactive )
                    return "inactive";
                else
                    throw new ArgumentException("Unrecognized RecordStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("OrganizationRelatedOrganizationComponent")]
        public partial class OrganizationRelatedOrganizationComponent : Element
        {
            /// <summary>
            /// The related organization
            /// </summary>
            public ResourceReference Organization { get; set; }
            
            /// <summary>
            /// How the organizations are related
            /// </summary>
            public CodeableConcept Relation { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("OrganizationContactPersonComponent")]
        public partial class OrganizationContactPersonComponent : Element
        {
            /// <summary>
            /// The type of contact person
            /// </summary>
            public CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Details of the contact person
            /// </summary>
            public Demographics Details { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("OrganizationAccreditationComponent")]
        public partial class OrganizationAccreditationComponent : Element
        {
            /// <summary>
            /// Identifier for the accreditation
            /// </summary>
            public Identifier Identifier { get; set; }
            
            /// <summary>
            /// What kind of accreditation
            /// </summary>
            public CodeableConcept Code { get; set; }
            
            /// <summary>
            /// Who conferred accreditation
            /// </summary>
            public ResourceReference Issuer { get; set; }
            
            /// <summary>
            /// When the accreditation is valid (date only)
            /// </summary>
            public Period Period { get; set; }
            
        }
        
        
        /// <summary>
        /// Identifier for this organization
        /// </summary>
        public List<Identifier> Identifier { get; set; }
        
        /// <summary>
        /// Name used for the organization
        /// </summary>
        public List<FhirString> Name { get; set; }
        
        /// <summary>
        /// Kind of organization
        /// </summary>
        public CodeableConcept Type { get; set; }
        
        /// <summary>
        /// An address for the organization
        /// </summary>
        public List<Address> Address { get; set; }
        
        /// <summary>
        /// A contact detail for the organization
        /// </summary>
        public List<Contact> Telecom { get; set; }
        
        /// <summary>
        /// The status of this organization's record
        /// </summary>
        public Code<Organization.RecordStatus> Status { get; set; }
        
        /// <summary>
        /// Formal certifications that convey authority
        /// </summary>
        public List<OrganizationAccreditationComponent> Accreditation { get; set; }
        
        /// <summary>
        /// Sub-, super-, and partner organizations
        /// </summary>
        public List<OrganizationRelatedOrganizationComponent> RelatedOrganization { get; set; }
        
        /// <summary>
        /// Contact person for the organization
        /// </summary>
        public List<OrganizationContactPersonComponent> ContactPerson { get; set; }
        
    }
    
}
