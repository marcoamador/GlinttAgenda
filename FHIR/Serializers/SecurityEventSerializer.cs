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
    * Serializer for SecurityEvent instances
    */
    internal static partial class SecurityEventSerializer
    {
        public static void SerializeSecurityEvent(SecurityEvent value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("SecurityEvent");
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
            
            // Serialize element event
            if(value.Event != null)
            {
                writer.WriteStartElement("event");
                SecurityEventSerializer.SerializeSecurityEventEventComponent(value.Event, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element participant
            if(value.Participant != null && value.Participant.Count > 0)
            {
                writer.WriteStartArrayElement("participant");
                foreach(var item in value.Participant)
                {
                    writer.WriteStartArrayMember("participant");
                    SecurityEventSerializer.SerializeSecurityEventParticipantComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element source
            if(value.Source != null)
            {
                writer.WriteStartElement("source");
                SecurityEventSerializer.SerializeSecurityEventSourceComponent(value.Source, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element object
            if(value.Object != null && value.Object.Count > 0)
            {
                writer.WriteStartArrayElement("object");
                foreach(var item in value.Object)
                {
                    writer.WriteStartArrayMember("object");
                    SecurityEventSerializer.SerializeSecurityEventObjectComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeSecurityEventObjectComponent(SecurityEvent.SecurityEventObjectComponent value, IFhirWriter writer)
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
                CodeSerializer.SerializeCode<SecurityEvent.SecurityEventObjectType>(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element role
            if(value.Role != null)
            {
                writer.WriteStartElement("role");
                CodeSerializer.SerializeCode<SecurityEvent.SecurityEventObjectRole>(value.Role, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element lifecycle
            if(value.Lifecycle != null)
            {
                writer.WriteStartElement("lifecycle");
                CodeSerializer.SerializeCode<SecurityEvent.SecurityEventObjectLifecycle>(value.Lifecycle, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element idType
            if(value.IdType != null)
            {
                writer.WriteStartElement("idType");
                CodingSerializer.SerializeCoding(value.IdType, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element id
            if(value.Id != null)
            {
                writer.WriteStartElement("id");
                FhirStringSerializer.SerializeFhirString(value.Id, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element sensitivity
            if(value.Sensitivity != null)
            {
                writer.WriteStartElement("sensitivity");
                FhirStringSerializer.SerializeFhirString(value.Sensitivity, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.Name, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element query
            if(value.Query != null)
            {
                writer.WriteStartElement("query");
                Base64BinarySerializer.SerializeBase64Binary(value.Query, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeSecurityEventSourceComponent(SecurityEvent.SecurityEventSourceComponent value, IFhirWriter writer)
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
            
            // Serialize element site
            if(value.Site != null)
            {
                writer.WriteStartElement("site");
                FhirStringSerializer.SerializeFhirString(value.Site, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element id
            if(value.Id != null)
            {
                writer.WriteStartElement("id");
                FhirStringSerializer.SerializeFhirString(value.Id, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null && value.Type.Count > 0)
            {
                writer.WriteStartArrayElement("type");
                foreach(var item in value.Type)
                {
                    writer.WriteStartArrayMember("type");
                    CodingSerializer.SerializeCoding(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeSecurityEventEventComponent(SecurityEvent.SecurityEventEventComponent value, IFhirWriter writer)
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
                CodingSerializer.SerializeCoding(value.Id, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element action
            if(value.Action != null)
            {
                writer.WriteStartElement("action");
                CodeSerializer.SerializeCode<SecurityEvent.SecurityEventEventAction>(value.Action, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element dateTime
            if(value.DateTime != null)
            {
                writer.WriteStartElement("dateTime");
                InstantSerializer.SerializeInstant(value.DateTime, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element outcome
            if(value.Outcome != null)
            {
                writer.WriteStartElement("outcome");
                CodeSerializer.SerializeCode<SecurityEvent.SecurityEventEventOutcome>(value.Outcome, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.Code != null && value.Code.Count > 0)
            {
                writer.WriteStartArrayElement("code");
                foreach(var item in value.Code)
                {
                    writer.WriteStartArrayMember("code");
                    CodingSerializer.SerializeCoding(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeSecurityEventParticipantNetworkComponent(SecurityEvent.SecurityEventParticipantNetworkComponent value, IFhirWriter writer)
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
                CodeSerializer.SerializeCode<SecurityEvent.SecurityEventParticipantNetworkType>(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element id
            if(value.Id != null)
            {
                writer.WriteStartElement("id");
                FhirStringSerializer.SerializeFhirString(value.Id, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeSecurityEventParticipantComponent(SecurityEvent.SecurityEventParticipantComponent value, IFhirWriter writer)
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
            
            // Serialize element userId
            if(value.UserId != null)
            {
                writer.WriteStartElement("userId");
                FhirStringSerializer.SerializeFhirString(value.UserId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element otherUserId
            if(value.OtherUserId != null)
            {
                writer.WriteStartElement("otherUserId");
                FhirStringSerializer.SerializeFhirString(value.OtherUserId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.Name, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element requestor
            if(value.Requestor != null)
            {
                writer.WriteStartElement("requestor");
                FhirBooleanSerializer.SerializeFhirBoolean(value.Requestor, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element role
            if(value.Role != null && value.Role.Count > 0)
            {
                writer.WriteStartArrayElement("role");
                foreach(var item in value.Role)
                {
                    writer.WriteStartArrayMember("role");
                    CodingSerializer.SerializeCoding(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element mediaId
            if(value.MediaId != null)
            {
                writer.WriteStartElement("mediaId");
                CodeableConceptSerializer.SerializeCodeableConcept(value.MediaId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element network
            if(value.Network != null)
            {
                writer.WriteStartElement("network");
                SecurityEventSerializer.SerializeSecurityEventParticipantNetworkComponent(value.Network, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
