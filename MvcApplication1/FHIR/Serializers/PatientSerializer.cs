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
    * Serializer for Patient instances
    */
    internal static partial class PatientSerializer
    {
        public static void SerializePatient(Patient value, IFhirWriter writer)
        {
            writer.WriteStartRootObject("Patient");
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
            
            // Serialize element link
            if(value.Link != null && value.Link.Count > 0)
            {
                writer.WriteStartArrayElement("link");
                foreach(var item in value.Link)
                {
                    writer.WriteStartArrayMember("link");
                    ResourceReferenceSerializer.SerializeResourceReference(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element active
            if(value.Active != null)
            {
                writer.WriteStartElement("active");
                FhirBooleanSerializer.SerializeFhirBoolean(value.Active, writer);
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
            
            // Serialize element details
            if(value.Details != null)
            {
                writer.WriteStartElement("details");
                DemographicsSerializer.SerializeDemographics(value.Details, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element contact
            if(value.Contact != null && value.Contact.Count > 0)
            {
                writer.WriteStartArrayElement("contact");
                foreach(var item in value.Contact)
                {
                    writer.WriteStartArrayMember("contact");
                    PatientSerializer.SerializeContactComponent(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element animal
            if(value.Animal != null)
            {
                writer.WriteStartElement("animal");
                PatientSerializer.SerializeAnimalComponent(value.Animal, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element provider
            if(value.Provider != null)
            {
                writer.WriteStartElement("provider");
                ResourceReferenceSerializer.SerializeResourceReference(value.Provider, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element multipleBirth
            if(value.MultipleBirth != null)
            {
                writer.WriteStartElement( SerializationUtil.BuildPolymorphicName("multipleBirth", value.MultipleBirth.GetType()) );
                FhirSerializer.SerializeElement(value.MultipleBirth, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element deceasedDate
            if(value.DeceasedDate != null)
            {
                writer.WriteStartElement("deceasedDate");
                FhirDateTimeSerializer.SerializeFhirDateTime(value.DeceasedDate, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element diet
            if(value.Diet != null)
            {
                writer.WriteStartElement("diet");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Diet, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
            writer.WriteEndRootObject();
        }
        
        public static void SerializeContactComponent(Patient.ContactComponent value, IFhirWriter writer)
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
            
            // Serialize element relationship
            if(value.Relationship != null && value.Relationship.Count > 0)
            {
                writer.WriteStartArrayElement("relationship");
                foreach(var item in value.Relationship)
                {
                    writer.WriteStartArrayMember("relationship");
                    CodeableConceptSerializer.SerializeCodeableConcept(item, writer);
                    writer.WriteEndArrayMember();
                }
                writer.WriteEndArrayElement();
            }
            
            // Serialize element details
            if(value.Details != null)
            {
                writer.WriteStartElement("details");
                DemographicsSerializer.SerializeDemographics(value.Details, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element organization
            if(value.Organization != null)
            {
                writer.WriteStartElement("organization");
                ResourceReferenceSerializer.SerializeResourceReference(value.Organization, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
        public static void SerializeAnimalComponent(Patient.AnimalComponent value, IFhirWriter writer)
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
            
            // Serialize element species
            if(value.Species != null)
            {
                writer.WriteStartElement("species");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Species, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element breed
            if(value.Breed != null)
            {
                writer.WriteStartElement("breed");
                CodeableConceptSerializer.SerializeCodeableConcept(value.Breed, writer);
                writer.WriteEndElement();
            }
            
            // Serialize element genderStatus
            if(value.GenderStatus != null)
            {
                writer.WriteStartElement("genderStatus");
                CodeableConceptSerializer.SerializeCodeableConcept(value.GenderStatus, writer);
                writer.WriteEndElement();
            }
            
            
            writer.WriteEndComplexContent();
        }
        
    }
}
