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
    /// A Diagnostic report - a combination of request information, atomic results, images, interpretation, and formatted reports
    /// </summary>
    [FhirResource("DiagnosticReport")]
    public partial class DiagnosticReport : Resource
    {
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DiagnosticReportRequestDetailComponent")]
        public partial class DiagnosticReportRequestDetailComponent : Element
        {
            /// <summary>
            /// Context where request was made
            /// </summary>
            public ResourceReference Encounter { get; set; }
            
            /// <summary>
            /// Id assigned by requester
            /// </summary>
            public Identifier RequestOrderId { get; set; }
            
            /// <summary>
            /// Receiver's Id for the request
            /// </summary>
            public Identifier ReceiverOrderId { get; set; }
            
            /// <summary>
            /// Test Requested
            /// </summary>
            public List<CodeableConcept> RequestTest { get; set; }
            
            /// <summary>
            /// Location of requested test (if applicable)
            /// </summary>
            public CodeableConcept BodySite { get; set; }
            
            /// <summary>
            /// Responsible for request
            /// </summary>
            public ResourceReference Requester { get; set; }
            
            /// <summary>
            /// Clinical information provided
            /// </summary>
            public FhirString ClinicalInfo { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("ResultGroupComponent")]
        public partial class ResultGroupComponent : Element
        {
            /// <summary>
            /// Name/Code for this group of results
            /// </summary>
            public CodeableConcept Name { get; set; }
            
            /// <summary>
            /// Specimen details for this group
            /// </summary>
            public ResourceReference Specimen { get; set; }
            
            /// <summary>
            /// Nested Report Group
            /// </summary>
            public List<ResultGroupComponent> Group { get; set; }
            
            /// <summary>
            /// An atomic data result
            /// </summary>
            public List<ResourceReference> Result { get; set; }
            
        }
        
        
        /// <summary>
        /// registered|interim|final|amended|cancelled|withdrawn
        /// </summary>
        public Code<ObservationStatus> Status { get; set; }
        
        /// <summary>
        /// Date this version was released
        /// </summary>
        public Instant Issued { get; set; }
        
        /// <summary>
        /// The subject of the report
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Responsible Diagnostic Service
        /// </summary>
        public ResourceReference Performer { get; set; }
        
        /// <summary>
        /// Id for external references to this report
        /// </summary>
        public Identifier ReportId { get; set; }
        
        /// <summary>
        /// What was requested
        /// </summary>
        public List<DiagnosticReportRequestDetailComponent> RequestDetail { get; set; }
        
        /// <summary>
        /// Biochemistry, Haematology etc.
        /// </summary>
        public CodeableConcept ServiceCategory { get; set; }
        
        /// <summary>
        /// Effective time of diagnostic report
        /// </summary>
        public FhirDateTime DiagnosticTime { get; set; }
        
        /// <summary>
        /// Results grouped by specimen/kind/category
        /// </summary>
        public ResultGroupComponent Results { get; set; }
        
        /// <summary>
        /// Key images associated with this report
        /// </summary>
        public List<ResourceReference> Image { get; set; }
        
        /// <summary>
        /// Clinical Interpretation of test results
        /// </summary>
        public FhirString Conclusion { get; set; }
        
        /// <summary>
        /// Codes for the conclusion
        /// </summary>
        public List<CodeableConcept> CodedDiagnosis { get; set; }
        
        /// <summary>
        /// Entire Report as issued
        /// </summary>
        public List<Attachment> Representation { get; set; }
        
    }
    
}
