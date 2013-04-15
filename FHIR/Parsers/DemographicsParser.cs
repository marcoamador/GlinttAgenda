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

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Demographics instances
    /// </summary>
    internal static partial class DemographicsParser
    {
        /// <summary>
        /// Parse Demographics
        /// </summary>
        public static Demographics ParseDemographics(IFhirReader reader, ErrorList errors, Demographics existingInstance = null )
        {
            Demographics result = existingInstance != null ? existingInstance : new Demographics();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element identifier
                    else if( ParserUtils.IsAtFhirElement(reader, "identifier") )
                    {
                        result.Identifier = new List<Identifier>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                            result.Identifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element name
                    else if( ParserUtils.IsAtFhirElement(reader, "name") )
                    {
                        result.Name = new List<HumanName>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "name") )
                            result.Name.Add(HumanNameParser.ParseHumanName(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element telecom
                    else if( ParserUtils.IsAtFhirElement(reader, "telecom") )
                    {
                        result.Telecom = new List<Contact>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "telecom") )
                            result.Telecom.Add(ContactParser.ParseContact(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element gender
                    else if( ParserUtils.IsAtFhirElement(reader, "gender") )
                        result.Gender = CodingParser.ParseCoding(reader, errors);
                    
                    // Parse element birthDate
                    else if( ParserUtils.IsAtFhirElement(reader, "birthDate") )
                        result.BirthDate = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element deceased
                    else if( ParserUtils.IsAtFhirElement(reader, "deceased") )
                        result.Deceased = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element address
                    else if( ParserUtils.IsAtFhirElement(reader, "address") )
                    {
                        result.Address = new List<Address>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "address") )
                            result.Address.Add(AddressParser.ParseAddress(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element photo
                    else if( ParserUtils.IsAtFhirElement(reader, "photo") )
                    {
                        result.Photo = new List<ResourceReference>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "photo") )
                            result.Photo.Add(ResourceReferenceParser.ParseResourceReference(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element maritalStatus
                    else if( ParserUtils.IsAtFhirElement(reader, "maritalStatus") )
                        result.MaritalStatus = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element language
                    else if( ParserUtils.IsAtFhirElement(reader, "language") )
                    {
                        result.Language = new List<Demographics.DemographicsLanguageComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "language") )
                            result.Language.Add(DemographicsParser.ParseDemographicsLanguageComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
        /// <summary>
        /// Parse DemographicsLanguageComponent
        /// </summary>
        public static Demographics.DemographicsLanguageComponent ParseDemographicsLanguageComponent(IFhirReader reader, ErrorList errors, Demographics.DemographicsLanguageComponent existingInstance = null )
        {
            Demographics.DemographicsLanguageComponent result = existingInstance != null ? existingInstance : new Demographics.DemographicsLanguageComponent();
            try
            {
                string currentElementName = reader.CurrentElementName;
                reader.EnterElement();
                
                while (reader.HasMoreElements())
                {
                    // Parse element extension
                    if( ParserUtils.IsAtFhirElement(reader, "extension") )
                    {
                        result.Extension = new List<Extension>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "extension") )
                            result.Extension.Add(ExtensionParser.ParseExtension(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element language
                    else if( ParserUtils.IsAtFhirElement(reader, "language") )
                        result.Language = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element mode
                    else if( ParserUtils.IsAtFhirElement(reader, "mode") )
                        result.Mode = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element proficiencyLevel
                    else if( ParserUtils.IsAtFhirElement(reader, "proficiencyLevel") )
                        result.ProficiencyLevel = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element preference
                    else if( ParserUtils.IsAtFhirElement(reader, "preference") )
                        result.Preference = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    else
                    {
                        errors.Add(String.Format("Encountered unknown element {0} while parsing {1}", reader.CurrentElementName, currentElementName), reader);
                        reader.SkipSubElementsFor(currentElementName);
                        result = null;
                    }
                }
                
                reader.LeaveElement();
            }
            catch (Exception ex)
            {
                errors.Add(ex.Message, reader);
            }
            return result;
        }
        
    }
}
