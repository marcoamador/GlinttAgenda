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
    * Serializer for CarePlan instances
    */
    internal static partial class CarePlanSerializer
    {
        public static void SerializeCarePlan(CarePlan value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("CarePlan");
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
            if(value.Identifier != null)
            {
                writer.WriteStartElement("identifier");
                IdentifierSerializer.SerializeIdentifier(value.Identifier, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element patient
            if(value.Patient != null)
            {
                writer.WriteStartElement("patient");
                ResourceReferenceSerializer.SerializeResourceReference(value.Patient, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.Status != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<CarePlan.CarePlanStatus>(value.Status, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element period
            if(value.Period != null)
            {
                writer.WriteStartElement("period");
                PeriodSerializer.SerializePeriod(value.Period, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element modified
            if(value.Modified != null)
            {
                writer.WriteStartElement("modified");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Modified, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element concern
            if(value.Concern != null && value.Concern.Count > 0)
            {
                writer.WriteStartArrayElement("concern");
                foreach(var item in value.Concern)
                {
                    writer.WriteStartArrayMember("concern");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element participant
            if(value.Participant != null && value.Participant.Count > 0)
            {
                writer.WriteStartArrayElement("participant");
                foreach(var item in value.Participant)
                {
                    writer.WriteStartArrayMember("participant");
                    CarePlanSerializer.SerializeCarePlanParticipantComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element goal
            if(value.Goal != null && value.Goal.Count > 0)
            {
                writer.WriteStartArrayElement("goal");
                foreach(var item in value.Goal)
                {
                    writer.WriteStartArrayMember("goal");
                    CarePlanSerializer.SerializeCarePlanGoalComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element activity
            if(value.Activity != null && value.Activity.Count > 0)
            {
                writer.WriteStartArrayElement("activity");
                foreach(var item in value.Activity)
                {
                    writer.WriteStartArrayMember("activity");
                    CarePlanSerializer.SerializeCarePlanActivityComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element notes
            if(value.Notes != null)
            {
                writer.WriteStartElement("notes");
                FhirStringSerializer.SerializeFhirString(value.Notes, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeCarePlanGoalComponent(CarePlan.CarePlanGoalComponent value, IFhirWriter writer)
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
            
            // Serialize element status
            if(value.Status != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<CarePlan.CarePlanGoalStatus>(value.Status, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element notes
            if(value.Notes != null)
            {
                writer.WriteStartElement("notes");
                FhirStringSerializer.SerializeFhirString(value.Notes, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeCarePlanParticipantComponent(CarePlan.CarePlanParticipantComponent value, IFhirWriter writer)
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
            
            // Serialize element role
            if(value.Role != null)
            {
                writer.WriteStartElement("role");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Role, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element member
            if(value.Member != null)
            {
                writer.WriteStartElement("member");
                ResourceReferenceSerializer.SerializeResourceReference(value.Member, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeCarePlanActivityComponent(CarePlan.CarePlanActivityComponent value, IFhirWriter writer)
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
            
            // Serialize element category
            if(value.Category != null)
            {
                writer.WriteStartElement("category");
                CodeSerializer.SerializeCode<CarePlan.CarePlanActivityCategory>(value.Category, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element status
            if(value.Status != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<CarePlan.CarePlanActivityStatus>(value.Status, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element prohibited
            if(value.Prohibited != null)
            {
                writer.WriteStartElement("prohibited");
                FhirBooleanSerializer.SerializeFhirBoolean(value.Prohibited, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element timing
            if(value.Timing != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("timing", value.Timing.GetType()) );
                FhirSerializer.SerializeElement(value.Timing, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element location
            if(value.Location != null)
            {
                writer.WriteStartElement("location");
                ResourceReferenceSerializer.SerializeResourceReference(value.Location, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element performer
            if(value.Performer != null && value.Performer.Count > 0)
            {
                writer.WriteStartArrayElement("performer");
                foreach(var item in value.Performer)
                {
                    writer.WriteStartArrayMember("performer");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element product
            if(value.Product != null)
            {
                writer.WriteStartElement("product");
                ResourceReferenceSerializer.SerializeResourceReference(value.Product, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element dailyAmount
            if(value.DailyAmount != null)
            {
                writer.WriteStartElement("dailyAmount");
                QuantitySerializer.SerializeQuantity(value.DailyAmount, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element quantity
            if(value.Quantity != null)
            {
                writer.WriteStartElement("quantity");
                QuantitySerializer.SerializeQuantity(value.Quantity, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element details
            if(value.Details != null)
            {
                writer.WriteStartElement("details");
                FhirStringSerializer.SerializeFhirString(value.Details, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element actionTaken
            if(value.ActionTaken != null && value.ActionTaken.Count > 0)
            {
                writer.WriteStartArrayElement("actionTaken");
                foreach(var item in value.ActionTaken)
                {
                    writer.WriteStartArrayMember("actionTaken");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element notes
            if(value.Notes != null)
            {
                writer.WriteStartElement("notes");
                FhirStringSerializer.SerializeFhirString(value.Notes, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
