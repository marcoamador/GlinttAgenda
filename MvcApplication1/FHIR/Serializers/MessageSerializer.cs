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
    * Serializer for Message instances
    */
    internal static partial class MessageSerializer
    {
        public static void SerializeMessage(Message value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Message");
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
                IdSerializer.SerializeId(value.Id, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element instant
            if(value.Instant != null)
            {
                writer.WriteStartElement("instant");
                InstantSerializer.SerializeInstant(value.Instant, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element event
            if(value.Event != null)
            {
                writer.WriteStartElement("event");
                CodeSerializer.SerializeCode(value.Event, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element response
            if(value.Response != null)
            {
                writer.WriteStartElement("response");
                MessageSerializer.SerializeMessageResponseComponent(value.Response, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element source
            if(value.Source != null)
            {
                writer.WriteStartElement("source");
                MessageSerializer.SerializeMessageSourceComponent(value.Source, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element destination
            if(value.Destination != null)
            {
                writer.WriteStartElement("destination");
                MessageSerializer.SerializeMessageDestinationComponent(value.Destination, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element enterer
            if(value.Enterer != null)
            {
                writer.WriteStartElement("enterer");
                ResourceReferenceSerializer.SerializeResourceReference(value.Enterer, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element author
            if(value.Author != null)
            {
                writer.WriteStartElement("author");
                ResourceReferenceSerializer.SerializeResourceReference(value.Author, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element receiver
            if(value.Receiver != null)
            {
                writer.WriteStartElement("receiver");
                ResourceReferenceSerializer.SerializeResourceReference(value.Receiver, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element responsible
            if(value.Responsible != null)
            {
                writer.WriteStartElement("responsible");
                ResourceReferenceSerializer.SerializeResourceReference(value.Responsible, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element effective
            if(value.Effective != null)
            {
                writer.WriteStartElement("effective");
                PeriodSerializer.SerializePeriod(value.Effective, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element reason
            if(value.Reason != null)
            {
                writer.WriteStartElement("reason");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Reason, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element data
            if(value.Data != null && value.Data.Count > 0)
            {
                writer.WriteStartArrayElement("data");
                foreach(var item in value.Data)
                {
                    writer.WriteStartArrayMember("data");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeMessageDestinationComponent(Message.MessageDestinationComponent value, IFhirWriter writer)
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
            
            // Serialize element target
            if(value.Target != null)
            {
                writer.WriteStartElement("target");
                ResourceReferenceSerializer.SerializeResourceReference(value.Target, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element endpoint
            if(value.Endpoint != null)
            {
                writer.WriteStartElement("endpoint");
                FhirUriSerializer.SerializeFhirUri(value.Endpoint, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeMessageSourceComponent(Message.MessageSourceComponent value, IFhirWriter writer)
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
            
            // Serialize element software
            if(value.Software != null)
            {
                writer.WriteStartElement("software");
                FhirStringSerializer.SerializeFhirString(value.Software, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element version
            if(value.Version != null)
            {
                writer.WriteStartElement("version");
                FhirStringSerializer.SerializeFhirString(value.Version, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element contact
            if(value.Contact != null)
            {
                writer.WriteStartElement("contact");
                ContactSerializer.SerializeContact(value.Contact, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element endpoint
            if(value.Endpoint != null)
            {
                writer.WriteStartElement("endpoint");
                FhirUriSerializer.SerializeFhirUri(value.Endpoint, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeMessageResponseComponent(Message.MessageResponseComponent value, IFhirWriter writer)
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
            
            // Serialize element id
            if(value.Id != null)
            {
                writer.WriteStartElement("id");
                IdSerializer.SerializeId(value.Id, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeSerializer.SerializeCode<Message.ResponseCode>(value.Code, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element details
            if(value.Details != null)
            {
                writer.WriteStartElement("details");
                ResourceReferenceSerializer.SerializeResourceReference(value.Details, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
