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
    /// A reference to a document
    /// </summary>
    [FhirResource("DocumentReference")]
    public partial class DocumentReference : Resource
    {
        /// <summary>
        /// The status of the document reference
        /// </summary>
        public enum DocumentReferenceStatus
        {
            Current, // This is the current reference for this document
            Superceded, // This reference has been superceded by another reference
            Error, // This reference was created in error
        }
        
        /// <summary>
        /// Conversion of DocumentReferenceStatusfrom and into string
        /// <summary>
        public static class DocumentReferenceStatusHandling
        {
            public static bool TryParse(string value, out DocumentReferenceStatus result)
            {
                result = default(DocumentReferenceStatus);
                
                if( value=="current")
                    result = DocumentReferenceStatus.Current;
                else if( value=="superceded")
                    result = DocumentReferenceStatus.Superceded;
                else if( value=="error")
                    result = DocumentReferenceStatus.Error;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(DocumentReferenceStatus value)
            {
                if( value==DocumentReferenceStatus.Current )
                    return "current";
                else if( value==DocumentReferenceStatus.Superceded )
                    return "superceded";
                else if( value==DocumentReferenceStatus.Error )
                    return "error";
                else
                    throw new ArgumentException("Unrecognized DocumentReferenceStatus value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DocumentReferenceContextComponent")]
        public partial class DocumentReferenceContextComponent : Element
        {
            /// <summary>
            /// Type of context (i.e. type of event)
            /// </summary>
            public List<CodeableConcept> Code { get; set; }
            
            /// <summary>
            /// Time described by the document
            /// </summary>
            public Period Period { get; set; }
            
            /// <summary>
            /// Kind of facility where patient was seen
            /// </summary>
            public CodeableConcept FacilityType { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DocumentReferenceServiceParameterComponent")]
        public partial class DocumentReferenceServiceParameterComponent : Element
        {
            /// <summary>
            /// Name of parameter
            /// </summary>
            public FhirString Name { get; set; }
            
            /// <summary>
            /// Parameter value
            /// </summary>
            public FhirString Value { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DocumentReferenceServiceComponent")]
        public partial class DocumentReferenceServiceComponent : Element
        {
            /// <summary>
            /// Type of service (i.e XDS.b)
            /// </summary>
            public CodeableConcept Type { get; set; }
            
            /// <summary>
            /// Service call parameters
            /// </summary>
            public List<DocumentReferenceServiceParameterComponent> Parameter { get; set; }
            
        }
        
        
        /// <summary>
        /// Master Version Specific Identifier
        /// </summary>
        public Identifier Id { get; set; }
        
        /// <summary>
        /// Other identifiers for the document
        /// </summary>
        public List<Identifier> Identifier { get; set; }
        
        /// <summary>
        /// The subject of the document
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// What kind of document this is
        /// </summary>
        public CodeableConcept Type { get; set; }
        
        /// <summary>
        /// Categories this record is in
        /// </summary>
        public List<ResourceReference> Category { get; set; }
        
        /// <summary>
        /// Who/what authored the document
        /// </summary>
        public List<ResourceReference> Author { get; set; }
        
        /// <summary>
        /// Org which maintains the document
        /// </summary>
        public ResourceReference Custodian { get; set; }
        
        /// <summary>
        /// Who authenticated the document
        /// </summary>
        public ResourceReference Authenticator { get; set; }
        
        /// <summary>
        /// Document creation time
        /// </summary>
        public FhirDateTime Created { get; set; }
        
        /// <summary>
        /// When this document reference created
        /// </summary>
        public Instant Indexed { get; set; }
        
        /// <summary>
        /// The status of this document reference
        /// </summary>
        public Code<DocumentReference.DocumentReferenceStatus> Status { get; set; }
        
        /// <summary>
        /// Status of the underlying document
        /// </summary>
        public CodeableConcept DocStatus { get; set; }
        
        /// <summary>
        /// If this document replaces another
        /// </summary>
        public ResourceReference Supercedes { get; set; }
        
        /// <summary>
        /// Human Readable description
        /// </summary>
        public FhirString Description { get; set; }
        
        /// <summary>
        /// Sensitivity of source document
        /// </summary>
        public CodeableConcept Confidentiality { get; set; }
        
        /// <summary>
        /// Primary language of the document
        /// </summary>
        public Code PrimaryLanguage { get; set; }
        
        /// <summary>
        /// Mime type of the document
        /// </summary>
        public Code Format { get; set; }
        
        /// <summary>
        /// Size of the document in bytes
        /// </summary>
        public Integer Size { get; set; }
        
        /// <summary>
        /// HexBinary representation of SHA1
        /// </summary>
        public FhirString Hash { get; set; }
        
        /// <summary>
        /// Where to access the document
        /// </summary>
        public FhirUri Location { get; set; }
        
        /// <summary>
        /// If access is not fully described by location
        /// </summary>
        public DocumentReferenceServiceComponent Service { get; set; }
        
        /// <summary>
        /// Clinical context of document
        /// </summary>
        public DocumentReferenceContextComponent Context { get; set; }
        
    }
    
}
