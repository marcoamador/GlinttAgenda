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
    * Serializer for DeviceCapabilities instances
    */
    internal static partial class DeviceCapabilitiesSerializer
    {
        public static void SerializeDeviceCapabilities(DeviceCapabilities value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("DeviceCapabilities");
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
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.Name, writer);
                writer.WriteEndElement();
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
            
            // Serialize element identity
            if(value.Identity != null)
            {
                writer.WriteStartElement("identity");
                ResourceReferenceSerializer.SerializeResourceReference(value.Identity, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element compartment
            if(value.Compartment != null && value.Compartment.Count > 0)
            {
                writer.WriteStartArrayElement("compartment");
                foreach(var item in value.Compartment)
                {
                    writer.WriteStartArrayMember("compartment");
                    DeviceCapabilitiesSerializer.SerializeDeviceCapabilitiesCompartmentComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeDeviceCapabilitiesCompartmentChannelComponent(DeviceCapabilities.DeviceCapabilitiesCompartmentChannelComponent value, IFhirWriter writer)
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
            
            // Serialize element metric
            if(value.Metric != null && value.Metric.Count > 0)
            {
                writer.WriteStartArrayElement("metric");
                foreach(var item in value.Metric)
                {
                    writer.WriteStartArrayMember("metric");
                    DeviceCapabilitiesSerializer.SerializeDeviceCapabilitiesCompartmentChannelMetricComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDeviceCapabilitiesCompartmentChannelMetricFacetComponent(DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricFacetComponent value, IFhirWriter writer)
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
            
            // Serialize element key
            if(value.Key != null)
            {
                writer.WriteStartElement("key");
                FhirStringSerializer.SerializeFhirString(value.Key, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element info
            if(value.Info != null)
            {
                writer.WriteStartElement("info");
                DeviceCapabilitiesSerializer.SerializeDeviceCapabilitiesCompartmentChannelMetricInfoComponent(value.Info, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDeviceCapabilitiesCompartmentComponent(DeviceCapabilities.DeviceCapabilitiesCompartmentComponent value, IFhirWriter writer)
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
            
            // Serialize element channel
            if(value.Channel != null && value.Channel.Count > 0)
            {
                writer.WriteStartArrayElement("channel");
                foreach(var item in value.Channel)
                {
                    writer.WriteStartArrayMember("channel");
                    DeviceCapabilitiesSerializer.SerializeDeviceCapabilitiesCompartmentChannelComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDeviceCapabilitiesCompartmentChannelMetricInfoComponent(DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricInfoComponent value, IFhirWriter writer)
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
                CodeSerializer.SerializeCode<DeviceCapabilities.DeviceDataType>(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element units
            if(value.Units != null)
            {
                writer.WriteStartElement("units");
                FhirStringSerializer.SerializeFhirString(value.Units, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element ucum
            if(value.Ucum != null)
            {
                writer.WriteStartElement("ucum");
                CodeSerializer.SerializeCode(value.Ucum, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element system
            if(value.System != null)
            {
                writer.WriteStartElement("system");
                FhirUriSerializer.SerializeFhirUri(value.System, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeDeviceCapabilitiesCompartmentChannelMetricComponent(DeviceCapabilities.DeviceCapabilitiesCompartmentChannelMetricComponent value, IFhirWriter writer)
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
            
            // Serialize element key
            if(value.Key != null)
            {
                writer.WriteStartElement("key");
                FhirStringSerializer.SerializeFhirString(value.Key, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element info
            if(value.Info != null)
            {
                writer.WriteStartElement("info");
                DeviceCapabilitiesSerializer.SerializeDeviceCapabilitiesCompartmentChannelMetricInfoComponent(value.Info, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element facet
            if(value.Facet != null && value.Facet.Count > 0)
            {
                writer.WriteStartArrayElement("facet");
                foreach(var item in value.Facet)
                {
                    writer.WriteStartArrayMember("facet");
                    DeviceCapabilitiesSerializer.SerializeDeviceCapabilitiesCompartmentChannelMetricFacetComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
