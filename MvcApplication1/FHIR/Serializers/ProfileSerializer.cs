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
    * Serializer for Profile instances
    */
    internal static partial class ProfileSerializer
    {
        public static void SerializeProfile(Profile value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Profile");
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
            
            // Serialize element version
            if(value.Version != null)
            {
                writer.WriteStartElement("version");
                FhirStringSerializer.SerializeFhirString(value.Version, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element author
            if(value.Author != null && value.Author.Count > 0)
            {
                writer.WriteStartArrayElement("author");
                foreach(var item in value.Author)
                {
                    writer.WriteStartArrayMember("author");
                    ProfileSerializer.SerializeAuthorComponent(item, writer);
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
            
            // Serialize element code
            if(value.Code != null && value.Code.Count > 0)
            {
                writer.WriteStartArrayElement("code");
                foreach(var item in value.Code)
                {
                    writer.WriteStartArrayMember("code");
                    CodingSerializer.SerializeCoding(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element status
            if(value.Status != null)
            {
                writer.WriteStartElement("status");
                ProfileSerializer.SerializeProfileStatusComponent(value.Status, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element import
            if(value.Import != null && value.Import.Count > 0)
            {
                writer.WriteStartArrayElement("import");
                foreach(var item in value.Import)
                {
                    writer.WriteStartArrayMember("import");
                    ProfileSerializer.SerializeProfileImportComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element bundle
            if(value.Bundle != null)
            {
                writer.WriteStartElement("bundle");
                CodeSerializer.SerializeCode(value.Bundle, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element constraint
            if(value.Constraint != null && value.Constraint.Count > 0)
            {
                writer.WriteStartArrayElement("constraint");
                foreach(var item in value.Constraint)
                {
                    writer.WriteStartArrayMember("constraint");
                    ProfileSerializer.SerializeProfileConstraintComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element extensionDefn
            if(value.ExtensionDefn != null && value.ExtensionDefn.Count > 0)
            {
                writer.WriteStartArrayElement("extensionDefn");
                foreach(var item in value.ExtensionDefn)
                {
                    writer.WriteStartArrayMember("extensionDefn");
                    ProfileSerializer.SerializeProfileExtensionDefnComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element binding
            if(value.Binding != null && value.Binding.Count > 0)
            {
                writer.WriteStartArrayElement("binding");
                foreach(var item in value.Binding)
                {
                    writer.WriteStartArrayMember("binding");
                    ProfileSerializer.SerializeProfileBindingComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeProfileConstraintSearchParamComponent(Profile.ProfileConstraintSearchParamComponent value, IFhirWriter writer)
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
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeSerializer.SerializeCode<SearchParamType>(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element repeats
            if(value.Repeats != null)
            {
                writer.WriteStartElement("repeats");
                CodeSerializer.SerializeCode<SearchRepeatBehavior>(value.Repeats, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element documentation
            if(value.Documentation != null)
            {
                writer.WriteStartElement("documentation");
                FhirStringSerializer.SerializeFhirString(value.Documentation, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProfileConstraintComponent(Profile.ProfileConstraintComponent value, IFhirWriter writer)
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
                CodeSerializer.SerializeCode(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.Name, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element purpose
            if(value.Purpose != null)
            {
                writer.WriteStartElement("purpose");
                FhirStringSerializer.SerializeFhirString(value.Purpose, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element profile
            if(value.Profile != null)
            {
                writer.WriteStartElement("profile");
                FhirUriSerializer.SerializeFhirUri(value.Profile, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element element
            if(value.Element != null && value.Element.Count > 0)
            {
                writer.WriteStartArrayElement("element");
                foreach(var item in value.Element)
                {
                    writer.WriteStartArrayMember("element");
                    ProfileSerializer.SerializeElementComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element searchParam
            if(value.SearchParam != null && value.SearchParam.Count > 0)
            {
                writer.WriteStartArrayElement("searchParam");
                foreach(var item in value.SearchParam)
                {
                    writer.WriteStartArrayMember("searchParam");
                    ProfileSerializer.SerializeProfileConstraintSearchParamComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeCodeDefinitionComponent(Profile.CodeDefinitionComponent value, IFhirWriter writer)
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
                FhirStringSerializer.SerializeFhirString(value.Code, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element system
            if(value.System != null)
            {
                writer.WriteStartElement("system");
                FhirUriSerializer.SerializeFhirUri(value.System, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element display
            if(value.Display != null)
            {
                writer.WriteStartElement("display");
                FhirStringSerializer.SerializeFhirString(value.Display, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element definition
            if(value.Definition != null)
            {
                writer.WriteStartElement("definition");
                FhirStringSerializer.SerializeFhirString(value.Definition, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeAuthorComponent(Profile.AuthorComponent value, IFhirWriter writer)
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
        
        public static void SerializeTypeRefComponent(Profile.TypeRefComponent value, IFhirWriter writer)
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
            
            // Serialize element profile
            if(value.Profile != null)
            {
                writer.WriteStartElement("profile");
                FhirUriSerializer.SerializeFhirUri(value.Profile, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeElementDefinitionConstraintComponent(Profile.ElementDefinitionConstraintComponent value, IFhirWriter writer)
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
            if(value.Id != null)
            {
                writer.WriteStartElement("id");
                IdSerializer.SerializeId(value.Id, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.Name, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element severity
            if(value.Severity != null)
            {
                writer.WriteStartElement("severity");
                CodeSerializer.SerializeCode<Profile.ConstraintSeverity>(value.Severity, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element human
            if(value.Human != null)
            {
                writer.WriteStartElement("human");
                FhirStringSerializer.SerializeFhirString(value.Human, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element xpath
            if(value.Xpath != null)
            {
                writer.WriteStartElement("xpath");
                FhirStringSerializer.SerializeFhirString(value.Xpath, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element ocl
            if(value.Ocl != null)
            {
                writer.WriteStartElement("ocl");
                FhirStringSerializer.SerializeFhirString(value.Ocl, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProfileExtensionDefnComponent(Profile.ProfileExtensionDefnComponent value, IFhirWriter writer)
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
            if(value.Id != null)
            {
                writer.WriteStartElement("id");
                IdSerializer.SerializeId(value.Id, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element contextType
            if(value.ContextType != null)
            {
                writer.WriteStartElement("contextType");
                CodeSerializer.SerializeCode<Profile.ExtensionContext>(value.ContextType, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element context
            if(value.Context != null && value.Context.Count > 0)
            {
                writer.WriteStartArrayElement("context");
                foreach(var item in value.Context)
                {
                    writer.WriteStartArrayMember("context");
                    FhirStringSerializer.SerializeFhirString(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element definition
            if(value.Definition != null)
            {
                writer.WriteStartElement("definition");
                ProfileSerializer.SerializeElementDefinitionComponent(value.Definition, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeElementDefinitionComponent(Profile.ElementDefinitionComponent value, IFhirWriter writer)
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
            
            // Serialize element short
            if(value.Short != null)
            {
                writer.WriteStartElement("short");
                FhirStringSerializer.SerializeFhirString(value.Short, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element formal
            if(value.Formal != null)
            {
                writer.WriteStartElement("formal");
                FhirStringSerializer.SerializeFhirString(value.Formal, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element comments
            if(value.Comments != null)
            {
                writer.WriteStartElement("comments");
                FhirStringSerializer.SerializeFhirString(value.Comments, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element requirements
            if(value.Requirements != null)
            {
                writer.WriteStartElement("requirements");
                FhirStringSerializer.SerializeFhirString(value.Requirements, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element synonym
            if(value.Synonym != null && value.Synonym.Count > 0)
            {
                writer.WriteStartArrayElement("synonym");
                foreach(var item in value.Synonym)
                {
                    writer.WriteStartArrayMember("synonym");
                    FhirStringSerializer.SerializeFhirString(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element min
            if(value.Min != null)
            {
                writer.WriteStartElement("min");
                IntegerSerializer.SerializeInteger(value.Min, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element max
            if(value.Max != null)
            {
                writer.WriteStartElement("max");
                FhirStringSerializer.SerializeFhirString(value.Max, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null && value.Type.Count > 0)
            {
                writer.WriteStartArrayElement("type");
                foreach(var item in value.Type)
                {
                    writer.WriteStartArrayMember("type");
                    ProfileSerializer.SerializeTypeRefComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element nameReference
            if(value.NameReference != null)
            {
                writer.WriteStartElement("nameReference");
                FhirStringSerializer.SerializeFhirString(value.NameReference, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element value
            if(value.Value != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("value", value.Value.GetType()) );
                FhirSerializer.SerializeElement(value.Value, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element maxLength
            if(value.MaxLength != null)
            {
                writer.WriteStartElement("maxLength");
                IntegerSerializer.SerializeInteger(value.MaxLength, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element condition
            if(value.Condition != null && value.Condition.Count > 0)
            {
                writer.WriteStartArrayElement("condition");
                foreach(var item in value.Condition)
                {
                    writer.WriteStartArrayMember("condition");
                    IdSerializer.SerializeId(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element constraint
            if(value.Constraint != null && value.Constraint.Count > 0)
            {
                writer.WriteStartArrayElement("constraint");
                foreach(var item in value.Constraint)
                {
                    writer.WriteStartArrayMember("constraint");
                    ProfileSerializer.SerializeElementDefinitionConstraintComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element mustSupport
            if(value.MustSupport != null)
            {
                writer.WriteStartElement("mustSupport");
                FhirBooleanSerializer.SerializeFhirBoolean(value.MustSupport, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element mustUnderstand
            if(value.MustUnderstand != null)
            {
                writer.WriteStartElement("mustUnderstand");
                FhirBooleanSerializer.SerializeFhirBoolean(value.MustUnderstand, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element binding
            if(value.Binding != null)
            {
                writer.WriteStartElement("binding");
                FhirStringSerializer.SerializeFhirString(value.Binding, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element mapping
            if(value.Mapping != null && value.Mapping.Count > 0)
            {
                writer.WriteStartArrayElement("mapping");
                foreach(var item in value.Mapping)
                {
                    writer.WriteStartArrayMember("mapping");
                    ProfileSerializer.SerializeElementDefinitionMappingComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProfileImportComponent(Profile.ProfileImportComponent value, IFhirWriter writer)
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
            
            // Serialize element uri
            if(value.Uri != null)
            {
                writer.WriteStartElement("uri");
                FhirUriSerializer.SerializeFhirUri(value.Uri, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element prefix
            if(value.Prefix != null)
            {
                writer.WriteStartElement("prefix");
                FhirStringSerializer.SerializeFhirString(value.Prefix, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProfileBindingComponent(Profile.ProfileBindingComponent value, IFhirWriter writer)
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
            
            // Serialize element definition
            if(value.Definition != null)
            {
                writer.WriteStartElement("definition");
                FhirStringSerializer.SerializeFhirString(value.Definition, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element type
            if(value.Type != null)
            {
                writer.WriteStartElement("type");
                CodeSerializer.SerializeCode<Profile.BindingType>(value.Type, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element isExtensible
            if(value.IsExtensible != null)
            {
                writer.WriteStartElement("isExtensible");
                FhirBooleanSerializer.SerializeFhirBoolean(value.IsExtensible, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element conformance
            if(value.Conformance != null)
            {
                writer.WriteStartElement("conformance");
                CodeSerializer.SerializeCode<Profile.BindingConformance>(value.Conformance, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element reference
            if(value.Reference != null)
            {
                writer.WriteStartElement("reference");
                FhirUriSerializer.SerializeFhirUri(value.Reference, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element concept
            if(value.Concept != null && value.Concept.Count > 0)
            {
                writer.WriteStartArrayElement("concept");
                foreach(var item in value.Concept)
                {
                    writer.WriteStartArrayMember("concept");
                    ProfileSerializer.SerializeCodeDefinitionComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeProfileStatusComponent(Profile.ProfileStatusComponent value, IFhirWriter writer)
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
                CodeSerializer.SerializeCode<Profile.ResourceProfileStatus>(value.Code, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element date
            if(value.Date != null)
            {
                writer.WriteStartElement("date");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.Date, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element comment
            if(value.Comment != null)
            {
                writer.WriteStartElement("comment");
                FhirStringSerializer.SerializeFhirString(value.Comment, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeElementDefinitionMappingComponent(Profile.ElementDefinitionMappingComponent value, IFhirWriter writer)
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
            
            // Serialize element target
            if(value.Target != null)
            {
                writer.WriteStartElement("target");
                FhirStringSerializer.SerializeFhirString(value.Target, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element map
            if(value.Map != null)
            {
                writer.WriteStartElement("map");
                FhirStringSerializer.SerializeFhirString(value.Map, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeElementComponent(Profile.ElementComponent value, IFhirWriter writer)
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
            
            // Serialize element path
            if(value.Path != null)
            {
                writer.WriteStartElement("path");
                FhirStringSerializer.SerializeFhirString(value.Path, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element name
            if(value.Name != null)
            {
                writer.WriteStartElement("name");
                FhirStringSerializer.SerializeFhirString(value.Name, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element definition
            if(value.Definition != null)
            {
                writer.WriteStartElement("definition");
                ProfileSerializer.SerializeElementDefinitionComponent(value.Definition, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element bundled
            if(value.Bundled != null)
            {
                writer.WriteStartElement("bundled");
                FhirBooleanSerializer.SerializeFhirBoolean(value.Bundled, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
