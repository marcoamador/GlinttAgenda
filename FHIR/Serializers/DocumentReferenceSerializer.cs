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
    * Serializer for DocumentReference instances
    */
    internal static partial class DocumentReferenceSerializer
    {
        public static void SerializeDocumentReference(DocumentReference value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("DocumentReference");
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
            
            // Serialize element identifier
            if(value.Identifier != null && value.Identifier.Count > 0)
            {
                writer.WriteStartArrayElement("identifier");
                foreach(var item in value.Identifier)
                {
                    writer.WriteStartArrayMember("identifier");
                    IdentifierSerializer.SerializeIdentifier(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element subject
            if(value.Subject != null)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element category
            if(value.Category != null && value.Category.Count > 0)
            {
                writer.WriteStartArrayElement("category");
                foreach(var item in value.Category)
                {
                    writer.WriteStartArrayMember("category");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
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
            
            // Serialize element custodian
            if(value.Custodian != null)
            {
                writer.WriteStartElement("custodian");
                ResourceReferenceSerializer.SerializeResourceReference(value.Custodian, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element authenticator
            if(value.Authenticator != null)
            {
                writer.WriteStartElement("authenticator");
                ResourceReferenceSerializer.SerializeResourceReference(value.Authenticator, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element created
            if(value.Created != null)
            {
                writer.WriteStartElement("created");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Created, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element indexed
            if(value.Indexed != null)
            {
                writer.WriteStartElement("indexed");
                InstantSerializer.SerializeInstant(value.Indexed, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.Status != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<DocumentReference.DocumentReferenceStatus>(value.Status, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element docStatus
            if(value.DocStatus != null)
            {
                writer.WriteStartElement("docStatus");
                CodeableConceptSerializer.SerializeCodeableConcept(value.DocStatus, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element supercedes
            if(value.Supercedes != null)
            {
                writer.WriteStartElement("supercedes");
                ResourceReferenceSerializer.SerializeResourceReference(value.Supercedes, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element confidentiality
            if(value.Confidentiality != null)
            {
                writer.WriteStartElement("confidentiality");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Confidentiality, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element primaryLanguage
            if(value.PrimaryLanguage != null)
            {
                writer.WriteStartElement("primaryLanguage");
                CodeSerializer.SerializeCode(value.PrimaryLanguage, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element format
            if(value.Format != null)
            {
                writer.WriteStartElement("format");
                CodeSerializer.SerializeCode(value.Format, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element size
            if(value.Size != null)
            {
                writer.WriteStartElement("size");
                IntegerSerializer.SerializeInteger(value.Size, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element hash
            if(value.Hash != null)
            {
                writer.WriteStartElement("hash");
                FhirStringSerializer.SerializeFhirString(value.Hash, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element location
            if(value.Location != null)
            {
                writer.WriteStartElement("location");
                FhirUriSerializer.SerializeFhirUri(value.Location, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element service
            if(value.Service != null)
            {
                writer.WriteStartElement("service");
                DocumentReferenceSerializer.SerializeDocumentReferenceServiceComponent(value.Service, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element context
            if(value.Context != null)
            {
                writer.WriteStartElement("context");
                DocumentReferenceSerializer.SerializeDocumentReferenceContextComponent(value.Context, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeDocumentReferenceContextComponent(DocumentReference.DocumentReferenceContextComponent value, IFhirWriter writer)
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
            
            // Serialize element facilityType
            if(value.FacilityType != null)
            {
                writer.WriteStartElement("facilityType");
                CodeableConceptSerializer.SerializeCodeableConcept(value.FacilityType, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDocumentReferenceServiceParameterComponent(DocumentReference.DocumentReferenceServiceParameterComponent value, IFhirWriter writer)
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
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.Name, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element value
            if(value.Value != null)
            {
                writer.WriteStartElement("value");
                FhirStringSerializer.SerializeFhirString(value.Value, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDocumentReferenceServiceComponent(DocumentReference.DocumentReferenceServiceComponent value, IFhirWriter writer)
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
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element parameter
            if(value.Parameter != null && value.Parameter.Count > 0)
            {
                writer.WriteStartArrayElement("parameter");
                foreach(var item in value.Parameter)
                {
                    writer.WriteStartArrayMember("parameter");
                    DocumentReferenceSerializer.SerializeDocumentReferenceServiceParameterComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
