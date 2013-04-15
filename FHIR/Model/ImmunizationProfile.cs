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
    /// An immunization profile
    /// </summary>
    [FhirResource("ImmunizationProfile")]
    public partial class ImmunizationProfile : Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImmunizationProfileRecommendationProtocolComponent")]
        public partial class ImmunizationProfileRecommendationProtocolComponent : Element
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
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImmunizationProfileRecommendationDateCriterionComponent")]
        public partial class ImmunizationProfileRecommendationDateCriterionComponent : Element
        {
            /// <summary>
            /// Date classification of recommendation
            /// </summary>
            public Code Code { get; set; }
            
            /// <summary>
            /// Date recommendation
            /// </summary>
            public FhirDateTime Value { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImmunizationProfileRecommendationSupportingAdverseEventReportComponent")]
        public partial class ImmunizationProfileRecommendationSupportingAdverseEventReportComponent : Element
        {
            /// <summary>
            /// Adverse event report identifier
            /// </summary>
            public List<Id> Id { get; set; }
            
            /// <summary>
            /// Adverse event report classification
            /// </summary>
            public Code ReportType { get; set; }
            
            /// <summary>
            /// Adverse event report date
            /// </summary>
            public FhirDateTime ReportDate { get; set; }
            
            /// <summary>
            /// Adverse event report text
            /// </summary>
            public FhirString Text { get; set; }
            
            /// <summary>
            /// Documented reaction
            /// </summary>
            public List<ResourceReference> Reaction { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ImmunizationProfileRecommendationComponent")]
        public partial class ImmunizationProfileRecommendationComponent : Element
        {
            /// <summary>
            /// Recommendation date
            /// </summary>
            public FhirDateTime RecommendationDate { get; set; }
            
            /// <summary>
            /// Antigen to be administered
            /// </summary>
            public Code VaccineType { get; set; }
            
            /// <summary>
            /// Recommended dose number
            /// </summary>
            public Integer DoseNumber { get; set; }
            
            /// <summary>
            /// Vaccine administration status
            /// </summary>
            public Code ForecastStatus { get; set; }
            
            /// <summary>
            /// Pertinent dates
            /// </summary>
            public List<ImmunizationProfileRecommendationDateCriterionComponent> DateCriterion { get; set; }
            
            /// <summary>
            /// Vaccine Administration Protocol
            /// </summary>
            public ImmunizationProfileRecommendationProtocolComponent Protocol { get; set; }
            
            /// <summary>
            /// Supporting Immunization
            /// </summary>
            public List<ResourceReference> SupportingImmunization { get; set; }
            
            /// <summary>
            /// Supporting adverse event report
            /// </summary>
            public List<ImmunizationProfileRecommendationSupportingAdverseEventReportComponent> SupportingAdverseEventReport { get; set; }
            
            /// <summary>
            /// Supporting Patient Observation
            /// </summary>
            public List<ResourceReference> SupportingPatientObservation { get; set; }
            
        }
        
        
        /// <summary>
        /// Who this profile is for
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Vaccine administration recommendations
        /// </summary>
        public List<ImmunizationProfileRecommendationComponent> Recommendation { get; set; }
        
    }
    
}
