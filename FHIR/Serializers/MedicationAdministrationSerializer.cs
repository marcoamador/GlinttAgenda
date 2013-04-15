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
    * Serializer for MedicationAdministration instances
    */
    internal static partial class MedicationAdministrationSerializer
    {
        public static void SerializeMedicationAdministration(MedicationAdministration value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("MedicationAdministration");
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
            
            // Serialize element administrationEventStatus
            if(value.AdministrationEventStatus != null)
            {
                writer.WriteStartElement("administrationEventStatus");
                CodeSerializer.SerializeCode<MedicationAdministration.MedicationAdministrationStatus>(value.AdministrationEventStatus, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element isNegated
            if(value.IsNegated != null)
            {
                writer.WriteStartElement("isNegated");
                FhirBooleanSerializer.SerializeFhirBoolean(value.IsNegated, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element negatedReason
            if(value.NegatedReason != null && value.NegatedReason.Count > 0)
            {
                writer.WriteStartArrayElement("negatedReason");
                foreach(var item in value.NegatedReason)
                {
                    writer.WriteStartArrayMember("negatedReason");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element effectiveTime
            if(value.EffectiveTime != null)
            {
                writer.WriteStartElement("effectiveTime");
                PeriodSerializer.SerializePeriod(value.EffectiveTime, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element method
            if(value.Method != null)
            {
                writer.WriteStartElement("method");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Method, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element approachSite
            if(value.ApproachSite != null)
            {
                writer.WriteStartElement("approachSite");
                CodeableConceptSerializer.SerializeCodeableConcept(value.ApproachSite, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element route
            if(value.Route != null)
            {
                writer.WriteStartElement("route");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Route, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element administeredDose
            if(value.AdministeredDose != null)
            {
                writer.WriteStartElement("administeredDose");
                QuantitySerializer.SerializeQuantity(value.AdministeredDose, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element doseRate
            if(value.DoseRate != null)
            {
                writer.WriteStartElement("doseRate");
                QuantitySerializer.SerializeQuantity(value.DoseRate, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element id
            if(value.Id != null && value.Id.Count > 0)
            {
                writer.WriteStartArrayElement("id");
                foreach(var item in value.Id)
                {
                    writer.WriteStartArrayMember("id");
                    IdentifierSerializer.SerializeIdentifier(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element prescription
            if(value.Prescription != null)
            {
                writer.WriteStartElement("prescription");
                ResourceReferenceSerializer.SerializeResourceReference(value.Prescription, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element patient
            if(value.Patient != null)
            {
                writer.WriteStartElement("patient");
                ResourceReferenceSerializer.SerializeResourceReference(value.Patient, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element medication
            if(value.Medication != null && value.Medication.Count > 0)
            {
                writer.WriteStartArrayElement("medication");
                foreach(var item in value.Medication)
                {
                    writer.WriteStartArrayMember("medication");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element visit
            if(value.Visit != null)
            {
                writer.WriteStartElement("visit");
                IdentifierSerializer.SerializeIdentifier(value.Visit, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element administrationDevice
            if(value.AdministrationDevice != null && value.AdministrationDevice.Count > 0)
            {
                writer.WriteStartArrayElement("administrationDevice");
                foreach(var item in value.AdministrationDevice)
                {
                    writer.WriteStartArrayMember("administrationDevice");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
    }
}
