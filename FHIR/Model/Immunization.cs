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
    /// An administered immunization
    /// </summary>
    [FhirResource("Immunization")]
    public partial class Immunization : Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImmunizationVaccinationProtocolComponent")]
        public partial class ImmunizationVaccinationProtocolComponent : Element
        {
            /// <summary>
            /// Dose Number
            /// </summary>
            public Integer DoseSequence { get; set; }
            
            /// <summary>
            /// Vaccine Administration Protocol Description
            /// </summary>
            public FhirString Description { get; set; }
            
            /// <summary>
            /// Vaccine Administration Protocol Authority
            /// </summary>
            public ResourceReference Authority { get; set; }
            
            /// <summary>
            /// Vaccine Series
            /// </summary>
            public FhirString Series { get; set; }
            
            /// <summary>
            /// Dose Number Recommendation
            /// </summary>
            public Integer SeriesDoses { get; set; }
            
            /// <summary>
            /// Targeted Disease
            /// </summary>
            public Code DoseTarget { get; set; }
            
            /// <summary>
            /// Dose Status
            /// </summary>
            public Code DoseStatus { get; set; }
            
            /// <summary>
            /// Dose Status Reason
            /// </summary>
            public Code DoseStatusReason { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImmunizationReactionComponent")]
        public partial class ImmunizationReactionComponent : Element
        {
            /// <summary>
            /// Date of reaction to the immunization
            /// </summary>
            public FhirDateTime Date { get; set; }
            
            /// <summary>
            /// Details of the reaction
            /// </summary>
            public ResourceReference Detail { get; set; }
            
            /// <summary>
            /// Self-reported indicator
            /// </summary>
            public FhirBoolean Reported { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImmunizationRefusalComponent")]
        public partial class ImmunizationRefusalComponent : Element
        {
            /// <summary>
            /// Explanation of refusal / exemption
            /// </summary>
            public Code Reason { get; set; }
            
        }
        
        
        /// <summary>
        /// Who this immunization was adminstered to
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Vaccine Ordering Provider Name
        /// </summary>
        public ResourceReference Requester { get; set; }
        
        /// <summary>
        /// Vaccine Administering Provider Name
        /// </summary>
        public ResourceReference Performer { get; set; }
        
        /// <summary>
        /// Vaccine Manufacturer
        /// </summary>
        public ResourceReference Manufacturer { get; set; }
        
        /// <summary>
        /// Vaccine Administration Facility
        /// </summary>
        public ResourceReference Location { get; set; }
        
        /// <summary>
        /// Vaccination  Administration Date
        /// </summary>
        public FhirDateTime Date { get; set; }
        
        /// <summary>
        /// If self-reported
        /// </summary>
        public FhirBoolean Reported { get; set; }
        
        /// <summary>
        /// Vaccine Product Administered
        /// </summary>
        public Code VaccineType { get; set; }
        
        /// <summary>
        /// Vaccine Lot Number
        /// </summary>
        public FhirString LotNumber { get; set; }
        
        /// <summary>
        /// Vaccine Expiration Date
        /// </summary>
        public Date ExpirationDate { get; set; }
        
        /// <summary>
        /// Vaccine  Site of Administration
        /// </summary>
        public Code Site { get; set; }
        
        /// <summary>
        /// Vaccine Route of Administration
        /// </summary>
        public Code Route { get; set; }
        
        /// <summary>
        /// Vaccine dosage
        /// </summary>
        public Quantity DoseQuantity { get; set; }
        
        /// <summary>
        /// Exemption(s)/ Parent Refusal(s) of Vaccine Product Type Administered
        /// </summary>
        public ImmunizationRefusalComponent Refusal { get; set; }
        
        /// <summary>
        /// Details of a reaction that follows immunization
        /// </summary>
        public List<ImmunizationReactionComponent> Reaction { get; set; }
        
        /// <summary>
        /// Vaccine Administration Protocol
        /// </summary>
        public ImmunizationVaccinationProtocolComponent VaccinationProtocol { get; set; }
        
    }
    
}
