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
    * Serializer for Immunization instances
    */
    internal static partial class ImmunizationSerializer
    {
        public static void SerializeImmunization(Immunization value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Immunization");
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
            
            // Serialize element subject
            if(value.Subject != null)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element requester
            if(value.Requester != null)
            {
                writer.WriteStartElement("requester");
                ResourceReferenceSerializer.SerializeResourceReference(value.Requester, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element performer
            if(value.Performer != null)
            {
                writer.WriteStartElement("performer");
                ResourceReferenceSerializer.SerializeResourceReference(value.Performer, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element manufacturer
            if(value.Manufacturer != null)
            {
                writer.WriteStartElement("manufacturer");
                ResourceReferenceSerializer.SerializeResourceReference(value.Manufacturer, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element location
            if(value.Location != null)
            {
                writer.WriteStartElement("location");
                ResourceReferenceSerializer.SerializeResourceReference(value.Location, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element date
            if(value.Date != null)
            {
                writer.WriteStartElement("date");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Date, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element reported
            if(value.Reported != null)
            {
                writer.WriteStartElement("reported");
                FhirBooleanSerializer.SerializeFhirBoolean(value.Reported, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element vaccineType
            if(value.VaccineType != null)
            {
                writer.WriteStartElement("vaccineType");
                CodeSerializer.SerializeCode(value.VaccineType, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element lotNumber
            if(value.LotNumber != null)
            {
                writer.WriteStartElement("lotNumber");
                FhirStringSerializer.SerializeFhirString(value.LotNumber, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element expirationDate
            if(value.ExpirationDate != null)
            {
                writer.WriteStartElement("expirationDate");
                DateSerializer.SerializeDate(value.ExpirationDate, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element site
            if(value.Site != null)
            {
                writer.WriteStartElement("site");
                CodeSerializer.SerializeCode(value.Site, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element route
            if(value.Route != null)
            {
                writer.WriteStartElement("route");
                CodeSerializer.SerializeCode(value.Route, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element doseQuantity
            if(value.DoseQuantity != null)
            {
                writer.WriteStartElement("doseQuantity");
                QuantitySerializer.SerializeQuantity(value.DoseQuantity, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element refusal
            if(value.Refusal != null)
            {
                writer.WriteStartElement("refusal");
                ImmunizationSerializer.SerializeImmunizationRefusalComponent(value.Refusal, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element reaction
            if(value.Reaction != null && value.Reaction.Count > 0)
            {
                writer.WriteStartArrayElement("reaction");
                foreach(var item in value.Reaction)
                {
                    writer.WriteStartArrayMember("reaction");
                    ImmunizationSerializer.SerializeImmunizationReactionComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element vaccinationProtocol
            if(value.VaccinationProtocol != null)
            {
                writer.WriteStartElement("vaccinationProtocol");
                ImmunizationSerializer.SerializeImmunizationVaccinationProtocolComponent(value.VaccinationProtocol, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeImmunizationVaccinationProtocolComponent(Immunization.ImmunizationVaccinationProtocolComponent value, IFhirWriter writer)
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
            
            // Serialize element doseSequence
            if(value.DoseSequence != null)
            {
                writer.WriteStartElement("doseSequence");
                IntegerSerializer.SerializeInteger(value.DoseSequence, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element authority
            if(value.Authority != null)
            {
                writer.WriteStartElement("authority");
                ResourceReferenceSerializer.SerializeResourceReference(value.Authority, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element series
            if(value.Series != null)
            {
                writer.WriteStartElement("series");
                FhirStringSerializer.SerializeFhirString(value.Series, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element seriesDoses
            if(value.SeriesDoses != null)
            {
                writer.WriteStartElement("seriesDoses");
                IntegerSerializer.SerializeInteger(value.SeriesDoses, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element doseTarget
            if(value.DoseTarget != null)
            {
                writer.WriteStartElement("doseTarget");
                CodeSerializer.SerializeCode(value.DoseTarget, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element doseStatus
            if(value.DoseStatus != null)
            {
                writer.WriteStartElement("doseStatus");
                CodeSerializer.SerializeCode(value.DoseStatus, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element doseStatusReason
            if(value.DoseStatusReason != null)
            {
                writer.WriteStartElement("doseStatusReason");
                CodeSerializer.SerializeCode(value.DoseStatusReason, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeImmunizationReactionComponent(Immunization.ImmunizationReactionComponent value, IFhirWriter writer)
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
            
            // Serialize element date
            if(value.Date != null)
            {
                writer.WriteStartElement("date");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Date, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element detail
            if(value.Detail != null)
            {
                writer.WriteStartElement("detail");
                ResourceReferenceSerializer.SerializeResourceReference(value.Detail, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element reported
            if(value.Reported != null)
            {
                writer.WriteStartElement("reported");
                FhirBooleanSerializer.SerializeFhirBoolean(value.Reported, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeImmunizationRefusalComponent(Immunization.ImmunizationRefusalComponent value, IFhirWriter writer)
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
            
            // Serialize element reason
            if(value.Reason != null)
            {
                writer.WriteStartElement("reason");
                CodeSerializer.SerializeCode(value.Reason, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
