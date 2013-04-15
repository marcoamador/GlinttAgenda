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
// Generated on Fri, Apr 12, 2013 22:57+1000 for FHIR v0.08
//

using Hl7.Fhir.Model;
using System.Xml;

namespace Hl7.Fhir.Parsers
{
    /// <summary>
    /// Parser for Encounter instances
    /// </summary>
    internal static partial class EncounterParser
    {
        /// <summary>
        /// Parse Encounter
        /// </summary>
        public static Encounter ParseEncounter(IFhirReader reader, ErrorList errors, Encounter existingInstance = null )
        {
            Encounter result = existingInstance != null ? existingInstance : new Encounter();
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
                    
                    // Parse element identifier
                    else if( ParserUtils.IsAtFhirElement(reader, "identifier") )
                    {
                        result.Identifier = new List<Identifier>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "identifier") )
                            result.Identifier.Add(IdentifierParser.ParseIdentifier(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element state
                    else if( ParserUtils.IsAtFhirElement(reader, "state") )
                        result.State = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element setting
                    else if( ParserUtils.IsAtFhirElement(reader, "setting") )
                        result.Setting = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element subject
                    else if( ParserUtils.IsAtFhirElement(reader, "subject") )
                        result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element responsible
                    else if( ParserUtils.IsAtFhirElement(reader, "responsible") )
                        result.Responsible = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element fulfills
                    else if( ParserUtils.IsAtFhirElement(reader, "fulfills") )
                        result.Fulfills = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element period
                    else if( ParserUtils.IsAtFhirElement(reader, "period") )
                        result.Period = PeriodParser.ParsePeriod(reader, errors);
                    
                    // Parse element length
                    else if( ParserUtils.IsAtFhirElement(reader, "length") )
                        result.Length = DurationParser.ParseDuration(reader, errors);
                    
                    // Parse element contact
                    else if( ParserUtils.IsAtFhirElement(reader, "contact") )
                        result.Contact = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element admission
                    else if( ParserUtils.IsAtFhirElement(reader, "admission") )
                        result.Admission = EncounterParser.ParseEncounterAdmissionComponent(reader, errors);
                    
                    // Parse element indication
                    else if( ParserUtils.IsAtFhirElement(reader, "indication") )
                        result.Indication = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element location
                    else if( ParserUtils.IsAtFhirElement(reader, "location") )
                    {
                        result.Location = new List<Encounter.EncounterLocationComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "location") )
                            result.Location.Add(EncounterParser.ParseEncounterLocationComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element discharge
                    else if( ParserUtils.IsAtFhirElement(reader, "discharge") )
                        result.Discharge = EncounterParser.ParseEncounterDischargeComponent(reader, errors);
                    
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
        /// Parse EncounterAdmissionComponent
        /// </summary>
        public static Encounter.EncounterAdmissionComponent ParseEncounterAdmissionComponent(IFhirReader reader, ErrorList errors, Encounter.EncounterAdmissionComponent existingInstance = null )
        {
            Encounter.EncounterAdmissionComponent result = existingInstance != null ? existingInstance : new Encounter.EncounterAdmissionComponent();
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
                    
                    // Parse element admitter
                    else if( ParserUtils.IsAtFhirElement(reader, "admitter") )
                        result.Admitter = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element origin
                    else if( ParserUtils.IsAtFhirElement(reader, "origin") )
                        result.Origin = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
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
        /// Parse EncounterLocationComponent
        /// </summary>
        public static Encounter.EncounterLocationComponent ParseEncounterLocationComponent(IFhirReader reader, ErrorList errors, Encounter.EncounterLocationComponent existingInstance = null )
        {
            Encounter.EncounterLocationComponent result = existingInstance != null ? existingInstance : new Encounter.EncounterLocationComponent();
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
                    
                    // Parse element location
                    else if( ParserUtils.IsAtFhirElement(reader, "location") )
                        result.Location = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element bed
                    else if( ParserUtils.IsAtFhirElement(reader, "bed", true) )
                        result.Bed = FhirParser.ParseElement(reader, errors);
                    
                    // Parse element period
                    else if( ParserUtils.IsAtFhirElement(reader, "period") )
                        result.Period = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element responsible
                    else if( ParserUtils.IsAtFhirElement(reader, "responsible") )
                        result.Responsible = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
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
        /// Parse EncounterDischargeComponent
        /// </summary>
        public static Encounter.EncounterDischargeComponent ParseEncounterDischargeComponent(IFhirReader reader, ErrorList errors, Encounter.EncounterDischargeComponent existingInstance = null )
        {
            Encounter.EncounterDischargeComponent result = existingInstance != null ? existingInstance : new Encounter.EncounterDischargeComponent();
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
                    
                    // Parse element discharger
                    else if( ParserUtils.IsAtFhirElement(reader, "discharger") )
                        result.Discharger = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element contact
                    else if( ParserUtils.IsAtFhirElement(reader, "contact") )
                        result.Contact = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element destination
                    else if( ParserUtils.IsAtFhirElement(reader, "destination") )
                        result.Destination = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
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
