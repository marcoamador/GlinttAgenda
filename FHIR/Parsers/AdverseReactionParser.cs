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
    /// Parser for AdverseReaction instances
    /// </summary>
    internal static partial class AdverseReactionParser
    {
        /// <summary>
        /// Parse AdverseReaction
        /// </summary>
        public static AdverseReaction ParseAdverseReaction(IFhirReader reader, ErrorList errors, AdverseReaction existingInstance = null )
        {
            AdverseReaction result = existingInstance != null ? existingInstance : new AdverseReaction();
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
                    
                    // Parse element reactionDate
                    else if( ParserUtils.IsAtFhirElement(reader, "reactionDate") )
                        result.ReactionDate = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element subject
                    else if( ParserUtils.IsAtFhirElement(reader, "subject") )
                        result.Subject = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element substance
                    else if( ParserUtils.IsAtFhirElement(reader, "substance") )
                        result.Substance = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element didNotOccurFlag
                    else if( ParserUtils.IsAtFhirElement(reader, "didNotOccurFlag") )
                        result.DidNotOccurFlag = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element recorder
                    else if( ParserUtils.IsAtFhirElement(reader, "recorder") )
                        result.Recorder = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element symptom
                    else if( ParserUtils.IsAtFhirElement(reader, "symptom") )
                    {
                        result.Symptom = new List<AdverseReaction.AdverseReactionSymptomComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "symptom") )
                            result.Symptom.Add(AdverseReactionParser.ParseAdverseReactionSymptomComponent(reader, errors));
                        
                        reader.LeaveArray();
                    }
                    
                    // Parse element exposure
                    else if( ParserUtils.IsAtFhirElement(reader, "exposure") )
                    {
                        result.Exposure = new List<AdverseReaction.AdverseReactionExposureComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "exposure") )
                            result.Exposure.Add(AdverseReactionParser.ParseAdverseReactionExposureComponent(reader, errors));
                        
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
        /// Parse AdverseReactionSymptomComponent
        /// </summary>
        public static AdverseReaction.AdverseReactionSymptomComponent ParseAdverseReactionSymptomComponent(IFhirReader reader, ErrorList errors, AdverseReaction.AdverseReactionSymptomComponent existingInstance = null )
        {
            AdverseReaction.AdverseReactionSymptomComponent result = existingInstance != null ? existingInstance : new AdverseReaction.AdverseReactionSymptomComponent();
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
                    
                    // Parse element code
                    else if( ParserUtils.IsAtFhirElement(reader, "code") )
                        result.Code = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element severity
                    else if( ParserUtils.IsAtFhirElement(reader, "severity") )
                        result.Severity = CodeParser.ParseCode<AdverseReaction.ReactionSeverity>(reader, errors);
                    
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
        /// Parse AdverseReactionExposureComponent
        /// </summary>
        public static AdverseReaction.AdverseReactionExposureComponent ParseAdverseReactionExposureComponent(IFhirReader reader, ErrorList errors, AdverseReaction.AdverseReactionExposureComponent existingInstance = null )
        {
            AdverseReaction.AdverseReactionExposureComponent result = existingInstance != null ? existingInstance : new AdverseReaction.AdverseReactionExposureComponent();
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
                    
                    // Parse element exposureDate
                    else if( ParserUtils.IsAtFhirElement(reader, "exposureDate") )
                        result.ExposureDate = FhirDateTimeParser.ParseFhirDateTime(reader, errors);
                    
                    // Parse element exposureType
                    else if( ParserUtils.IsAtFhirElement(reader, "exposureType") )
                        result.ExposureType = CodeParser.ParseCode<AdverseReaction.ExposureType>(reader, errors);
                    
                    // Parse element substance
                    else if( ParserUtils.IsAtFhirElement(reader, "substance") )
                        result.Substance = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
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
