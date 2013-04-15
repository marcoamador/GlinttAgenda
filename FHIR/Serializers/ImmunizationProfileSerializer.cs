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
    * Serializer for ImmunizationProfile instances
    */
    internal static partial class ImmunizationProfileSerializer
    {
        public static void SerializeImmunizationProfile(ImmunizationProfile value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("ImmunizationProfile");
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
            
            // Serialize element recommendation
            if(value.Recommendation != null && value.Recommendation.Count > 0)
            {
                writer.WriteStartArrayElement("recommendation");
                foreach(var item in value.Recommendation)
                {
                    writer.WriteStartArrayMember("recommendation");
                    ImmunizationProfileSerializer.SerializeImmunizationProfileRecommendationComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeImmunizationProfileRecommendationProtocolComponent(ImmunizationProfile.ImmunizationProfileRecommendationProtocolComponent value, IFhirWriter writer)
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
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeImmunizationProfileRecommendationDateCriterionComponent(ImmunizationProfile.ImmunizationProfileRecommendationDateCriterionComponent value, IFhirWriter writer)
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
            
            // Serialize element value
            if(value.Value != null)
            {
                writer.WriteStartElement("value");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Value, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeImmunizationProfileRecommendationSupportingAdverseEventReportComponent(ImmunizationProfile.ImmunizationProfileRecommendationSupportingAdverseEventReportComponent value, IFhirWriter writer)
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
            if(value.Id != null && value.Id.Count > 0)
            {
                writer.WriteStartArrayElement("id");
                foreach(var item in value.Id)
                {
                    writer.WriteStartArrayMember("id");
                    IdSerializer.SerializeId(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element reportType
            if(value.ReportType != null)
            {
                writer.WriteStartElement("reportType");
                CodeSerializer.SerializeCode(value.ReportType, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element reportDate
            if(value.ReportDate != null)
            {
                writer.WriteStartElement("reportDate");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.ReportDate, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element text
            if(value.Text != null)
            {
                writer.WriteStartElement("text");
                FhirStringSerializer.SerializeFhirString(value.Text, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element reaction
            if(value.Reaction != null && value.Reaction.Count > 0)
            {
                writer.WriteStartArrayElement("reaction");
                foreach(var item in value.Reaction)
                {
                    writer.WriteStartArrayMember("reaction");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeImmunizationProfileRecommendationComponent(ImmunizationProfile.ImmunizationProfileRecommendationComponent value, IFhirWriter writer)
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
            
            // Serialize element recommendationDate
            if(value.RecommendationDate != null)
            {
                writer.WriteStartElement("recommendationDate");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.RecommendationDate, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element vaccineType
            if(value.VaccineType != null)
            {
                writer.WriteStartElement("vaccineType");
                CodeSerializer.SerializeCode(value.VaccineType, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element doseNumber
            if(value.DoseNumber != null)
            {
                writer.WriteStartElement("doseNumber");
                IntegerSerializer.SerializeInteger(value.DoseNumber, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element forecastStatus
            if(value.ForecastStatus != null)
            {
                writer.WriteStartElement("forecastStatus");
                CodeSerializer.SerializeCode(value.ForecastStatus, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element dateCriterion
            if(value.DateCriterion != null && value.DateCriterion.Count > 0)
            {
                writer.WriteStartArrayElement("dateCriterion");
                foreach(var item in value.DateCriterion)
                {
                    writer.WriteStartArrayMember("dateCriterion");
                    ImmunizationProfileSerializer.SerializeImmunizationProfileRecommendationDateCriterionComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element protocol
            if(value.Protocol != null)
            {
                writer.WriteStartElement("protocol");
                ImmunizationProfileSerializer.SerializeImmunizationProfileRecommendationProtocolComponent(value.Protocol, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element supportingImmunization
            if(value.SupportingImmunization != null && value.SupportingImmunization.Count > 0)
            {
                writer.WriteStartArrayElement("supportingImmunization");
                foreach(var item in value.SupportingImmunization)
                {
                    writer.WriteStartArrayMember("supportingImmunization");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element supportingAdverseEventReport
            if(value.SupportingAdverseEventReport != null && value.SupportingAdverseEventReport.Count > 0)
            {
                writer.WriteStartArrayElement("supportingAdverseEventReport");
                foreach(var item in value.SupportingAdverseEventReport)
                {
                    writer.WriteStartArrayMember("supportingAdverseEventReport");
                    ImmunizationProfileSerializer.SerializeImmunizationProfileRecommendationSupportingAdverseEventReportComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element supportingPatientObservation
            if(value.SupportingPatientObservation != null && value.SupportingPatientObservation.Count > 0)
            {
                writer.WriteStartArrayElement("supportingPatientObservation");
                foreach(var item in value.SupportingPatientObservation)
                {
                    writer.WriteStartArrayMember("supportingPatientObservation");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
