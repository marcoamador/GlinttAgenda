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

using Hl7.Fhir.Model;
using System.Xml;
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for Document instances
    */
    internal static partial class DocumentSerializer
    {
        public static void SerializeDocument(Document value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Document");
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element language
            if(value.Language != null)
            {
                writer.WriteStartElement("language");
                CodeSerializer.SerializeCode(value.Language, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element text
            if(value.Text != null)
            {
                writer.WriteStartElement("text");
                NarrativeSerializer.SerializeNarrative(value.Text, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element contained
            if(value.Contained != null && value.Contained.Count > 0)
            {
                writer.WriteStartArrayElement("contained");
                foreach(var item in value.Contained)
                {
                    writer.WriteStartArrayMember("contained");
                    FhirSerializer.SerializeResource(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element id
            if(value.Id != null)
            {
                writer.WriteStartElement("id");
                IdentifierSerializer.SerializeIdentifier(value.Id, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element versionId
            if(value.VersionId != null)
            {
                writer.WriteStartElement("versionId");
                IdentifierSerializer.SerializeIdentifier(value.VersionId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element created
            if(value.Created != null)
            {
                writer.WriteStartElement("created");
                InstantSerializer.SerializeInstant(value.Created, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element class
            if(value.Class != null)
            {
                writer.WriteStartElement("class");
                CodingSerializer.SerializeCoding(value.Class, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element title
            if(value.Title != null)
            {
                writer.WriteStartElement("title");
                FhirStringSerializer.SerializeFhirString(value.Title, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element confidentiality
            if(value.Confidentiality != null)
            {
                writer.WriteStartElement("confidentiality");
                CodingSerializer.SerializeCoding(value.Confidentiality, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element author
            if(value.Author != null && value.Author.Count > 0)
            {
                writer.WriteStartArrayElement("author");
                foreach(var item in value.Author)
                {
                    writer.WriteStartArrayMember("author");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element attester
            if(value.Attester != null && value.Attester.Count > 0)
            {
                writer.WriteStartArrayElement("attester");
                foreach(var item in value.Attester)
                {
                    writer.WriteStartArrayMember("attester");
                    DocumentSerializer.SerializeDocumentAttesterComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element custodian
            if(value.Custodian != null)
            {
                writer.WriteStartElement("custodian");
                ResourceReferenceSerializer.SerializeResourceReference(value.Custodian, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element event
            if(value.Event != null)
            {
                writer.WriteStartElement("event");
                DocumentSerializer.SerializeDocumentEventComponent(value.Event, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element visit
            if(value.Visit != null)
            {
                writer.WriteStartElement("visit");
                ResourceReferenceSerializer.SerializeResourceReference(value.Visit, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element replaces
            if(value.Replaces != null)
            {
                writer.WriteStartElement("replaces");
                IdSerializer.SerializeId(value.Replaces, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element provenance
            if(value.Provenance != null && value.Provenance.Count > 0)
            {
                writer.WriteStartArrayElement("provenance");
                foreach(var item in value.Provenance)
                {
                    writer.WriteStartArrayMember("provenance");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element stylesheet
            if(value.Stylesheet != null)
            {
                writer.WriteStartElement("stylesheet");
                AttachmentSerializer.SerializeAttachment(value.Stylesheet, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element representation
            if(value.Representation != null)
            {
                writer.WriteStartElement("representation");
                AttachmentSerializer.SerializeAttachment(value.Representation, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element section
            if(value.Section != null && value.Section.Count > 0)
            {
                writer.WriteStartArrayElement("section");
                foreach(var item in value.Section)
                {
                    writer.WriteStartArrayMember("section");
                    DocumentSerializer.SerializeSectionComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeSectionComponent(Document.SectionComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element code
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element content
            if(value.Content != null)
            {
                writer.WriteStartElement("content");
                ResourceReferenceSerializer.SerializeResourceReference(value.Content, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element section
            if(value.Section != null && value.Section.Count > 0)
            {
                writer.WriteStartArrayElement("section");
                foreach(var item in value.Section)
                {
                    writer.WriteStartArrayMember("section");
                    DocumentSerializer.SerializeSectionComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDocumentAttesterComponent(Document.DocumentAttesterComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element mode
            if(value.Mode != null)
            {
                writer.WriteStartElement("mode");
                CodeSerializer.SerializeCode<Document.DocumentAttestationMode>(value.Mode, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element time
            if(value.Time != null)
            {
                writer.WriteStartElement("time");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Time, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element party
            if(value.Party != null)
            {
                writer.WriteStartElement("party");
                ResourceReferenceSerializer.SerializeResourceReference(value.Party, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDocumentEventComponent(Document.DocumentEventComponent value, IFhirWriter writer)
        {
            writer.WriteStartComplexContent();
            
            // Serialize element's localId attribute
            if( value.InternalId != null && !String.IsNullOrEmpty(value.InternalId.Contents) )
            	writer.WriteRefIdContents(value.InternalId.Contents);
            
            // Serialize element extension
            if(value.Extension != null && value.Extension.Count > 0)
            {
                writer.WriteStartArrayElement("extension");
                foreach(var item in value.Extension)
                {
                    writer.WriteStartArrayMember("extension");
                    ExtensionSerializer.SerializeExtension(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element code
            if(value.Code != null && value.Code.Count > 0)
            {
                writer.WriteStartArrayElement("code");
                foreach(var item in value.Code)
                {
                    writer.WriteStartArrayMember("code");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element period
            if(value.Period != null)
            {
                writer.WriteStartElement("period");
                PeriodSerializer.SerializePeriod(value.Period, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element detail
            if(value.Detail != null && value.Detail.Count > 0)
            {
                writer.WriteStartArrayElement("detail");
                foreach(var item in value.Detail)
                {
                    writer.WriteStartArrayMember("detail");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
