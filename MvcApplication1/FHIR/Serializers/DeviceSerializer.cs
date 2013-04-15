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
    * Serializer for Device instances
    */
    internal static partial class DeviceSerializer
    {
        public static void SerializeDevice(Device value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Device");
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
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element manufacturer
            if(value.Manufacturer != null)
            {
                writer.WriteStartElement("manufacturer");
                FhirStringSerializer.SerializeFhirString(value.Manufacturer, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element model
            if(value.Model != null)
            {
                writer.WriteStartElement("model");
                FhirStringSerializer.SerializeFhirString(value.Model, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element version
            if(value.Version != null)
            {
                writer.WriteStartElement("version");
                FhirStringSerializer.SerializeFhirString(value.Version, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element identity
            if(value.Identity != null)
            {
                writer.WriteStartElement("identity");
                DeviceSerializer.SerializeDeviceIdentityComponent(value.Identity, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element owner
            if(value.Owner != null)
            {
                writer.WriteStartElement("owner");
                ResourceReferenceSerializer.SerializeResourceReference(value.Owner, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element assignedId
            if(value.AssignedId != null && value.AssignedId.Count > 0)
            {
                writer.WriteStartArrayElement("assignedId");
                foreach(var item in value.AssignedId)
                {
                    writer.WriteStartArrayMember("assignedId");
                    IdentifierSerializer.SerializeIdentifier(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element location
            if(value.Location != null)
            {
                writer.WriteStartElement("location");
                ResourceReferenceSerializer.SerializeResourceReference(value.Location, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element patient
            if(value.Patient != null)
            {
                writer.WriteStartElement("patient");
                ResourceReferenceSerializer.SerializeResourceReference(value.Patient, writer);
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
            
            // Serialize element url
            if(value.Url != null)
            {
                writer.WriteStartElement("url");
                FhirUriSerializer.SerializeFhirUri(value.Url, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeDeviceIdentityComponent(Device.DeviceIdentityComponent value, IFhirWriter writer)
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
            
            // Serialize element gtin
            if(value.Gtin != null)
            {
                writer.WriteStartElement("gtin");
                FhirStringSerializer.SerializeFhirString(value.Gtin, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element lot
            if(value.Lot != null)
            {
                writer.WriteStartElement("lot");
                FhirStringSerializer.SerializeFhirString(value.Lot, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element serialNumber
            if(value.SerialNumber != null)
            {
                writer.WriteStartElement("serialNumber");
                FhirStringSerializer.SerializeFhirString(value.SerialNumber, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element expiry
            if(value.Expiry != null)
            {
                writer.WriteStartElement("expiry");
                DateSerializer.SerializeDate(value.Expiry, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
