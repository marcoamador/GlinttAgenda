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
    * Serializer for Encounter instances
    */
    internal static partial class EncounterSerializer
    {
        public static void SerializeEncounter(Encounter value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Encounter");
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
            
            // Serialize element state
            if(value.State != null)
            {
                writer.WriteStartElement("state");
                CodeableConceptSerializer.SerializeCodeableConcept(value.State, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element setting
            if(value.Setting != null)
            {
                writer.WriteStartElement("setting");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Setting, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element responsible
            if(value.Responsible != null)
            {
                writer.WriteStartElement("responsible");
                ResourceReferenceSerializer.SerializeResourceReference(value.Responsible, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element fulfills
            if(value.Fulfills != null)
            {
                writer.WriteStartElement("fulfills");
                ResourceReferenceSerializer.SerializeResourceReference(value.Fulfills, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element period
            if(value.Period != null)
            {
                writer.WriteStartElement("period");
                PeriodSerializer.SerializePeriod(value.Period, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element length
            if(value.Length != null)
            {
                writer.WriteStartElement("length");
                QuantitySerializer.SerializeQuantity(value.Length, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element contact
            if(value.Contact != null)
            {
                writer.WriteStartElement("contact");
                ResourceReferenceSerializer.SerializeResourceReference(value.Contact, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element admission
            if(value.Admission != null)
            {
                writer.WriteStartElement("admission");
                EncounterSerializer.SerializeEncounterAdmissionComponent(value.Admission, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element indication
            if(value.Indication != null)
            {
                writer.WriteStartElement("indication");
                ResourceReferenceSerializer.SerializeResourceReference(value.Indication, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element location
            if(value.Location != null && value.Location.Count > 0)
            {
                writer.WriteStartArrayElement("location");
                foreach(var item in value.Location)
                {
                    writer.WriteStartArrayMember("location");
                    EncounterSerializer.SerializeEncounterLocationComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element discharge
            if(value.Discharge != null)
            {
                writer.WriteStartElement("discharge");
                EncounterSerializer.SerializeEncounterDischargeComponent(value.Discharge, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeEncounterAdmissionComponent(Encounter.EncounterAdmissionComponent value, IFhirWriter writer)
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
            
            // Serialize element admitter
            if(value.Admitter != null)
            {
                writer.WriteStartElement("admitter");
                ResourceReferenceSerializer.SerializeResourceReference(value.Admitter, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element origin
            if(value.Origin != null)
            {
                writer.WriteStartElement("origin");
                ResourceReferenceSerializer.SerializeResourceReference(value.Origin, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeEncounterLocationComponent(Encounter.EncounterLocationComponent value, IFhirWriter writer)
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
            
            // Serialize element location
            if(value.Location != null)
            {
                writer.WriteStartElement("location");
                ResourceReferenceSerializer.SerializeResourceReference(value.Location, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element bed
            if(value.Bed != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("bed", value.Bed.GetType()) );
                FhirSerializer.SerializeElement(value.Bed, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element period
            if(value.Period != null)
            {
                writer.WriteStartElement("period");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Period, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element responsible
            if(value.Responsible != null)
            {
                writer.WriteStartElement("responsible");
                ResourceReferenceSerializer.SerializeResourceReference(value.Responsible, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeEncounterDischargeComponent(Encounter.EncounterDischargeComponent value, IFhirWriter writer)
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
            
            // Serialize element discharger
            if(value.Discharger != null)
            {
                writer.WriteStartElement("discharger");
                ResourceReferenceSerializer.SerializeResourceReference(value.Discharger, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element contact
            if(value.Contact != null)
            {
                writer.WriteStartElement("contact");
                ResourceReferenceSerializer.SerializeResourceReference(value.Contact, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element destination
            if(value.Destination != null)
            {
                writer.WriteStartElement("destination");
                ResourceReferenceSerializer.SerializeResourceReference(value.Destination, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
