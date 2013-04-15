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
    * Serializer for DiagnosticReport instances
    */
    internal static partial class DiagnosticReportSerializer
    {
        public static void SerializeDiagnosticReport(DiagnosticReport value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("DiagnosticReport");
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
            
            // Serialize element status
            if(value.Status != null)
            {
                writer.WriteStartElement("status");
                CodeSerializer.SerializeCode<ObservationStatus>(value.Status, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element issued
            if(value.Issued != null)
            {
                writer.WriteStartElement("issued");
                InstantSerializer.SerializeInstant(value.Issued, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element performer
            if(value.Performer != null)
            {
                writer.WriteStartElement("performer");
                ResourceReferenceSerializer.SerializeResourceReference(value.Performer, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element reportId
            if(value.ReportId != null)
            {
                writer.WriteStartElement("reportId");
                IdentifierSerializer.SerializeIdentifier(value.ReportId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element requestDetail
            if(value.RequestDetail != null && value.RequestDetail.Count > 0)
            {
                writer.WriteStartArrayElement("requestDetail");
                foreach(var item in value.RequestDetail)
                {
                    writer.WriteStartArrayMember("requestDetail");
                    DiagnosticReportSerializer.SerializeDiagnosticReportRequestDetailComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element serviceCategory
            if(value.ServiceCategory != null)
            {
                writer.WriteStartElement("serviceCategory");
                CodeableConceptSerializer.SerializeCodeableConcept(value.ServiceCategory, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element diagnosticTime
            if(value.DiagnosticTime != null)
            {
                writer.WriteStartElement("diagnosticTime");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.DiagnosticTime, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element results
            if(value.Results != null)
            {
                writer.WriteStartElement("results");
                DiagnosticReportSerializer.SerializeResultGroupComponent(value.Results, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element image
            if(value.Image != null && value.Image.Count > 0)
            {
                writer.WriteStartArrayElement("image");
                foreach(var item in value.Image)
                {
                    writer.WriteStartArrayMember("image");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element conclusion
            if(value.Conclusion != null)
            {
                writer.WriteStartElement("conclusion");
                FhirStringSerializer.SerializeFhirString(value.Conclusion, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element codedDiagnosis
            if(value.CodedDiagnosis != null && value.CodedDiagnosis.Count > 0)
            {
                writer.WriteStartArrayElement("codedDiagnosis");
                foreach(var item in value.CodedDiagnosis)
                {
                    writer.WriteStartArrayMember("codedDiagnosis");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element representation
            if(value.Representation != null && value.Representation.Count > 0)
            {
                writer.WriteStartArrayElement("representation");
                foreach(var item in value.Representation)
                {
                    writer.WriteStartArrayMember("representation");
                    AttachmentSerializer.SerializeAttachment(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeDiagnosticReportRequestDetailComponent(DiagnosticReport.DiagnosticReportRequestDetailComponent value, IFhirWriter writer)
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
            
            // Serialize element encounter
            if(value.Encounter != null)
            {
                writer.WriteStartElement("encounter");
                ResourceReferenceSerializer.SerializeResourceReference(value.Encounter, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element requestOrderId
            if(value.RequestOrderId != null)
            {
                writer.WriteStartElement("requestOrderId");
                IdentifierSerializer.SerializeIdentifier(value.RequestOrderId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element receiverOrderId
            if(value.ReceiverOrderId != null)
            {
                writer.WriteStartElement("receiverOrderId");
                IdentifierSerializer.SerializeIdentifier(value.ReceiverOrderId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element requestTest
            if(value.RequestTest != null && value.RequestTest.Count > 0)
            {
                writer.WriteStartArrayElement("requestTest");
                foreach(var item in value.RequestTest)
                {
                    writer.WriteStartArrayMember("requestTest");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element bodySite
            if(value.BodySite != null)
            {
                writer.WriteStartElement("bodySite");
                CodeableConceptSerializer.SerializeCodeableConcept(value.BodySite, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element requester
            if(value.Requester != null)
            {
                writer.WriteStartElement("requester");
                ResourceReferenceSerializer.SerializeResourceReference(value.Requester, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element clinicalInfo
            if(value.ClinicalInfo != null)
            {
                writer.WriteStartElement("clinicalInfo");
                FhirStringSerializer.SerializeFhirString(value.ClinicalInfo, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeResultGroupComponent(DiagnosticReport.ResultGroupComponent value, IFhirWriter writer)
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
                CodeableConceptSerializer.SerializeCodeableConcept(value.Name, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element specimen
            if(value.Specimen != null)
            {
                writer.WriteStartElement("specimen");
                ResourceReferenceSerializer.SerializeResourceReference(value.Specimen, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element group
            if(value.Group != null && value.Group.Count > 0)
            {
                writer.WriteStartArrayElement("group");
                foreach(var item in value.Group)
                {
                    writer.WriteStartArrayMember("group");
                    DiagnosticReportSerializer.SerializeResultGroupComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element result
            if(value.Result != null && value.Result.Count > 0)
            {
                writer.WriteStartArrayElement("result");
                foreach(var item in value.Result)
                {
                    writer.WriteStartArrayMember("result");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
