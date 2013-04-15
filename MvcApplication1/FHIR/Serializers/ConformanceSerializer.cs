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

using Hl7.Fhir.Model;
using System.Xml;
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for Conformance instances
    */
    internal static partial class ConformanceSerializer
    {
        public static void SerializeConformance(Conformance value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Conformance");
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
            
            // Serialize element date
            if(value.Date != null)
            {
                writer.WriteStartElement("date");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Date, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element publisher
            if(value.Publisher != null)
            {
                writer.WriteStartElement("publisher");
                ConformanceSerializer.SerializeConformancePublisherComponent(value.Publisher, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element software
            if(value.Software != null)
            {
                writer.WriteStartElement("software");
                ConformanceSerializer.SerializeConformanceSoftwareComponent(value.Software, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element implementation
            if(value.Implementation != null)
            {
                writer.WriteStartElement("implementation");
                ConformanceSerializer.SerializeConformanceImplementationComponent(value.Implementation, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element proposal
            if(value.Proposal != null)
            {
                writer.WriteStartElement("proposal");
                ConformanceSerializer.SerializeConformanceProposalComponent(value.Proposal, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element version
            if(value.Version != null)
            {
                writer.WriteStartElement("version");
                IdSerializer.SerializeId(value.Version, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element acceptUnknown
            if(value.AcceptUnknown != null)
            {
                writer.WriteStartElement("acceptUnknown");
                FhirBooleanSerializer.SerializeFhirBoolean(value.AcceptUnknown, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element format
            if(value.Format != null && value.Format.Count > 0)
            {
                writer.WriteStartArrayElement("format");
                foreach(var item in value.Format)
                {
                    writer.WriteStartArrayMember("format");
                    CodeSerializer.SerializeCode(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element rest
            if(value.Rest != null && value.Rest.Count > 0)
            {
                writer.WriteStartArrayElement("rest");
                foreach(var item in value.Rest)
                {
                    writer.WriteStartArrayMember("rest");
                    ConformanceSerializer.SerializeConformanceRestComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element messaging
            if(value.Messaging != null && value.Messaging.Count > 0)
            {
                writer.WriteStartArrayElement("messaging");
                foreach(var item in value.Messaging)
                {
                    writer.WriteStartArrayMember("messaging");
                    ConformanceSerializer.SerializeConformanceMessagingComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element document
            if(value.Document != null && value.Document.Count > 0)
            {
                writer.WriteStartArrayElement("document");
                foreach(var item in value.Document)
                {
                    writer.WriteStartArrayMember("document");
                    ConformanceSerializer.SerializeConformanceDocumentComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeConformanceSoftwareComponent(Conformance.ConformanceSoftwareComponent value, IFhirWriter writer)
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
            
            // Serialize element version
            if(value.Version != null)
            {
                writer.WriteStartElement("version");
                FhirStringSerializer.SerializeFhirString(value.Version, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element releaseDate
            if(value.ReleaseDate != null)
            {
                writer.WriteStartElement("releaseDate");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.ReleaseDate, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceRestComponent(Conformance.ConformanceRestComponent value, IFhirWriter writer)
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
                CodeSerializer.SerializeCode<Conformance.RestfulConformanceMode>(value.Mode, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element documentation
            if(value.Documentation != null)
            {
                writer.WriteStartElement("documentation");
                FhirStringSerializer.SerializeFhirString(value.Documentation, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element security
            if(value.Security != null)
            {
                writer.WriteStartElement("security");
                ConformanceSerializer.SerializeConformanceRestSecurityComponent(value.Security, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element resource
            if(value.Resource != null && value.Resource.Count > 0)
            {
                writer.WriteStartArrayElement("resource");
                foreach(var item in value.Resource)
                {
                    writer.WriteStartArrayMember("resource");
                    ConformanceSerializer.SerializeConformanceRestResourceComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element batch
            if(value.Batch != null)
            {
                writer.WriteStartElement("batch");
                FhirBooleanSerializer.SerializeFhirBoolean(value.Batch, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element history
            if(value.History != null)
            {
                writer.WriteStartElement("history");
                FhirBooleanSerializer.SerializeFhirBoolean(value.History, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceMessagingComponent(Conformance.ConformanceMessagingComponent value, IFhirWriter writer)
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
            
            // Serialize element endpoint
            if(value.Endpoint != null)
            {
                writer.WriteStartElement("endpoint");
                FhirUriSerializer.SerializeFhirUri(value.Endpoint, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element documentation
            if(value.Documentation != null)
            {
                writer.WriteStartElement("documentation");
                FhirStringSerializer.SerializeFhirString(value.Documentation, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element event
            if(value.Event != null && value.Event.Count > 0)
            {
                writer.WriteStartArrayElement("event");
                foreach(var item in value.Event)
                {
                    writer.WriteStartArrayMember("event");
                    ConformanceSerializer.SerializeConformanceMessagingEventComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceImplementationComponent(Conformance.ConformanceImplementationComponent value, IFhirWriter writer)
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
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element url
            if(value.Url != null)
            {
                writer.WriteStartElement("url");
                FhirUriSerializer.SerializeFhirUri(value.Url, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element software
            if(value.Software != null)
            {
                writer.WriteStartElement("software");
                ConformanceSerializer.SerializeConformanceSoftwareComponent(value.Software, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceRestResourceComponent(Conformance.ConformanceRestResourceComponent value, IFhirWriter writer)
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
                CodeSerializer.SerializeCode(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element profile
            if(value.Profile != null)
            {
                writer.WriteStartElement("profile");
                FhirUriSerializer.SerializeFhirUri(value.Profile, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element operation
            if(value.Operation != null && value.Operation.Count > 0)
            {
                writer.WriteStartArrayElement("operation");
                foreach(var item in value.Operation)
                {
                    writer.WriteStartArrayMember("operation");
                    ConformanceSerializer.SerializeConformanceRestResourceOperationComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element readHistory
            if(value.ReadHistory != null)
            {
                writer.WriteStartElement("readHistory");
                FhirBooleanSerializer.SerializeFhirBoolean(value.ReadHistory, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element searchInclude
            if(value.SearchInclude != null && value.SearchInclude.Count > 0)
            {
                writer.WriteStartArrayElement("searchInclude");
                foreach(var item in value.SearchInclude)
                {
                    writer.WriteStartArrayMember("searchInclude");
                    FhirStringSerializer.SerializeFhirString(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element searchParam
            if(value.SearchParam != null && value.SearchParam.Count > 0)
            {
                writer.WriteStartArrayElement("searchParam");
                foreach(var item in value.SearchParam)
                {
                    writer.WriteStartArrayMember("searchParam");
                    ConformanceSerializer.SerializeConformanceRestResourceSearchParamComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceRestResourceOperationComponent(Conformance.ConformanceRestResourceOperationComponent value, IFhirWriter writer)
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
                CodeSerializer.SerializeCode<Conformance.RestfulOperation>(value.Code, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element documentation
            if(value.Documentation != null)
            {
                writer.WriteStartElement("documentation");
                FhirStringSerializer.SerializeFhirString(value.Documentation, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceProposalComponent(Conformance.ConformanceProposalComponent value, IFhirWriter writer)
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
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceMessagingEventComponent(Conformance.ConformanceMessagingEventComponent value, IFhirWriter writer)
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
                CodeSerializer.SerializeCode(value.Code, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element mode
            if(value.Mode != null)
            {
                writer.WriteStartElement("mode");
                CodeSerializer.SerializeCode<Conformance.ConformanceEventMode>(value.Mode, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element protocol
            if(value.Protocol != null && value.Protocol.Count > 0)
            {
                writer.WriteStartArrayElement("protocol");
                foreach(var item in value.Protocol)
                {
                    writer.WriteStartArrayMember("protocol");
                    CodingSerializer.SerializeCoding(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element focus
            if(value.Focus != null)
            {
                writer.WriteStartElement("focus");
                CodeSerializer.SerializeCode(value.Focus, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element request
            if(value.Request != null)
            {
                writer.WriteStartElement("request");
                FhirUriSerializer.SerializeFhirUri(value.Request, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element response
            if(value.Response != null)
            {
                writer.WriteStartElement("response");
                FhirUriSerializer.SerializeFhirUri(value.Response, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element documentation
            if(value.Documentation != null)
            {
                writer.WriteStartElement("documentation");
                FhirStringSerializer.SerializeFhirString(value.Documentation, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceRestSecurityCertificateComponent(Conformance.ConformanceRestSecurityCertificateComponent value, IFhirWriter writer)
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
                CodeSerializer.SerializeCode(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element blob
            if(value.Blob != null)
            {
                writer.WriteStartElement("blob");
                Base64BinarySerializer.SerializeBase64Binary(value.Blob, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceDocumentComponent(Conformance.ConformanceDocumentComponent value, IFhirWriter writer)
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
                CodeSerializer.SerializeCode<Conformance.DocumentMode>(value.Mode, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element documentation
            if(value.Documentation != null)
            {
                writer.WriteStartElement("documentation");
                FhirStringSerializer.SerializeFhirString(value.Documentation, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element profile
            if(value.Profile != null)
            {
                writer.WriteStartElement("profile");
                FhirUriSerializer.SerializeFhirUri(value.Profile, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceRestSecurityComponent(Conformance.ConformanceRestSecurityComponent value, IFhirWriter writer)
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
            
            // Serialize element service
            if(value.Service != null && value.Service.Count > 0)
            {
                writer.WriteStartArrayElement("service");
                foreach(var item in value.Service)
                {
                    writer.WriteStartArrayMember("service");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element certificate
            if(value.Certificate != null && value.Certificate.Count > 0)
            {
                writer.WriteStartArrayElement("certificate");
                foreach(var item in value.Certificate)
                {
                    writer.WriteStartArrayMember("certificate");
                    ConformanceSerializer.SerializeConformanceRestSecurityCertificateComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformancePublisherComponent(Conformance.ConformancePublisherComponent value, IFhirWriter writer)
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
            
            // Serialize element address
            if(value.Address != null)
            {
                writer.WriteStartElement("address");
                AddressSerializer.SerializeAddress(value.Address, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element contact
            if(value.Contact != null && value.Contact.Count > 0)
            {
                writer.WriteStartArrayElement("contact");
                foreach(var item in value.Contact)
                {
                    writer.WriteStartArrayMember("contact");
                    ContactSerializer.SerializeContact(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConformanceRestResourceSearchParamComponent(Conformance.ConformanceRestResourceSearchParamComponent value, IFhirWriter writer)
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
            
            // Serialize element source
            if(value.Source != null)
            {
                writer.WriteStartElement("source");
                FhirUriSerializer.SerializeFhirUri(value.Source, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeSerializer.SerializeCode<SearchParamType>(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element repeats
            if(value.Repeats != null)
            {
                writer.WriteStartElement("repeats");
                CodeSerializer.SerializeCode<SearchRepeatBehavior>(value.Repeats, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element documentation
            if(value.Documentation != null)
            {
                writer.WriteStartElement("documentation");
                FhirStringSerializer.SerializeFhirString(value.Documentation, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element target
            if(value.Target != null && value.Target.Count > 0)
            {
                writer.WriteStartArrayElement("target");
                foreach(var item in value.Target)
                {
                    writer.WriteStartArrayMember("target");
                    CodeSerializer.SerializeCode(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element chain
            if(value.Chain != null && value.Chain.Count > 0)
            {
                writer.WriteStartArrayElement("chain");
                foreach(var item in value.Chain)
                {
                    writer.WriteStartArrayMember("chain");
                    FhirStringSerializer.SerializeFhirString(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
