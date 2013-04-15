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
    * Serializer for ImagingStudy instances
    */
    internal static partial class ImagingStudySerializer
    {
        public static void SerializeImagingStudy(ImagingStudy value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("ImagingStudy");
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
            
            // Serialize element dateTime
            if(value.DateTime != null)
            {
                writer.WriteStartElement("dateTime");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.DateTime, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element subject
            if(value.Subject != null)
            {
                writer.WriteStartElement("subject");
                ResourceReferenceSerializer.SerializeResourceReference(value.Subject, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element uid
            if(value.Uid != null)
            {
                writer.WriteStartElement("uid");
                OidSerializer.SerializeOid(value.Uid, writer);
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
            
            // Serialize element requester
            if(value.Requester != null)
            {
                writer.WriteStartElement("requester");
                ResourceReferenceSerializer.SerializeResourceReference(value.Requester, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element accessionNo
            if(value.AccessionNo != null)
            {
                writer.WriteStartElement("accessionNo");
                IdentifierSerializer.SerializeIdentifier(value.AccessionNo, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element clinicalInformation
            if(value.ClinicalInformation != null)
            {
                writer.WriteStartElement("clinicalInformation");
                FhirStringSerializer.SerializeFhirString(value.ClinicalInformation, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element procedure
            if(value.Procedure != null && value.Procedure.Count > 0)
            {
                writer.WriteStartArrayElement("procedure");
                foreach(var item in value.Procedure)
                {
                    writer.WriteStartArrayMember("procedure");
                    CodingSerializer.SerializeCoding(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element interpreter
            if(value.Interpreter != null)
            {
                writer.WriteStartElement("interpreter");
                ResourceReferenceSerializer.SerializeResourceReference(value.Interpreter, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element series
            if(value.Series != null && value.Series.Count > 0)
            {
                writer.WriteStartArrayElement("series");
                foreach(var item in value.Series)
                {
                    writer.WriteStartArrayMember("series");
                    ImagingStudySerializer.SerializeImagingStudySeriesComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeImagingStudySeriesComponent(ImagingStudy.ImagingStudySeriesComponent value, IFhirWriter writer)
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
            
            // Serialize element number
            if(value.Number != null)
            {
                writer.WriteStartElement("number");
                IntegerSerializer.SerializeInteger(value.Number, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element modality
            if(value.Modality != null)
            {
                writer.WriteStartElement("modality");
                CodeSerializer.SerializeCode<ImagingStudy.ImageModality>(value.Modality, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element datetime
            if(value.Datetime != null)
            {
                writer.WriteStartElement("datetime");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Datetime, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element uid
            if(value.Uid != null)
            {
                writer.WriteStartElement("uid");
                OidSerializer.SerializeOid(value.Uid, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element description
            if(value.Description != null)
            {
                writer.WriteStartElement("description");
                FhirStringSerializer.SerializeFhirString(value.Description, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element bodySite
            if(value.BodySite != null)
            {
                writer.WriteStartElement("bodySite");
                CodingSerializer.SerializeCoding(value.BodySite, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element image
            if(value.Image != null && value.Image.Count > 0)
            {
                writer.WriteStartArrayElement("image");
                foreach(var item in value.Image)
                {
                    writer.WriteStartArrayMember("image");
                    ImagingStudySerializer.SerializeImagingStudySeriesImageComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeImagingStudySeriesImageComponent(ImagingStudy.ImagingStudySeriesImageComponent value, IFhirWriter writer)
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
            
            // Serialize element number
            if(value.Number != null)
            {
                writer.WriteStartElement("number");
                IntegerSerializer.SerializeInteger(value.Number, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element dateTime
            if(value.DateTime != null)
            {
                writer.WriteStartElement("dateTime");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.DateTime, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element uid
            if(value.Uid != null)
            {
                writer.WriteStartElement("uid");
                OidSerializer.SerializeOid(value.Uid, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element dicomClass
            if(value.DicomClass != null)
            {
                writer.WriteStartElement("dicomClass");
                OidSerializer.SerializeOid(value.DicomClass, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element url
            if(value.Url != null)
            {
                writer.WriteStartElement("url");
                FhirUriSerializer.SerializeFhirUri(value.Url, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
