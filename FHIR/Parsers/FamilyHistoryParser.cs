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
    /// Parser for FamilyHistory instances
    /// </summary>
    internal static partial class FamilyHistoryParser
    {
        /// <summary>
        /// Parse FamilyHistory
        /// </summary>
        public static FamilyHistory ParseFamilyHistory(IFhirReader reader, ErrorList errors, FamilyHistory existingInstance = null )
        {
            FamilyHistory result = existingInstance != null ? existingInstance : new FamilyHistory();
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
                    
                    // Parse element relation
                    else if( ParserUtils.IsAtFhirElement(reader, "relation") )
                    {
                        result.Relation = new List<FamilyHistory.FamilyHistoryRelationComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "relation") )
                            result.Relation.Add(FamilyHistoryParser.ParseFamilyHistoryRelationComponent(reader, errors));
                        
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
        /// Parse FamilyHistoryRelationConditionComponent
        /// </summary>
        public static FamilyHistory.FamilyHistoryRelationConditionComponent ParseFamilyHistoryRelationConditionComponent(IFhirReader reader, ErrorList errors, FamilyHistory.FamilyHistoryRelationConditionComponent existingInstance = null )
        {
            FamilyHistory.FamilyHistoryRelationConditionComponent result = existingInstance != null ? existingInstance : new FamilyHistory.FamilyHistoryRelationConditionComponent();
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
                    
                    // Parse element type
                    else if( ParserUtils.IsAtFhirElement(reader, "type") )
                        result.Type = CodeableConceptParser.ParseCodeableConcept(reader, errors);
                    
                    // Parse element fatal
                    else if( ParserUtils.IsAtFhirElement(reader, "fatal") )
                        result.Fatal = FhirBooleanParser.ParseFhirBoolean(reader, errors);
                    
                    // Parse element onset
                    else if( ParserUtils.IsAtFhirElement(reader, "onset", true) )
                        result.Onset = FhirParser.ParseElement(reader, errors);
                    
                    // Parse element note
                    else if( ParserUtils.IsAtFhirElement(reader, "note") )
                        result.Note = FhirStringParser.ParseFhirString(reader, errors);
                    
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
        /// Parse FamilyHistoryRelationComponent
        /// </summary>
        public static FamilyHistory.FamilyHistoryRelationComponent ParseFamilyHistoryRelationComponent(IFhirReader reader, ErrorList errors, FamilyHistory.FamilyHistoryRelationComponent existingInstance = null )
        {
            FamilyHistory.FamilyHistoryRelationComponent result = existingInstance != null ? existingInstance : new FamilyHistory.FamilyHistoryRelationComponent();
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
                    
                    // Parse element relatedPerson
                    else if( ParserUtils.IsAtFhirElement(reader, "relatedPerson") )
                        result.RelatedPerson = ResourceReferenceParser.ParseResourceReference(reader, errors);
                    
                    // Parse element relationship
                    else if( ParserUtils.IsAtFhirElement(reader, "relationship") )
                        result.Relationship = CodeParser.ParseCode<FamilyHistory.FamilialRelationship>(reader, errors);
                    
                    // Parse element deceased
                    else if( ParserUtils.IsAtFhirElement(reader, "deceased", true) )
                        result.Deceased = FhirParser.ParseElement(reader, errors);
                    
                    // Parse element note
                    else if( ParserUtils.IsAtFhirElement(reader, "note") )
                        result.Note = FhirStringParser.ParseFhirString(reader, errors);
                    
                    // Parse element condition
                    else if( ParserUtils.IsAtFhirElement(reader, "condition") )
                    {
                        result.Condition = new List<FamilyHistory.FamilyHistoryRelationConditionComponent>();
                        reader.EnterArray();
                        
                        while( ParserUtils.IsAtArrayElement(reader, "condition") )
                            result.Condition.Add(FamilyHistoryParser.ParseFamilyHistoryRelationConditionComponent(reader, errors));
                        
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
        
    }
}
