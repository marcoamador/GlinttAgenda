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
    /// Parser for Immunization instances
    /// </summary>
    internal static partial class ImmunizationParser
    {
        /// <summary>
        /// Parse Immunization
        /// </summary>
        public static Immunization ParseImmunization(IFhirReader reader, ErrorList errors, Immunization existingInstance = null )
        {
            Immunization result = existingInstance != null ? existingInstance : new Immunization();
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
                    
                    // Parse element language
                    else if( ParserUtils.IsAtFhirElement(reader, "language") )
                        result.Language = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element text
                    else if( ParserUtils.IsAtFhirElement(reader, "text") )
                        result.Text = NarrativeParser.ParseNarrative(reader, errors);
                    
                    // Parse element contained
                    else if( ParserUtils.IsAtFhirElement(reader, "contained") )
                    {
                        result.Contained = new List<Resource>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "contained") )
                            result.Contained.Add(ParserUtils.ParseContainedResource(reader,errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element internalId
                    else if( reader.IsAtRefIdElement() )
                        result.InternalId = Id.Parse(reader.ReadRefIdContents());
                    
                    // Parse element subject
                    else if( ParserUtils.IsAtFhirElement(reader, "subject") )
                        result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element requester
                    else if( ParserUtils.IsAtFhirElement(reader, "requester") )
                        result.Requester = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element performer
                    else if( ParserUtils.IsAtFhirElement(reader, "performer") )
                        result.Performer = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element manufacturer
                    else if( ParserUtils.IsAtFhirElement(reader, "manufacturer") )
                        result.Manufacturer = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element location
                    else if( ParserUtils.IsAtFhirElement(reader, "location") )
                        result.Location = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element date
                    else if( ParserUtils.IsAtFhirElement(reader, "date") )
                        result.Date = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element reported
                    else if( ParserUtils.IsAtFhirElement(reader, "reported") )
                        result.Reported = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element vaccineType
                    else if( ParserUtils.IsAtFhirElement(reader, "vaccineType") )
                        result.VaccineType = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element lotNumber
                    else if( ParserUtils.IsAtFhirElement(reader, "lotNumber") )
                        result.LotNumber = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element expirationDate
                    else if( ParserUtils.IsAtFhirElement(reader, "expirationDate") )
                        result.ExpirationDate = DateParser.ParseDate(reader, errors);
                    
                    // Parse element site
                    else if( ParserUtils.IsAtFhirElement(reader, "site") )
                        result.Site = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element route
                    else if( ParserUtils.IsAtFhirElement(reader, "route") )
                        result.Route = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element doseQuantity
                    else if( ParserUtils.IsAtFhirElement(reader, "doseQuantity") )
                        result.DoseQuantity = QuantityParser.ParseQuantity(reader, errors);
                    
                    // Parse element refusal
                    else if( ParserUtils.IsAtFhirElement(reader, "refusal") )
                        result.Refusal = ImmunizationParser.ParseImmunizationRefusalComponent(reader, errors);
                    
                    // Parse element reaction
                    else if( ParserUtils.IsAtFhirElement(reader, "reaction") )
                    {
                        result.Reaction = new List<Immunization.ImmunizationReactionComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "reaction") )
                            result.Reaction.Add(ImmunizationParser.ParseImmunizationReactionComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element vaccinationProtocol
                    else if( ParserUtils.IsAtFhirElement(reader, "vaccinationProtocol") )
                        result.VaccinationProtocol = ImmunizationParser.ParseImmunizationVaccinationProtocolComponent(reader, errors);
                    
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
        /// Parse ImmunizationVaccinationProtocolComponent
        /// </summary>
        public static Immunization.ImmunizationVaccinationProtocolComponent ParseImmunizationVaccinationProtocolComponent(IFhirReader reader, ErrorList errors, Immunization.ImmunizationVaccinationProtocolComponent existingInstance = null )
        {
            Immunization.ImmunizationVaccinationProtocolComponent result = existingInstance != null ? existingInstance : new Immunization.ImmunizationVaccinationProtocolComponent();
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
                    
                    // Parse element doseSequence
                    else if( ParserUtils.IsAtFhirElement(reader, "doseSequence") )
                        result.DoseSequence = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element description
                    else if( ParserUtils.IsAtFhirElement(reader, "description") )
                        result.Description = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element authority
                    else if( ParserUtils.IsAtFhirElement(reader, "authority") )
                        result.Authority = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element series
                    else if( ParserUtils.IsAtFhirElement(reader, "series") )
                        result.Series = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element seriesDoses
                    else if( ParserUtils.IsAtFhirElement(reader, "seriesDoses") )
                        result.SeriesDoses = IntegerParser.ParseInteger(reader, errors);
                    
                    // Parse element doseTarget
                    else if( ParserUtils.IsAtFhirElement(reader, "doseTarget") )
                        result.DoseTarget = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element doseStatus
                    else if( ParserUtils.IsAtFhirElement(reader, "doseStatus") )
                        result.DoseStatus = CodeParser.ParseCode(reader, errors);
                    
                    // Parse element doseStatusReason
                    else if( ParserUtils.IsAtFhirElement(reader, "doseStatusReason") )
                        result.DoseStatusReason = CodeParser.ParseCode(reader, errors);
                    
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
        /// Parse ImmunizationReactionComponent
        /// </summary>
        public static Immunization.ImmunizationReactionComponent ParseImmunizationReactionComponent(IFhirReader reader, ErrorList errors, Immunization.ImmunizationReactionComponent existingInstance = null )
        {
            Immunization.ImmunizationReactionComponent result = existingInstance != null ? existingInstance : new Immunization.ImmunizationReactionComponent();
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
                    
                    // Parse element date
                    else if( ParserUtils.IsAtFhirElement(reader, "date") )
                        result.Date = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element detail
                    else if( ParserUtils.IsAtFhirElement(reader, "detail") )
                        result.Detail = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element reported
                    else if( ParserUtils.IsAtFhirElement(reader, "reported") )
                        result.Reported = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
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
        /// Parse ImmunizationRefusalComponent
        /// </summary>
        public static Immunization.ImmunizationRefusalComponent ParseImmunizationRefusalComponent(IFhirReader reader, ErrorList errors, Immunization.ImmunizationRefusalComponent existingInstance = null )
        {
            Immunization.ImmunizationRefusalComponent result = existingInstance != null ? existingInstance : new Immunization.ImmunizationRefusalComponent();
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
                    
                    // Parse element reason
                    else if( ParserUtils.IsAtFhirElement(reader, "reason") )
                        result.Reason = CodeParser.ParseCode(reader, errors);
                    
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
