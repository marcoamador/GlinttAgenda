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
    /// A document that contains resources
    /// </summary>
    [FhirResource("Document")]
    public partial class Document : Resource
    {
        /// <summary>
        /// The way in which a person authenticated a document
        /// </summary>
        public enum DocumentAttestationMode
        {
            Personal, // The person authenticated the document in their personal capacity
            Professional, // The person authenticated the document in their professional capacity
            Legal, // The person authenticated the document and accepted legal responsibility for its content
            Official, // The organization authenticated the document as consistent with their policies and procedures
        }
        
        /// <summary>
        /// Conversion of DocumentAttestationModefrom and into string
        /// <summary>
        public static class DocumentAttestationModeHandling
        {
            public static bool TryParse(string value, out DocumentAttestationMode result)
            {
                result = default(DocumentAttestationMode);
                
                if( value=="personal")
                    result = DocumentAttestationMode.Personal;
                else if( value=="professional")
                    result = DocumentAttestationMode.Professional;
                else if( value=="legal")
                    result = DocumentAttestationMode.Legal;
                else if( value=="official")
                    result = DocumentAttestationMode.Official;
                else
                    return false;
                
                return true;
            }
            
            public static string ToString(DocumentAttestationMode value)
            {
                if( value==DocumentAttestationMode.Personal )
                    return "personal";
                else if( value==DocumentAttestationMode.Professional )
                    return "professional";
                else if( value==DocumentAttestationMode.Legal )
                    return "legal";
                else if( value==DocumentAttestationMode.Official )
                    return "official";
                else
                    throw new ArgumentException("Unrecognized DocumentAttestationMode value: " + value.ToString());
            }
        }
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("SectionComponent")]
        public partial class SectionComponent : Element
        {
            /// <summary>
            /// Classification of section (recommended)
            /// </summary>
            public CodeableConcept Code { get; set; }
            
            /// <summary>
            /// If section different to document
            /// </summary>
            public ResourceReference Subject { get; set; }
            
            /// <summary>
            /// The actual data for the section
            /// </summary>
            public ResourceReference Content { get; set; }
            
            /// <summary>
            /// Nested Section
            /// </summary>
            public List<SectionComponent> Section { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DocumentAttesterComponent")]
        public partial class DocumentAttesterComponent : Element
        {
            /// <summary>
            /// personal | professional | legal | official
            /// </summary>
            public Code<Document.DocumentAttestationMode> Mode { get; set; }
            
            /// <summary>
            /// When document attested
            /// </summary>
            public FhirDateTime Time { get; set; }
            
            /// <summary>
            /// Who attested the document
            /// </summary>
            public ResourceReference Party { get; set; }
            
        }
        
        
        /// <summary>
        /// null
        /// </summary>
        [FhirComposite("DocumentEventComponent")]
        public partial class DocumentEventComponent : Element
        {
            /// <summary>
            /// Code(s) that apply to the event being documented
            /// </summary>
            public List<CodeableConcept> Code { get; set; }
            
            /// <summary>
            /// The period covered by the document
            /// </summary>
            public Period Period { get; set; }
            
            /// <summary>
            /// Full details for the event(s) the document concents
            /// </summary>
            public List<ResourceReference> Detail { get; set; }
            
        }
        
        
        /// <summary>
        /// Logical identifier for document (version-independent)
        /// </summary>
        public Identifier Id { get; set; }
        
        /// <summary>
        /// Version-specific identifier for document
        /// </summary>
        public Identifier VersionId { get; set; }
        
        /// <summary>
        /// Document creation time
        /// </summary>
        public Instant Created { get; set; }
        
        /// <summary>
        /// Particular kind of document
        /// </summary>
        public Coding Class { get; set; }
        
        /// <summary>
        /// Kind of document (LOINC if possible)
        /// </summary>
        public CodeableConcept Type { get; set; }
        
        /// <summary>
        /// Document title
        /// </summary>
        public FhirString Title { get; set; }
        
        /// <summary>
        /// As defined by affinity domain
        /// </summary>
        public Coding Confidentiality { get; set; }
        
        /// <summary>
        /// Who/what the document is about
        /// </summary>
        public ResourceReference Subject { get; set; }
        
        /// <summary>
        /// Who/what authored the final document
        /// </summary>
        public List<ResourceReference> Author { get; set; }
        
        /// <summary>
        /// Attests to accuracy of document
        /// </summary>
        public List<DocumentAttesterComponent> Attester { get; set; }
        
        /// <summary>
        /// Org which maintains the document
        /// </summary>
        public ResourceReference Custodian { get; set; }
        
        /// <summary>
        /// The clinical event/act/item being documented
        /// </summary>
        public DocumentEventComponent Event { get; set; }
        
        /// <summary>
        /// Context of the document
        /// </summary>
        public ResourceReference Encounter { get; set; }
        
        /// <summary>
        /// If this document replaces another
        /// </summary>
        public Id Replaces { get; set; }
        
        /// <summary>
        /// Additional provenance about the document and it's parts
        /// </summary>
        public List<ResourceReference> Provenance { get; set; }
        
        /// <summary>
        /// Stylesheet to use when rendering the document
        /// </summary>
        public Attachment Stylesheet { get; set; }
        
        /// <summary>
        /// Alternative representation of the document
        /// </summary>
        public Attachment Representation { get; set; }
        
        /// <summary>
        /// Document is broken into sections
        /// </summary>
        public List<SectionComponent> Section { get; set; }
        
    }
    
}
