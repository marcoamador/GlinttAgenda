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
    * Serializer for ValueSet instances
    */
    internal static partial class ValueSetSerializer
    {
        public static void SerializeValueSet(ValueSet value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("ValueSet");
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
            
            // Serialize element author
            if(value.Author != null && value.Author.Count > 0)
            {
                writer.WriteStartArrayElement("author");
                foreach(var item in value.Author)
                {
                    writer.WriteStartArrayMember("author");
                    ValueSetSerializer.SerializeAuthorComponent(item, writer);
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
                CodeSerializer.SerializeCode<ValueSet.ValueSetStatus>(value.Status, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element date
            if(value.Date != null)
            {
                writer.WriteStartElement("date");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Date, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element identifier
            if(value.Identifier != null)
            {
                writer.WriteStartElement("identifier");
                FhirStringSerializer.SerializeFhirString(value.Identifier, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element version
            if(value.Version != null)
            {
                writer.WriteStartElement("version");
                FhirStringSerializer.SerializeFhirString(value.Version, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element restricts
            if(value.Restricts != null && value.Restricts.Count > 0)
            {
                writer.WriteStartArrayElement("restricts");
                foreach(var item in value.Restricts)
                {
                    writer.WriteStartArrayMember("restricts");
                    FhirUriSerializer.SerializeFhirUri(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element import
            if(value.Import != null && value.Import.Count > 0)
            {
                writer.WriteStartArrayElement("import");
                foreach(var item in value.Import)
                {
                    writer.WriteStartArrayMember("import");
                    FhirUriSerializer.SerializeFhirUri(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element include
            if(value.Include != null && value.Include.Count > 0)
            {
                writer.WriteStartArrayElement("include");
                foreach(var item in value.Include)
                {
                    writer.WriteStartArrayMember("include");
                    ValueSetSerializer.SerializeConceptSetComponent(item, writer);
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
                    ValueSetSerializer.SerializeConceptSetComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeConceptSetComponent(ValueSet.ConceptSetComponent value, IFhirWriter writer)
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
            
            // Serialize element system
            if(value.System != null)
            {
                writer.WriteStartElement("system");
                FhirUriSerializer.SerializeFhirUri(value.System, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element version
            if(value.Version != null)
            {
                writer.WriteStartElement("version");
                FhirStringSerializer.SerializeFhirString(value.Version, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element mode
            if(value.Mode != null)
            {
                writer.WriteStartElement("mode");
                CodeSerializer.SerializeCode<ValueSet.CodeSelectionMode>(value.Mode, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element code
            if(value.Code != null && value.Code.Count > 0)
            {
                writer.WriteStartArrayElement("code");
                foreach(var item in value.Code)
                {
                    writer.WriteStartArrayMember("code");
                    CodeSerializer.SerializeCode(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element filter
            if(value.Filter != null && value.Filter.Count > 0)
            {
                writer.WriteStartArrayElement("filter");
                foreach(var item in value.Filter)
                {
                    writer.WriteStartArrayMember("filter");
                    ValueSetSerializer.SerializeConceptSetFilterComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeConceptSetFilterComponent(ValueSet.ConceptSetFilterComponent value, IFhirWriter writer)
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
            
            // Serialize element property
            if(value.Property != null)
            {
                writer.WriteStartElement("property");
                CodeSerializer.SerializeCode(value.Property, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element op
            if(value.Op != null)
            {
                writer.WriteStartElement("op");
                CodeSerializer.SerializeCode<ValueSet.FilterOperator>(value.Op, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element value
            if(value.Value != null)
            {
                writer.WriteStartElement("value");
                CodeSerializer.SerializeCode(value.Value, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeAuthorComponent(ValueSet.AuthorComponent value, IFhirWriter writer)
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
            
            // Serialize element role
            if(value.Role != null)
            {
                writer.WriteStartElement("role");
                FhirStringSerializer.SerializeFhirString(value.Role, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element telecom
            if(value.Telecom != null && value.Telecom.Count > 0)
            {
                writer.WriteStartArrayElement("telecom");
                foreach(var item in value.Telecom)
                {
                    writer.WriteStartArrayMember("telecom");
                    ContactSerializer.SerializeContact(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
