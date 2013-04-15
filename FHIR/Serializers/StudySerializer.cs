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
// Generated on Thu, Apr 11, 2013 13:03+1000 for FHIR v0.08
//

using Hl7.Fhir.Model;
using System.Xml;
using Newtonsoft.Json;
using Hl7.Fhir.Serializers;

namespace Hl7.Fhir.Serializers
{
    /*
    * Serializer for Study instances
    */
    internal static partial class StudySerializer
    {
        public static void SerializeStudy(Study value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Study");
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
            
            // Serialize element lastModified
            if(value.LastModified != null)
            {
                writer.WriteStartElement("lastModified");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.LastModified, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element versionId
            if(value.VersionId != null)
            {
                writer.WriteStartElement("versionId");
                FhirStringSerializer.SerializeFhirString(value.VersionId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element authorSystem
            if(value.AuthorSystem != null)
            {
                writer.WriteStartElement("authorSystem");
                StudySerializer.SerializeStudyAuthorSystemComponent(value.AuthorSystem, writer);
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
            
            // Serialize element title
            if(value.Title != null)
            {
                writer.WriteStartElement("title");
                FhirStringSerializer.SerializeFhirString(value.Title, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element objective
            if(value.Objective != null && value.Objective.Count > 0)
            {
                writer.WriteStartArrayElement("objective");
                foreach(var item in value.Objective)
                {
                    writer.WriteStartArrayMember("objective");
                    FhirStringSerializer.SerializeFhirString(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element outcomeMeasure
            if(value.OutcomeMeasure != null && value.OutcomeMeasure.Count > 0)
            {
                writer.WriteStartArrayElement("outcomeMeasure");
                foreach(var item in value.OutcomeMeasure)
                {
                    writer.WriteStartArrayMember("outcomeMeasure");
                    FhirStringSerializer.SerializeFhirString(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element sponsor
            if(value.Sponsor != null)
            {
                writer.WriteStartElement("sponsor");
                FhirStringSerializer.SerializeFhirString(value.Sponsor, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element plannedParticipants
            if(value.PlannedParticipants != null)
            {
                writer.WriteStartElement("plannedParticipants");
                IntegerSerializer.SerializeInteger(value.PlannedParticipants, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element group
            if(value.Group != null && value.Group.Count > 0)
            {
                writer.WriteStartArrayElement("group");
                foreach(var item in value.Group)
                {
                    writer.WriteStartArrayMember("group");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element focus
            if(value.Focus != null && value.Focus.Count > 0)
            {
                writer.WriteStartArrayElement("focus");
                foreach(var item in value.Focus)
                {
                    writer.WriteStartArrayMember("focus");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element arm
            if(value.Arm != null && value.Arm.Count > 0)
            {
                writer.WriteStartArrayElement("arm");
                foreach(var item in value.Arm)
                {
                    writer.WriteStartArrayMember("arm");
                    StudySerializer.SerializeStudyArmComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element epoch
            if(value.Epoch != null && value.Epoch.Count > 0)
            {
                writer.WriteStartArrayElement("epoch");
                foreach(var item in value.Epoch)
                {
                    writer.WriteStartArrayMember("epoch");
                    StudySerializer.SerializeStudyEpochComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element timepoint
            if(value.Timepoint != null && value.Timepoint.Count > 0)
            {
                writer.WriteStartArrayElement("timepoint");
                foreach(var item in value.Timepoint)
                {
                    writer.WriteStartArrayMember("timepoint");
                    StudySerializer.SerializeStudyTimepointComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element resource
            if(value.Resource != null && value.Resource.Count > 0)
            {
                writer.WriteStartArrayElement("resource");
                foreach(var item in value.Resource)
                {
                    writer.WriteStartArrayMember("resource");
                    StudySerializer.SerializeStudyResourceComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element stableDiseaseMinimumDuration
            if(value.StableDiseaseMinimumDuration != null)
            {
                writer.WriteStartElement("stableDiseaseMinimumDuration");
                QuantitySerializer.SerializeQuantity(value.StableDiseaseMinimumDuration, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element confirmedResponseDuration
            if(value.ConfirmedResponseDuration != null)
            {
                writer.WriteStartElement("confirmedResponseDuration");
                QuantitySerializer.SerializeQuantity(value.ConfirmedResponseDuration, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element start
            if(value.Start != null)
            {
                writer.WriteStartElement("start");
                DateSerializer.SerializeDate(value.Start, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element end
            if(value.End != null)
            {
                writer.WriteStartElement("end");
                DateSerializer.SerializeDate(value.End, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element duration
            if(value.Duration != null)
            {
                writer.WriteStartElement("duration");
                QuantitySerializer.SerializeQuantity(value.Duration, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element purpose
            if(value.Purpose != null)
            {
                writer.WriteStartElement("purpose");
                CodeSerializer.SerializeCode<Study.StudyPurpose>(value.Purpose, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element phase
            if(value.Phase != null)
            {
                writer.WriteStartElement("phase");
                CodeSerializer.SerializeCode<Study.StudyPhase>(value.Phase, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeSerializer.SerializeCode<Study.StudyType>(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element trialType
            if(value.TrialType != null)
            {
                writer.WriteStartElement("trialType");
                CodeSerializer.SerializeCode<Study.StudyTrialType>(value.TrialType, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element isRandomized
            if(value.IsRandomized != null)
            {
                writer.WriteStartElement("isRandomized");
                FhirBooleanSerializer.SerializeFhirBoolean(value.IsRandomized, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element blindingScheme
            if(value.BlindingScheme != null)
            {
                writer.WriteStartElement("blindingScheme");
                CodeSerializer.SerializeCode<Study.StudyBlindingScheme>(value.BlindingScheme, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element controlType
            if(value.ControlType != null)
            {
                writer.WriteStartElement("controlType");
                CodeSerializer.SerializeCode<Study.StudyControlType>(value.ControlType, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element interventionModel
            if(value.InterventionModel != null)
            {
                writer.WriteStartElement("interventionModel");
                CodeSerializer.SerializeCode<Study.StudyInterventionModel>(value.InterventionModel, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element interventionType
            if(value.InterventionType != null)
            {
                writer.WriteStartElement("interventionType");
                CodeSerializer.SerializeCode<Study.StudyInterventionType>(value.InterventionType, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element isAddOn
            if(value.IsAddOn != null)
            {
                writer.WriteStartElement("isAddOn");
                FhirBooleanSerializer.SerializeFhirBoolean(value.IsAddOn, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element isAdaptive
            if(value.IsAdaptive != null)
            {
                writer.WriteStartElement("isAdaptive");
                FhirBooleanSerializer.SerializeFhirBoolean(value.IsAdaptive, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element arms
            if(value.Arms != null)
            {
                writer.WriteStartElement("arms");
                IntegerSerializer.SerializeInteger(value.Arms, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element randomizationQuotient
            if(value.RandomizationQuotient != null)
            {
                writer.WriteStartElement("randomizationQuotient");
                RatioSerializer.SerializeRatio(value.RandomizationQuotient, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element indication
            if(value.Indication != null)
            {
                writer.WriteStartElement("indication");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Indication, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element currentTreatment
            if(value.CurrentTreatment != null && value.CurrentTreatment.Count > 0)
            {
                writer.WriteStartArrayElement("currentTreatment");
                foreach(var item in value.CurrentTreatment)
                {
                    writer.WriteStartArrayMember("currentTreatment");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element comparativeTreatment
            if(value.ComparativeTreatment != null)
            {
                writer.WriteStartElement("comparativeTreatment");
                CodeableConceptSerializer.SerializeCodeableConcept(value.ComparativeTreatment, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element treatment
            if(value.Treatment != null)
            {
                writer.WriteStartElement("treatment");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Treatment, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element pharmacologicalClass
            if(value.PharmacologicalClass != null)
            {
                writer.WriteStartElement("pharmacologicalClass");
                CodeableConceptSerializer.SerializeCodeableConcept(value.PharmacologicalClass, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element route
            if(value.Route != null)
            {
                writer.WriteStartElement("route");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Route, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element dose
            if(value.Dose != null)
            {
                writer.WriteStartElement("dose");
                QuantitySerializer.SerializeQuantity(value.Dose, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element doseFrequency
            if(value.DoseFrequency != null)
            {
                writer.WriteStartElement("doseFrequency");
                QuantitySerializer.SerializeQuantity(value.DoseFrequency, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element stopRules
            if(value.StopRules != null)
            {
                writer.WriteStartElement("stopRules");
                FhirStringSerializer.SerializeFhirString(value.StopRules, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element participants
            if(value.Participants != null)
            {
                writer.WriteStartElement("participants");
                IntegerSerializer.SerializeInteger(value.Participants, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element dataCutoff
            if(value.DataCutoff != null)
            {
                writer.WriteStartElement("dataCutoff");
                StudySerializer.SerializeStudyDataCutoffComponent(value.DataCutoff, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element country
            if(value.Country != null && value.Country.Count > 0)
            {
                writer.WriteStartArrayElement("country");
                foreach(var item in value.Country)
                {
                    writer.WriteStartArrayMember("country");
                    CodeSerializer.SerializeCode(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeStudyTimepointPreconditionConditionComponent(Study.StudyTimepointPreconditionConditionComponent value, IFhirWriter writer)
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
            
            // Serialize element value
            if(value.Value != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("value", value.Value.GetType()) );
                FhirSerializer.SerializeElement(value.Value, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeStudyResourceComponent(Study.StudyResourceComponent value, IFhirWriter writer)
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
                CodeSerializer.SerializeCode<Study.StudyResourceType>(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element content
            if(value.Content != null)
            {
                writer.WriteStartElement("content");
                AttachmentSerializer.SerializeAttachment(value.Content, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeStudyEpochComponent(Study.StudyEpochComponent value, IFhirWriter writer)
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
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeStudyTimepointActivityComponent(Study.StudyTimepointActivityComponent value, IFhirWriter writer)
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
            
            // Serialize element alternative
            if(value.Alternative != null && value.Alternative.Count > 0)
            {
                writer.WriteStartArrayElement("alternative");
                foreach(var item in value.Alternative)
                {
                    writer.WriteStartArrayMember("alternative");
                    IdRefSerializer.SerializeIdRef(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element component
            if(value.Component != null && value.Component.Count > 0)
            {
                writer.WriteStartArrayElement("component");
                foreach(var item in value.Component)
                {
                    writer.WriteStartArrayMember("component");
                    StudySerializer.SerializeStudyTimepointActivityComponentComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element following
            if(value.Following != null && value.Following.Count > 0)
            {
                writer.WriteStartArrayElement("following");
                foreach(var item in value.Following)
                {
                    writer.WriteStartArrayMember("following");
                    IdRefSerializer.SerializeIdRef(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element wait
            if(value.Wait != null)
            {
                writer.WriteStartElement("wait");
                QuantitySerializer.SerializeQuantity(value.Wait, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element category
            if(value.Category != null)
            {
                writer.WriteStartElement("category");
                CodeSerializer.SerializeCode<Study.StudyActivityCategory>(value.Category, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.Code != null)
            {
                writer.WriteStartElement("code");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Code, writer);
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
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeStudyTimepointPreconditionComponent(Study.StudyTimepointPreconditionComponent value, IFhirWriter writer)
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
            
            // Serialize element condition
            if(value.Condition != null)
            {
                writer.WriteStartElement("condition");
                StudySerializer.SerializeStudyTimepointPreconditionConditionComponent(value.Condition, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element intersection
            if(value.Intersection != null && value.Intersection.Count > 0)
            {
                writer.WriteStartArrayElement("intersection");
                foreach(var item in value.Intersection)
                {
                    writer.WriteStartArrayMember("intersection");
                    StudySerializer.SerializeStudyTimepointPreconditionComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element union
            if(value.Union != null && value.Union.Count > 0)
            {
                writer.WriteStartArrayElement("union");
                foreach(var item in value.Union)
                {
                    writer.WriteStartArrayMember("union");
                    StudySerializer.SerializeStudyTimepointPreconditionComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element exclude
            if(value.Exclude != null && value.Exclude.Count > 0)
            {
                writer.WriteStartArrayElement("exclude");
                foreach(var item in value.Exclude)
                {
                    writer.WriteStartArrayMember("exclude");
                    StudySerializer.SerializeStudyTimepointPreconditionComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeStudyAuthorSystemComponent(Study.StudyAuthorSystemComponent value, IFhirWriter writer)
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
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeStudyDataCutoffComponent(Study.StudyDataCutoffComponent value, IFhirWriter writer)
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
            
            // Serialize element date
            if(value.Date != null)
            {
                writer.WriteStartElement("date");
                DateSerializer.SerializeDate(value.Date, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeStudyTimepointActivityComponentComponent(Study.StudyTimepointActivityComponentComponent value, IFhirWriter writer)
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
            
            // Serialize element sequence
            if(value.Sequence != null)
            {
                writer.WriteStartElement("sequence");
                IntegerSerializer.SerializeInteger(value.Sequence, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element activity
            if(value.Activity != null)
            {
                writer.WriteStartElement("activity");
                IdRefSerializer.SerializeIdRef(value.Activity, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeStudyArmComponent(Study.StudyArmComponent value, IFhirWriter writer)
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
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeStudyTimepointComponent(Study.StudyTimepointComponent value, IFhirWriter writer)
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
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element precondition
            if(value.Precondition != null)
            {
                writer.WriteStartElement("precondition");
                StudySerializer.SerializeStudyTimepointPreconditionComponent(value.Precondition, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element exit
            if(value.Exit != null)
            {
                writer.WriteStartElement("exit");
                StudySerializer.SerializeStudyTimepointPreconditionComponent(value.Exit, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element arm
            if(value.Arm != null)
            {
                writer.WriteStartElement("arm");
                IdRefSerializer.SerializeIdRef(value.Arm, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element epoch
            if(value.Epoch != null)
            {
                writer.WriteStartElement("epoch");
                IdRefSerializer.SerializeIdRef(value.Epoch, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element armSequence
            if(value.ArmSequence != null)
            {
                writer.WriteStartElement("armSequence");
                IntegerSerializer.SerializeInteger(value.ArmSequence, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element firstActivity
            if(value.FirstActivity != null && value.FirstActivity.Count > 0)
            {
                writer.WriteStartArrayElement("firstActivity");
                foreach(var item in value.FirstActivity)
                {
                    writer.WriteStartArrayMember("firstActivity");
                    IdRefSerializer.SerializeIdRef(item, writer);
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
                    StudySerializer.SerializeStudyTimepointActivityComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
