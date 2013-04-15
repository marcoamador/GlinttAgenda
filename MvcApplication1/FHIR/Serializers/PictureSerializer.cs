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
    * Serializer for Picture instances
    */
    internal static partial class PictureSerializer
    {
        public static void SerializePicture(Picture value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Picture");
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
            
            // Serialize element dateTime
            if(value.DateTime != null)
            {
                writer.WriteStartElement("dateTime");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.DateTime, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element operator
            if(value.Operator != null)
            {
                writer.WriteStartElement("operator");
                ResourceReferenceSerializer.SerializeResourceReference(value.Operator, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element identifier
            if(value.Identifier != null)
            {
                writer.WriteStartElement("identifier");
                IdentifierSerializer.SerializeIdentifier(value.Identifier, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element accessionNo
            if(value.AccessionNo != null)
            {
                writer.WriteStartElement("accessionNo");
                IdentifierSerializer.SerializeIdentifier(value.AccessionNo, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element studyId
            if(value.StudyId != null)
            {
                writer.WriteStartElement("studyId");
                IdentifierSerializer.SerializeIdentifier(value.StudyId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element seriesId
            if(value.SeriesId != null)
            {
                writer.WriteStartElement("seriesId");
                IdentifierSerializer.SerializeIdentifier(value.SeriesId, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element method
            if(value.Method != null)
            {
                writer.WriteStartElement("method");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Method, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element requester
            if(value.Requester != null)
            {
                writer.WriteStartElement("requester");
                ResourceReferenceSerializer.SerializeResourceReference(value.Requester, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element modality
            if(value.Modality != null)
            {
                writer.WriteStartElement("modality");
                CodeSerializer.SerializeCode<Picture.ImageModality3>(value.Modality, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element deviceName
            if(value.DeviceName != null)
            {
                writer.WriteStartElement("deviceName");
                FhirStringSerializer.SerializeFhirString(value.DeviceName, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element height
            if(value.Height != null)
            {
                writer.WriteStartElement("height");
                IntegerSerializer.SerializeInteger(value.Height, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element width
            if(value.Width != null)
            {
                writer.WriteStartElement("width");
                IntegerSerializer.SerializeInteger(value.Width, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element bits
            if(value.Bits != null)
            {
                writer.WriteStartElement("bits");
                IntegerSerializer.SerializeInteger(value.Bits, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element frames
            if(value.Frames != null)
            {
                writer.WriteStartElement("frames");
                IntegerSerializer.SerializeInteger(value.Frames, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element frameDelay
            if(value.FrameDelay != null)
            {
                writer.WriteStartElement("frameDelay");
                QuantitySerializer.SerializeQuantity(value.FrameDelay, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element view
            if(value.View != null)
            {
                writer.WriteStartElement("view");
                CodeableConceptSerializer.SerializeCodeableConcept(value.View, writer);
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
            writer.WriteEndRootObject();
        }
        
    }
}
